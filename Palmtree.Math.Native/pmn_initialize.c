/*
pmn_initialize.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

// CPUIDについては以下を参照
//   http://www.wdic.org/w/SCI/cpuid%20%28x86%29
// 組み込み関数については以下を参照
//   https://software.intel.com/sites/landingpage/IntrinsicsGuide/#techs=Other // Intel本家(英語)
//   https://msdn.microsoft.com/ja-jp/library/hh977023.aspx // MS

#include <windows.h>
#include <intrin.h>
#include <immintrin.h>
#include "pmn.h"
#include "pmn_internal.h"

// EAX=0x07
#define CPU_FEATURE_FLAG_BMI1   (1U << 3)
#define CPU_FEATURE_FLAG_BMI2   (1U << 8)
#define CPU_FEATURE_FLAG_ADX    (1U << 19)

// EAX=0x80000001
#define CPU_FEATURE_FLAG_LZCNT  (1U << 5)
#define CPU_FEATURE_FLAG_ABM    (1U << 5) /* == LZCNT */

__declspec(dllexport) int __stdcall PMN_Initialize()
{
    PROCESSOR_FEATURES feature;
    feature.PROCESSOR_FEATURE_ADX = FALSE;
    int cpu_id_buffer[4];
    __cpuid(cpu_id_buffer, 0);
    if (cpu_id_buffer[0] < 7)
        feature.PROCESSOR_FEATURE_ADX = FALSE;
    else
    {
        __cpuid(cpu_id_buffer, 7);
        if (cpu_id_buffer[1] & CPU_FEATURE_FLAG_ADX)
            feature.PROCESSOR_FEATURE_ADX = TRUE;
        else
            feature.PROCESSOR_FEATURE_ADX = FALSE;
    }

    __cpuid(cpu_id_buffer, 0x80000000);
    if (cpu_id_buffer[0] < 0x80000001)
        feature.PROCESSOR_FEATURE_LZCNT = FALSE;
    else
    {
        __cpuid(cpu_id_buffer, 0x80000001);
        if (cpu_id_buffer[2] & CPU_FEATURE_FLAG_LZCNT)
            feature.PROCESSOR_FEATURE_LZCNT = TRUE;
        else
            feature.PROCESSOR_FEATURE_LZCNT = FALSE;
    }

    if (!Initialize_Add(&feature))
        return (FALSE);
    if (!Initialize_GetEffectiveBitCount(&feature))
        return (FALSE);

    return (TRUE);
}

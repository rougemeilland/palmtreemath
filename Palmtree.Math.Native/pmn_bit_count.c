/*
pmn_bit_count.c

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

size_t GetUInt32EffectiveBitCount_Imp(unsigned __int32 value)
{
    if (value == 0)
        return (0);
    if (value & 0xffff0000)
    {
        if (value & 0xff000000)
        {
            if (value & 0xf0000000)
            {
                if (value & 0xc0000000)
                {
                    if (value & 0x80000000)
                        return (32);
                    else
                        return (31);
                }
                else
                {
                    if (value & 0x20000000)
                        return (30);
                    else
                        return (29);
                }
            }
            else
            {
                if (value & 0xc000000)
                {
                    if (value & 0x8000000)
                        return (28);
                    else
                        return (27);
                }
                else
                {
                    if (value & 0x2000000)
                        return (26);
                    else
                        return (25);
                }
            }
        }
        else
        {
            if (value & 0xf00000)
            {
                if (value & 0xc00000)
                {
                    if (value & 0x800000)
                        return (24);
                    else
                        return (23);
                }
                else
                {
                    if (value & 0x200000)
                        return (22);
                    else
                        return (21);
                }
            }
            else
            {
                if (value & 0xc0000)
                {
                    if (value & 0x80000)
                        return (20);
                    else
                        return (19);
                }
                else
                {
                    if (value & 0x20000)
                        return (18);
                    else
                        return (17);
                }
            }
        }
    }
    else
    {
        if (value & 0xff00)
        {
            if (value & 0xf000)
            {
                if (value & 0xc000)
                {
                    if (value & 0x8000)
                        return (16);
                    else
                        return (15);
                }
                else
                {
                    if (value & 0x2000)
                        return (14);
                    else
                        return (13);
                }
            }
            else
            {
                if (value & 0xc00)
                {
                    if (value & 0x800)
                        return (12);
                    else
                        return (11);
                }
                else
                {
                    if (value & 0x200)
                        return (10);
                    else
                        return (9);
                }
            }
        }
        else
        {
            if (value & 0xf0)
            {
                if (value & 0xc0)
                {
                    if (value & 0x80)
                        return (8);
                    else
                        return (7);
                }
                else
                {
                    if (value & 0x20)
                        return (6);
                    else
                        return (5);
                }
            }
            else
            {
                if (value & 0xc)
                {
                    if (value & 0x8)
                        return (4);
                    else
                        return (3);
                }
                else
                {
                    if (value & 0x2)
                        return (2);
                    else
                        return (1);
                }
            }
        }
    }
}

#ifdef _M_IX64
size_t GetUInt64EffectiveBitCount_Imp(unsigned __int64  value)
{
    if (value == 0)
        return (0);
    if (value & 0xffffffff00000000)
    {
        if (value & 0xffff000000000000)
        {
            if (value & 0xff00000000000000)
            {
                if (value & 0xf000000000000000)
                {
                    if (value & 0xc000000000000000)
                    {
                        if (value & 0x8000000000000000)
                            return (64);
                        else
                            return (63);
                    }
                    else
                    {
                        if (value & 0x2000000000000000)
                            return (62);
                        else
                            return (61);
                    }
                }
                else
                {
                    if (value & 0xc00000000000000)
                    {
                        if (value & 0x800000000000000)
                            return (60);
                        else
                            return (59);
                    }
                    else
                    {
                        if (value & 0x200000000000000)
                            return (58);
                        else
                            return (57);
                    }
                }
            }
            else
            {
                if (value & 0xf0000000000000)
                {
                    if (value & 0xc0000000000000)
                    {
                        if (value & 0x80000000000000)
                            return (56);
                        else
                            return (55);
                    }
                    else
                    {
                        if (value & 0x20000000000000)
                            return (54);
                        else
                            return (53);
                    }
                }
                else
                {
                    if (value & 0xc000000000000)
                    {
                        if (value & 0x8000000000000)
                            return (52);
                        else
                            return (51);
                    }
                    else
                    {
                        if (value & 0x2000000000000)
                            return (50);
                        else
                            return (49);
                    }
                }
            }
        }
        else
        {
            if (value & 0xff0000000000)
            {
                if (value & 0xf00000000000)
                {
                    if (value & 0xc00000000000)
                    {
                        if (value & 0x800000000000)
                            return (48);
                        else
                            return (47);
                    }
                    else
                    {
                        if (value & 0x200000000000)
                            return (46);
                        else
                            return (45);
                    }
                }
                else
                {
                    if (value & 0xc0000000000)
                    {
                        if (value & 0x80000000000)
                            return (44);
                        else
                            return (43);
                    }
                    else
                    {
                        if (value & 0x20000000000)
                            return (42);
                        else
                            return (41);
                    }
                }
            }
            else
            {
                if (value & 0xf000000000)
                {
                    if (value & 0xc000000000)
                    {
                        if (value & 0x8000000000)
                            return (40);
                        else
                            return (39);
                    }
                    else
                    {
                        if (value & 0x2000000000)
                            return (38);
                        else
                            return (37);
                    }
                }
                else
                {
                    if (value & 0xc00000000)
                    {
                        if (value & 0x800000000)
                            return (36);
                        else
                            return (35);
                    }
                    else
                    {
                        if (value & 0x200000000)
                            return (34);
                        else
                            return (33);
                    }
                }
            }
        }
    }
    else
    {
        if (value & 0xffff0000)
        {
            if (value & 0xff000000)
            {
                if (value & 0xf0000000)
                {
                    if (value & 0xc0000000)
                    {
                        if (value & 0x80000000)
                            return (32);
                        else
                            return (31);
                    }
                    else
                    {
                        if (value & 0x20000000)
                            return (30);
                        else
                            return (29);
                    }
                }
                else
                {
                    if (value & 0xc000000)
                    {
                        if (value & 0x8000000)
                            return (28);
                        else
                            return (27);
                    }
                    else
                    {
                        if (value & 0x2000000)
                            return (26);
                        else
                            return (25);
                    }
                }
            }
            else
            {
                if (value & 0xf00000)
                {
                    if (value & 0xc00000)
                    {
                        if (value & 0x800000)
                            return (24);
                        else
                            return (23);
                    }
                    else
                    {
                        if (value & 0x200000)
                            return (22);
                        else
                            return (21);
                    }
                }
                else
                {
                    if (value & 0xc0000)
                    {
                        if (value & 0x80000)
                            return (20);
                        else
                            return (19);
                    }
                    else
                    {
                        if (value & 0x20000)
                            return (18);
                        else
                            return (17);
                    }
                }
            }
        }
        else
        {
            if (value & 0xff00)
            {
                if (value & 0xf000)
                {
                    if (value & 0xc000)
                    {
                        if (value & 0x8000)
                            return (16);
                        else
                            return (15);
                    }
                    else
                    {
                        if (value & 0x2000)
                            return (14);
                        else
                            return (13);
                    }
                }
                else
                {
                    if (value & 0xc00)
                    {
                        if (value & 0x800)
                            return (12);
                        else
                            return (11);
                    }
                    else
                    {
                        if (value & 0x200)
                            return (10);
                        else
                            return (9);
                    }
                }
            }
            else
            {
                if (value & 0xf0)
                {
                    if (value & 0xc0)
                    {
                        if (value & 0x80)
                            return (8);
                        else
                            return (7);
                    }
                    else
                    {
                        if (value & 0x20)
                            return (6);
                        else
                            return (5);
                    }
                }
                else
                {
                    if (value & 0xc)
                    {
                        if (value & 0x8)
                            return (4);
                        else
                            return (3);
                    }
                    else
                    {
                        if (value & 0x2)
                            return (2);
                        else
                            return (1);
                    }
                }
            }
        }
    }
}
#endif // _M_IX64


size_t GetUInt32EffectiveBitCount_Imp_LZCNT(unsigned __int32 value)
{
    return (32 - _lzcnt_u32(value));
}

#ifdef _M_IX64
size_t GetUInt64EffectiveBitCount_Imp_LZCNT(unsigned __int64  value)
{
    return (64 - _lzcnt_u64(value));
}
#endif // _M_IX64


size_t (*EntryPoint_GetUInt32EffectiveBitCount)(unsigned __int32 value) = GetUInt32EffectiveBitCount_Imp;
#ifdef _M_IX64
size_t(*EntryPoint_GetUInt64EffectiveBitCount)(unsigned __int64 value) = GetUInt64EffectiveBitCount_Imp;
#endif // _M_IX64

int Initialize_GetEffectiveBitCount(PROCESSOR_FEATURES *feature)
{
    if (feature->PROCESSOR_FEATURE_LZCNT)
    {
        EntryPoint_GetUInt32EffectiveBitCount = GetUInt32EffectiveBitCount_Imp_LZCNT;
#ifdef _M_IX64
        EntryPoint_GetUInt64EffectiveBitCount = GetUInt64EffectiveBitCount_Imp_LZCNT;
#endif // _M_IX64
    }
    else
    {
        EntryPoint_GetUInt32EffectiveBitCount = GetUInt32EffectiveBitCount_Imp;
#ifdef _M_IX64
        EntryPoint_GetUInt64EffectiveBitCount = GetUInt64EffectiveBitCount_Imp;
#endif // _M_IX64
    }
    return (TRUE);
}

__declspec(dllexport) size_t __stdcall PMN_GetUInt32EffectiveBitCount(unsigned __int32 value)
{
    return ((*EntryPoint_GetUInt32EffectiveBitCount)(value));
}

__declspec(dllexport) size_t __stdcall PMN_GetUInt64EffectiveBitCount(unsigned __int64  value)
{
#ifdef _M_IX64
    return ((*EntryPoint_GetUInt64EffectiveBitCount)(value));
#else // _M_IX64
    unsigned __int32 value_low = (unsigned __int32)value;
    unsigned __int32 value_high = (unsigned __int32)(value >> 32);
    return ((*EntryPoint_GetUInt32EffectiveBitCount)(value_high) + sizeof(value_low)*8);
#endif // _M_IX64
}

__declspec(dllexport) int __stdcall PMN_GetEffectiveBitCount(void* buffer, size_t buffer_size, size_t *bit_count)
{
    if (!CheckBuffer(buffer, buffer_size))
        return (FALSE);
    if (bit_count == NULL)
        return (FALSE);
    __UNIT_TYPE *p = (__UNIT_TYPE*)((unsigned char*)buffer + buffer_size) - 1;
    size_t offset = (buffer_size - sizeof(__UNIT_TYPE)) * 8;
    while (offset >= 0)
    {
        if (*p != 0)
        {
#ifdef _M_IX64
            *bit_count = (*EntryPoint_GetUInt64EffectiveBitCount)(*p) + offset;
#else // _M_IX64
            *bit_count = (*EntryPoint_GetUInt32EffectiveBitCount)(*p) + offset;
#endif // _M_IX64
            return (TRUE);
        }
        --p;
        offset -= sizeof(__UNIT_TYPE) * 8;
    }
    *bit_count = 0;
    return (TRUE);
}

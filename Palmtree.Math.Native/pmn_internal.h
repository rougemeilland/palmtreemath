/*
pmn_internal.h

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <stdlib.h>

#ifndef __INCLUDED_PMN_INTERNAL_H
#define __INCLUDED_PMN_INTERNAL_H

#ifdef _M_IX86
typedef unsigned __int32 __UNIT_TYPE;
#elif defined(_M_IX64)
typedef unsigned __int64 __UNIT_TYPE;
#else
// undefined
#endif

typedef struct _tag_PROCESSOR_FEATURES
{
    unsigned PROCESSOR_FEATURE_ADX : 1;
    unsigned PROCESSOR_FEATURE_LZCNT : 1;
} PROCESSOR_FEATURES;

extern __UNIT_TYPE* AllocateBuffer(size_t size);
extern void FreeBuffer(__UNIT_TYPE* buffer);
extern int CheckBuffer(const void* buffer, size_t size);
extern size_t NormalizeBufferSize(const void* buffer, size_t size);

extern int Initialize_Add(PROCESSOR_FEATURES* feature);
extern int Initialize_GetEffectiveBitCount(PROCESSOR_FEATURES *feature);

#endif // __INCLUDED_PMN_INTERNAL_H

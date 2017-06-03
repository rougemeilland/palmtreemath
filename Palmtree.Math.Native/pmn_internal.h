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
    unsigned PROCESSOR_FEATURE_POPCNT : 1;
    unsigned PROCESSOR_FEATURE_ADX : 1;
    unsigned PROCESSOR_FEATURE_LZCNT : 1;
} PROCESSOR_FEATURES;

typedef struct __tag_BUFFER_HEADER
{
    size_t UNIT_COUNT;
    __UNIT_TYPE UNIT_ARRAY[1];
} UNIT_BUFFER;

extern UNIT_BUFFER* AllocateBuffer(size_t size);
extern void FreeBuffer(UNIT_BUFFER* buffer);
extern int CheckInputBuffer(UNIT_BUFFER* buffer);
extern int CheckOutputBuffer(UNIT_BUFFER* buffer);
extern void NormalizeBuffer(UNIT_BUFFER* buffer);

extern int Initialize_Add(PROCESSOR_FEATURES* feature);
extern int Initialize_Properties(PROCESSOR_FEATURES *feature);

#endif // __INCLUDED_PMN_INTERNAL_H

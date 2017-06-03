/*
pmn_memory.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <windows.h>
#include "pmn.h"
#include "pmn_internal.h"


UNIT_BUFFER* AllocateBuffer(size_t size)
{
    size_t unit_count = (size + sizeof(__UNIT_TYPE) - 1) / sizeof(__UNIT_TYPE);
    size_t buffer_size = sizeof(UNIT_BUFFER) - sizeof(__UNIT_TYPE) + sizeof(__UNIT_TYPE) * unit_count;
    UNIT_BUFFER* buffer = (UNIT_BUFFER*)_aligned_malloc(buffer_size, __alignof(UNIT_BUFFER));
    buffer->UNIT_COUNT = unit_count;
    return (buffer);
}

void FreeBuffer(UNIT_BUFFER* buffer)
{
    _aligned_free(buffer);
}

int CheckInputBuffer(UNIT_BUFFER* buffer)
{
    if (buffer == NULL)
        return (FALSE);
    unsigned __int64 addr = (unsigned __int64)buffer;
    if (addr % __alignof(__UNIT_TYPE) != 0)
        return (FALSE);
    if (buffer->UNIT_COUNT == 0)
        return (FALSE);
    if (buffer->UNIT_ARRAY[buffer->UNIT_COUNT - 1] == 0)
        return (FALSE);
    return (TRUE);
}

int CheckOutputBuffer(UNIT_BUFFER* buffer)
{
    if (buffer == NULL)
        return (FALSE);
    unsigned __int64 addr = (unsigned __int64)buffer;
    if (addr % __alignof(__UNIT_TYPE) != 0)
        return (FALSE);
    if (buffer->UNIT_COUNT == 0)
        return (FALSE);
    return (TRUE);
}

void NormalizeBuffer(UNIT_BUFFER* buffer)
{
    __UNIT_TYPE* p_start = &buffer->UNIT_ARRAY[0];
    __UNIT_TYPE* p = &buffer->UNIT_ARRAY[buffer->UNIT_COUNT];
    while (p > p_start)
    {
        __UNIT_TYPE* t = p - 1;
        if (*t != 0)
        {
            buffer->UNIT_COUNT = p - p_start;
            return;
        }
        p = t;
    }
    buffer->UNIT_COUNT = 0;
    return;
}

__declspec(dllexport) void* __stdcall PMN_AllocateBuffer(size_t size)
{
    return (AllocateBuffer(size));
}

__declspec(dllexport) void __stdcall PMN_FreeBuffer(void* p)
{
    _aligned_free(p);
}

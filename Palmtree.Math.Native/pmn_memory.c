/*
pmn_memory.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <windows.h>
#include "pmn.h"
#include "pmn_internal.h"


__UNIT_TYPE* AllocateBuffer(size_t size)
{
    if (size == 0)
        return ((__UNIT_TYPE*)_aligned_malloc(sizeof(__UNIT_TYPE), __alignof(__UNIT_TYPE)));
    else
        return ((__UNIT_TYPE*)_aligned_malloc((size + sizeof(__UNIT_TYPE) - 1) / sizeof(__UNIT_TYPE) * sizeof(__UNIT_TYPE), __alignof(__UNIT_TYPE)));
}

void FreeBuffer(__UNIT_TYPE* buffer)
{
    _aligned_free(buffer);
}

int CheckBuffer(const void* buffer, size_t size)
{
    if (buffer == NULL)
        return (FALSE);
    if (size == 0)
        return (FALSE);
    unsigned __int64 addr = (unsigned __int64)buffer;
    if (addr % __alignof(__UNIT_TYPE) != 0)
        return (FALSE);
    if (size % sizeof(__UNIT_TYPE) != 0)
        return (FALSE);
    return (TRUE);
}

size_t NormalizeBufferSize(const void* buffer, size_t size)
{
#ifdef _M_IX64
    unsigned __int64* p1 = (unsigned __int64*)buffer;
    unsigned __int64* p2 = (unsigned __int64*)((unsigned char*)buffer + size);
#else // _M_IX64
    unsigned __int32* p1 = (unsigned __int32*)buffer;
    unsigned __int32* p2 = (unsigned __int32*)((unsigned char*)buffer + size);
#endif // _M_IX64
    while (p2 > p1 && *(p2 - 1) == 0)
        --p2;
    return ((unsigned char*)p2 - (unsigned char*)p1);
}

__declspec(dllexport) void* __stdcall PMN_AllocateBuffer(size_t size)
{
    return (AllocateBuffer(size));
}

__declspec(dllexport) void __stdcall PMN_FreeBuffer(void* p)
{
    _aligned_free(p);
}

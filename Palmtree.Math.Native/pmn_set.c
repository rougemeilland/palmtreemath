/*
pmn_set.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <windows.h>
#include <intrin.h>
#include <immintrin.h>
#include "pmn.h"
#include "pmn_internal.h"

int SetUint32Value_Imp(void * buffer, size_t * buffer_size, unsigned __int32 value)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE);
    if (*buffer_size < expected_size)
        return (FALSE);
    size_t word_count = expected_size / sizeof(unsigned __int32);
    *buffer_size = expected_size;
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (word_count)
    {
    case 4:
        p[3] = 0;
    case 3:
        p[2] = 0;
    case 2:
        p[1] = 0;
    case 1:
        p[0] = value;
        break;
    default:
        __stosd((PDWORD)&p[1], 0, word_count - 1);
        break;
    }
    return (TRUE);
}

int SetUint64Value_Imp_x86(void * buffer, size_t * buffer_size, unsigned __int32 value_high, unsigned __int32 value_low)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE) >= sizeof(unsigned __int32)*2 ? sizeof(__UNIT_TYPE) : sizeof(unsigned __int32) * 2;
    if (*buffer_size < expected_size)
        return (FALSE);
    size_t word_count = expected_size / sizeof(unsigned __int32);
    *buffer_size = expected_size;
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (word_count)
    {
    case 4:
        p[3] = 0;
    case 3:
        p[2] = 0;
    case 2:
        p[1] = value_high;
    case 1:
        p[0] = value_low;
        break;
    default:
        __stosd((PDWORD)&p[2], 0, word_count - 2);
        break;
    }
    return (TRUE);
}

#ifdef _M_IX64
int SetUint64Value_Imp_x64(void * buffer, size_t * buffer_size, unsigned __int64 value)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int64))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE);
    if (*buffer_size < expected_size)
        return (FALSE);
    size_t word_count = expected_size / sizeof(unsigned __int64);
    *buffer_size = expected_size;
    unsigned __int64* p = (unsigned __int64*)buffer;
    switch (word_count)
    {
    case 4:
        p[3] = 0;
    case 3:
        p[2] = 0;
    case 2:
        p[1] = 0;
    case 1:
        p[0] = value;
        break;
    default:
        __stosq((PDWORD64)&p[1], 0, word_count - 1);
        break;
    }
    return (TRUE);
}
#endif // _M_IX64

__declspec(dllexport) int __stdcall PMN_SetUint32Value(void* buffer, size_t* buffer_size, unsigned __int32 value)
{
    if (buffer_size == NULL)
        return (FALSE);
    if (!CheckBuffer(buffer, *buffer_size))
        return (FALSE);
    return (SetUint32Value_Imp(buffer, buffer_size, value));
}

__declspec(dllexport) int __stdcall PMN_SetUint64Value(void* buffer, size_t* buffer_size, unsigned __int64 value)
{
    if (buffer_size == NULL)
        return (FALSE);
    if (!CheckBuffer(buffer, *buffer_size))
        return (FALSE);
    if (value > 0xffffffff)
        return (FALSE);
#ifdef _M_IX64
    return (SetUint64Value_Imp_x64(buffer, buffer_size, value));
#else // _M_IX64
    unsigned __int32 value_low = (unsigned __int32)value;
    unsigned __int32 value_high = (unsigned __int32)(value >> 32);
    return (SetUint64Value_Imp_x86(buffer, buffer_size, value_high, value_low));
#endif // _M_IX64
}

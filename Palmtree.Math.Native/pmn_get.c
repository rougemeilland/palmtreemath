/*
pmn_get.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <windows.h>
#include <intrin.h>
#include <immintrin.h>
#include "pmn.h"
#include "pmn_internal.h"

int GetUint32Value_Imp(const void * buffer, size_t buffer_size, unsigned __int32 *value_buffer)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE);
    if (buffer_size > expected_size)
        return (FALSE);
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (expected_size / sizeof(unsigned __int32))
    {
    case 4:
        if (p[3])
            return (FALSE);
        if (p[2])
            return (FALSE);
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 3:
        if (p[2])
            return (FALSE);
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 2:
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 1:
        *value_buffer = p[0];
        return (TRUE);
    default:
        return (FALSE);
    }
}

int GetUint64Value_Imp_x86(const void * buffer, size_t buffer_size, unsigned __int32 *value_buffer_high, unsigned __int32 *value_buffer_low)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE) > sizeof(unsigned __int32) * 2 ? sizeof(__UNIT_TYPE) : sizeof(unsigned __int32) * 2;
    if (buffer_size > expected_size)
        return (FALSE);
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (expected_size / sizeof(unsigned __int32))
    {
    case 4:
        if (p[3])
            return (FALSE);
        if (p[2])
            return (FALSE);
        *value_buffer_high = p[1];
        *value_buffer_low = p[0];
        return (TRUE);
    case 3:
        if (p[2])
            return (FALSE);
        *value_buffer_high = p[1];
        *value_buffer_low = p[0];
        return (TRUE);
    case 2:
        *value_buffer_high = p[1];
        *value_buffer_low = p[0];
        return (TRUE);
    case 1:
        *value_buffer_high = 0;
        *value_buffer_low = p[0];
        return (TRUE);
    default:
        return (FALSE);
    }
}

#ifdef _M_IX64
int GetUint64Value_Imp_x64(const void * buffer, size_t buffer_size, unsigned __int64 *value_buffer)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int64))
        return (FALSE);
    size_t expected_size = sizeof(__UNIT_TYPE);
    if (buffer_size > expected_size)
        return (FALSE);
    unsigned __int64* p = (unsigned __int64*)buffer;
    switch (expected_size / sizeof(unsigned __int64))
    {
    case 4:
        if (p[3])
            return (FALSE);
        if (p[2])
            return (FALSE);
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 3:
        if (p[2])
            return (FALSE);
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 2:
        if (p[1])
            return (FALSE);
        *value_buffer = p[0];
        return (TRUE);
    case 1:
        *value_buffer = p[0];
        return (TRUE);
    default:
        return (FALSE);
    }
}
#endif // _M_IX64

__declspec(dllexport) int __stdcall PMN_GetUint32Value(const void* buffer, size_t buffer_size, unsigned __int32 *value_buffer)
{
    if (value_buffer == NULL)
        return (FALSE);
    if (!CheckBuffer(buffer, buffer_size))
        return (FALSE);
    return (GetUint32Value_Imp(buffer, buffer_size, value_buffer));
}

__declspec(dllexport) int __stdcall PMN_GetUint64Value(const void* buffer, size_t buffer_size, unsigned __int64 *value_buffer)
{
    if (value_buffer == NULL)
        return (FALSE);
    if (!CheckBuffer(buffer, buffer_size))
        return (FALSE);
#ifdef _M_IX64
    return (GetUint64Value_Imp_x64(buffer, buffer_size, value_buffer));
#else // _M_IX64
    unsigned __int32 value_low;
    unsigned __int32 value_high;
    if (!GetUint64Value_Imp_x86(buffer, buffer_size, &value_high, &value_low))
        return (FALSE);
    *value_buffer = ((unsigned __int64)value_high << 32) | value_low;
    return (TRUE);
#endif // _M_IX64
}

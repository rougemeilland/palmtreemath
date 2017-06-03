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

int GetUint32Value_Imp(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t maximum_buffer_size = sizeof(__UNIT_TYPE);
    size_t maximum_unit_count = maximum_buffer_size / sizeof(__UNIT_TYPE);
    size_t maximum_word_count = maximum_buffer_size / sizeof(unsigned __int32);
    if (buffer->UNIT_COUNT > maximum_unit_count)
        return (FALSE);
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (maximum_word_count)
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

int GetUint64Value_Imp_x86(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer_high, unsigned __int32 *value_buffer_low)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    size_t maximum_buffer_size = sizeof(__UNIT_TYPE) > sizeof(unsigned __int32) * 2 ? sizeof(__UNIT_TYPE) : sizeof(unsigned __int32) * 2;
    size_t maximum_unit_count = maximum_buffer_size / sizeof(__UNIT_TYPE);
    size_t maximum_word_count = maximum_buffer_size / sizeof(unsigned __int32);
    if (buffer->UNIT_COUNT > maximum_unit_count)
        return (FALSE);
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (maximum_word_count)
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
int GetUint64Value_Imp_x64(UNIT_BUFFER* buffer, unsigned __int64 *value_buffer)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int64))
        return (FALSE);
    size_t maximum_buffer_size = sizeof(__UNIT_TYPE);
    size_t maximum_unit_count = maximum_buffer_size / sizeof(__UNIT_TYPE);
    size_t maximum_word_count = maximum_buffer_size / sizeof(unsigned __int64);
    if (buffer->UNIT_COUNT > maximum_unit_count)
        return (FALSE);
    unsigned __int64* p = (unsigned __int64*)buffer;
    switch (maximum_word_count)
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

__declspec(dllexport) int __stdcall PMN_GetUint32Value(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
    return (GetUint32Value_Imp(buffer, value_buffer));
}

__declspec(dllexport) int __stdcall PMN_GetUint64Value(UNIT_BUFFER* buffer, unsigned __int64 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
#ifdef _M_IX64
    return (GetUint64Value_Imp_x64(buffer, value_buffer));
#else // _M_IX64
    unsigned __int32 value_low;
    unsigned __int32 value_high;
    if (!GetUint64Value_Imp_x86(buffer, &value_high, &value_low))
        return (FALSE);
    *value_buffer = ((unsigned __int64)value_high << 32) | value_low;
    return (TRUE);
#endif // _M_IX64
}

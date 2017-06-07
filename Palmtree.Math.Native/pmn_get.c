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

#pragma region GetUint32Value関数

static int GetUint32Value_Imp(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer)
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

__declspec(dllexport) int __stdcall PMN_GetUint32Value(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
    return (GetUint32Value_Imp(buffer, value_buffer));
}

#pragma endregion

#pragma region GetUint64Value関数

#ifdef _M_IX86
static int GetUint64Value(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer_high, unsigned __int32 *value_buffer_low)
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
#elif defined(_M_IX64)
static int GetUint64Value(UNIT_BUFFER* buffer, unsigned __int64 *value_buffer)
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
#else
// undefined
#endif

__declspec(dllexport) int __stdcall PMN_GetUint64Value(UNIT_BUFFER* buffer, unsigned __int64 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
#ifdef _M_IX64
    return (GetUint64Value(buffer, value_buffer));
#elif defined(_M_IX86)
    unsigned __int32 value_low;
    unsigned __int32 value_high;
    if (!GetUint64Value(buffer, &value_high, &value_low))
        return (FALSE);
    *value_buffer = ((unsigned __int64)value_high << 32) | value_low;
    return (TRUE);
#else
    return (FALSE);
#endif
}

#pragma endregion

#pragma region PMN_GetLeastSignificant32Bit関数

__declspec(dllexport) int __stdcall PMN_GetLeastSignificant32Bit(UNIT_BUFFER* buffer, unsigned __int32 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    *value_buffer = (unsigned __int32)buffer->UNIT_ARRAY[0];
    return (TRUE);
}

#pragma endregion

#pragma region PMN_GetLeastSignificant64Bit関数

__declspec(dllexport) int __stdcall PMN_GetLeastSignificant64Bit(UNIT_BUFFER* buffer, unsigned __int64 *value_buffer)
{
    if (!CheckInputBuffer(buffer))
        return (FALSE);
    if (value_buffer == NULL)
        return (FALSE);
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    if (sizeof(__UNIT_TYPE) >= sizeof(unsigned __int64))
        *value_buffer = (unsigned __int64)buffer->UNIT_ARRAY[0];
    else
    {
        size_t word_count = sizeof(unsigned __int64) / sizeof(__UNIT_TYPE);
        unsigned __int64 value;
        switch (word_count)
        {
        case 2:
            value = buffer->UNIT_ARRAY[0];
            if (buffer->UNIT_COUNT >= 2)
                value |= (unsigned __int64)buffer->UNIT_ARRAY[1] << (sizeof(unsigned __int64) / 2 * 8);
            break;
        default:
            value = buffer->UNIT_ARRAY[0];
            break;
        }
        *value_buffer = value;
    }
    return (TRUE);
}

#pragma endregion

int Initialize_Get(PROCESSOR_FEATURES *feature)
{
    return (TRUE);
}

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

int SetUint32Value_Imp(UNIT_BUFFER * buffer, unsigned __int32 value)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    if (buffer->UNIT_COUNT < 1)
        return (FALSE);
    buffer->UNIT_COUNT = 1;
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (sizeof(__UNIT_TYPE) / sizeof(unsigned __int32))
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
        // sizeof(__UNIT_TYPE) が  sizeof(unsigned __int32) の4倍を超えている場合はとりあえずエラーにし、必要になってから対応を考える。
        return (FALSE);
    }
    return (TRUE);
}

int SetUint64Value_Imp_x86(UNIT_BUFFER * buffer, unsigned __int32 value_high, unsigned __int32 value_low)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int32))
        return (FALSE);
    if (buffer->UNIT_COUNT < 1)
        return (FALSE);
    size_t buffer_size = sizeof(__UNIT_TYPE) >= sizeof(unsigned __int32) * 2 ? sizeof(__UNIT_TYPE)  : sizeof(unsigned __int32)*2;
    buffer->UNIT_COUNT = buffer_size / sizeof(__UNIT_TYPE);
    unsigned __int32* p = (unsigned __int32*)buffer;
    switch (buffer_size / sizeof(unsigned __int32))
    {
    case 8:
        p[7] = 0;
    case 7:
        p[6] = 0;
    case 6:
        p[5] = 0;
    case 5:
        p[4] = 0;
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
        // sizeof(__UNIT_TYPE) が  sizeof(unsigned __int32) の8倍を超えている場合はとりあえずエラーにし、必要になってから対応を考える。
        return (FALSE);
    }
    return (TRUE);
}

#ifdef _M_IX64
int SetUint64Value_Imp_x64(UNIT_BUFFER * buffer, unsigned __int64 value)
{
    if (sizeof(__UNIT_TYPE) < sizeof(unsigned __int64))
        return (FALSE);
    if (buffer->UNIT_COUNT < 1)
        return (FALSE);
    buffer->UNIT_COUNT = 1;
    unsigned __int64* p = (unsigned __int64*)buffer;
    switch (sizeof(__UNIT_TYPE) / sizeof(unsigned __int64))
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
        // sizeof(__UNIT_TYPE) が  sizeof(unsigned __int64) の4倍を超えている場合はとりあえずエラーにし、必要になってから対応を考える。
        return (FALSE);
    }
    return (TRUE);
}
#endif // _M_IX64

__declspec(dllexport) int __stdcall PMN_SetUint32Value(UNIT_BUFFER* buffer, unsigned __int32 value)
{
    if (!CheckOutputBuffer(buffer))
        return (FALSE);
    return (SetUint32Value_Imp(buffer, value));
}

__declspec(dllexport) int __stdcall PMN_SetUint64Value(UNIT_BUFFER* buffer, unsigned __int64 value)
{
    if (!CheckOutputBuffer(buffer))
        return (FALSE);
#ifdef _M_IX64
    return (SetUint64Value_Imp_x64(buffer, value));
#else // _M_IX64
    unsigned __int32 value_low = (unsigned __int32)value;
    unsigned __int32 value_high = (unsigned __int32)(value >> 32);
    return (SetUint64Value_Imp_x86(buffer, value_high, value_low));
#endif // _M_IX64
}
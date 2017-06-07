/*
pmn_subtract.c

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

#ifdef _M_IX86
__inline static char _SUBTRACT(char borrow, unsigned __int32 x, unsigned __int32 y, unsigned __int32* z)
{
    return (_subborrow_u32(borrow, x, y, z));
}
__inline static void _MEMCPY(unsigned __int32* dst, const unsigned __int32* src, size_t len)
{
    __movsd((unsigned long*)dst, (const unsigned long*)src, len);
}
#elif defined(_M_IX64)
__inline static char _SUBTRACT(char borrow, unsigned __int64 x, unsigned __int64 y, unsigned __int64* z)
{
    return (_subborrow_u64(borrow, x, y, z));
}
__inline static void _MEMCPY(unsigned __int64* dst, const unsigned __int64* src, size_t len)
{
    __movsq((PDWORD64)dst, (const DWORD64*)src, len);
}
#else
// not defined
#endif

#pragma region Subtract関数

static int Subtract(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count1 = y->UNIT_COUNT;
    size_t count2 = x->UNIT_COUNT - count1;
    size_t count1_8 = count1 / 8;
    char borrow = 0;
    if (count1_8)
    {
        do
        {
            borrow = _SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(borrow, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
            x_ptr += 8;
            y_ptr += 8;
            z_ptr += 8;
        } while (--count1_8);
    }
    if (count1 & 0x04)
    {
        borrow = _SUBTRACT(_SUBTRACT(_SUBTRACT(_SUBTRACT(borrow, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
    }
    if (count1 & 0x02)
    {
        borrow = _SUBTRACT(_SUBTRACT(borrow, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
    }
    if (count1 & 0x01)
    {
        borrow = _SUBTRACT(borrow, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
    }
    if (borrow)
    {
        while (1)
        {
            if (!count2)
                return (FALSE);
            if (!_SUBTRACT(0, *x_ptr, 1, z_ptr))
            {
                ++z_ptr;
                if (--count2)
                {
                    _MEMCPY(z_ptr, x_ptr+1, count2);
                    z_ptr += count2;
                }
                break;
            }
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
    }
    else if (count2)
    {
        _MEMCPY(z_ptr, x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

__declspec(dllexport) int __stdcall PMN_Subtract(UNIT_BUFFER* x, UNIT_BUFFER* y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (!CheckInputBuffer(y))
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT)
        return (FALSE);
    if (x->UNIT_COUNT < y->UNIT_COUNT)
        return (FALSE);
    if (!Subtract(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region SubtractUInt32関数

static int SubtractUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    if (_SUBTRACT(0, *x_ptr, y, z_ptr))
    {
        ++x_ptr;
        ++z_ptr;
        while (1)
        {
            if (!count2)
                return (FALSE);
            if (!_SUBTRACT(0, *x_ptr, 1, z_ptr))
            {
                ++z_ptr;
                if (--count2)
                {
                    _MEMCPY(z_ptr, x_ptr + 1, count2);
                    z_ptr += count2;
                }
                break;
            }
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
    }
    else if (count2)
    {
        ++z_ptr;
        _MEMCPY(z_ptr, x_ptr + 1, count2);
        z_ptr += count2;
    }
    else
        ++z_ptr;

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

__declspec(dllexport) int __stdcall PMN_SubtractUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (y == 0)
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT)
        return (FALSE);
    if (x->UNIT_COUNT < (sizeof(unsigned __int32) + sizeof(__UNIT_TYPE) - 1) / sizeof(__UNIT_TYPE))
        return (FALSE);
    if (!SubtractUInt32(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region SubtractUInt64関数

#ifdef _M_IX86
static int SubtractUInt64(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    if (x->UNIT_COUNT < 2)
        return (FALSE);
    size_t count2 = x->UNIT_COUNT - 2;
    if (_SUBTRACT(_SUBTRACT(0, x_ptr[0], y_low, &z_ptr[0]), x_ptr[1], y_high, &z_ptr[1]))
    {
        x_ptr += 2;
        z_ptr += 2;
        while (1)
        {
            if (!count2)
                return (FALSE);
            if (!_SUBTRACT(0, *x_ptr, 1, z_ptr))
            {
                ++z_ptr;
                if (--count2)
                {
                    _MEMCPY(z_ptr, x_ptr + 1, count2);
                    z_ptr += count2;
                }
                break;
            }
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
    }
    else if (count2)
    {
        z_ptr += 2;
        _MEMCPY(z_ptr, x_ptr + 2, count2);
        z_ptr += count2;
    }
    else
        z_ptr += 2;

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#elif defined(_M_IX64)
static int SubtractUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    if (_SUBTRACT(0, *x_ptr, y, z_ptr))
    {
        ++x_ptr;
        ++z_ptr;
        while (count2)
        {
            if (!count2)
                return (FALSE);
            if (!_SUBTRACT(0, *x_ptr, 1, z_ptr))
            {
                ++z_ptr;
                if (--count2)
                {
                    _MEMCPY(z_ptr, x_ptr + 1, count2);
                    z_ptr += count2;
                }
                break;
            }
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
    }
    else if (count2)
    {
        ++z_ptr;
        _MEMCPY(z_ptr, x_ptr + 1, count2);
        z_ptr += count2;
    }
    else
        ++z_ptr;

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#else
#endif

__declspec(dllexport) int __stdcall PMN_SubtractUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (y == 0)
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT)
        return (FALSE);
    if (z->UNIT_COUNT < (sizeof(unsigned __int64) + sizeof(__UNIT_TYPE) - 1) / sizeof(__UNIT_TYPE))
        return (FALSE);
#if defined(_M_IX86)
    unsigned __int32 y_high = (unsigned __int32)(y >> 32);
    unsigned __int32 y_low = (unsigned __int32)y;
    if (y_high == 0)
    {
        if (!SubtractUInt32(x, y_low, z))
            return (FALSE);
    }
    else
    {
        if (!SubtractUInt64(x, y_high, y_low, z))
            return (FALSE);
    }
#elif defined(_M_IX64)
    if (!SubtractUInt64(x, y, z))
        return (FALSE);
#endif // _M_IX86
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

int Initialize_Subtract(PROCESSOR_FEATURES *feature)
{
    return (TRUE);
}

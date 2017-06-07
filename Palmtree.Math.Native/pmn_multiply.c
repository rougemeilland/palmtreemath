/*
pmn_multiply.c

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
__inline static char _ADD(char carry, unsigned __int32 x, unsigned __int32 y, unsigned __int32* z)
{
    return (_addcarry_u32(carry, x, y, z));
}
__inline static unsigned __int32 _MULTIPLY(unsigned __int32 x, unsigned __int32 y, unsigned __int32* z_high)
{
    unsigned __int64 t = __emulu(x, y);
    *z_high = (unsigned __int32)(t >> 32);
    return ((unsigned __int32)t);
}
#elif defined(_M_IX64)
__inline static char _ADD(char carry, unsigned __int64 x, unsigned __int64 y, unsigned __int64* z)
{
    return (_addcarry_u64(carry, x, y, z));
}
__inline static unsigned __int64 _MULTIPLY(unsigned __int64 x, unsigned __int64 y, unsigned __int64* z_high)
{
    return (_mul128(x, y, z_high));
}
#else
// undefined
#endif

#pragma region Multiply関数

static int Multiply(UNIT_BUFFER* x, UNIT_BUFFER* y, UNIT_BUFFER* z)
{
    // part1:
    // 0 <= n < y->UNIT_COUNT - 1
    // 0 <= x_index < n + 1
    // 0 <= y_index < n + 1

    // part2:
    // y->UNIT_COUNT - 1 <= n < x->UNIT_COUNT
    // n + 1 - y->UNIT_COUNT <= x_index < n + 1
    // 0 <= y_index < y->UNIT_COUNT

    // part3:
    // x->UNIT_COUNT <= n < x->UNIT_COUNT + y->UNIT_COUNT - 1
    // n + 1 - y->UNIT_COUNT <= x_index < x->UNIT_COUNT
    // n + 1 - x->UNIT_COUNT <= y_index < y->UNIT_COUNT

    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    __UNIT_TYPE z_high1 = 0;
    __UNIT_TYPE z_high2 = 0;
    size_t n;
    size_t n_count;
    *z_ptr = 0;

#pragma region part.1
    if (y->UNIT_COUNT > 1)
    {
        n = 0;
        n_count = y->UNIT_COUNT - 1;
        do
        {
            __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
            __UNIT_TYPE* y_ptr = y->UNIT_ARRAY + n;
            size_t x_count = n + 1;
            size_t x_count_8 = x_count / 8;
            if (x_count_8)
            {
                do
                {
                    __UNIT_TYPE a_low;
                    __UNIT_TYPE a_high;
                    a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[4], y_ptr[-4], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[5], y_ptr[-5], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[6], y_ptr[-6], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[7], y_ptr[-7], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    x_ptr += 8;
                    y_ptr -= 8;
                } while (--x_count_8);
            }
            if (x_count & 0x04)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 4;
                y_ptr -= 4;
            }
            if (x_count & 0x02)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 2;
                y_ptr -= 2;
            }
            if (x_count & 0x01)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 1;
                y_ptr -= 1;
            }
            ++n;
            --n_count;
            ++z_ptr;
            *z_ptr = z_high1;
            z_high1 = z_high2;
            z_high2 = 0;
        } while (n_count > 0);
    }
#pragma endregion

#pragma region part.2
    n = y->UNIT_COUNT - 1;
    n_count = x->UNIT_COUNT - y->UNIT_COUNT + 1;
    do
    {
        __UNIT_TYPE* x_ptr = x->UNIT_ARRAY + n + 1 - y->UNIT_COUNT;
        __UNIT_TYPE* y_ptr = y->UNIT_ARRAY + y->UNIT_COUNT - 1;
        size_t x_count = y->UNIT_COUNT;
        size_t x_count_8 = x_count / 8;
        if (x_count_8)
        {
            do
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[4], y_ptr[-4], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[5], y_ptr[-5], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[6], y_ptr[-6], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[7], y_ptr[-7], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 8;
                y_ptr -= 8;
            } while (--x_count_8);
        }
        if (x_count & 0x04)
        {
            __UNIT_TYPE a_low;
            __UNIT_TYPE a_high;
            a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            x_ptr += 4;
            y_ptr -= 4;
        }
        if (x_count & 0x02)
        {
            __UNIT_TYPE a_low;
            __UNIT_TYPE a_high;
            a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            x_ptr += 2;
            y_ptr -= 2;
        }
        if (x_count & 0x01)
        {
            __UNIT_TYPE a_low;
            __UNIT_TYPE a_high;
            a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
            _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
            x_ptr += 1;
            y_ptr -= 1;
        }
        ++n;
        --n_count;
        ++z_ptr;
        *z_ptr = z_high1;
        z_high1 = z_high2;
        z_high2 = 0;
    } while (n_count > 0);
#pragma endregion

#pragma region part.3
    if (y->UNIT_COUNT > 1)
    {
        n = x->UNIT_COUNT;
        n_count = y->UNIT_COUNT - 1;
        do
        {
            __UNIT_TYPE* x_ptr = x->UNIT_ARRAY + n + 1 - y->UNIT_COUNT;
            __UNIT_TYPE* y_ptr = y->UNIT_ARRAY - 1;
            size_t x_count = x->UNIT_COUNT + y->UNIT_COUNT - n - 1;
            size_t x_count_8 = x_count / 8;
            if (x_count_8)
            {
                do
                {
                    __UNIT_TYPE a_low;
                    __UNIT_TYPE a_high;
                    a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[4], y_ptr[-4], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[5], y_ptr[-5], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[6], y_ptr[-6], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    a_low = _MULTIPLY(x_ptr[7], y_ptr[-7], &a_high);
                    _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                    x_ptr += 8;
                    y_ptr -= 8;
                } while (--x_count_8);
            }
            if (x_count & 0x04)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[2], y_ptr[-2], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[3], y_ptr[-3], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 4;
                y_ptr -= 4;
            }
            if (x_count & 0x02)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                a_low = _MULTIPLY(x_ptr[1], y_ptr[-1], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 2;
                y_ptr -= 2;
            }
            if (x_count & 0x01)
            {
                __UNIT_TYPE a_low;
                __UNIT_TYPE a_high;
                a_low = _MULTIPLY(x_ptr[0], y_ptr[-0], &a_high);
                _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
                x_ptr += 1;
                y_ptr -= 1;
            }
            ++n;
            --n_count;
            ++z_ptr;
            *z_ptr = z_high1;
            z_high1 = z_high2;
            z_high2 = 0;
        } while (n_count > 0);
    }
#pragma endregion

    if (z_high2)
    {
        *z_ptr++ = z_high1;
        *z_ptr++ = z_high2;
    }
    else if (z_high1)
    {
        *z_ptr++ = z_high1;
    }
    else
    {
    }

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

static int(*EntryPoint_Multiply)(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z) = Multiply;

__declspec(dllexport) int __stdcall PMN_Multiply(UNIT_BUFFER* x, UNIT_BUFFER* y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (!CheckInputBuffer(y))
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT + y->UNIT_COUNT - 1)
        return (FALSE);
    if (x->UNIT_COUNT < y->UNIT_COUNT)
        return (FALSE);
    if (!(*EntryPoint_Multiply)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region MultipyUInt32関数

int MultipyUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    __UNIT_TYPE z_high1 = 0;
    __UNIT_TYPE z_high2 = 0;
    size_t count = x->UNIT_COUNT;
    *z_ptr = 0;

    do
    {
        __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
        __UNIT_TYPE a_low;
        __UNIT_TYPE a_high;
        a_low = _MULTIPLY(*x_ptr, y, &a_high);
        _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
        ++z_ptr;
        *z_ptr = z_high1;
        z_high1 = z_high2;
        z_high2 = 0;
        --count;
    } while (count);

    if (z_high2)
    {
        *z_ptr++ = z_high1;
        *z_ptr++ = z_high2;
    }
    else if (z_high1)
    {
        *z_ptr++ = z_high1;
    }
    else
    {
    }

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

static int(*EntryPoint_MultipyUInt32)(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z) = MultipyUInt32;

__declspec(dllexport) int __stdcall PMN_MultipyUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (y == 0)
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT)
        return (FALSE);
    if (!(*EntryPoint_MultipyUInt32)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region MultipyUInt64関数

#if _M_IX86
int MultipyUInt64(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    __UNIT_TYPE z_high1 = 0;
    __UNIT_TYPE z_high2 = 0;
    __UNIT_TYPE z_high3 = 0;
    size_t count = x->UNIT_COUNT;
    *z_ptr = 0;

    do
    {
        __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
        __UNIT_TYPE a_low;
        __UNIT_TYPE a_high;
        a_low = _MULTIPLY(*x_ptr, y_low, &a_high);
        _ADD(_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1), z_high2, 0, &z_high2);
        a_low = _MULTIPLY(*x_ptr, y_high, &a_high);
        _ADD(_ADD(_ADD(0, z_high1, a_low, &z_high1), z_high2, a_high, &z_high2), z_high3, 0, &z_high3);
        ++z_ptr;
        *z_ptr = z_high1;
        z_high1 = z_high2;
        z_high2 = z_high3;
        z_high3 = 0;
        --count;
    } while (count);

    if (z_high3)
    {
        *z_ptr++ = z_high1;
        *z_ptr++ = z_high2;
        *z_ptr++ = z_high3;
    }
    else if (z_high2)
    {
        *z_ptr++ = z_high1;
        *z_ptr++ = z_high2;
    }
    else if (z_high1)
    {
        *z_ptr++ = z_high1;
    }
    else
    {
    }

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#elif defined(_M_IX64)
int MultipyUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    __UNIT_TYPE z_high1 = 0;
    __UNIT_TYPE z_high2 = 0;

    size_t count = x->UNIT_COUNT;

    do
    {
        __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
        __UNIT_TYPE a_low;
        __UNIT_TYPE a_high;
        a_low = _MULTIPLY(*x_ptr, y, &a_high);
        if (_ADD(_ADD(0, *z_ptr, a_low, z_ptr), z_high1, a_high, &z_high1))
            ++z_high2;
        ++z_ptr;
        *z_ptr = z_high1;
        z_high1 = z_high2;
        z_high2 = 0;
        --count;
    } while (count);

    if (z_high2)
    {
        *z_ptr++ = z_high1;
        *z_ptr++ = z_high2;
    }
    else if (z_high1)
    {
        *z_ptr++ = z_high1;
    }
    else
    {
    }

    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#else
// undefined
#endif

#if _M_IX86
static int(*EntryPoint_MultipyUInt64)(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z) = MultipyUInt64;
#elif defined(_M_IX64)
static int(*EntryPoint_MultipyUInt64)(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z) = MultipyUInt64;
#else
// undefined
#endif

__declspec(dllexport) int __stdcall PMN_MultipyUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (y == 0)
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT + 1)
        return (FALSE);
    if (x->UNIT_COUNT < 2)
        return (FALSE);
#if _M_IX86
    unsigned __int32 y_high = (unsigned __int32)(y >> 32);
    unsigned __int32 y_low = (unsigned __int32)y;
    if (y_high == 0)
    {
        if (!(*EntryPoint_MultipyUInt32)(x, y_low, z))
            return (FALSE);
    }
    else
    {
        if (!(*EntryPoint_MultipyUInt64)(x, y_high, y_low, z))
            return (FALSE);
    }
    NormalizeBuffer(z);
    return (TRUE);
#elif defined(_M_IX64)
    if (!(*EntryPoint_MultipyUInt64)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
#else
    return (FALSE);
#endif
}

#pragma endregion


int Initialize_Multiply(PROCESSOR_FEATURES *feature)
{
    EntryPoint_Multiply = Multiply;
    return (TRUE);
}

/*
pmn_add.c

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
__inline static void _MEMCPY(unsigned __int32* dst, const unsigned __int32* src, size_t len)
{
    __movsd((unsigned long*)dst, (const unsigned long*)src, len);
}
#elif defined(_M_IX64)
__inline static char _ADD(char carry, unsigned __int64 x, unsigned __int64 y, unsigned __int64* z)
{
    return (_addcarry_u64(carry, x, y, z));
}
__inline static void _MEMCPY(unsigned __int64* dst, const unsigned __int64* src, size_t len)
{
    __movsq((PDWORD64)dst, (const DWORD64*)src, len);
}
#else
// not defined
#endif

#pragma region Add関数

static int Add(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t part1_count = y->UNIT_COUNT;
    size_t part2_count = x->UNIT_COUNT - part1_count;
    char carry = 0;
    size_t part1_count_8 = part1_count / 8;
    if (part1_count_8)
    {
        do
        {
            carry = _ADD(_ADD(_ADD(_ADD(_ADD(_ADD(_ADD(_ADD(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
            x_ptr += 8;
            y_ptr += 8;
            z_ptr += 8;
        } while (--part1_count_8);
    }
    if (part1_count & 0x04)
    {
        carry = _ADD(_ADD(_ADD(_ADD(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
    }
    if (part1_count & 0x02)
    {
        carry = _ADD(_ADD(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
    }
    if (part1_count & 0x01)
    {
        carry = _ADD(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
    }
    if (carry)
    {
        while (1)
        {
            if (!part2_count)
            {
#if _DEBUG
                if (z_ptr >= z_ptr_limit)
                    return (FALSE);
#endif // _DEBUG
                *z_ptr++ = 1;
                break;
            }
            if (!_ADD(0, *x_ptr, 1, z_ptr))
            {
                ++z_ptr;
                if (--part2_count)
                {
                    _MEMCPY(z_ptr, x_ptr+1, part2_count);
                    z_ptr += part2_count;
                }
                break;
            }
            ++x_ptr;
            ++z_ptr;
            --part2_count;
        }
    }
    else if (part2_count)
    {
        _MEMCPY(z_ptr, x_ptr, part2_count);
        z_ptr += part2_count;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

static int(*EntryPoint_Add)(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z) = Add;

__declspec(dllexport) int __stdcall PMN_Add(UNIT_BUFFER* x, UNIT_BUFFER* y, UNIT_BUFFER* z)
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
    if (!(*EntryPoint_Add)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region AddUInt32関数

static int AddUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    if (_ADD(0, *x_ptr, y, z_ptr))
    {
        ++x_ptr;
        ++z_ptr;
        while (count2)
        {
            if (!count2)
            {
#if _DEBUG
                if (z_ptr >= z_ptr_limit)
                    return (FALSE);
#endif // _DEBUG
                *z_ptr = 1;
                ++z_ptr;
                break;
            }
            if (!_ADD(0, *x_ptr, 1, z_ptr))
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
    else  if (count2)
    {
        ++z_ptr;
        _MEMCPY(z_ptr, x_ptr+1, count2);
        z_ptr += count2;
    }
    else
        ++z_ptr;
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

static int(*EntryPoint_AddUInt32)(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z) = AddUInt32;

__declspec(dllexport) int __stdcall PMN_AddUInt32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
    if (!CheckInputBuffer(x))
        return (FALSE);
    if (y == 0)
        return (FALSE);
    if (!CheckOutputBuffer(z))
        return (FALSE);
    if (z->UNIT_COUNT < x->UNIT_COUNT)
        return (FALSE);
    if (z->UNIT_COUNT < (sizeof(unsigned __int32) + sizeof(__UNIT_TYPE) - 1) / sizeof(__UNIT_TYPE))
        return (FALSE);
    if (!(*EntryPoint_AddUInt32)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

#pragma region AddUInt64関数

#ifdef _M_IX86
static int AddUInt64(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    if (x->UNIT_COUNT < 2)
    {
        if (_ADD(_ADD(0, *x_ptr, y_low, &z_ptr[0]), 0, y_high, &z_ptr[1]))
        {
            z_ptr[2] = 1;
            z_ptr += 1;
        }
        z_ptr += 2;
    }
    else
    {
        size_t count2 = x->UNIT_COUNT - 2;
        if (_ADD(_ADD(0, x_ptr[0], y_low, &z_ptr[0]), x_ptr[1], y_high, &z_ptr[1]))
        {
            x_ptr += 2;
            z_ptr += 2;
            while (1)
            {
                if (!count2)
                {
#if _DEBUG
                    if (z_ptr >= z_ptr_limit)
                        return (FALSE);
#endif // _DEBUG
                    *z_ptr = 1;
                    ++z_ptr;
                    break;
                }
                if (!_ADD(0, *x_ptr, 1, z_ptr))
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
            _MEMCPY(z_ptr + 2, x_ptr + 2, count2);
            z_ptr += count2 + 2;
        }
        else
            z_ptr += 2;
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#elif defined(_M_IX64)
static int AddUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    if (_ADD(0, *x_ptr, y, z_ptr))
    {
        ++x_ptr;
        ++z_ptr;
        while (1)
        {
            if (!count2)
            {
#if _DEBUG
                if (z_ptr >= z_ptr_limit)
                    return (FALSE);
#endif // _DEBUG
                *z_ptr = 1;
                ++z_ptr;
                break;
            }
            if (!_ADD(0, *x_ptr, 1, z_ptr))
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
        ++z_ptr;
        _MEMCPY(z_ptr, x_ptr+1, count2);
        z_ptr += count2;
    }
    else
        ++z_ptr;
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#else
#endif

#if defined(_M_IX86)
static int(*EntryPoint_AddUInt64)(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z) = AddUInt64;
#elif defined(_M_IX64)
static int(*EntryPoint_AddUInt64)(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z) = AddUInt64;
#else
// undefined
#endif

__declspec(dllexport) int __stdcall PMN_AddUInt64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
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
        if (!(*EntryPoint_AddUInt32)(x, y_low, z))
            return (FALSE);
    }
    else
    {
        if (!(*EntryPoint_AddUInt64)(x, y_high, y_low, z))
            return (FALSE);
    }
    NormalizeBuffer(z);
    return (TRUE);
#elif defined(_M_IX64)
    if (!(*EntryPoint_AddUInt64)(x, y, z))
        return (FALSE);
    NormalizeBuffer(z);
    return (TRUE);
#else
    return (FALSE);
#endif
}

#pragma endregion

int Initialize_Add(PROCESSOR_FEATURES *feature)
{
    EntryPoint_Add = Add;
    EntryPoint_AddUInt32 = AddUInt32;
    EntryPoint_AddUInt64 = AddUInt64;
    return (TRUE);
}

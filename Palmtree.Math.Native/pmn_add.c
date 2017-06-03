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

#pragma region Add関数

#ifdef _M_IX86
int Add_ADC32(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count1 = y->UNIT_COUNT;
    size_t count2 = x->UNIT_COUNT - count1;
    char carry = 0;
    while (count1 >= 8)
    {
        carry = _addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
        x_ptr += 8;
        y_ptr += 8;
        z_ptr += 8;
        count1 -= 8;
    }
    if (count1 >= 4)
    {
        carry = _addcarry_u32(_addcarry_u32(_addcarry_u32(_addcarry_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
        count1 -= 4;
    }
    if (count1 >= 2)
    {
        carry = _addcarry_u32(_addcarry_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
        count1 -= 2;
    }
    if (count1)
    {
        carry = _addcarry_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
        count1 -= 1;
    }
    while (carry && count2)
    {
        carry = _addcarry_u32(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int Add_ADX32(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count1 = y->UNIT_COUNT;
    size_t count2 = x->UNIT_COUNT - count1;
    char carry = 0;
    while (count1 >= 8)
    {
        carry = _addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
        x_ptr += 8;
        y_ptr += 8;
        z_ptr += 8;
        count1 -= 8;
    }
    if (count1 >= 4)
    {
        carry = _addcarryx_u32(_addcarryx_u32(_addcarryx_u32(_addcarryx_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
        count1 -= 4;
    }
    if (count1 >= 2)
    {
        carry = _addcarryx_u32(_addcarryx_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
        count1 -= 2;
    }
    if (count1)
    {
        carry = _addcarryx_u32(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
        count1 -= 1;
    }
    while (carry && count2)
    {
        carry = _addcarryx_u32(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif // _M_IX86

#ifdef _M_IX64
int Add_ADC64(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count1 = y->UNIT_COUNT;
    size_t count2 = x->UNIT_COUNT - count1;
    char carry = 0;
    while (count1 >= 8)
    {
        carry = _addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
        x_ptr += 8;
        y_ptr += 8;
        z_ptr += 8;
        count1 -= 8;
    }
    if (count1 >= 4)
    {
        carry = _addcarry_u64(_addcarry_u64(_addcarry_u64(_addcarry_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
        count1 -= 4;
    }
    if (count1 >= 2)
    {
        carry = _addcarry_u64(_addcarry_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
        count1 -= 2;
    }
    if (count1)
    {
        carry = _addcarry_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
        count1 -= 1;
    }
    while (carry && count2)
    {
        carry = _addcarry_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int Add_ADX64(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* y_ptr = y->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count1 = y->UNIT_COUNT;
    size_t count2 = x->UNIT_COUNT - count1;
    char carry = 0;
    while (count1 >= 8)
    {
        carry = _addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3), *(x_ptr + 4), *(y_ptr + 4), z_ptr + 4), *(x_ptr + 5), *(y_ptr + 5), z_ptr + 5), *(x_ptr + 6), *(y_ptr + 6), z_ptr + 6), *(x_ptr + 7), *(y_ptr + 7), z_ptr + 7);
        x_ptr += 8;
        y_ptr += 8;
        z_ptr += 8;
        count1 -= 8;
    }
    if (count1 >= 4)
    {
        carry = _addcarryx_u64(_addcarryx_u64(_addcarryx_u64(_addcarryx_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1), *(x_ptr + 2), *(y_ptr + 2), z_ptr + 2), *(x_ptr + 3), *(y_ptr + 3), z_ptr + 3);
        x_ptr += 4;
        y_ptr += 4;
        z_ptr += 4;
        count1 -= 4;
    }
    if (count1 >= 2)
    {
        carry = _addcarryx_u64(_addcarryx_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0), *(x_ptr + 1), *(y_ptr + 1), z_ptr + 1);
        x_ptr += 2;
        y_ptr += 2;
        z_ptr += 2;
        count1 -= 2;
    }
    if (count1)
    {
        carry = _addcarryx_u64(carry, *(x_ptr + 0), *(y_ptr + 0), z_ptr + 0);
        x_ptr += 1;
        y_ptr += 1;
        z_ptr += 1;
        count1 -= 1;
    }
    while (carry && count2)
    {
        carry = _addcarryx_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif

#if defined(_M_IX86)
int(*EntryPoint_Add)(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z) = Add_ADC32;
#elif defined(_M_IX64)
int(*EntryPoint_Add)(UNIT_BUFFER* x, UNIT_BUFFER*  y, UNIT_BUFFER* z) = Add_ADC64;
#else
#endif

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

#ifdef _M_IX86
int AddUInt32_ADC32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarry_u32(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarry_u32(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int AddUInt32_ADX32(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarryx_u32(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarryx_u32(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif // _M_IX86

#ifdef _M_IX64
int AddUInt32_ADC64(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarry_u64(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarry_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64 *)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int AddUInt32_ADX64(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarryx_u64(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarryx_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64 *)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif

#if defined(_M_IX86)
int(*EntryPoint_AddUInt32)(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z) = AddUInt32_ADC32;
#elif defined(_M_IX64)
int(*EntryPoint_AddUInt32)(UNIT_BUFFER* x, unsigned __int32 y, UNIT_BUFFER* z) = AddUInt32_ADC64;
#else
#endif

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
int AddUInt64_ADC32(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    if (x->UNIT_COUNT < 2)
    {
        char carry = 0;
        carry = _addcarry_u32(carry, *x_ptr, y_low, &z_ptr[0]);
        carry = _addcarry_u32(carry, 0, y_high, &z_ptr[1]);
        x_ptr += 1;
        z_ptr += 2;
        if (carry)
        {
            *z_ptr = 1;
            z_ptr += 1;
        }
    }
    else
    {
        size_t count2 = x->UNIT_COUNT - 2;
        char carry = 0;
        carry = _addcarry_u32(carry, x_ptr[0], y_low, &z_ptr[0]);
        carry = _addcarry_u32(carry, x_ptr[1], y_high, &z_ptr[1]);
        x_ptr += 2;
        z_ptr += 2;
        while (carry && count2)
        {
            carry = _addcarry_u32(carry, *x_ptr, 0, z_ptr);
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
        if (carry)
        {
#if _DEBUG
            if (z_ptr >= z_ptr_limit)
                return (FALSE);
#endif // _DEBUG
            *z_ptr = 1;
            ++z_ptr;
        }
        else if (count2)
        {
            __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
            z_ptr += count2;
        }
        else
        {
        }
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int AddUInt64_ADX32(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    if (x->UNIT_COUNT < 2)
    {
        char carry = 0;
        carry = _addcarryx_u32(carry, *x_ptr, y_low, &z_ptr[0]);
        carry = _addcarryx_u32(carry, 0, y_high, &z_ptr[1]);
        x_ptr += 1;
        z_ptr += 2;
        if (carry)
        {
            *z_ptr = 1;
            z_ptr += 1;
        }
    }
    else
    {
        size_t count2 = x->UNIT_COUNT - 2;
        char carry = 0;
        carry = _addcarryx_u32(carry, x_ptr[0], y_low, &z_ptr[0]);
        carry = _addcarryx_u32(carry, x_ptr[1], y_high, &z_ptr[1]);
        x_ptr += 2;
        z_ptr += 2;
        while (carry && count2)
        {
            carry = _addcarryx_u32(carry, *x_ptr, 0, z_ptr);
            ++x_ptr;
            ++z_ptr;
            --count2;
        }
        if (carry)
        {
#if _DEBUG
            if (z_ptr >= z_ptr_limit)
                return (FALSE);
#endif // _DEBUG
            *z_ptr = 1;
            ++z_ptr;
        }
        else if (count2)
        {
            __movsd((unsigned long*)z_ptr, (const unsigned long*)x_ptr, count2);
            z_ptr += count2;
        }
        else
        {
        }
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif // _M_IX86

#ifdef _M_IX64
int AddUInt64_ADC64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarry_u64(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarry_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}

int AddUInt64_ADX64(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z)
{
#if _DEBUG
    __UNIT_TYPE* z_ptr_limit = &z->UNIT_ARRAY[z->UNIT_COUNT];
#endif // _DEBUG
    __UNIT_TYPE* x_ptr = x->UNIT_ARRAY;
    __UNIT_TYPE* z_ptr = z->UNIT_ARRAY;
    size_t count2 = x->UNIT_COUNT - 1;
    char carry = _addcarryx_u64(0, *x_ptr, y, z_ptr);
    ++x_ptr;
    ++z_ptr;
    while (carry && count2)
    {
        carry = _addcarryx_u64(carry, *x_ptr, 0, z_ptr);
        ++x_ptr;
        ++z_ptr;
        --count2;
    }
    if (carry)
    {
#if _DEBUG
        if (z_ptr >= z_ptr_limit)
            return (FALSE);
#endif // _DEBUG
        *z_ptr = 1;
        ++z_ptr;
    }
    else if (count2)
    {
        __movsq((PDWORD64)z_ptr, (const DWORD64*)x_ptr, count2);
        z_ptr += count2;
    }
    else
    {
    }
    z->UNIT_COUNT = z_ptr - z->UNIT_ARRAY;
    return (TRUE);
}
#endif

#if defined(_M_IX86)
int(*EntryPoint_AddUInt64)(UNIT_BUFFER* x, unsigned __int32 y_high, unsigned __int32 y_low, UNIT_BUFFER* z) = AddUInt64_ADC32;
#elif defined(_M_IX64)
int(*EntryPoint_AddUInt64)(UNIT_BUFFER* x, unsigned __int64 y, UNIT_BUFFER* z) = AddUInt64_ADC64;
#else
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
    if (!(*EntryPoint_AddUInt64)(x, (unsigned __int32)(y >> 32), (unsigned __int32)y, z))
        return (FALSE);
#elif defined(_M_IX64)
    if (!(*EntryPoint_AddUInt64)(x, y, z))
        return (FALSE);
#endif // _M_IX86
    NormalizeBuffer(z);
    return (TRUE);
}

#pragma endregion

int Initialize_Add(PROCESSOR_FEATURES *feature)
{
    if (feature->PROCESSOR_FEATURE_ADX)
    {
#if defined(_M_IX86)
        if (sizeof(__UNIT_TYPE) != sizeof(unsigned __int32))
            return (FALSE);
        EntryPoint_Add = Add_ADX32;
        EntryPoint_AddUInt32 = AddUInt32_ADX32;
        EntryPoint_AddUInt64 = AddUInt64_ADX32;
#elif defined(_M_IX64)
        if (sizeof(__UNIT_TYPE) != sizeof(unsigned __int64))
            return (FALSE);
        EntryPoint_Add = Add_ADX64;
        EntryPoint_AddUInt32 = AddUInt32_ADX64;
        EntryPoint_AddUInt64 = AddUInt64_ADX64;
#else
        return (FALSE);
#endif
    }
    else
    {
#if defined(_M_IX86)
        if (sizeof(__UNIT_TYPE) != sizeof(unsigned __int32))
            return (FALSE);
        EntryPoint_Add = Add_ADC32;
        EntryPoint_AddUInt32 = AddUInt32_ADX32;
        EntryPoint_AddUInt64 = AddUInt64_ADX32;
#elif defined(_M_IX64)
        if (sizeof(__UNIT_TYPE) != sizeof(unsigned __int64))
            return (FALSE);
        EntryPoint_Add = Add_ADC64;
        EntryPoint_AddUInt32 = AddUInt32_ADC64;
        EntryPoint_AddUInt64 = AddUInt64_ADC64;
#else
        return (FALSE);
#endif
    }
    return (TRUE);
}

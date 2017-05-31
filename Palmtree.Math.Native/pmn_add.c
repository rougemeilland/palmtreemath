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

int Add_ADC32(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length)
{
#if _DEBUG
    if (x == NULL)
        return (FALSE);
    if (y == NULL)
        return (FALSE);
    if (z == NULL)
        return (FALSE);
    if (z_length == NULL)
        return (FALSE);
    if (x_length < y_length)
        return (FALSE);
    if (*z_length < x_length)
        return (FALSE);
    unsigned __int32* z_ptr_limit = (unsigned __int32*)((unsigned char*)z + *z_length);
#endif // _DEBUG
    unsigned __int32* x_ptr = (unsigned __int32*)x;
    unsigned __int32* y_ptr = (unsigned __int32*)y;
    unsigned __int32* z_ptr = (unsigned __int32*)z;
    size_t count1 = y_length / sizeof(unsigned __int32);
    size_t count2 = x_length / sizeof(unsigned __int32) - count1;
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
    *z_length = (unsigned char*)z_ptr - (unsigned char*)z;
    return (TRUE);
}

int Add_ADX32(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length)
{
#if _DEBUG
    if (x == NULL)
        return (FALSE);
    if (y == NULL)
        return (FALSE);
    if (z == NULL)
        return (FALSE);
    if (z_length == NULL)
        return (FALSE);
    if (x_length < y_length)
        return (FALSE);
    if (*z_length < x_length)
        return (FALSE);
    unsigned __int32* z_ptr_limit = (unsigned __int32*)((unsigned char*)z + *z_length);
#endif // _DEBUG
    unsigned __int32* x_ptr = (unsigned __int32*)x;
    unsigned __int32* y_ptr = (unsigned __int32*)y;
    unsigned __int32* z_ptr = (unsigned __int32*)z;
    size_t count1 = y_length / sizeof(unsigned __int32);
    size_t count2 = x_length / sizeof(unsigned __int32) - count1;
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
    *z_length = (unsigned char*)z_ptr - (unsigned char*)z;
    return (TRUE);
}

#ifdef _M_IX64
int Add_ADC64(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length)
{
#if _DEBUG
    if (x == NULL)
        return (FALSE);
    if (y == NULL)
        return (FALSE);
    if (z == NULL)
        return (FALSE);
    if (z_length == NULL)
        return (FALSE);
    if (x_length < y_length)
        return (FALSE);
    if (*z_length < x_length)
        return (FALSE);
    unsigned __int64* z_ptr_limit = (unsigned __int64*)((unsigned char*)z + *z_length);
#endif // _DEBUG
    unsigned __int64* x_ptr = (unsigned __int64*)x;
    unsigned __int64* y_ptr = (unsigned __int64*)y;
    unsigned __int64* z_ptr = (unsigned __int64*)z;
    size_t count1 = y_length / sizeof(unsigned __int64);
    size_t count2 = x_length / sizeof(unsigned __int64) - count1;
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
    *z_length = (unsigned char*)z_ptr - (unsigned char*)z;
    return (TRUE);
}

int Add_ADX64(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length)
{
#if _DEBUG
    if (x == NULL)
        return (FALSE);
    if (y == NULL)
        return (FALSE);
    if (z == NULL)
        return (FALSE);
    if (z_length == NULL)
        return (FALSE);
    if (x_length < y_length)
        return (FALSE);
    if (*z_length < x_length)
        return (FALSE);
    unsigned __int64* z_ptr_limit = (unsigned __int64*)((unsigned char*)z + *z_length);
#endif // _DEBUG
    unsigned __int64* x_ptr = (unsigned __int64*)x;
    unsigned __int64* y_ptr = (unsigned __int64*)y;
    unsigned __int64* z_ptr = (unsigned __int64*)z;
    size_t count1 = y_length / sizeof(unsigned __int64);
    size_t count2 = x_length / sizeof(unsigned __int64) - count1;
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
    *z_length = (unsigned char*)z_ptr - (unsigned char*)z;
    return (TRUE);
}
#endif

int(*EntryPoint_Add)(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length) = Add_ADC32;

int Initialize_Add(PROCESSOR_FEATURES *feature)
{
    if (feature->PROCESSOR_FEATURE_ADX)
    {
#ifdef _M_IX64
        EntryPoint_Add = Add_ADX64;
#else // _M_IX64
        EntryPoint_Add = Add_ADX32;
#endif // _M_IX64
    }
    else
    {
#ifdef _M_IX64
        EntryPoint_Add = Add_ADC64;
#else // _M_IX64
        EntryPoint_Add = Add_ADC32;
#endif // _M_IX64
    }
    return (TRUE);
}

__declspec(dllexport) int __stdcall PMN_Add(void* x, size_t x_length, void*  y, size_t y_length, void* z, size_t* z_length)
{
    if (!CheckBuffer(x, x_length))
        return (FALSE);
    if (!CheckBuffer(y, y_length))
        return (FALSE);
    if (!CheckBuffer(z, *z_length))
        return (FALSE);
    if (!(*EntryPoint_Add)(x, x_length, y, y_length, z, z_length))
        return (FALSE);
    *z_length = NormalizeBufferSize(z, *z_length);
    return (TRUE);
}

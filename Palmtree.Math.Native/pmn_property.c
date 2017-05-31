/*
pmn_property.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

#include <windows.h>
#include <intrin.h>
#include <immintrin.h>
#include "pmn.h"
#include "pmn_internal.h"

int IsOne_Imp(const void * buffer, size_t buffer_size, int* result)
{
    *result = buffer_size == sizeof(__UNIT_TYPE) && *((__UNIT_TYPE*)buffer) == 1;
    return (TRUE);
}

__declspec(dllexport) int __stdcall PMN_IsOne(const void* buffer, size_t buffer_size, int* result)
{
    if (!CheckBuffer(buffer, buffer_size))
        return (FALSE);
    return (IsOne_Imp(buffer, buffer_size, result));
}

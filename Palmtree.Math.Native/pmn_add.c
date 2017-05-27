/*
pmn_add.c

Copyright (c) 2017 Palmtree Software

This software is released under the MIT License.
https://opensource.org/licenses/MIT
*/

// CPUID�ɂ���:
//   http://www.wdic.org/w/SCI/cpuid%20%28x86%29
// �g�ݍ��݊֐��ɂ���:
//   https://software.intel.com/sites/landingpage/IntrinsicsGuide/#techs=Other // �{��(�p��)
//   https://msdn.microsoft.com/ja-jp/library/hh977023.aspx // MS

#include <windows.h>
#include <malloc.h>
#include <intrin.h>
#include <immintrin.h>
#include "pmn.h"
#include "pmn_internal.h"

#if defined(_M_IX86)

#elif defined(_M_IX64)

#else

#endif

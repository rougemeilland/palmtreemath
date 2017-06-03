#include <windows.h>
#include <intrin.h>
#include <immintrin.h>

int AddUInt32_ADC32(unsigned __int32 x, unsigned __int32 y, unsigned __int64* z)
{
    unsigned __int32* z_ptr = (unsigned __int32*)z;
    char carry = _addcarry_u32(0, x, y, z_ptr + 0);
    _addcarry_u32(carry, 0, 0, z_ptr + 1);
    return (TRUE);
}

#if 1
int AddUInt32_ADX32(unsigned __int32 x, unsigned __int32 y, unsigned __int64* z)
{
    unsigned __int32* z_ptr = (unsigned __int32*)z;
    char carry = _addcarryx_u32(0, x, y, z_ptr + 0);
    _addcarryx_u32(carry, 0, 0, z_ptr + 1);
    return (TRUE);
}
#endif // 0


__declspec(dllexport) int __stdcall PMN_AddUInt32(unsigned __int32 x, unsigned __int32 y, unsigned __int64* z, int flag)
{
    return (!(flag ? AddUInt32_ADX32 : AddUInt32_ADC32)(x, y, z));
}


#include <windows.h>
#include <intrin.h>
#include <immintrin.h>

/*
���P���Ȉȉ��̃R�[�h�ł��Č����܂����B
*/
__declspec(dllexport) char __stdcall Statement_ADX(char carry, unsigned __int32 x, unsigned __int32 y, unsigned __int32* z_high, unsigned __int32* z_low)
{
    carry = _addcarryx_u32(carry, x, y, z_low);
    carry = _addcarryx_u32(carry, 0, 0, z_high);
    return (carry);
}

/*

�y�G���[���b�Z�[�W�z
*****�G���[���b�Z�[�W��������*****
------ �r���h�J�n: �v���W�F�N�g: CppBug, �\��: Release Win32 ------
Add.c
���C�u���� Z:\Sources\Lunor\Repos\palmtreemath\Release\CppBug.lib �ƃI�u�W�F�N�g Z:\Sources\Lunor\Repos\palmtreemath\Release\CppBug.exp ���쐬��
�R�[�h�������Ă��܂��B
z:\sources\lunor\repos\palmtreemath\cppbug\add.c(13): fatal error C1001: �R���p�C���œ����G���[���������܂����B
(�R���p�C�� �t�@�C�� 'f:\dd\vctools\compiler\utc\src\p2\main.c'�A�s 255)
���̖����������ɂ́A��L�̏ꏊ�t�߂̃v���O������P�������邩�ύX���Ă��������B
�ڍׂɂ��ẮAVisual C++ �w���v ���j���[�̃T�|�[�g���R�}���h��
�I�����Ă��������B�܂��̓T�|�[�g��� �w���v �t�@�C�����Q�Ƃ��Ă��������B

�v���W�F�N�g "CppBug.vcxproj" �̃r���h���I�����܂��� -- ���s�B
*****�G���[���b�Z�[�W�����܂�*****


�y���s���Ă݂����Ɓz
�E_addcarryx_u32 �� _addcarry_u32 �ɒu��������Ɛ���Ƀr���h�ł��܂����B
�E11�s�ڂ��R�����g�A�E�g����Ɛ���Ƀr���h�ł��܂����B
�Ecarry �� 2�� _addcarryx_u32 �̊Ԃň����p���ł��邱�Ƃ��֌W���Ă���̂�������Ȃ��ƍl���āA������10�`11�s�ڂ��ȉ��̂悤�ɕύX���Ă݂܂������A���l�̃G���[���������܂����B
*****�ύX��������*****
carry = _addcarryx_u32(0, x, y, z_low);
carry = _addcarryx_u32(0, 0, 0, z_high);
*****�ύX�����܂�*****

*/
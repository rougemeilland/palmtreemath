#include <windows.h>
#include <intrin.h>
#include <immintrin.h>

/*
より単純な以下のコードでも再現しました。
*/
__declspec(dllexport) char __stdcall Statement_ADX(char carry, unsigned __int32 x, unsigned __int32 y, unsigned __int32* z_high, unsigned __int32* z_low)
{
    carry = _addcarryx_u32(carry, x, y, z_low);
    carry = _addcarryx_u32(carry, 0, 0, z_high);
    return (carry);
}

/*

【エラーメッセージ】
*****エラーメッセージここから*****
------ ビルド開始: プロジェクト: CppBug, 構成: Release Win32 ------
Add.c
ライブラリ Z:\Sources\Lunor\Repos\palmtreemath\Release\CppBug.lib とオブジェクト Z:\Sources\Lunor\Repos\palmtreemath\Release\CppBug.exp を作成中
コード生成しています。
z:\sources\lunor\repos\palmtreemath\cppbug\add.c(13): fatal error C1001: コンパイラで内部エラーが発生しました。
(コンパイラ ファイル 'f:\dd\vctools\compiler\utc\src\p2\main.c'、行 255)
この問題を回避するには、上記の場所付近のプログラムを単純化するか変更してください。
詳細については、Visual C++ ヘルプ メニューのサポート情報コマンドを
選択してください。またはサポート情報 ヘルプ ファイルを参照してください。

プロジェクト "CppBug.vcxproj" のビルドが終了しました -- 失敗。
*****エラーメッセージここまで*****


【試行してみたこと】
・_addcarryx_u32 を _addcarry_u32 に置き換えると正常にビルドできました。
・11行目をコメントアウトすると正常にビルドできました。
・carry を 2つの _addcarryx_u32 の間で引き継いでいることが関係しているのかもしれないと考えて、試しに10～11行目を以下のように変更してみましたが、同様のエラーが発生しました。
*****変更ここから*****
carry = _addcarryx_u32(0, x, y, z_low);
carry = _addcarryx_u32(0, 0, 0, z_high);
*****変更ここまで*****

*/
/*
  LinqExtensions.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Palmtree.Math
{
    /// <summary>
    /// <see cref="UnsignedLongLongInteger"/>/<see cref="LongLongInteger"/>/<see cref="RationalNumber"/>型のコレクションの拡張メソッドのクラスです。
    /// </summary>
    public static class LinqExtensions
    {
        #region AverageAccumulator<ELEMENT_T> の定義

        private class AverageAccumulator<ELEMENT_T>
        {
            #region コンストラクタ

            public AverageAccumulator(ELEMENT_T total, uint count)
            {
                Total = total;
                Count = count;
            }

            #endregion

            #region パブリックプロパティ

            public ELEMENT_T Total { get; private set; }
            public uint Count { get; private set; }

            #endregion
        }

        #endregion

        #region MinMaxAccumulator<ELEMENT_T, VALUE_T> の定義

        private class MinMaxAccumulator<ELEMENT_T, VALUE_T>
        {
            #region コンストラクタ

            public MinMaxAccumulator(ELEMENT_T item, VALUE_T value)
            {
                Item = item;
                Value = value;
            }

            #endregion

            #region パブリックプロパティ

            public ELEMENT_T Item { get; private set; }
            public VALUE_T Value { get; private set; }

            #endregion
        }

        #endregion

        #region Sum のオーバーロード

        /// <summary>
        /// コレクションに含まれる要素の合計値を返します。
        /// </summary>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static UnsignedLongLongInteger Sum(this IEnumerable<UnsignedLongLongInteger> source)
        {
            return (source.SumImp(UnsignedLongLongInteger.Zero, (x, y) => x + y));
        }

        /// <summary>
        /// コレクションに含まれる要素の合計値を返します。
        /// </summary>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static LongLongInteger Sum(this IEnumerable<LongLongInteger> source)
        {
            return (source.SumImp(LongLongInteger.Zero, (x, y) => x + y));
        }

        /// <summary>
        /// コレクションに含まれる要素の合計値を返します。
        /// </summary>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static RationalNumber Sum(this IEnumerable<RationalNumber> source)
        {
            return (source.SumImp(RationalNumber.Zero, (x, y) => x + y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の合計値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から合計値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static UnsignedLongLongInteger Sum<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, UnsignedLongLongInteger> value_selecter)
        {
            return (source.SumImp(value_selecter, UnsignedLongLongInteger.Zero, (x, y) => x + y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の合計値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から合計値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static LongLongInteger Sum<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, LongLongInteger> value_selecter)
        {
            return (source.SumImp(value_selecter, LongLongInteger.Zero, (x, y) => x + y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の合計値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 合計値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から合計値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された合計値です。
        /// </returns>
        public static RationalNumber Sum<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, RationalNumber> value_selecter)
        {
            return (source.SumImp(value_selecter, RationalNumber.Zero, (x, y) => x + y));
        }

        #endregion

        #region Average のオーバーロード

        /// <summary>
        /// コレクションに含まれる要素の平均値を返します。
        /// </summary>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static UnsignedLongLongInteger Average(this IEnumerable<UnsignedLongLongInteger> source)
        {
            return (AverageImp(source, UnsignedLongLongInteger.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        /// <summary>
        /// コレクションに含まれる要素の平均値を返します。
        /// </summary>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static LongLongInteger Average(this IEnumerable<LongLongInteger> source)
        {
            return (AverageImp(source, LongLongInteger.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        /// <summary>
        /// コレクションに含まれる要素の平均値を返します。
        /// </summary>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static RationalNumber Average(this IEnumerable<RationalNumber> source)
        {
            return (AverageImp(source, RationalNumber.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の平均値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から平均値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static UnsignedLongLongInteger Average<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, UnsignedLongLongInteger> value_selecter)
        {
            return (source.AverageImp(value_selecter, UnsignedLongLongInteger.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の平均値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から平均値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static LongLongInteger Average<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, LongLongInteger> value_selecter)
        {
            return (source.AverageImp(value_selecter, LongLongInteger.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の平均値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 平均値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から平均値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された平均値です。
        /// </returns>
        public static RationalNumber Average<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, RationalNumber> value_selecter)
        {
            return (source.AverageImp(value_selecter, RationalNumber.Zero, (x, y) => x + y, (x, y) => x / y));
        }

        #endregion

        #region Min のオーバーロード

        /// <summary>
        /// コレクションに含まれる要素の最小値を返します。
        /// </summary>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static UnsignedLongLongInteger Min(this IEnumerable<UnsignedLongLongInteger> source)
        {
            return (source.MinMaxImp((x, y) => x < y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素の最小値を返します。
        /// </summary>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static LongLongInteger Min(this IEnumerable<LongLongInteger> source)
        {
            return (source.MinMaxImp((x, y) => x < y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素の最小値を返します。
        /// </summary>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static RationalNumber Min(this IEnumerable<RationalNumber> source)
        {
            return (source.MinMaxImp((x, y) => x < y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最小値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最小値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static UnsignedLongLongInteger Min<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, UnsignedLongLongInteger> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x < y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最小値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最小値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static LongLongInteger Min<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, LongLongInteger> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x < y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最小値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最小値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最小値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最小値です。
        /// </returns>
        public static RationalNumber Min<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, RationalNumber> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x < y).Value);
        }

        #endregion

        #region Max のオーバーロード

        /// <summary>
        /// コレクションに含まれる要素の最大値を返します。
        /// </summary>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static UnsignedLongLongInteger Max(this IEnumerable<UnsignedLongLongInteger> source)
        {
            return (source.MinMaxImp((x, y) => x > y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素の最大値を返します。
        /// </summary>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static LongLongInteger Max(this IEnumerable<LongLongInteger> source)
        {
            return (source.MinMaxImp((x, y) => x > y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素の最大値を返します。
        /// </summary>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static RationalNumber Max(this IEnumerable<RationalNumber> source)
        {
            return (source.MinMaxImp((x, y) => x > y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最大値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最大値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static UnsignedLongLongInteger Max<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, UnsignedLongLongInteger> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x > y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最大値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最大値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static LongLongInteger Max<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, LongLongInteger> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x > y).Value);
        }

        /// <summary>
        /// コレクションに含まれる要素からセレクタで取得した値の最大値を返します。
        /// </summary>
        /// <typeparam name="ELEMENT_T">
        /// コレクションの要素の型です。
        /// </typeparam>
        /// <param name="source">
        /// 最大値を計算するコレクションです。
        /// </param>
        /// <param name="value_selecter">
        /// コレクションの要素から最大値を計算する値を取得するためのセレクタです。
        /// </param>
        /// <returns>
        /// 計算された最大値です。
        /// </returns>
        public static RationalNumber Max<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, RationalNumber> value_selecter)
        {
            return (source.MinMaxImp(value_selecter, (x, y) => x > y).Value);
        }

        #endregion

        #region プライベートメソッド

        private static ELEMENT_T SumImp<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, ELEMENT_T zero_value, Func<ELEMENT_T, ELEMENT_T, ELEMENT_T> adder)
        {
            return (source.SumImp(item => item, zero_value, adder));
        }

        private static VALUE_T SumImp<ELEMENT_T, VALUE_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, VALUE_T> value_selecter, VALUE_T zero_value, Func<VALUE_T, VALUE_T, VALUE_T> adder)
        {
            return (source.Aggregate(zero_value, (total, x) => adder(total, value_selecter(x))));
        }

        private static ELEMENT_T AverageImp<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, ELEMENT_T zero_value, Func<ELEMENT_T, ELEMENT_T, ELEMENT_T> adder, Func<ELEMENT_T, uint, ELEMENT_T> divider)
        {
            return (source.AverageImp(item => item, zero_value, adder, divider));
        }

        private static VALUE_T AverageImp<ELEMENT_T, VALUE_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, VALUE_T> value_selecter, VALUE_T zero_value, Func<VALUE_T, VALUE_T, VALUE_T> adder, Func<VALUE_T, uint, VALUE_T> divider)
        {
            var result = source.Aggregate(new AverageAccumulator<VALUE_T>(zero_value, 0), (acc, x) => new AverageAccumulator<VALUE_T>(adder(acc.Total, value_selecter(x)), acc.Count + 1));
            return (divider(result.Total, result.Count));
        }

        private static MinMaxAccumulator<ELEMENT_T, ELEMENT_T> MinMaxImp<ELEMENT_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, ELEMENT_T, bool> is_replace)
        {
            return (source.MinMaxImp(item => item, is_replace));
        }

        private static MinMaxAccumulator<ELEMENT_T, VALUE_T> MinMaxImp<ELEMENT_T, VALUE_T>(this IEnumerable<ELEMENT_T> source, Func<ELEMENT_T, VALUE_T> value_selecter, Func<VALUE_T, VALUE_T, bool> is_replace)
        {
            var r = source.Aggregate((MinMaxAccumulator<ELEMENT_T, VALUE_T>)null,
                                     (acc, item) =>
                                     {
                                         var value = value_selecter(item);
                                         if (acc == null || is_replace(value, acc.Value))
                                             return (new MinMaxAccumulator<ELEMENT_T, VALUE_T>(item, value));
                                         else
                                             return (acc);
                                     });
            if (r == null)
                throw new ArgumentException();
            return (r);
        }
        #endregion
    }
}
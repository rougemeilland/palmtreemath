/*
  RationalNumberSerializer.cs

  Copyright (c) 2017 Palmtree Software

  This software is released under the MIT License.
  https://opensource.org/licenses/MIT
*/

using System;
using System.Globalization;
using Palmtree.Plugin;
using Palmtree.Serialization;

namespace Palmtree.Math.SerializerPlugin
{
    internal class RationalNumberSerializer
        : SimpleTypeSerializerBase
    {
        #region コンストラクタ

        public RationalNumberSerializer(PluginInitializingParameter p)
            : base(p.IsBuiltin, false, null, Guid.Empty, typeof(RationalNumber), "RationalNumber")
        {
        }

        #endregion

        #region SimpleTypeSerializers から継承されたメンバ

        protected override string Serialize(object instance)
        {
            RationalNumber value = (RationalNumber)instance;
            return (value.ToString("R", CultureInfo.InvariantCulture.NumberFormat));
        }

        protected override object Deserialize(string text)
        {
            RationalNumber instance;
            if (!RationalNumber.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture.NumberFormat, out instance))
                throw (new ArgumentException(string.Format("テキスト'{0}'を型'{1}'としてデシリアライズできません。",
                                                           text,
                                                           instance.GetType().FullName),
                                             "text"));
            return (instance);
        }

        #endregion
    }
}

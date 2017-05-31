/*
  UnsignedLongLongIntegerSerializer.cs

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
    internal class UnsignedLongLongIntegerSerializer
        : SimpleTypeSerializerBase
    {
        #region コンストラクタ

        public UnsignedLongLongIntegerSerializer(PluginInitializingParameter p)
            : base(p.IsBuiltin, false, null, Guid.Empty, typeof(UnsignedLongLongInteger), "UnsignedLongLongInteger")
        {
        }

        #endregion

        #region SimpleTypeSerializers から継承されたメンバ

        protected override string Serialize(object instance)
        {
            UnsignedLongLongInteger value = (UnsignedLongLongInteger)instance;
            return (value.ToString("R", CultureInfo.InvariantCulture.NumberFormat));
        }

        protected override object Deserialize(string text)
        {
            UnsignedLongLongInteger instance;
            if (!UnsignedLongLongInteger.TryParse(text, NumberStyles.Integer | NumberStyles.AllowThousands, CultureInfo.InvariantCulture.NumberFormat, out instance))
                throw (new ArgumentException(string.Format("テキスト'{0}'を型'{1}'としてデシリアライズできません。",
                                                           text,
                                                           instance.GetType().FullName),
                                             "text"));
            return (instance);
        }

        #endregion
    }
}

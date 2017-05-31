/*
  LongLongIntegerSerializer.cs

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
    internal class LongLongIntegerSerializer
        : SimpleTypeSerializerBase
    {
        #region コンストラクタ

        public LongLongIntegerSerializer(PluginInitializingParameter p)
            : base(p.IsBuiltin, false, null, Guid.Empty, typeof(LongLongInteger), "LongLongInteger")
        {
        }

        #endregion

        #region SimpleTypeSerializers から継承されたメンバ

        protected override string Serialize(object instance)
        {
            LongLongInteger value = (LongLongInteger)instance;
            return (value.ToString("R", CultureInfo.InvariantCulture.NumberFormat));
        }

        protected override object Deserialize(string text)
        {
            LongLongInteger instance;
            if (!LongLongInteger.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture.NumberFormat, out instance))
                throw (new ArgumentException(string.Format("テキスト'{0}'を型'{1}'としてデシリアライズできません。",
                                                           text,
                                                           instance.GetType().FullName),
                                             "text"));
            return (instance);
        }

        #endregion
    }
}
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
        #region �R���X�g���N�^

        public UnsignedLongLongIntegerSerializer(PluginInitializingParameter p)
            : base(p.IsBuiltin, false, null, Guid.Empty, typeof(UnsignedLongLongInteger), "UnsignedLongLongInteger")
        {
        }

        #endregion

        #region SimpleTypeSerializers ����p�����ꂽ�����o

        protected override string Serialize(object instance)
        {
            UnsignedLongLongInteger value = (UnsignedLongLongInteger)instance;
            return (value.ToString("R", CultureInfo.InvariantCulture.NumberFormat));
        }

        protected override object Deserialize(string text)
        {
            UnsignedLongLongInteger instance;
            if (!UnsignedLongLongInteger.TryParse(text, NumberStyles.Integer | NumberStyles.AllowThousands, CultureInfo.InvariantCulture.NumberFormat, out instance))
                throw (new ArgumentException(string.Format("�e�L�X�g'{0}'��^'{1}'�Ƃ��ăf�V���A���C�Y�ł��܂���B",
                                                           text,
                                                           instance.GetType().FullName),
                                             "text"));
            return (instance);
        }

        #endregion
    }
}

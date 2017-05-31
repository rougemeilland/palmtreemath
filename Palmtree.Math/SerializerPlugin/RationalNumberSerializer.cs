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
        #region �R���X�g���N�^

        public RationalNumberSerializer(PluginInitializingParameter p)
            : base(p.IsBuiltin, false, null, Guid.Empty, typeof(RationalNumber), "RationalNumber")
        {
        }

        #endregion

        #region SimpleTypeSerializers ����p�����ꂽ�����o

        protected override string Serialize(object instance)
        {
            RationalNumber value = (RationalNumber)instance;
            return (value.ToString("R", CultureInfo.InvariantCulture.NumberFormat));
        }

        protected override object Deserialize(string text)
        {
            RationalNumber instance;
            if (!RationalNumber.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture.NumberFormat, out instance))
                throw (new ArgumentException(string.Format("�e�L�X�g'{0}'��^'{1}'�Ƃ��ăf�V���A���C�Y�ł��܂���B",
                                                           text,
                                                           instance.GetType().FullName),
                                             "text"));
            return (instance);
        }

        #endregion
    }
}

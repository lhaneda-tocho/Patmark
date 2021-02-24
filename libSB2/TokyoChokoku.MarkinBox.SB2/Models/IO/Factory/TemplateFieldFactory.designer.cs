﻿﻿// 
// This code is generated by "TemplateFieldFactory.tt"
// Not allowed to modify this code because your changes are deleted when in regeration.
// 


namespace TokyoChokoku.MarkinBox.Sketchbook
{
	using System;
	using System.Collections.Generic;

    using TokyoChokoku.MarkinBox.Sketchbook.Fields;
	using TokyoChokoku.MarkinBox.Sketchbook.Parameters;

	
	public static partial class FieldFactory
	{

        /// <summary>
        /// ファイルから読み取った MBData からフィールドを作成します．
        /// MBData の形式が不正であり，読み取ることができなかった場合は null となります．
        /// </summary>
        /// <param name="raw">Raw.</param>
		public static IField<IConstantParameter> Create (MBData raw) {

			if ( !FieldTypeExt.IsDefined (raw.Type) ) {
				string errorMessage = "No such field type : " + raw.Type;
                System.Diagnostics.Debug.WriteLine (errorMessage);
                return null;
			}

			var fieldType = (FieldType)raw.Type;

			switch ( fieldType ) {
			case FieldType.HorizontalText:
				return HorizontalText.Constant.Create (raw);

			case FieldType.YVerticalText:
				return YVerticalText.Constant.Create (raw);

			case FieldType.XVerticalText:
				return XVerticalText.Constant.Create (raw);

			case FieldType.InnerArcText:
				return InnerArcText.Constant.Create (raw);

			case FieldType.OuterArcText:
				return OuterArcText.Constant.Create (raw);

			case FieldType.QrCode:
				return QrCode.Constant.Create (raw);

			case FieldType.DataMatrix:
				return DataMatrix.Constant.Create (raw);

			case FieldType.Rectangle:
				return Rectangle.Constant.Create (raw);

			case FieldType.Triangle:
				return Triangle.Constant.Create (raw);

			case FieldType.Circle:
				return Circle.Constant.Create (raw);

			case FieldType.Line:
				return Line.Constant.Create (raw);

			case FieldType.Bypass:
				return Bypass.Constant.Create (raw);

			case FieldType.Ellipse:
				return Ellipse.Constant.Create (raw);

			default:
				throw new ForgottenToImplementFactoryException ();
			}
		}



        /// <summary>
        /// ファイルから読み取った MBData から可変フィールドを作成します．
        /// MBData の形式が不正であり，読み取ることができなかった場合は null となります．
        /// </summary>
        /// <param name="raw">Raw.</param>
        public static IMutableField<IMutableParameter> CreateMutable (MBData raw) {

            if ( !FieldTypeExt.IsDefined (raw.Type) ) {
                string errorMessage = "No such field type : " + raw.Type;
                System.Diagnostics.Debug.WriteLine (errorMessage);
                return null;
            }

            var fieldType = (FieldType)raw.Type;

            switch ( fieldType ) {
            case FieldType.HorizontalText:
                return HorizontalText.Mutable.Create (raw);

            case FieldType.YVerticalText:
                return YVerticalText.Mutable.Create (raw);

            case FieldType.XVerticalText:
                return XVerticalText.Mutable.Create (raw);

            case FieldType.InnerArcText:
                return InnerArcText.Mutable.Create (raw);

            case FieldType.OuterArcText:
                return OuterArcText.Mutable.Create (raw);

            case FieldType.QrCode:
                return QrCode.Mutable.Create (raw);

            case FieldType.DataMatrix:
                return DataMatrix.Mutable.Create (raw);

            case FieldType.Rectangle:
                return Rectangle.Mutable.Create (raw);

            case FieldType.Triangle:
                return Triangle.Mutable.Create (raw);

            case FieldType.Circle:
                return Circle.Mutable.Create (raw);

            case FieldType.Line:
                return Line.Mutable.Create (raw);

            case FieldType.Bypass:
                return Bypass.Mutable.Create (raw);

            case FieldType.Ellipse:
                return Ellipse.Mutable.Create (raw);

            default:
                throw new ForgottenToImplementFactoryException ();
            }
        }

	}
}
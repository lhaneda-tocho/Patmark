﻿// 
// This code is generated by "OwnerTemplate.tt"
// Not allowed to modify this code because your changes are deleted when in regeration.
// 


namespace TokyoChokoku.MarkinBox.Sketchbook.Fields
{
	using System;
	using System.Collections.Generic;

	using TokyoChokoku.MarkinBox.Sketchbook.Parameters;

	
	public sealed partial class Owner
	{
		public static Owner Create (MBData raw) {
			if ( !FieldTypeExt.IsDefined (raw.Type) ) {
				string errorMessage = "No such field type : " + raw.Type;
				var text = HorizontalText.Mutable.Create ();
				text.Parameter.Text = errorMessage;
				return Owner.Create ( text.ToConstant () );
			}

			var fieldType = (FieldType)raw.Type;

			switch ( fieldType ) {
			case FieldType.HorizontalText:
				return new Owner (HorizontalText.Constant.Create (raw));

			case FieldType.YVerticalText:
				return new Owner (YVerticalText.Constant.Create (raw));

			case FieldType.XVerticalText:
				return new Owner (XVerticalText.Constant.Create (raw));

			case FieldType.InnerArcText:
				return new Owner (InnerArcText.Constant.Create (raw));

			case FieldType.OuterArcText:
				return new Owner (OuterArcText.Constant.Create (raw));

			case FieldType.QrCode:
				return new Owner (QrCode.Constant.Create (raw));

			case FieldType.DataMatrix:
				return new Owner (DataMatrix.Constant.Create (raw));

			case FieldType.Rectangle:
				return new Owner (Rectangle.Constant.Create (raw));

			case FieldType.Triangle:
				return new Owner (Triangle.Constant.Create (raw));

			case FieldType.Circle:
				return new Owner (Circle.Constant.Create (raw));

			case FieldType.Line:
				return new Owner (Line.Constant.Create (raw));

			case FieldType.Bypass:
				return new Owner (Bypass.Constant.Create (raw));

			case FieldType.Ellipse:
				return new Owner (Ellipse.Constant.Create (raw));

			default:
				throw new ForgottenToImplementFactoryException ();
			}
		}


	}
}
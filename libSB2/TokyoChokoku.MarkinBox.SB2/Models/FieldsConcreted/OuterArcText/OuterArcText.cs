﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using TokyoChokoku.MarkinBox.Sketchbook.Parameters;

namespace TokyoChokoku.MarkinBox.Sketchbook.Fields
{
	/// <summary>
	/// 
	/// </summary>
	public abstract partial class OuterArcText
	{
        public IField <IConstantParameter> ToInnerArcText () {
            return InnerArcText.Constant.Create (ToSerializable ());
        }
	}
}


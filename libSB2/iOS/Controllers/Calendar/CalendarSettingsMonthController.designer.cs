// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TokyoChokoku.MarkinBox.Sketchbook.iOS
{
    [Register ("CalendarSettingsMonthController")]
    partial class CalendarSettingsMonthController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView InputCollection { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (InputCollection != null) {
                InputCollection.Dispose ();
                InputCollection = null;
            }
        }
    }
}
﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XibTableCellDesign
{
  [Register("MyCustomCell")]
  partial class MyCustomCell
  {
    [Outlet]
    UIKit.UILabel ConferenceDescription { get; set; }

    [Outlet]
    UIKit.UILabel ConferenceName { get; set; }

    [Outlet]
    UIKit.UILabel ConferenceStart { get; set; }

    void ReleaseDesignerOutlets()
    {
      if (ConferenceDescription != null)
      {
        ConferenceDescription.Dispose();
        ConferenceDescription = null;
      }

      if (ConferenceName != null)
      {
        ConferenceName.Dispose();
        ConferenceName = null;
      }

      if (ConferenceStart != null)
      {
        ConferenceStart.Dispose();
        ConferenceStart = null;
      }
    }
  }
}

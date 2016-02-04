// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XibTableCellDesign
{
	[Register ("AccountReceivableCell")]
	partial class AccountReceivableCell
	{
		[Outlet]
		UIKit.UIButton btnInvoice { get; set; }

		[Outlet]
		UIKit.UILabel lblBalance { get; set; }

		[Outlet]
		UIKit.UILabel lblDueDate { get; set; }

		[Outlet]
		UIKit.UILabel lblTransAmount { get; set; }

		[Outlet]
		UIKit.UILabel lblTransDate { get; set; }

		[Outlet]
		UIKit.UILabel lblTransType { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnInvoice != null) {
				btnInvoice.Dispose ();
				btnInvoice = null;
			}

			if (lblTransDate != null) {
				lblTransDate.Dispose ();
				lblTransDate = null;
			}

			if (lblDueDate != null) {
				lblDueDate.Dispose ();
				lblDueDate = null;
			}

			if (lblTransType != null) {
				lblTransType.Dispose ();
				lblTransType = null;
			}

			if (lblTransAmount != null) {
				lblTransAmount.Dispose ();
				lblTransAmount = null;
			}

			if (lblBalance != null) {
				lblBalance.Dispose ();
				lblBalance = null;
			}
		}
	}
}

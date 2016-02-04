using System;

using Foundation;
using UIKit;

namespace XibTableCellDesign
{
  public partial class AccountReceivableCell : UITableViewCell
  {
    public static readonly NSString Key = new NSString("AccountReceivableCell");
    public static readonly UINib Nib;

    public AccountsReceivable Model { get; set; }


    static AccountReceivableCell()
    {
      Nib = UINib.FromName("AccountReceivableCell", NSBundle.MainBundle);
    }

    protected AccountReceivableCell(IntPtr handle) : base(handle)
    {
      // Note: this .ctor should not contain any initialization logic.
    }

    public override void LayoutSubviews()
    {
      base.LayoutSubviews();

      //  this.ConferenceName.Text = Model.Name;
      //  this.ConferenceStart.Text = Model.StartDate.ToShortDateString();
      //  this.ConferenceDescription.Text = Model.Description;

      this.btnInvoice.SetTitle(Model.Reference, UIControlState.Normal);
      this.lblTransDate.Text = Model.TransDate.ToShortDateString();
      this.lblDueDate.Text = Model.TransDate.ToShortDateString();
      this.lblTransAmount.Text = Model.TransAmount.ToString("N2");
      this.lblBalance.Text = Model.Balance.ToString("N2");

      //}
    }
  }

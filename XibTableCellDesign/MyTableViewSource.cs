using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace XibTableCellDesign
{
  public class MyTableViewSource : UITableViewSource
  {
    private readonly List<Conference> _conferences;

    public MyTableViewSource(List<Conference> conferences)
    {
      _conferences = conferences;
    }

    public override nint RowsInSection(UITableView tableview, nint section)
    {
      return _conferences.Count();
    }

    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
    {
      var conference = _conferences[indexPath.Row];
      var cell = (MyCustomCell)tableView.DequeueReusableCell(MyCustomCell.Key);
      if (cell == null)
      {
        cell = MyCustomCell.Create();
      }
      cell.Model = conference;

      return cell;
    }

    public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
    {
      return 130;
    }
  }
}
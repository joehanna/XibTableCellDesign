using System;
namespace XibTableCellDesign
{
  public class AccountsReceivable
  {
    public AccountsReceivable()
    {
    }
    public string CusBillTo { get; set; }
    public string Reference { get; set; }
    public string TransType { get; set; }
    public DateTime TransDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal TransAmount { get; set; }
    public decimal Balance { get; set; }
    public int AgingPeriod { get; set; }
  }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCERP.Entities
{
    public class DailyReportGreenware
    {
        int CasterID { set; get; }
        int ItemID { set; get; }
        int StyleID { set; get; }
        int SizeID { set; get; }
        int MoldStockQuantity { set; get; }
        int MoldCastQuantity { set; get; }
        int Break { set; get; }
        int BalanceBreak { set; get; }
        int DryBreak { set; get; }
        int BalanceBF { set; get; }
        int Total { set; get; }
        int Checked { set; get; }
        int Balance { set; get; }
        string Remarks { set; get; }
    }
}

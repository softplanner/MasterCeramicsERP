using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MCERP.DAL;
using MCERP.Entities;
using System.Media;
namespace MasterCeramicsERP
{
    public partial class frmAlarmAboutRawStock : Form
    {
        public frmAlarmAboutRawStock()
        {
            InitializeComponent();
        }

        private void frmAlarmAboutRawStock_Load(object sender, EventArgs e)
        {
            //var player = new SoundPlayer();
            //player.SoundLocation = @"\alarm.wav";
            //player.Play();
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            int row=-1;
            RawMaterialStockDAL dal=new RawMaterialStockDAL();
            RawMaterialDAL rmdal=new RawMaterialDAL();
            dgvAlarm.Rows.Clear();
            List<RawMaterialStock> lst = new List<RawMaterialStock>();
            lst = dal.getStockList();
            lst.TrimExcess();
            for(int i=0;i<lst.Count;i++)
            {
                if(lst[i].Quantity<=lst[i].AlarmAmount)
                {
                    row=dgvAlarm.Rows.Add();
                    dgvAlarm.Rows[row].Cells[0].Value = rmdal.getMaterialName(lst[i].RMID);
                    dgvAlarm.Rows[row].Cells[1].Value = lst[i].Quantity.ToString();
                    dgvAlarm.Rows[row].Cells[2].Value = lst[i].AlarmAmount.ToString();
                }
            }
        }
    }
}

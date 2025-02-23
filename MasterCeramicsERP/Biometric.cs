using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIA;

namespace MasterCeramicsERP
{
    public partial class Biometric : Form
    {
        public Biometric()
        {
            InitializeComponent();
        }

        private void Biometric_Load(object sender, EventArgs e)
        {
            CommonDialogClass class1 = new CommonDialogClass();
            Device d = class1.ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, true, false);
            //if (d != null)
            //{
            //    settings.DeviceID = d.DeviceID;
            //    settings.Save();
            //}

            //WIA.CommonDialog dialog = new WIA.CommonDialogClass();
            //WIA.Device device = dialog.ShowSelectDevice(
            //WIA.WiaDeviceType.ScannerDeviceType, true, false);
            //dialog.ShowAcquisitionWizard(device);

            WIA.CommonDialog dialog = new WIA.CommonDialogClass();
            WIA.ImageFile file = dialog.ShowAcquireImage(
            WIA.WiaDeviceType.ScannerDeviceType,
            WIA.WiaImageIntent.UnspecifiedIntent,
            WIA.WiaImageBias.MaximizeQuality,
            WIA.FormatID.wiaFormatJPEG,
            true, true, false);
            file.SaveFile(@"c:\myimage." + file.FileExtension);
            dialog.ShowAcquisitionWizard(d);

        }
    }
}

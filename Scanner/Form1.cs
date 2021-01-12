using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWia_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new WIA.CommonDialogClass();
                WIA.Device scanner = dialog.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, true, false);
                dialog.ShowAcquisitionWizard(scanner);
            }
            catch
            {

                MessageBox.Show("Não foi possível scannear documento");
            }
        }
    }
}

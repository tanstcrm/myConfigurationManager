using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FpgaPysical;

namespace FpgaCongifurationManager
{
    public partial class FpgaStatusComponent : UserControl
    {
        public FpgaStatus fpgaStatus { get; set; } = new FpgaStatus();
        public FpgaStatusComponent()
        {
            InitializeComponent();
            initEmptyStatus();
        }

        private void initEmptyStatus()
        {
            setInitialListOfPadNumList();
        }

        private void ipAddrTbx_TextChanged(object sender, EventArgs e)
        {
            System.Net.IPAddress tmp;
            if (System.Net.IPAddress.TryParse(ipAddrTbx.Text, out tmp))
            {
                ipAddrCheckResultLbl.Text = "OK";
            }
            else
            {
                ipAddrCheckResultLbl.Text = "invalid value";
            }
        }

        private void setInitialListOfPadNumList()
        {
            for (int i = 0; i < 6; i++) { PadNumList.Items.Add(i.ToString()); }
            PadNumList.SelectedIndex = 0;
        }
        private void PadNumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dac0Tbx.Text = fpgaStatus.dac[PadNumList.SelectedIndex][0].ToString();
            dac1Tbx.Text = fpgaStatus.dac[PadNumList.SelectedIndex][1].ToString();
            dac2Tbx.Text = fpgaStatus.dac[PadNumList.SelectedIndex][2].ToString();
            dac3Tbx.Text = fpgaStatus.dac[PadNumList.SelectedIndex][3].ToString();
        }
        private void dac0Tbx_TextChanged(object sender, EventArgs e)
        {
            double value;
            calcDacVal(dac0Tbx.Text, 0, out value);
            dac0ValueLbl.Text = value.ToString("#,000") + "[V]";
        }

        private void dac1Tbx_TextChanged(object sender, EventArgs e)
        {
            double value;
            calcDacVal(dac1Tbx.Text, 1, out value);
            dac1ValueLbl.Text = value.ToString("#,000") + "[mV]";
        }

        private void dac2Tbx_TextChanged(object sender, EventArgs e)
        {
            double value;
            calcDacVal(dac2Tbx.Text, 2, out value);
            dac2ValueLbl.Text = value.ToString("#,000") + "[mV]";
        }
        private void dac3Tbx_TextChanged(object sender, EventArgs e)
        {
            double value;
            calcDacVal(dac2Tbx.Text, 3, out value);
            dac3ValueLbl.Text = value.ToString("#,000") + "[mV]";
        }
        private void calcDacVal(string str, int index, out double result)
        {
            result = 0;
            if ( index > fpgaStatus.dacValSlope.Length ) { return; }
            if (double.TryParse(str, out result) == false) { return; }
            result = result * fpgaStatus.dacValSlope[index] + fpgaStatus.dacValIntercept[index];
            return;
        }




    }
}

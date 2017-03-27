using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FpgaCongifurationManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] fpgas = { "192.168.100.1", "192.168.100.45" };
            setFpgaList(fpgas);
        }

        private void setFpgaList(string[] args)
        {
            if (args == null) { return; }
            fpgaBoardSelectListBox.Items.Clear();
            foreach (string name in args)
            {
                fpgaBoardSelectListBox.Items.Add(name);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Class;


namespace Test2.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AppData.Panel = panel1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AppData.OpenFormMain(new Autohorization());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppData.OpenFormMain(new Autohorization());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

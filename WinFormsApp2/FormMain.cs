using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLookUpByName formLookUpByName = new FormLookUpByName();
            formLookUpByName.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLookUpByMenu formLookUpByMenu = new FormLookUpByMenu();
            formLookUpByMenu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

    }
}

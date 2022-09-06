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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonResultByName_Click(object sender, EventArgs e)
        {
            FormLookUpByName formLookUpByName = new FormLookUpByName();
            formLookUpByName.ShowDialog();
        }

        private void buttonResultByMenu_Click(object sender, EventArgs e)
        {
            FormLookUpByMenu formLookUpByMenu = new FormLookUpByMenu();
            formLookUpByMenu.ShowDialog();
        }
    }
}

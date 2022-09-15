using MySql.Data.MySqlClient;
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
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();

            TabPage tabPage = new System.Windows.Forms.TabPage();
            TabControl tabControl = new System.Windows.Forms.TabControl();
            tabPage.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabPage1
            // 
            tabPage.Location = new System.Drawing.Point(4, 24);
            tabPage.Name = "tabPage2";
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(1008, 1660);
            tabPage.TabIndex = 0;
            tabPage.Text = "tabPage2";
            tabPage.UseVisualStyleBackColor = true;

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage);

        }
    }
}

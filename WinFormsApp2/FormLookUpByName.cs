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
    public partial class FormLookUpByName : Form
    {
        public FormLookUpByName()
        {
            InitializeComponent();
        }

        private void button_selectByName(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid= kioskManager; Pwd=abcd1234;");

            dataGridView1.Rows.Clear();
            String selectQuery = "select mName, hname, hteam from orderHistory as o, menu where o.mNo = menu.mNo order by mName";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

            MySqlDataReader table = cmd.ExecuteReader();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "메뉴이름";
            dataGridView1.Columns[1].Name = "주문자명";
            dataGridView1.Columns[2].Name = "반구분";

            while (table.Read())
            {
                dataGridView1.Rows.Add(table["mName"], table["hname"], table["hteam"]);
            }

            connection.Close();
        }

    }
}

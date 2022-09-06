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
    public partial class FormLookUpByMenu : Form
    {
        public FormLookUpByMenu()
        {
            InitializeComponent();
        }
        private void button_selectByMenu(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid= kioskManager; Pwd=abcd1234;");

            dataGridView_selectByMenu.Rows.Clear();
            String selectQuery = "select mName, count(*) as total from orderHistory as o, menu where o.mNo = menu.mNo group by mName";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

            MySqlDataReader table = cmd.ExecuteReader();

            dataGridView_selectByMenu.ColumnCount = 2;
            dataGridView_selectByMenu.Columns[0].Name = "메뉴이름";
            dataGridView_selectByMenu.Columns[1].Name = "수량";

            while (table.Read())
            {
                dataGridView_selectByMenu.Rows.Add(table["mName"], table["total"]);
            }

            connection.Close();
        }

    }
}
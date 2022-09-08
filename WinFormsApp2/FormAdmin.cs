using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            selectOrderhistory();
        }

        //private void buttonCheck_Click(object sender, EventArgs e)
        private void selectOrderhistory()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                dataGridView1.Rows.Clear();
                String selectQuery = "select hNo, mName, hname, hteam from orderHistory as o, menu where o.mNo = menu.mNo order by o.hNo";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "주문번호";
                dataGridView1.Columns[1].Name = "메뉴이름";
                dataGridView1.Columns[2].Name = "주문자명";
                dataGridView1.Columns[3].Name = "반구분";

                while (table.Read())
                {
                    dataGridView1.Rows.Add(table["hNo"], table["mName"], table["hname"], table["hteam"]);
                }

                dataGridView2.Rows.Clear();
                String selectQuery2 = "select mName, count(*) as total from orderHistory as o, menu where o.mNo = menu.mNo group by mName";
                connection.Close();

                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection);

                MySqlDataReader table2 = cmd2.ExecuteReader();

                dataGridView2.ColumnCount = 2;
                dataGridView2.Columns[0].Name = "메뉴이름";
                dataGridView2.Columns[1].Name = "수량";

                while (table2.Read())
                {
                    dataGridView2.Rows.Add(table2["mName"], table2["total"]);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 조회 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                String selectQuery = "delete from orderHistory where hNo";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("주문 초기화 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 초기화 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            selectOrderhistory();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                string selected_hNO = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string deleteQuery = "DELETE FROM orderHistory WHERE hNo = '#hNo'";

                deleteQuery = deleteQuery.Replace("#hNo", selected_hNO);

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                MessageBox.Show("주문 삭제 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("주문 삭제 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            selectOrderhistory();
        }
    }
}

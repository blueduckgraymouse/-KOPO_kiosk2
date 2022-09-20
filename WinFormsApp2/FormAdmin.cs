using MySql.Data.MySqlClient;
using System.Xml.Linq;

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
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");


                dataGridViewSortedByName.Rows.Clear();

                String selectQuery = "select oNo, pName, mName, oHotOrIce, cName from orderHistory as o, menu as m, class as c, people as p where o.mNo = m.mNo and p.cno = c.cno and o.pno = p.pno order by cName, pName";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                dataGridViewSortedByName.ColumnCount = 5;
                dataGridViewSortedByName.Columns[0].Name = "주문번호";
                dataGridViewSortedByName.Columns[1].Name = "반구분";
                dataGridViewSortedByName.Columns[2].Name = "주문자명";
                dataGridViewSortedByName.Columns[3].Name = "메뉴이름";
                dataGridViewSortedByName.Columns[4].Name = "핫 / 아이스";

                while (table.Read())
                {
                    dataGridViewSortedByName.Rows.Add(table["oNo"], table["cName"], table["pName"], table["mName"], table["oHotOrIce"]);
                }



                dataGridViewSortedByCount.Rows.Clear();

                String selectQuery2 = "select mName, count(*) as total, oHotOrIce from orderHistory as o, menu where o.mNo = menu.mNo group by mName, oHotOrIce order by mName desc";
                connection.Close();

                dataGridViewSortedByName.Columns[0].Visible = false;

                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection);

                MySqlDataReader table2 = cmd2.ExecuteReader();

                dataGridViewSortedByCount.ColumnCount = 3;
                dataGridViewSortedByCount.Columns[0].Name = "메뉴이름";
                dataGridViewSortedByCount.Columns[1].Name = "수량";
                dataGridViewSortedByCount.Columns[2].Name = "핫 / 아이스";

                while (table2.Read())
                {
                    dataGridViewSortedByCount.Rows.Add(table2["mName"], table2["total"], table2["oHotOrIce"]);
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 조회 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("주문 목록을 초기화하시겠습니까?", "초기화", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                    MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                    String selectQuery = "delete from orderHistory where oNo > 0";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("주문 초기화 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("주문 초기화 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                selectOrderhistory();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(dataGridViewSortedByName.CurrentRow.Cells[2].Value.ToString() + "님의 주문을 삭제하시겠습니까?", "삭제", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                    MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                    string selected_oNo = dataGridViewSortedByName.CurrentRow.Cells[0].Value.ToString();

                    string deleteQuery = "DELETE FROM orderHistory WHERE oNo = '#oNo'";

                    deleteQuery = deleteQuery.Replace("#oNo", selected_oNo);

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show("주문 삭제 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("주문 삭제 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                selectOrderhistory();
            }
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}

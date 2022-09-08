using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class FormSelectName : Form
    {
        public FormSelectName(String classNo)
        {
            InitializeComponent();

            setButtons(classNo);
        }
        public void setButtons(String selected_cNO)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                String selectQuery = "select pNo, pName from people as p where cNo = '#cNo'";

                selectQuery = selectQuery.Replace("#cNo", selected_cNO);
                //selectQuery = selectQuery.Replace("#cNo", "1");

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                int count = 0;

                while (table.Read())
                {
                    Button btn_clone = new Button();
                    btn_clone.Click += new EventHandler(btn_clone_click);

                    this.Controls.Add(btn_clone);
                    //int width = ;
                    //int height = ;
                    btn_clone.Location = new Point(50 + (100 * count), 50);
                    btn_clone.Width = 60;
                    btn_clone.Height = 30;
                    btn_clone.FlatStyle = FlatStyle.Standard;
                    btn_clone.BackColor = Color.FromArgb(100, Color.Yellow);
                    btn_clone.Text = table["pName"].ToString();
                    count++;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 조회 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btn_clone_click(object sender, EventArgs e)
        {

        }
    }
}

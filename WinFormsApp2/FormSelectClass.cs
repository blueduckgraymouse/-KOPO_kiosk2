using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class FormSelectClass : Form
    {
        public FormSelectClass()
        {
            InitializeComponent();

            setButtons();
        }

        private void setButtons()
        {
            try
            {
                // 조회
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "select cNO, cName from class";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                int count = 0;

                int width = 50;
                int height = 200;
                Color[] background = { Color.PaleVioletRed, Color.Wheat, Color.Gainsboro };
                // 980, 200 - 사이즈
                // 50, 200  - 위치, 간격 300
                while (table.Read())
                {
                    String name = table["cName"].ToString();

                    Button btn_clone = new Button();
                    btn_clone.Click += new EventHandler(buttonClone_Click);

                    this.Controls.Add(btn_clone);

                    btn_clone.Location = new Point(width, height + 300 * count);

                    btn_clone.Width = 200;
                    btn_clone.Height = 980;
                    btn_clone.FlatStyle = FlatStyle.Standard;
                    btn_clone.BackColor = Color.FromArgb(100, background[count % 3]);

                    btn_clone.Size = new System.Drawing.Size(980, 200);
                    btn_clone.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btn_clone.Text = name;

                    btn_clone.Name = table["cNo"].ToString();
                    count++;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("분반 로딩 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonClone_Click(object sender, EventArgs e)
        {
            String cNo = ((Button)sender).Name;
            FormSelectName formSelectName = new FormSelectName(cNo);
            formSelectName.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showForm("2");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            showForm("3");
        }



        private void showForm(String ClassNo)
        {
            FormSelectName formSelectName = new FormSelectName(ClassNo);
            formSelectName.Show();
            this.Hide();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}
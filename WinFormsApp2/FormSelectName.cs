using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class FormSelectName : Form
    {
        String cNo;
        public FormSelectName(String selected_cNo)
        {
            InitializeComponent();

            cNo = selected_cNo;

            setButtons();
        }
        public void setButtons()
        {
            try
            {
                // 조회
                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                String selectQuery = "select pNo, pName from people as p where cNo = '#cNo' Order by pNo";

                selectQuery = selectQuery.Replace("#cNo", cNo);
                //selectQuery = selectQuery.Replace("#cNo", "1");

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                int count = 0;

                //1080 / 1920
                // 위 여백 200
                // 양쪽 여백 105 -> 210 = 870
                // 버튼 크기 200 100 -> 45 200 45 -> 290씩 3개
                // 폰트 17
                
                int[] width = {145, 435, 725};
                int height = 200;

                // 버튼 추가
                while (table.Read())
                {
                    String name = table["pName"].ToString();
                    //name = name.Substring(0,1) + "*" + name.Substring(3);

                    Button btn_clone = new Button();
                    btn_clone.Click += new EventHandler(buttonClone_Click);

                    this.Controls.Add(btn_clone);
                    
                    

                    //sbtn_clone.Location = new Point(50 + (100 * count), 50);
                    btn_clone.Location = new Point(width[count % 3], height + 150 * (count / 3));

                    btn_clone.Width = 60;
                    btn_clone.Height = 30;
                    btn_clone.FlatStyle = FlatStyle.Standard;
                    btn_clone.BackColor = Color.FromArgb(100, Color.Wheat);

                    btn_clone.Size = new System.Drawing.Size(200, 100);
                    btn_clone.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btn_clone.Text = name;

                    btn_clone.Name = table["pNo"].ToString();
                    count++;
                }

                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void buttonClone_Click(object sender, EventArgs e)
        {

            String pNo = ((Button)sender).Name;
            //MessageBox.Show(pNo);
            // cNo , name 다음 페이지로 전달
            FormSelectMenu formSelectMenu = new FormSelectMenu(cNo, pNo);
            formSelectMenu.Show();
            this.Hide();
        }

        public void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void buttonHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}

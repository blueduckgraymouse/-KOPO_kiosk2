using MySql.Data.MySqlClient;
using Button = System.Windows.Forms.Button;

namespace WinFormsApp2
{
    public partial class FormSelectMenu : Form
    {
        String cNo;
        String pNo;

        public FormSelectMenu(String selected_cNo, String selected_pNo)
        {
            InitializeComponent();

            cNo = selected_cNo;
            pNo = selected_pNo;

            setTagPages();
        }

        private void setTagPages()
        {
            /* 탭 페이지 */

            // 탭 컨트롤 선언
            TabControl tabControl = new TabControl();
            tabControl.SuspendLayout();

            int index = 0;
            // 탭 생성
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                String selectQuery = "select cNo, cName from category";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                //int totalCount = Convert.ToInt32(cmd.ExecuteScalar());

                // 버튼 추가
                while (table.Read())
                {
                    String name = table["cName"].ToString();
                    String cNo = table["cNo"].ToString();

                    // 탭 페이지 선언
                    TabPage tabpage_clone = new TabPage();
                    tabpage_clone.SuspendLayout();



                    /* 버튼 */
                    try
                    {
                        MySqlConnection connection2 = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                        String selectQuery2 = "select mNo, sNo, mName, mVisible from menu as m where cNo = 'cNo'";

                        selectQuery2 = selectQuery.Replace("#cNo", cNo);

                        connection.Open();

                        MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection);

                        MySqlDataReader table2 = cmd2.ExecuteReader();

                        int count = 0;

                        //1080 / 1920
                        // 위 여백 200
                        // 양쪽 여백 105 -> 210 = 870
                        // 버튼 크기 200 100 -> 45 200 45 -> 290씩 3개
                        // 폰트 17

                        int[] width = { 145, 435, 725 };
                        int height = 100;

                        // 버튼 추가
                        while (table2.Read())
                        {
                            String menuName = table2["mName"].ToString();

                            Button btn_clone = new Button();
                            //btn_clone.Click += new EventHandler(buttonClone_Click);

                            btn_clone.Location = new Point(width[count % 3], height + 150 * (count / 3));
                            btn_clone.Width = 60;
                            btn_clone.Height = 30;
                            btn_clone.FlatStyle = FlatStyle.Standard;
                            btn_clone.BackColor = Color.FromArgb(100, Color.Wheat);
                            btn_clone.Size = new System.Drawing.Size(200, 100);
                            btn_clone.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                            btn_clone.Text = name;
                            btn_clone.Name = table["pNo"].ToString();

                            tabpage_clone.Controls.Add(btn_clone);

                            count++;
                        }

                        connection2.Close();
                    }
                    catch (Exception ex)
                    {

                    } // 버튼

                    index++;

                    // 탭 페이지 구성
                    tabpage_clone.Location = new System.Drawing.Point(4, 24);
                    tabpage_clone.Name = "tabPage" + cNo;
                    tabpage_clone.Padding = new System.Windows.Forms.Padding(3);
                    tabpage_clone.Size = new System.Drawing.Size(192, 72);
                    tabpage_clone.TabIndex = index;
                    tabpage_clone.Text = name;
                    tabpage_clone.UseVisualStyleBackColor = true;

                    tabControl.Controls.Add(tabpage_clone);
                }

                connection.Close();
            }
            catch (Exception ex)
            {

            }

            tabControl.Location = new System.Drawing.Point(25, 154);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1016, 1688);
            tabControl.TabIndex = index + 1;

            this.SuspendLayout();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormSelectName fromSelectName = new FormSelectName(cNo);
            fromSelectName.Show();
            this.Hide();
        }
    }
}

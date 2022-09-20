using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class FormSelectIceOrHot : Form
    {
        String cNo;
        String pNo;
        String mNo;
        String HotOrIce;

        public FormSelectIceOrHot(String selected_cNo, String selected_pNo, String selected_mNo)
        {
            InitializeComponent();
            cNo = selected_cNo;
            pNo = selected_pNo;
            mNo = selected_mNo;

            setButtons();
        }

        private void setButtons()
        {
            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "select mHot, mIce from menu where mNo=" + mNo;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    String mHot = table["mHot"].ToString();
                    String mIce = table["mIce"].ToString();

                    if (mIce.Equals("True"))
                    {
                        Button buttonIce = new Button();

                        buttonIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        buttonIce.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        buttonIce.ForeColor = System.Drawing.Color.Blue;
                        buttonIce.Location = new System.Drawing.Point(587, 290);
                        buttonIce.Name = "Ice";
                        buttonIce.Size = new System.Drawing.Size(336, 127);
                        buttonIce.TabIndex = 5;
                        buttonIce.Text = "Ice";
                        buttonIce.UseVisualStyleBackColor = false;
                        buttonIce.Click += new System.EventHandler(button_Click);

                        this.Controls.Add(buttonIce);
                    }

                    if (mHot.Equals("True"))
                    {
                        Button buttonHot = new Button();

                        buttonHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                        buttonHot.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        buttonHot.ForeColor = System.Drawing.Color.Red;
                        buttonHot.Location = new System.Drawing.Point(141, 290);
                        buttonHot.Name = "Hot";
                        buttonHot.Size = new System.Drawing.Size(336, 127);
                        buttonHot.TabIndex = 4;
                        buttonHot.Text = "Hot";
                        buttonHot.UseVisualStyleBackColor = false;
                        buttonHot.Click += new System.EventHandler(button_Click);

                        this.Controls.Add(buttonHot);
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("핫 / 아이스 로딩 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Hide();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormSelectMenu formSelectMenu = new FormSelectMenu(cNo, pNo);
            formSelectMenu.Show();
            Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {
            HotOrIce = ((Button)sender).Name;

            String pName = getPName();
            String mName = getMName();


            if (checkOrderBefore())
            {
                DialogResult result = MessageBox.Show(pName + "님 " + mName + "(" + HotOrIce + ")로 주문 하시겠습니까?", "주문", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    saveOrder();
                    goMainPage();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(pName + "님 " + mName + "(" + HotOrIce + ")로 주문을 바꾸시겠습니까?", "주문", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    updateOrder();
                    goMainPage();
                }
            }

        }

        private String getPName()
        {
            String pName = "";

            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "select pName from people where pNo=" + pNo;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                pName = reader["pName"].ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문자 이름 로딩 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return pName;
        }

        private String getMName()
        {
            String mName = "";

            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "select mName from menu where mNo=" + mNo;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                mName = reader["mName"].ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("메뉴 이름 로딩 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return mName;
        }

        private bool checkOrderBefore()
        {
            bool flag = false;

            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "select count(*) as count from orderhistory where pNo=" + pNo;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                String result = reader["count"].ToString();

                if (result.Equals("0"))
                {
                    flag = true;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("기 주문 여부 로딩 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return flag;
        }

        private void saveOrder()
        {
            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = " insert into orderHistory(mNo, pNo, oHotOrIce) values(" + mNo + ", " + pNo + ", \"" + HotOrIce + "\")";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 저장 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void updateOrder()
        {
            try
            {
                //MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");
                MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Database=kiosk; Uid=root; Pwd=abcd1234;");

                String selectQuery = "update orderHistory set mNo = " + mNo + ", oHotOrIce = \"" + HotOrIce + "\" where pNo = " + pNo;

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("주문 저장 실패" + ex.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void goMainPage()
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }
    }
}

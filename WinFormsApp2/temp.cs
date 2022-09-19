﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class temp : Form
    {
        String cNo = "1";

        public temp()
        {
            InitializeComponent();

            try
            {
                int i = 0;

                MySqlConnection connection = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                String selectQuery = "select cNo, cName from category";

                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

                MySqlDataReader table = cmd.ExecuteReader();

                // 버튼 추가
                while (table.Read())
                {
                    String name = table["cName"].ToString();
                    String cNo = table["cNo"].ToString();

                    // 탭 페이지 선언
                    TabPage tabpage_clone = new TabPage();
                    //tabpage_clone.SuspendLayout();
                    // 탭 페이지 구성
                    tabpage_clone.Location = new System.Drawing.Point(4, 24);
                    tabpage_clone.Name = "tabPage" + cNo;
                    tabpage_clone.Padding = new System.Windows.Forms.Padding(3);
                    tabpage_clone.Size = new System.Drawing.Size(192, 72);
                    tabpage_clone.TabIndex = i;
                    tabpage_clone.Text = name;
                    tabpage_clone.UseVisualStyleBackColor = true;

                    tabControl1.Controls.Add(tabpage_clone);

                    try
                    {
                        // 조회
                        MySqlConnection connection2 = new MySqlConnection("Server=192.168.23.94; Port=3305; Database=kiosk; Uid=kioskManager; Pwd=abcd1234;");

                        String selectQuery2 = "select mNo, sNo, mName, mVisible from menu as m where cNo = " + cNo;


                        connection2.Open();

                        MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection2);

                        MySqlDataReader table2 = cmd2.ExecuteReader();

                        int count = 0;

                        //1080 / 1920
                        // 위 여백 200
                        // 양쪽 여백 105 -> 210 = 870
                        // 버튼 크기 200 100 -> 45 200 45 -> 290씩 3개
                        // 폰트 17

                        int[] width = { 145, 435, 725 };
                        int height = 200;

                        // 버튼 추가
                        while (table2.Read())
                        {
                            String name2 = table2["mName"].ToString();

                            Button btn_clone = new Button();

                            this.Controls.Add(btn_clone);

                            btn_clone.Location = new Point(width[count % 3], height + 150 * (count / 3));

                            btn_clone.Width = 60;
                            btn_clone.Height = 30;
                            btn_clone.FlatStyle = FlatStyle.Standard;
                            btn_clone.BackColor = Color.FromArgb(100, Color.Wheat);

                            btn_clone.Size = new System.Drawing.Size(200, 100);
                            btn_clone.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                            btn_clone.Text = name2;

                            btn_clone.Name = table2["mNo"].ToString();
                            count++;

                            tabpage_clone.Controls.Add(btn_clone);
                        }

                        connection2.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                    i++;
                }

                connection.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
﻿namespace WinFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // 주문
            form1.Show();
            this.Hide();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();  // 주문 조회
            formAdmin.Show();
            this.Hide();
        }
    }
}

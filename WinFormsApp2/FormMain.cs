namespace WinFormsApp2
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
            form1.ShowDialog();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }
    }
}

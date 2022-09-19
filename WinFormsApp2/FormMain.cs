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
            FormSelectClass formSelectClass = new FormSelectClass();  // 주문
            formSelectClass.Show();
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

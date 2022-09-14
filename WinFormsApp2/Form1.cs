namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm("1");
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
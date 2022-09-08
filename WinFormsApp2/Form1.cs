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

            Label label1 = new Label();

            /*
            if (radioButton1.Checked) { 
                result += radioButton1.Text;
            }else if (radioButton2.Checked) { 
                result += radioButton2.Text;
            }

            if (textBox1.Text == "") { 
                MessageBox.Show("이름을 입력하세요", "Warning");
            } else if (comboBox1.Text == "") { 
                MessageBox.Show("소속반을 입력하세요", "Warning");
            } else if (comboBox1.Text != "A반" && comboBox1.Text != "B반") { 
                MessageBox.Show("소속반을 다시 입력하세요", "Warning");
            } else MessageBox.Show("소속 반 : " + comboBox1.Text + "   이름 : " + textBox1.Text + "\n선택한 메뉴 : " + result);
            */
            //원래 창 가리기
            this.Hide();
            //Form2 showForm2 = new Form2();
            //showForm2.Show();
            showForm("1");

        }
        private void button2_Click(object sender, EventArgs e)
        {

            Label label1 = new Label();

            this.Hide();
            showForm("2");

        }
        private void button3_Click(object sender, EventArgs e)
        {

            Label label1 = new Label();

            //원래 창 가리기
            this.Hide();
            showForm("3");
            //Form2 showForm2 = new Form2();
            //showForm2.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showForm(String ClassNo)
        {
            //Form2 showForm2 = new Form2();
            //showForm2.Show();
            FormSelectName formSelectName = new FormSelectName(ClassNo);
            formSelectName.Show();
        }
    }
}
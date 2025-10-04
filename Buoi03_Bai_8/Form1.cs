namespace Buoi03_Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chao "+this.cbTen.SelectedItem.ToString()+" Chuc mot ngay vui ve.");
        }
    }
}

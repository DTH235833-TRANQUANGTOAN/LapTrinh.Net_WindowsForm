namespace Buoi02_Bai_3._4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGiai_Click(object sender, EventArgs e)
    {
        double a = double.Parse(tboxa.Text);
        double b = double.Parse(tboxb.Text);
        double c = double.Parse(tboxc.Text);

        string result;

        if (a == 0)
        {
            if (b == 0)
            {
                result = c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
            }
            else
            {
                double x = -c / b;
                result = $"Phương trình có một nghiệm: x = {x}";
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                result = "Phương trình vô nghiệm thực.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                result = $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                result = $"Phương trình có hai nghiệm:\r\nx1 = {x1}\r\nx2 = {x2}";
            }
        }

        tboxkq.Text = result;
    }
}

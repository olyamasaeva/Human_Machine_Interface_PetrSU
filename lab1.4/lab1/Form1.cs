using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1
{
    public partial class Form1 : Form
    {
        List<Tuple<Label, TextBox,TextBox>> el = new List<Tuple<Label, TextBox,TextBox>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void find_formula(double a)
        {
            double c;
            c = 5.0 / 9.0 * (a - 32);
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfCheltoFar.Text = c.ToString();
            c = (a * 9.0 / 5.0) + 32;
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfFartoChel.Text = c.ToString();
            c = a + 273;
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfCheltoKel.Text = c.ToString();
            c = 9 * (a - 273) / 5 + 32;
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfKeltoFar.Text = c.ToString();
            c = a - 273;
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfKeltoChel.Text = c.ToString();
            c = 5 * (a - 32) / 9 + 273;
            c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
            IfFartoKel.Text = c.ToString();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FarTex_TextChanged(object sender, EventArgs e)
        {
            ErrMes.Text = "";
            FarTex.ForeColor = Color.Black;
            ErrMes.Text = "";
            FarTex.ForeColor = Color.Black;
            Tuple<Label, TextBox> r = Tuple.Create(FarLab, FarTex); ;
            if (r.Item2.Text.Length > 0)
            {
                double d;
                try
                {
                    d = Convert.ToDouble(r.Item2.Text);
                }
                catch (FormatException)
                {
                    FarTex.ForeColor = Color.Red;
                    ErrMes.Text = "Неправильный формат числа. Попробуйте исправить и повторить попытку.";
                    return;
                }
                find_formula(d);
            }
        }
    }
}

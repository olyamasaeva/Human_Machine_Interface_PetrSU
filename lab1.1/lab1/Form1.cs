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
        List<Tuple<Label, TextBox>> el = new List<Tuple<Label, TextBox>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void find_formula(String t,double a)
        {
            double c;
            if (t == "Градусы Фаренгейта") {
                c = 5.0 / 9.0 * (a - 32);
                c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
                ChelTex.Text = c.ToString();
            }
            else {
                c = (a * 9.0 / 5.0) + 32;
                c = Math.Round(c, 3, MidpointRounding.AwayFromZero);
                FarTex.Text = c.ToString();
            }
            return;
        }
        private void TransFarToChel_Click(object sender, EventArgs e)
        {
            ErrMes.Text = "";
            ChelTex.ForeColor = Color.Black;
            FarTex.ForeColor = Color.Black;
            Tuple<Label, TextBox> r = el[0];
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
                    find_formula(r.Item1.Text, d);
                }
            }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            el.Add(Tuple.Create<Label, TextBox>(FarLab, FarTex));
            el.Add(Tuple.Create<Label, TextBox>(ChelLab, ChelTex));
        }

        private void FarTex_TextChanged(object sender, EventArgs e)
        {
            ChelTex.ForeColor = Color.Black;
            FarTex.ForeColor = Color.Black;
            ErrMes.Text = "";
        }
    }
}

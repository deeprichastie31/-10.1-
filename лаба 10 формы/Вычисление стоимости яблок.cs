using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_10_формы
{
    public partial class Вычисление_стоимости_яблок : Form
    {
        float a;
        float b;
        string s;
        string d;
        float rez = 0f;
        public Вычисление_стоимости_яблок()
        {
            InitializeComponent();
            this.kilogramms.AutoSize = false;
            this.kilogramms.Size = new Size(this.kilogramms.Size.Width, 58);
            this.textformoney.AutoSize = false;
            this.textformoney.Size = new Size(this.textformoney.Width, 58); // это отвечает за размер двух текстбоксов, в которые вводятся значения кг и стоимость
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            rez = a * b;
            Вывод.Text = rez.ToString();
        }

        private void kilogramms_TextChanged(object sender, EventArgs e)
        {
            s = this.kilogramms.Text;
            a = Convert.ToSingle(s);
        }

        private void textformoney_TextChanged(object sender, EventArgs e)
        {
            d = this.textformoney.Text;
            b = Convert.ToSingle(d);
        }

        private void Вывод_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

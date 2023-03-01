using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prfctic12_4_Poleev
{
    public partial class Form1 : Form
    {
        Buyer qwe = new Buyer();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Checked();
        }
        public void Checked()
        {
            string error = "";
            if (string.IsNullOrWhiteSpace(textBox1.Text) && !Regex.IsMatch(textBox1.Text, "^[а - яА-Я]+$"))
            {
                error += "Введите имя правильно";
            }
            else
            {
                qwe.Name = textBox1.Text;
            }
            if (numericUpDown1.Value <= 0)
            {
                error += "\nВыберите цену правильно";
            }
            else
            {
                qwe.Price = Convert.ToDouble(numericUpDown1.Value);
            }
            if (numericUpDown2.Value <= 0)
            {
                error += "\nВыберите кол-во правильно";
            }
            else
            {
                qwe.Quantity = Convert.ToInt32(numericUpDown2.Value);
            }
            if (numericUpDown3.Value <= 0)
            {
                error += "\nВыберите кол-во денег верно правильно";
            }
            else
            {
                qwe.Wallet = Convert.ToDouble(numericUpDown3.Value);
            }
            if (error == "")
            {
                MessageBox.Show(qwe.InfoProduct(), "Информация о покупке", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(qwe.Buy(), "Купить", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(qwe.Moods(), "Проверка настроения", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

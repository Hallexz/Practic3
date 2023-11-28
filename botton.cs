using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(30, 30);

            textBox2 = new TextBox();
            textBox2.Location = new System.Drawing.Point(30, 60);

            textBox3 = new TextBox();
            textBox3.Location = new System.Drawing.Point(30, 90);

            radioButton1 = new RadioButton();
            radioButton1.Text = "Остаток от деления";
            radioButton1.Location = new System.Drawing.Point(30, 120);

            radioButton2 = new RadioButton();
            radioButton2.Text = "Возведение в степень";
            radioButton2.Location = new System.Drawing.Point(30, 150);

            button1 = new Button();
            button1.Text = "Вычислить";
            button1.Location = new System.Drawing.Point(30, 180);
            button1.Click += new EventHandler(button1_Click);

            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Controls.Add(radioButton1);
            this.Controls.Add(radioButton2);
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result;

                if (radioButton1.Checked) // Остаток от деления
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно.");
                        return;
                    }
                    result = num1 % num2;
                }
                else if (radioButton2.Checked) // Возведение в степень
                {
                    result = Math.Pow(num1, num2);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип операции.");
                    return;
                }

                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите числовые значения.");
            }
        }
    }
}

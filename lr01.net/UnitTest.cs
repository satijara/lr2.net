using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lr01.net
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Calculation_abc calc = new Calculation_abc(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text)
                );

                label4.Text = "Результат: " + calc.Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Calculation_ab calc = new Calculation_ab(
                    Convert.ToInt32(textBox4.Text),
                    Convert.ToInt32(textBox5.Text)
                );

                label7.Text = "Результат: " + calc.Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Tetrahedron t = new Tetrahedron(
                    Convert.ToDouble(textBox6.Text)
                );

                label9.Text =
                    "Об'єм: " + t.CalculateVolume().ToString("F4") +
                    "\nВисота: " + t.CalculateHeight().ToString("F4") +
                    "\nПлоща: " + t.CalculateSurfaceArea().ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

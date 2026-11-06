using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr01.net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.button2.Click += this.button2_Click;
            this.button1.Click += this.button1_Click;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                Arrays a = new Arrays(n);
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Rows.Add(a[i].ToString());
                }
                var sum = a.Sum;
                label2.Text = sum.Item2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

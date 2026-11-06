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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.button2.Click += this.button2_Click;
            this.button1.Click += this.button1_Click;
        }
        private void button1_Click(object sender, EventArgs e) {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                int m = 0;
                n = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox2.Text);
                Arrays2D a = new Arrays2D(n, m);
                DataGridViewTextBoxColumn dvage;
                for (int i = 0; i < m; i++)
                {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = a.X_Length;
                dataGridView1.ColumnCount = a.Y_Length;
                for (int i = 0; i < a.X_Length; i++)
                {
                    for (int j = 0; j < a.Y_Length; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    }
                }
                var result = a.Sum_Dob;
                label3.Text = result.Item1.ToString();
                label4.Text = result.Item2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
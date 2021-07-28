using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final2
{
    public partial class busBlue : Form
    {
        public busBlue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Program.cards.Count(); i++)
                {
                    if (textBox1.Text == Program.cards[i].ToString())
                    {
                        Program.cards[i].transfer(Convert.ToInt32(textBox3.Text));
                        // Console.WriteLine(Program.cards[i].ToString());
                        DataTable table = ConvertListToDataTable(Program.cards);
                        dataGridView1.DataSource = table;
                        textBox4.Text = Program.cards[i].ToString().Substring(Program.cards[i].ToString().LastIndexOf('=') + 1);

                    }

                }
            }
            catch
            {
                Error e1 = new Error();
                e1.Show();
            }

        }

        private void busBlue_Load(object sender, EventArgs e)
        {
           
            textBox1.Visible = false;
            DataTable table = ConvertListToDataTable(Program.cards);
            //  dataGridView1.DataSource = Program.cards.Select(cards[0]) ToList();
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumn(0);
        }
        static DataTable ConvertListToDataTable(List<Card> list)
        {
            DataTable table = new DataTable();
            int columns = 2;

            table.Columns.Add("All CARDS");
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; textBox1.Visible = false;
                textBox1.Text = row.Cells["All CARDS"].Value.ToString();
                for (int i = 0; i < Program.cards.Count(); i++)
                {
                    if (textBox1.Text == Program.cards[i].ToString())
                    {
                        textBox2.Text = textBox1.Text.Substring(textBox1.Text.LastIndexOf('=') + 1);
                    }

                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

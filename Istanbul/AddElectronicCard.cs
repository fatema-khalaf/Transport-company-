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
    public partial class AddElectronicCard : Form
    {
        public AddElectronicCard()
        {
            InitializeComponent();
        }

        private void Creat_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                int points;
                id = Convert.ToInt32(textBox1.Text);
                points = Convert.ToInt32(textBox3.Text);
                ElectronicCardList e1 = new ElectronicCardList(id, points);
                e1.Id = id;
                e1.Points = points;
                Program.cards.Add(e1.MakeProduct());
                textBox1.Text = "";
                textBox3.Text = "";
                done d1 = new done();
                d1.Show();
            }
            catch
            {
                Error e1 = new Error();
                e1.Show();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

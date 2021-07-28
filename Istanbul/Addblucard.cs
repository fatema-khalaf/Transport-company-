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
    public partial class AddBlueCard : Form
    {
        public AddBlueCard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Creat_Click(object sender, EventArgs e)
        {
            try {
                int id;
                string type;
                int balance;
                id = Convert.ToInt32(textBox1.Text);
                type = comboBox1.Text;
                balance = Convert.ToInt32(textBox3.Text);
                BlueCardList e1 = new BlueCardList(id, type, balance);
                e1.Id = id;
                e1.Type = type;
                e1.Points = balance;
                Program.cards.Add(e1.MakeProduct());
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                done d1 = new done();
                d1.Show();
                //Console.WriteLine(Program.cards[0].ToString());

            }
            catch
            {
                Error e1 = new Error();
                e1.Show();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBlueCard_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Full fare");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Teacher");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class AddIstanbulCard : Form
    {
        public AddIstanbulCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddIstanbulCard_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Full fare");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Teacher");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Creat_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string type;
                double balance;
                id = Convert.ToInt32(textBox1.Text);
                type = comboBox1.Text;
                balance = Convert.ToInt32(textBox3.Text);
                IstanbulCardList e1 = new IstanbulCardList(id, type, balance);
                e1.Id1 = id;
                e1.Type1 = type;
                e1.Balance1 = balance;
                Program.cards.Add(e1.MakeProduct());
                comboBox1.Text = "";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

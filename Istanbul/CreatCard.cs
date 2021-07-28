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
    public partial class CreatCard : Form
    {
        public static int count = 0;
        public static int countcard = 0;
        public CreatCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int points;
            id = Convert.ToInt32(textBox1.Text);
            points = Convert.ToInt32(textBox2.Text);
            ElectronicCardList e1 = new ElectronicCardList(id, points);
            e1.Id = id;
            e1.Points = points;
            Program.cards.Add(e1.MakeProduct());
           
           // Program.data.Add(new string[] { Convert.ToString(e1.Id), Convert.ToString(e1.Points) });
            //Program.data.Add(new string [] {"hbhg",",lmk" });
           // dataGridView1.Rows[count].Cells[0].Value = e1.Id.ToString();
           // dataGridView1.Rows[count].Cells[1].Value = e1.Points.ToString();
            count++;
            countcard++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Renaissance
{
    public partial class Housing : Form
    {
        public Housing()
        {
            InitializeComponent();
        }

        private void btnHousing_Click(object sender, EventArgs e)
        {
         
            float area = float.Parse(textBox1.Text);
            int floors = int.Parse(textBox2.Text);
            int rooms = int.Parse(textBox3.Text);
            int kitchens = int.Parse(textBox4.Text);
            int Toilets = int.Parse(textBox5.Text);
            HousingSpace hs = new HousingSpace(area,floors,rooms,kitchens,Toilets);
            MessageBox.Show("Total cost for Housing Space:" + hs.CalculatePrice().ToString());
        }

        private void Housing_Load(object sender, EventArgs e)
        {

        }
    }
}

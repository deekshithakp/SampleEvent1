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
    public partial class CommercialOffice : Form
    {
        public CommercialOffice()
        {
            InitializeComponent();
        }

   
        private void btnCommercial_Click(object sender, EventArgs e)
        {
         
            float area = float.Parse(textBox1.Text);
            int floors = int.Parse(textBox2.Text);
            int seats = int.Parse(textBox3.Text);
            int cabins = int.Parse(textBox4.Text);
            int Toilets = int.Parse(textBox5.Text);
            CommercialOfficeSpace cS = new CommercialOfficeSpace(area,floors,seats,cabins, Toilets);
            MessageBox.Show("Total cost for commercial Space:" + cS.CalculatePrice().ToString());
        }

        private void CommercialOffice_Load(object sender, EventArgs e)
        {

        }
    }
}

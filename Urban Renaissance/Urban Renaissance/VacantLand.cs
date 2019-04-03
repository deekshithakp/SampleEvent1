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
    public partial class VacantLand : Form
    {
        public VacantLand()
        {
            InitializeComponent();
        }


        private void VacantLand_Load(object sender, EventArgs e)
        {

        }

        private void VacantArea_Click_1(object sender, EventArgs e)
        {
            float area = float.Parse(textBox1.Text);
            vacantLandSPace Vl = new vacantLandSPace(area);
            MessageBox.Show("Total cost vacant space:" + Vl.CalculatePrice().ToString());
        }
    }
}

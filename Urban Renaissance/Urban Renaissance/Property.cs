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
    public partial class Property : Form
    {
        public Property()
        {
            InitializeComponent();
         
        }

       

        private void Property_Load(object sender, EventArgs e)
        {
          
        }

        private void vacant_CheckedChanged(object sender, EventArgs e)
        {
            if (vacant.Checked == true)
            {
                VacantLand vl = new VacantLand();
                vl.ShowDialog();
            }

        }

        private void commercialSpace_CheckedChanged(object sender, EventArgs e)
        {
            if(commercialSpace.Checked==true)
            {
                CommercialOffice co = new CommercialOffice();
                co.ShowDialog();
                co.Close();
            }
            
        }

        private void housingspace_CheckedChanged(object sender, EventArgs e)
        {
            if(housingspace.Checked==true)
            {
                Housing housing = new Housing();
                housing.ShowDialog();
                housing.Close();
            }
            
        }
    }
}

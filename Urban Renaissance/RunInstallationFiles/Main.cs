using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunInstallationFiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void install_Click(object sender, EventArgs e)
        {
            if (mysql.Checked)
            {
                string installerFilePath= @"D:\winforms\mysql-connector-odbc-5.1.13-win32.msi";
                string displayName = "MySQL Connector/ODBC 5.1";
               InstallationClass installClass = new InstallationClass(installerFilePath,displayName);
               MessageBox.Show("MY Sql "+ installClass.InstallPackage());

            }
            if (FireBird.Checked)
            {

                string installerFilePath = @"D:\winforms\Firebird_ODBC_2.0.1.152_Win32.exe";
                string displayName = "Firebird/InterBase(r) ODBC driver 2.0.1.152";
                InstallationClass installClass = new InstallationClass(installerFilePath, displayName);
               MessageBox.Show("FireBird "+installClass.InstallPackage());

            }
            if (vfp.Checked)
            {
                string installerFilePath = @"D:\winforms\VFPOLEDBSetup.msi";
                string displayName = "Microsoft Visual FoxPro OLE DB Provider";
                InstallationClass installClass = new InstallationClass(installerFilePath, displayName);
               MessageBox.Show("Fox Pro "+installClass.InstallPackage());
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //ListViewItem item1 = new ListViewItem("MySQL");
            //item1.SubItems.Add("My SQL Driver");
            //item1.SubItems.Add("Installed");
            //item1.SubItems.Add("");
            //listView1.Items.AddRange(new ListViewItem[] { item1 });
        }
    }
}

namespace RunInstallationFiles
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mysql = new System.Windows.Forms.CheckBox();
            this.FireBird = new System.Windows.Forms.CheckBox();
            this.vfp = new System.Windows.Forms.CheckBox();
            this.install = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ClmnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnInstalled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnMoreInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mysql
            // 
            this.mysql.AutoSize = true;
            this.mysql.Location = new System.Drawing.Point(137, 72);
            this.mysql.Name = "mysql";
            this.mysql.Size = new System.Drawing.Size(55, 17);
            this.mysql.TabIndex = 0;
            this.mysql.Text = "MySql";
            this.mysql.UseVisualStyleBackColor = true;
            // 
            // FireBird
            // 
            this.FireBird.AutoSize = true;
            this.FireBird.Location = new System.Drawing.Point(332, 72);
            this.FireBird.Name = "FireBird";
            this.FireBird.Size = new System.Drawing.Size(94, 17);
            this.FireBird.TabIndex = 1;
            this.FireBird.Text = "FireBird ODBC";
            this.FireBird.UseVisualStyleBackColor = true;
            // 
            // vfp
            // 
            this.vfp.AutoSize = true;
            this.vfp.Location = new System.Drawing.Point(603, 72);
            this.vfp.Name = "vfp";
            this.vfp.Size = new System.Drawing.Size(85, 17);
            this.vfp.TabIndex = 2;
            this.vfp.Text = "VFP OLEDB";
            this.vfp.UseVisualStyleBackColor = true;
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(970, 72);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(75, 23);
            this.install.TabIndex = 3;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmnProduct,
            this.clmnDriver,
            this.clmnInstalled,
            this.clmnMoreInfo});
            this.listView1.Location = new System.Drawing.Point(12, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1130, 213);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ClmnProduct
            // 
            this.ClmnProduct.Text = "Product";
            // 
            // clmnDriver
            // 
            this.clmnDriver.Text = "Driver";
            // 
            // clmnInstalled
            // 
            this.clmnInstalled.Text = "Status";
            // 
            // clmnMoreInfo
            // 
            this.clmnMoreInfo.Text = "MoreInfo";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 435);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.install);
            this.Controls.Add(this.vfp);
            this.Controls.Add(this.FireBird);
            this.Controls.Add(this.mysql);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mysql;
        private System.Windows.Forms.CheckBox FireBird;
        private System.Windows.Forms.CheckBox vfp;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ClmnProduct;
        private System.Windows.Forms.ColumnHeader clmnDriver;
        private System.Windows.Forms.ColumnHeader clmnInstalled;
        private System.Windows.Forms.ColumnHeader clmnMoreInfo;
    }
}


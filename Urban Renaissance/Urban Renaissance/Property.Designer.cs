namespace Urban_Renaissance
{
    partial class Property
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
            this.vacant = new System.Windows.Forms.RadioButton();
            this.commercialSpace = new System.Windows.Forms.RadioButton();
            this.housingspace = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // vacant
            // 
            this.vacant.AutoSize = true;
            this.vacant.Location = new System.Drawing.Point(26, 85);
            this.vacant.Name = "vacant";
            this.vacant.Size = new System.Drawing.Size(82, 17);
            this.vacant.TabIndex = 3;
            this.vacant.Text = "Vacant land";
            this.vacant.UseVisualStyleBackColor = true;
            this.vacant.CheckedChanged += new System.EventHandler(this.vacant_CheckedChanged);
            // 
            // commercialSpace
            // 
            this.commercialSpace.AutoSize = true;
            this.commercialSpace.Location = new System.Drawing.Point(26, 132);
            this.commercialSpace.Name = "commercialSpace";
            this.commercialSpace.Size = new System.Drawing.Size(113, 17);
            this.commercialSpace.TabIndex = 4;
            this.commercialSpace.Text = "Commercial Space";
            this.commercialSpace.UseVisualStyleBackColor = true;
            this.commercialSpace.CheckedChanged += new System.EventHandler(this.commercialSpace_CheckedChanged);
            // 
            // housingspace
            // 
            this.housingspace.AutoSize = true;
            this.housingspace.Location = new System.Drawing.Point(26, 175);
            this.housingspace.Name = "housingspace";
            this.housingspace.Size = new System.Drawing.Size(64, 17);
            this.housingspace.TabIndex = 5;
            this.housingspace.Text = "Housing";
            this.housingspace.UseVisualStyleBackColor = true;
            this.housingspace.CheckedChanged += new System.EventHandler(this.housingspace_CheckedChanged);
            // 
            // Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.housingspace);
            this.Controls.Add(this.commercialSpace);
            this.Controls.Add(this.vacant);
            this.Name = "Property";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Property_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton vacant;
        private System.Windows.Forms.RadioButton commercialSpace;
        private System.Windows.Forms.RadioButton housingspace;
    }
}


namespace Urban_Renaissance
{
    partial class VacantLand
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
            this.VacantArea = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VacantArea
            // 
            this.VacantArea.Location = new System.Drawing.Point(131, 136);
            this.VacantArea.Name = "VacantArea";
            this.VacantArea.Size = new System.Drawing.Size(75, 23);
            this.VacantArea.TabIndex = 5;
            this.VacantArea.Text = "Submit";
            this.VacantArea.UseVisualStyleBackColor = true;
            this.VacantArea.Click += new System.EventHandler(this.VacantArea_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area (Sq Feet)";
            // 
            // VacantLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.VacantArea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "VacantLand";
            this.Text = "VacantLand";
            this.Load += new System.EventHandler(this.VacantLand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VacantArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
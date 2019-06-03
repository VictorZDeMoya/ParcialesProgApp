namespace PAParcial1_VictorZDeMoya
{
    partial class ProductosPMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosPMENU));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegistroTabMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasTabMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroTabMENU,
            this.ConsultasTabMENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegistroTabMENU
            // 
            this.RegistroTabMENU.Name = "RegistroTabMENU";
            this.RegistroTabMENU.Size = new System.Drawing.Size(96, 24);
            this.RegistroTabMENU.Text = "REGISTROS";
            this.RegistroTabMENU.Click += new System.EventHandler(this.RegistroTabMENU_Click);
            // 
            // ConsultasTabMENU
            // 
            this.ConsultasTabMENU.Name = "ConsultasTabMENU";
            this.ConsultasTabMENU.Size = new System.Drawing.Size(101, 24);
            this.ConsultasTabMENU.Text = "CONSULTAS";
            this.ConsultasTabMENU.Click += new System.EventHandler(this.ConsultasTabMENU_Click);
            // 
            // ProductosPMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 72);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductosPMENU";
            this.Text = "MENU PROGRAMA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistroTabMENU;
        private System.Windows.Forms.ToolStripMenuItem ConsultasTabMENU;
    }
}


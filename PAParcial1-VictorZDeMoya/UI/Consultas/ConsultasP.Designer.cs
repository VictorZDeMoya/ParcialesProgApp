namespace PAParcial1_VictorZDeMoya.UI.Consultas
{
    partial class ConsultasP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasP));
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalInvWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBTN.Location = new System.Drawing.Point(350, 23);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(93, 60);
            this.RefreshBTN.TabIndex = 0;
            this.RefreshBTN.Text = "\r\nREFRESH";
            this.RefreshBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RefreshBTN.UseMnemonic = false;
            this.RefreshBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "VALOR DEL INVENTARIO";
            // 
            // TotalInvWrite
            // 
            this.TotalInvWrite.Location = new System.Drawing.Point(24, 61);
            this.TotalInvWrite.Name = "TotalInvWrite";
            this.TotalInvWrite.Size = new System.Drawing.Size(301, 22);
            this.TotalInvWrite.TabIndex = 2;
            // 
            // ConsultasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 104);
            this.Controls.Add(this.TotalInvWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultasP";
            this.Text = "CONSULTAS DE PRODUCTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalInvWrite;
    }
}
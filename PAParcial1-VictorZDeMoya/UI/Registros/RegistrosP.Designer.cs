namespace PAParcial1_VictorZDeMoya.UI.Registros
{
    partial class RegistrosP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosP));
            this.IdPicker = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTBox = new System.Windows.Forms.TextBox();
            this.ValorInvTBox = new System.Windows.Forms.TextBox();
            this.CostoTBox = new System.Windows.Forms.TextBox();
            this.NuevoBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.GuardarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.ValorGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdPicker
            // 
            this.IdPicker.Location = new System.Drawing.Point(112, 41);
            this.IdPicker.Name = "IdPicker";
            this.IdPicker.Size = new System.Drawing.Size(75, 22);
            this.IdPicker.TabIndex = 0;
            // 
            // DescripcionTBox
            // 
            this.DescripcionTBox.Location = new System.Drawing.Point(112, 84);
            this.DescripcionTBox.Name = "DescripcionTBox";
            this.DescripcionTBox.Size = new System.Drawing.Size(319, 22);
            this.DescripcionTBox.TabIndex = 1;
            // 
            // ExistenciaTBox
            // 
            this.ExistenciaTBox.Location = new System.Drawing.Point(112, 132);
            this.ExistenciaTBox.Name = "ExistenciaTBox";
            this.ExistenciaTBox.Size = new System.Drawing.Size(120, 22);
            this.ExistenciaTBox.TabIndex = 2;
            // 
            // ValorInvTBox
            // 
            this.ValorInvTBox.Location = new System.Drawing.Point(125, 178);
            this.ValorInvTBox.Name = "ValorInvTBox";
            this.ValorInvTBox.Size = new System.Drawing.Size(107, 22);
            this.ValorInvTBox.TabIndex = 3;
            // 
            // CostoTBox
            // 
            this.CostoTBox.Location = new System.Drawing.Point(112, 223);
            this.CostoTBox.Name = "CostoTBox";
            this.CostoTBox.Size = new System.Drawing.Size(120, 22);
            this.CostoTBox.TabIndex = 4;
            // 
            // NuevoBTN
            // 
            this.NuevoBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NuevoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoBTN.Location = new System.Drawing.Point(19, 288);
            this.NuevoBTN.Name = "NuevoBTN";
            this.NuevoBTN.Size = new System.Drawing.Size(119, 63);
            this.NuevoBTN.TabIndex = 5;
            this.NuevoBTN.Text = "NUEVO";
            this.NuevoBTN.UseVisualStyleBackColor = false;
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(185, 288);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(119, 63);
            this.EliminarBTN.TabIndex = 6;
            this.EliminarBTN.Text = "ELIMINAR";
            this.EliminarBTN.UseVisualStyleBackColor = false;
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBTN.Location = new System.Drawing.Point(348, 288);
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(105, 63);
            this.GuardarBTN.TabIndex = 7;
            this.GuardarBTN.Text = "GUARDAR";
            this.GuardarBTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Costo";
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBTN.Location = new System.Drawing.Point(250, 12);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(154, 63);
            this.BuscarBTN.TabIndex = 13;
            this.BuscarBTN.Text = "BUSCAR";
            this.BuscarBTN.UseVisualStyleBackColor = false;
            // 
            // ValorGridView
            // 
            this.ValorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValorGridView.Location = new System.Drawing.Point(279, 132);
            this.ValorGridView.Name = "ValorGridView";
            this.ValorGridView.RowTemplate.Height = 24;
            this.ValorGridView.Size = new System.Drawing.Size(161, 126);
            this.ValorGridView.TabIndex = 14;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistrosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 373);
            this.Controls.Add(this.ValorGridView);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarBTN);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.NuevoBTN);
            this.Controls.Add(this.CostoTBox);
            this.Controls.Add(this.ValorInvTBox);
            this.Controls.Add(this.ExistenciaTBox);
            this.Controls.Add(this.DescripcionTBox);
            this.Controls.Add(this.IdPicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrosP";
            this.Text = "REGISTROS DE PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.IdPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdPicker;
        private System.Windows.Forms.TextBox DescripcionTBox;
        private System.Windows.Forms.TextBox ExistenciaTBox;
        private System.Windows.Forms.TextBox ValorInvTBox;
        private System.Windows.Forms.TextBox CostoTBox;
        private System.Windows.Forms.Button NuevoBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button GuardarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.DataGridView ValorGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
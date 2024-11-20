namespace GestionVeterinaria.Forms
{
    partial class FormReporte1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEdad1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEdad2 = new System.Windows.Forms.TextBox();
            this.btnFiltrarEdades = new System.Windows.Forms.Button();
            this.dgvInforme1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolverMenu1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Veterinaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(110, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rango de Edad";
            // 
            // txtBoxEdad1
            // 
            this.txtBoxEdad1.Location = new System.Drawing.Point(58, 99);
            this.txtBoxEdad1.Name = "txtBoxEdad1";
            this.txtBoxEdad1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEdad1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "---";
            // 
            // txtBoxEdad2
            // 
            this.txtBoxEdad2.Location = new System.Drawing.Point(186, 99);
            this.txtBoxEdad2.Name = "txtBoxEdad2";
            this.txtBoxEdad2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEdad2.TabIndex = 6;
            // 
            // btnFiltrarEdades
            // 
            this.btnFiltrarEdades.Location = new System.Drawing.Point(121, 145);
            this.btnFiltrarEdades.Name = "btnFiltrarEdades";
            this.btnFiltrarEdades.Size = new System.Drawing.Size(99, 26);
            this.btnFiltrarEdades.TabIndex = 7;
            this.btnFiltrarEdades.Text = "Filtrar";
            this.btnFiltrarEdades.UseVisualStyleBackColor = true;
            this.btnFiltrarEdades.Click += new System.EventHandler(this.btnFiltrarEdades_Click);
            // 
            // dgvInforme1
            // 
            this.dgvInforme1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme1.Location = new System.Drawing.Point(368, 95);
            this.dgvInforme1.Name = "dgvInforme1";
            this.dgvInforme1.Size = new System.Drawing.Size(599, 445);
            this.dgvInforme1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrarEdades);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxEdad1);
            this.groupBox1.Controls.Add(this.txtBoxEdad2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnVolverMenu1
            // 
            this.btnVolverMenu1.Location = new System.Drawing.Point(121, 466);
            this.btnVolverMenu1.Name = "btnVolverMenu1";
            this.btnVolverMenu1.Size = new System.Drawing.Size(126, 50);
            this.btnVolverMenu1.TabIndex = 10;
            this.btnVolverMenu1.Text = "Volver al Menu";
            this.btnVolverMenu1.UseVisualStyleBackColor = true;
            this.btnVolverMenu1.Click += new System.EventHandler(this.btnVolverMenu1_Click);
            // 
            // FormReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 552);
            this.Controls.Add(this.btnVolverMenu1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInforme1);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte1";
            this.Text = "Gestion Veterianria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEdad1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEdad2;
        private System.Windows.Forms.Button btnFiltrarEdades;
        private System.Windows.Forms.DataGridView dgvInforme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolverMenu1;
    }
}
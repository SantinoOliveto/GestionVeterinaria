namespace GestionVeterinaria.Forms
{
    partial class FormReporte2
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
            this.dgvInforme2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarCliente = new System.Windows.Forms.Button();
            this.btnVolverMenu2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion Veterinaria";
            // 
            // dgvInforme2
            // 
            this.dgvInforme2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme2.Location = new System.Drawing.Point(368, 101);
            this.dgvInforme2.Name = "dgvInforme2";
            this.dgvInforme2.Size = new System.Drawing.Size(542, 445);
            this.dgvInforme2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnMostrarCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 231);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnMostrarCliente
            // 
            this.btnMostrarCliente.Location = new System.Drawing.Point(121, 108);
            this.btnMostrarCliente.Name = "btnMostrarCliente";
            this.btnMostrarCliente.Size = new System.Drawing.Size(99, 26);
            this.btnMostrarCliente.TabIndex = 7;
            this.btnMostrarCliente.Text = "Mostrar";
            this.btnMostrarCliente.UseVisualStyleBackColor = true;
            this.btnMostrarCliente.Click += new System.EventHandler(this.btnMostrarCliente_Click);
            // 
            // btnVolverMenu2
            // 
            this.btnVolverMenu2.Location = new System.Drawing.Point(123, 472);
            this.btnVolverMenu2.Name = "btnVolverMenu2";
            this.btnVolverMenu2.Size = new System.Drawing.Size(126, 50);
            this.btnVolverMenu2.TabIndex = 11;
            this.btnVolverMenu2.Text = "Volver al Menu";
            this.btnVolverMenu2.UseVisualStyleBackColor = true;
            this.btnVolverMenu2.Click += new System.EventHandler(this.btnVolverMenu2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(107, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Informe General";
            // 
            // FormReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 558);
            this.Controls.Add(this.btnVolverMenu2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInforme2);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte2";
            this.Text = "Gestion Veterinaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInforme2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarCliente;
        private System.Windows.Forms.Button btnVolverMenu2;
        private System.Windows.Forms.Label label2;
    }
}
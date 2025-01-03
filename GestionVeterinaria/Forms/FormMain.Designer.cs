﻿namespace GestionVeterinaria.Forms
{
    partial class FormMain
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
            this.grpBoxEspecie = new System.Windows.Forms.GroupBox();
            this.btnAltaEspecie = new System.Windows.Forms.Button();
            this.txtBoxPesoPromedioEspecie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEdadMadurezEspecie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNombreEspecie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.txtBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDNICliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxAnimales = new System.Windows.Forms.GroupBox();
            this.btnAltaAnimal = new System.Windows.Forms.Button();
            this.cmbBoxEspecie = new System.Windows.Forms.ComboBox();
            this.cmbBoxCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxPesoAnimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEdadAnimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNombreAnimal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFormInforme1 = new System.Windows.Forms.Button();
            this.btnFormInforme2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpBoxEspecie.SuspendLayout();
            this.grpBoxCliente.SuspendLayout();
            this.grpBoxAnimales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion Veterinaria";
            // 
            // grpBoxEspecie
            // 
            this.grpBoxEspecie.Controls.Add(this.btnAltaEspecie);
            this.grpBoxEspecie.Controls.Add(this.txtBoxPesoPromedioEspecie);
            this.grpBoxEspecie.Controls.Add(this.label6);
            this.grpBoxEspecie.Controls.Add(this.txtBoxEdadMadurezEspecie);
            this.grpBoxEspecie.Controls.Add(this.label4);
            this.grpBoxEspecie.Controls.Add(this.txtBoxNombreEspecie);
            this.grpBoxEspecie.Controls.Add(this.label5);
            this.grpBoxEspecie.Location = new System.Drawing.Point(362, 76);
            this.grpBoxEspecie.Name = "grpBoxEspecie";
            this.grpBoxEspecie.Size = new System.Drawing.Size(257, 283);
            this.grpBoxEspecie.TabIndex = 2;
            this.grpBoxEspecie.TabStop = false;
            this.grpBoxEspecie.Text = "Alta Especie";
            // 
            // btnAltaEspecie
            // 
            this.btnAltaEspecie.Location = new System.Drawing.Point(83, 235);
            this.btnAltaEspecie.Name = "btnAltaEspecie";
            this.btnAltaEspecie.Size = new System.Drawing.Size(75, 23);
            this.btnAltaEspecie.TabIndex = 10;
            this.btnAltaEspecie.Text = "Cargar";
            this.btnAltaEspecie.UseVisualStyleBackColor = true;
            this.btnAltaEspecie.Click += new System.EventHandler(this.btnAltaEspecie_Click);
            // 
            // txtBoxPesoPromedioEspecie
            // 
            this.txtBoxPesoPromedioEspecie.Location = new System.Drawing.Point(37, 187);
            this.txtBoxPesoPromedioEspecie.Name = "txtBoxPesoPromedioEspecie";
            this.txtBoxPesoPromedioEspecie.Size = new System.Drawing.Size(184, 20);
            this.txtBoxPesoPromedioEspecie.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(64, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Peso Promedio (KG)";
            // 
            // txtBoxEdadMadurezEspecie
            // 
            this.txtBoxEdadMadurezEspecie.Location = new System.Drawing.Point(37, 117);
            this.txtBoxEdadMadurezEspecie.Name = "txtBoxEdadMadurezEspecie";
            this.txtBoxEdadMadurezEspecie.Size = new System.Drawing.Size(184, 20);
            this.txtBoxEdadMadurezEspecie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(66, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad de Madurez";
            // 
            // txtBoxNombreEspecie
            // 
            this.txtBoxNombreEspecie.Location = new System.Drawing.Point(37, 49);
            this.txtBoxNombreEspecie.Name = "txtBoxNombreEspecie";
            this.txtBoxNombreEspecie.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNombreEspecie.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(94, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // grpBoxCliente
            // 
            this.grpBoxCliente.Controls.Add(this.btnAltaCliente);
            this.grpBoxCliente.Controls.Add(this.txtBoxNombreCliente);
            this.grpBoxCliente.Controls.Add(this.label3);
            this.grpBoxCliente.Controls.Add(this.txtBoxDNICliente);
            this.grpBoxCliente.Controls.Add(this.label2);
            this.grpBoxCliente.Location = new System.Drawing.Point(79, 76);
            this.grpBoxCliente.Name = "grpBoxCliente";
            this.grpBoxCliente.Size = new System.Drawing.Size(257, 216);
            this.grpBoxCliente.TabIndex = 3;
            this.grpBoxCliente.TabStop = false;
            this.grpBoxCliente.Text = "Alta Cliente";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(83, 167);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAltaCliente.TabIndex = 4;
            this.btnAltaCliente.Text = "Cargar";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // txtBoxNombreCliente
            // 
            this.txtBoxNombreCliente.Location = new System.Drawing.Point(33, 117);
            this.txtBoxNombreCliente.Name = "txtBoxNombreCliente";
            this.txtBoxNombreCliente.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNombreCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(90, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txtBoxDNICliente
            // 
            this.txtBoxDNICliente.Location = new System.Drawing.Point(33, 49);
            this.txtBoxDNICliente.Name = "txtBoxDNICliente";
            this.txtBoxDNICliente.Size = new System.Drawing.Size(184, 20);
            this.txtBoxDNICliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(102, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // grpBoxAnimales
            // 
            this.grpBoxAnimales.Controls.Add(this.btnAltaAnimal);
            this.grpBoxAnimales.Controls.Add(this.cmbBoxEspecie);
            this.grpBoxAnimales.Controls.Add(this.cmbBoxCliente);
            this.grpBoxAnimales.Controls.Add(this.label10);
            this.grpBoxAnimales.Controls.Add(this.label11);
            this.grpBoxAnimales.Controls.Add(this.txtBoxPesoAnimal);
            this.grpBoxAnimales.Controls.Add(this.label7);
            this.grpBoxAnimales.Controls.Add(this.txtBoxEdadAnimal);
            this.grpBoxAnimales.Controls.Add(this.label8);
            this.grpBoxAnimales.Controls.Add(this.txtBoxNombreAnimal);
            this.grpBoxAnimales.Controls.Add(this.label9);
            this.grpBoxAnimales.Location = new System.Drawing.Point(649, 76);
            this.grpBoxAnimales.Name = "grpBoxAnimales";
            this.grpBoxAnimales.Size = new System.Drawing.Size(264, 441);
            this.grpBoxAnimales.TabIndex = 4;
            this.grpBoxAnimales.TabStop = false;
            this.grpBoxAnimales.Text = "Alta Animales";
            // 
            // btnAltaAnimal
            // 
            this.btnAltaAnimal.Location = new System.Drawing.Point(91, 373);
            this.btnAltaAnimal.Name = "btnAltaAnimal";
            this.btnAltaAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAltaAnimal.TabIndex = 22;
            this.btnAltaAnimal.Text = "Cargar";
            this.btnAltaAnimal.UseVisualStyleBackColor = true;
            this.btnAltaAnimal.Click += new System.EventHandler(this.btnAltaAnimal_Click);
            // 
            // cmbBoxEspecie
            // 
            this.cmbBoxEspecie.FormattingEnabled = true;
            this.cmbBoxEspecie.Location = new System.Drawing.Point(38, 118);
            this.cmbBoxEspecie.Name = "cmbBoxEspecie";
            this.cmbBoxEspecie.Size = new System.Drawing.Size(184, 21);
            this.cmbBoxEspecie.TabIndex = 21;
            // 
            // cmbBoxCliente
            // 
            this.cmbBoxCliente.FormattingEnabled = true;
            this.cmbBoxCliente.Location = new System.Drawing.Point(38, 56);
            this.cmbBoxCliente.Name = "cmbBoxCliente";
            this.cmbBoxCliente.Size = new System.Drawing.Size(184, 21);
            this.cmbBoxCliente.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(95, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Especie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(95, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = " Cliente";
            // 
            // txtBoxPesoAnimal
            // 
            this.txtBoxPesoAnimal.Location = new System.Drawing.Point(38, 319);
            this.txtBoxPesoAnimal.Name = "txtBoxPesoAnimal";
            this.txtBoxPesoAnimal.Size = new System.Drawing.Size(184, 20);
            this.txtBoxPesoAnimal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(95, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Peso (KG)";
            // 
            // txtBoxEdadAnimal
            // 
            this.txtBoxEdadAnimal.Location = new System.Drawing.Point(38, 249);
            this.txtBoxEdadAnimal.Name = "txtBoxEdadAnimal";
            this.txtBoxEdadAnimal.Size = new System.Drawing.Size(184, 20);
            this.txtBoxEdadAnimal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(103, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Edad";
            // 
            // txtBoxNombreAnimal
            // 
            this.txtBoxNombreAnimal.Location = new System.Drawing.Point(38, 181);
            this.txtBoxNombreAnimal.Name = "txtBoxNombreAnimal";
            this.txtBoxNombreAnimal.Size = new System.Drawing.Size(184, 20);
            this.txtBoxNombreAnimal.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(95, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nombre";
            // 
            // btnFormInforme1
            // 
            this.btnFormInforme1.Location = new System.Drawing.Point(79, 404);
            this.btnFormInforme1.Name = "btnFormInforme1";
            this.btnFormInforme1.Size = new System.Drawing.Size(126, 50);
            this.btnFormInforme1.TabIndex = 5;
            this.btnFormInforme1.Text = "Primer Reporte";
            this.btnFormInforme1.UseVisualStyleBackColor = true;
            this.btnFormInforme1.Click += new System.EventHandler(this.btnFormInforme1_Click);
            // 
            // btnFormInforme2
            // 
            this.btnFormInforme2.Location = new System.Drawing.Point(79, 467);
            this.btnFormInforme2.Name = "btnFormInforme2";
            this.btnFormInforme2.Size = new System.Drawing.Size(126, 50);
            this.btnFormInforme2.TabIndex = 6;
            this.btnFormInforme2.Text = "Segundo Reporte";
            this.btnFormInforme2.UseVisualStyleBackColor = true;
            this.btnFormInforme2.Click += new System.EventHandler(this.btnFormInforme2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(211, 435);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 50);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 552);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFormInforme2);
            this.Controls.Add(this.btnFormInforme1);
            this.Controls.Add(this.grpBoxEspecie);
            this.Controls.Add(this.grpBoxAnimales);
            this.Controls.Add(this.grpBoxCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Gestion Veterinaria";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpBoxEspecie.ResumeLayout(false);
            this.grpBoxEspecie.PerformLayout();
            this.grpBoxCliente.ResumeLayout(false);
            this.grpBoxCliente.PerformLayout();
            this.grpBoxAnimales.ResumeLayout(false);
            this.grpBoxAnimales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxEspecie;
        private System.Windows.Forms.GroupBox grpBoxCliente;
        private System.Windows.Forms.GroupBox grpBoxAnimales;
        private System.Windows.Forms.TextBox txtBoxDNICliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.TextBox txtBoxNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPesoPromedioEspecie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxEdadMadurezEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNombreEspecie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAltaEspecie;
        private System.Windows.Forms.ComboBox cmbBoxEspecie;
        private System.Windows.Forms.ComboBox cmbBoxCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxPesoAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEdadAnimal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxNombreAnimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAltaAnimal;
        private System.Windows.Forms.Button btnFormInforme1;
        private System.Windows.Forms.Button btnFormInforme2;
        private System.Windows.Forms.Button btnActualizar;
    }
}
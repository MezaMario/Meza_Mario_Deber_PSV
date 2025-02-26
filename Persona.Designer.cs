namespace calculador
{
    partial class Persona
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrarl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese su Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese su Ciudad:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(113, 47);
            this.Nombre.Name = "Nombre";
            this.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 5;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(113, 114);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 6;
            this.Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(113, 181);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(100, 20);
            this.Cedula.TabIndex = 7;
            this.Cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(113, 255);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(100, 20);
            this.Edad.TabIndex = 8;
            this.Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(113, 317);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(100, 20);
            this.Ciudad.TabIndex = 9;
            this.Ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(51, 379);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(82, 23);
            this.registrar.TabIndex = 10;
            this.registrar.Text = "REGISTRAR";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingrese su Apellido:";
            // 
            // mostrarl
            // 
            this.mostrarl.Location = new System.Drawing.Point(188, 379);
            this.mostrarl.Name = "mostrarl";
            this.mostrarl.Size = new System.Drawing.Size(93, 23);
            this.mostrarl.TabIndex = 12;
            this.mostrarl.Text = "Mostrar Lista";
            this.mostrarl.UseVisualStyleBackColor = true;
            this.mostrarl.Click += new System.EventHandler(this.mostrarl_Click);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.mostrarl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Persona";
            this.Text = "Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mostrarl;
    }
}
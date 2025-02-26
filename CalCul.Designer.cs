namespace calculador
{
    partial class CalCul
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalCul));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btn_Calcu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Suuma = new System.Windows.Forms.CheckBox();
            this.Reesta = new System.Windows.Forms.CheckBox();
            this.Multi = new System.Windows.Forms.CheckBox();
            this.Divi = new System.Windows.Forms.CheckBox();
            this.modul = new System.Windows.Forms.CheckBox();
            this.persobt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese 1er Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese 2do Numero:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(110, 65);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(88, 21);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(110, 140);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(88, 21);
            this.num2.TabIndex = 3;
            // 
            // btn_Calcu
            // 
            this.btn_Calcu.Location = new System.Drawing.Point(26, 235);
            this.btn_Calcu.Name = "btn_Calcu";
            this.btn_Calcu.Size = new System.Drawing.Size(110, 54);
            this.btn_Calcu.TabIndex = 4;
            this.btn_Calcu.Text = "CALCULAR";
            this.btn_Calcu.UseVisualStyleBackColor = true;
            this.btn_Calcu.Click += new System.EventHandler(this.btn_Calcu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::calculador.Properties.Resources.cal;
            this.pictureBox1.InitialImage = global::calculador.Properties.Resources.cal;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Suuma
            // 
            this.Suuma.AutoSize = true;
            this.Suuma.Location = new System.Drawing.Point(112, 167);
            this.Suuma.Name = "Suuma";
            this.Suuma.Size = new System.Drawing.Size(33, 19);
            this.Suuma.TabIndex = 6;
            this.Suuma.Text = "+";
            this.Suuma.UseVisualStyleBackColor = true;
            // 
            // Reesta
            // 
            this.Reesta.AutoSize = true;
            this.Reesta.Location = new System.Drawing.Point(114, 192);
            this.Reesta.Name = "Reesta";
            this.Reesta.Size = new System.Drawing.Size(31, 19);
            this.Reesta.TabIndex = 7;
            this.Reesta.Text = "-";
            this.Reesta.UseVisualStyleBackColor = true;
            // 
            // Multi
            // 
            this.Multi.AutoSize = true;
            this.Multi.Location = new System.Drawing.Point(165, 167);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(33, 19);
            this.Multi.TabIndex = 8;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            // 
            // Divi
            // 
            this.Divi.AutoSize = true;
            this.Divi.Location = new System.Drawing.Point(165, 192);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(30, 19);
            this.Divi.TabIndex = 9;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            // 
            // modul
            // 
            this.modul.AutoSize = true;
            this.modul.Location = new System.Drawing.Point(139, 217);
            this.modul.Name = "modul";
            this.modul.Size = new System.Drawing.Size(33, 19);
            this.modul.TabIndex = 10;
            this.modul.Text = "%";
            this.modul.UseVisualStyleBackColor = true;
            // 
            // persobt
            // 
            this.persobt.Location = new System.Drawing.Point(178, 235);
            this.persobt.Name = "persobt";
            this.persobt.Size = new System.Drawing.Size(110, 54);
            this.persobt.TabIndex = 11;
            this.persobt.Text = "Nueva Ventana";
            this.persobt.UseVisualStyleBackColor = true;
            this.persobt.Click += new System.EventHandler(this.persobt_Click);
            // 
            // CalCul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculador.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(312, 301);
            this.Controls.Add(this.persobt);
            this.Controls.Add(this.modul);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Reesta);
            this.Controls.Add(this.Suuma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Calcu);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CalCul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button btn_Calcu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Suuma;
        private System.Windows.Forms.CheckBox Reesta;
        private System.Windows.Forms.CheckBox Multi;
        private System.Windows.Forms.CheckBox Divi;
        private System.Windows.Forms.CheckBox modul;
        private System.Windows.Forms.Button persobt;
    }
}


namespace SalarioTrabajador
{
    partial class Form1
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
            this.lbl_Horas = new System.Windows.Forms.Label();
            this.lbl_PagoHora = new System.Windows.Forms.Label();
            this.lbl_Normal = new System.Windows.Forms.Label();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.txt_PagoHora = new System.Windows.Forms.TextBox();
            this.txt_TotalNormal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_TotalExtra = new System.Windows.Forms.TextBox();
            this.lbl_TotalExtra = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Location = new System.Drawing.Point(23, 26);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(35, 13);
            this.lbl_Horas.TabIndex = 0;
            this.lbl_Horas.Text = "Horas";
            // 
            // lbl_PagoHora
            // 
            this.lbl_PagoHora.AutoSize = true;
            this.lbl_PagoHora.Location = new System.Drawing.Point(23, 50);
            this.lbl_PagoHora.Name = "lbl_PagoHora";
            this.lbl_PagoHora.Size = new System.Drawing.Size(74, 13);
            this.lbl_PagoHora.TabIndex = 1;
            this.lbl_PagoHora.Text = "Pago por hora";
            // 
            // lbl_Normal
            // 
            this.lbl_Normal.AutoSize = true;
            this.lbl_Normal.Location = new System.Drawing.Point(23, 76);
            this.lbl_Normal.Name = "lbl_Normal";
            this.lbl_Normal.Size = new System.Drawing.Size(67, 13);
            this.lbl_Normal.TabIndex = 2;
            this.lbl_Normal.Text = "Total Normal";
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(103, 23);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(100, 20);
            this.txt_Horas.TabIndex = 3;
            // 
            // txt_PagoHora
            // 
            this.txt_PagoHora.Location = new System.Drawing.Point(103, 47);
            this.txt_PagoHora.Name = "txt_PagoHora";
            this.txt_PagoHora.Size = new System.Drawing.Size(100, 20);
            this.txt_PagoHora.TabIndex = 4;
            // 
            // txt_TotalNormal
            // 
            this.txt_TotalNormal.Location = new System.Drawing.Point(103, 73);
            this.txt_TotalNormal.Name = "txt_TotalNormal";
            this.txt_TotalNormal.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalNormal.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_TotalExtra
            // 
            this.txt_TotalExtra.Location = new System.Drawing.Point(103, 97);
            this.txt_TotalExtra.Name = "txt_TotalExtra";
            this.txt_TotalExtra.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalExtra.TabIndex = 8;
            // 
            // lbl_TotalExtra
            // 
            this.lbl_TotalExtra.AutoSize = true;
            this.lbl_TotalExtra.Location = new System.Drawing.Point(23, 104);
            this.lbl_TotalExtra.Name = "lbl_TotalExtra";
            this.lbl_TotalExtra.Size = new System.Drawing.Size(58, 13);
            this.lbl_TotalExtra.TabIndex = 7;
            this.lbl_TotalExtra.Text = "Total Extra";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(103, 121);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 199);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TotalExtra);
            this.Controls.Add(this.lbl_TotalExtra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_TotalNormal);
            this.Controls.Add(this.txt_PagoHora);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.lbl_Normal);
            this.Controls.Add(this.lbl_PagoHora);
            this.Controls.Add(this.lbl_Horas);
            this.Name = "Form1";
            this.Text = "Calcular Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.Label lbl_PagoHora;
        private System.Windows.Forms.Label lbl_Normal;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.TextBox txt_PagoHora;
        private System.Windows.Forms.TextBox txt_TotalNormal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TotalExtra;
        private System.Windows.Forms.Label lbl_TotalExtra;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label5;
    }
}


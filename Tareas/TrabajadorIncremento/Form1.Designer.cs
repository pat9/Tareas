namespace TrabajadorIncremento
{
    partial class frm_Salario
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
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.txt_Pago = new System.Windows.Forms.TextBox();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.txt_Sal = new System.Windows.Forms.TextBox();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.txt_Porcent = new System.Windows.Forms.TextBox();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Location = new System.Drawing.Point(61, 29);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(35, 13);
            this.lbl_Horas.TabIndex = 0;
            this.lbl_Horas.Text = "Horas";
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(102, 26);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(100, 20);
            this.txt_Horas.TabIndex = 1;
            // 
            // txt_Pago
            // 
            this.txt_Pago.Location = new System.Drawing.Point(102, 52);
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.Size = new System.Drawing.Size(100, 20);
            this.txt_Pago.TabIndex = 3;
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.Location = new System.Drawing.Point(20, 55);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(76, 13);
            this.lbl_Pago.TabIndex = 2;
            this.lbl_Pago.Text = "Pago por Hora";
            // 
            // txt_Sal
            // 
            this.txt_Sal.Location = new System.Drawing.Point(102, 104);
            this.txt_Sal.Name = "txt_Sal";
            this.txt_Sal.Size = new System.Drawing.Size(100, 20);
            this.txt_Sal.TabIndex = 5;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(57, 107);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(39, 13);
            this.lbl_Salario.TabIndex = 4;
            this.lbl_Salario.Text = "Salario";
            // 
            // txt_Porcent
            // 
            this.txt_Porcent.Location = new System.Drawing.Point(102, 78);
            this.txt_Porcent.Name = "txt_Porcent";
            this.txt_Porcent.Size = new System.Drawing.Size(100, 20);
            this.txt_Porcent.TabIndex = 7;
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Location = new System.Drawing.Point(38, 81);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(58, 13);
            this.lbl_Porcentaje.TabIndex = 6;
            this.lbl_Porcentaje.Text = "Porcentaje";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(102, 131);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 184);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Porcent);
            this.Controls.Add(this.lbl_Porcentaje);
            this.Controls.Add(this.txt_Sal);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.txt_Pago);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.lbl_Horas);
            this.Name = "frm_Salario";
            this.Text = "Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.TextBox txt_Pago;
        private System.Windows.Forms.Label lbl_Pago;
        private System.Windows.Forms.TextBox txt_Sal;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.TextBox txt_Porcent;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.Button btn_Calcular;
    }
}


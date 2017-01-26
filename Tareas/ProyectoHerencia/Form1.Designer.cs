namespace ProyectoHerencia
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
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Location = new System.Drawing.Point(38, 34);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Numero1.TabIndex = 0;
            this.lbl_Numero1.Text = "Numero 1:";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Location = new System.Drawing.Point(36, 60);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Numero2.TabIndex = 1;
            this.lbl_Numero2.Text = "Numero 2:";
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(100, 31);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor1.TabIndex = 2;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(99, 57);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor2.TabIndex = 3;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(100, 84);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_Resultado.TabIndex = 4;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(37, 87);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(41, 125);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(75, 23);
            this.btn_Suma.TabIndex = 6;
            this.btn_Suma.Text = "Suma";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(158, 125);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(75, 23);
            this.btn_Resta.TabIndex = 7;
            this.btn_Resta.Text = "Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 178);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
    }
}


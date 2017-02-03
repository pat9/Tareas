namespace TrabajadorDescuento
{
    partial class frm_Descuento
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.txt_Sal = new System.Windows.Forms.TextBox();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(113, 112);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular.TabIndex = 13;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(112, 60);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(100, 20);
            this.txt_Descuento.TabIndex = 12;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(48, 63);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(59, 13);
            this.lbl_Descuento.TabIndex = 11;
            this.lbl_Descuento.Text = "Descuento";
            // 
            // txt_Sal
            // 
            this.txt_Sal.Location = new System.Drawing.Point(112, 34);
            this.txt_Sal.Name = "txt_Sal";
            this.txt_Sal.Size = new System.Drawing.Size(100, 20);
            this.txt_Sal.TabIndex = 10;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(67, 37);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(39, 13);
            this.lbl_Salario.TabIndex = 9;
            this.lbl_Salario.Text = "Salario";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(41, 89);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(66, 13);
            this.lbl_Total.TabIndex = 14;
            this.lbl_Total.Text = "Total Salario";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(113, 86);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 15;
            // 
            // frm_Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 180);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.txt_Sal);
            this.Controls.Add(this.lbl_Salario);
            this.Name = "frm_Descuento";
            this.Text = "Descuento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.TextBox txt_Sal;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
    }
}


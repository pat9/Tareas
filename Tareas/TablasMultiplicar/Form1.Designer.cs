namespace TablasMultiplicar
{
    partial class frm_Tabla
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
            this.rtb_Tabla = new System.Windows.Forms.RichTextBox();
            this.txt_Tabla = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Tabla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_Tabla
            // 
            this.rtb_Tabla.Location = new System.Drawing.Point(12, 77);
            this.rtb_Tabla.Name = "rtb_Tabla";
            this.rtb_Tabla.Size = new System.Drawing.Size(197, 154);
            this.rtb_Tabla.TabIndex = 0;
            this.rtb_Tabla.Text = "";
            this.rtb_Tabla.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_Tabla
            // 
            this.txt_Tabla.Location = new System.Drawing.Point(58, 27);
            this.txt_Tabla.Name = "txt_Tabla";
            this.txt_Tabla.Size = new System.Drawing.Size(100, 20);
            this.txt_Tabla.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(58, 237);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(102, 24);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(84, 11);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(47, 13);
            this.lbl_Numero.TabIndex = 3;
            this.lbl_Numero.Text = "Numero:";
            // 
            // lbl_Tabla
            // 
            this.lbl_Tabla.AutoSize = true;
            this.lbl_Tabla.Location = new System.Drawing.Point(55, 61);
            this.lbl_Tabla.Name = "lbl_Tabla";
            this.lbl_Tabla.Size = new System.Drawing.Size(98, 13);
            this.lbl_Tabla.TabIndex = 4;
            this.lbl_Tabla.Text = "Tabla de multiplicar";
            this.lbl_Tabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 267);
            this.Controls.Add(this.lbl_Tabla);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Tabla);
            this.Controls.Add(this.rtb_Tabla);
            this.Name = "frm_Tabla";
            this.Text = "Tabla de multiplicar";
            this.Load += new System.EventHandler(this.frm_Tabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Tabla;
        private System.Windows.Forms.TextBox txt_Tabla;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Tabla;
    }
}


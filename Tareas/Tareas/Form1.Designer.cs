namespace Tareas
{
    partial class frm_Porcentaje
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
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.rgb_Porcentaje = new System.Windows.Forms.GroupBox();
            this.rbt_P80 = new System.Windows.Forms.RadioButton();
            this.rbt_P10 = new System.Windows.Forms.RadioButton();
            this.rbt_P40 = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.rgb_Porcentaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(33, 29);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(70, 18);
            this.lbl_Cantidad.TabIndex = 0;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(109, 26);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 24);
            this.txt_Cantidad.TabIndex = 1;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.d);
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // rgb_Porcentaje
            // 
            this.rgb_Porcentaje.Controls.Add(this.rbt_P80);
            this.rgb_Porcentaje.Controls.Add(this.rbt_P10);
            this.rgb_Porcentaje.Controls.Add(this.rbt_P40);
            this.rgb_Porcentaje.Location = new System.Drawing.Point(12, 69);
            this.rgb_Porcentaje.Name = "rgb_Porcentaje";
            this.rgb_Porcentaje.Size = new System.Drawing.Size(260, 71);
            this.rgb_Porcentaje.TabIndex = 2;
            this.rgb_Porcentaje.TabStop = false;
            this.rgb_Porcentaje.Text = "Ménu de porcentaje";
            // 
            // rbt_P80
            // 
            this.rbt_P80.AutoSize = true;
            this.rbt_P80.Location = new System.Drawing.Point(152, 35);
            this.rbt_P80.Name = "rbt_P80";
            this.rbt_P80.Size = new System.Drawing.Size(45, 17);
            this.rbt_P80.TabIndex = 2;
            this.rbt_P80.TabStop = true;
            this.rbt_P80.Text = "%80";
            this.rbt_P80.UseVisualStyleBackColor = true;
            // 
            // rbt_P10
            // 
            this.rbt_P10.AutoSize = true;
            this.rbt_P10.Location = new System.Drawing.Point(24, 35);
            this.rbt_P10.Name = "rbt_P10";
            this.rbt_P10.Size = new System.Drawing.Size(45, 17);
            this.rbt_P10.TabIndex = 1;
            this.rbt_P10.TabStop = true;
            this.rbt_P10.Text = "10%";
            this.rbt_P10.UseVisualStyleBackColor = true;
            // 
            // rbt_P40
            // 
            this.rbt_P40.AutoSize = true;
            this.rbt_P40.Location = new System.Drawing.Point(88, 35);
            this.rbt_P40.Name = "rbt_P40";
            this.rbt_P40.Size = new System.Drawing.Size(45, 17);
            this.rbt_P40.TabIndex = 0;
            this.rbt_P40.TabStop = true;
            this.rbt_P40.Text = "40%";
            this.rbt_P40.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(100, 146);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(83, 35);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(109, 196);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 24);
            this.txt_Resultado.TabIndex = 4;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(28, 196);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(75, 18);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // frm_Porcentaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 242);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rgb_Porcentaje);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Name = "frm_Porcentaje";
            this.Text = "Sacar porcentaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rgb_Porcentaje.ResumeLayout(false);
            this.rgb_Porcentaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.GroupBox rgb_Porcentaje;
        private System.Windows.Forms.RadioButton rbt_P80;
        private System.Windows.Forms.RadioButton rbt_P10;
        private System.Windows.Forms.RadioButton rbt_P40;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}


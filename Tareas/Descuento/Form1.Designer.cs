namespace Descuento
{
    partial class frm_Descuentos
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
            this.lbl_TotalPagar = new System.Windows.Forms.Label();
            this.lbl_MontoPagar = new System.Windows.Forms.Label();
            this.grb_Colores = new System.Windows.Forms.GroupBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.rbt_Rojo = new System.Windows.Forms.RadioButton();
            this.rbt_Verde = new System.Windows.Forms.RadioButton();
            this.rbt_Morado = new System.Windows.Forms.RadioButton();
            this.rbt_Azul = new System.Windows.Forms.RadioButton();
            this.rbt_Gris = new System.Windows.Forms.RadioButton();
            this.rbt_Blanco = new System.Windows.Forms.RadioButton();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.grb_Colores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TotalPagar
            // 
            this.lbl_TotalPagar.AutoSize = true;
            this.lbl_TotalPagar.Location = new System.Drawing.Point(32, 194);
            this.lbl_TotalPagar.Name = "lbl_TotalPagar";
            this.lbl_TotalPagar.Size = new System.Drawing.Size(70, 13);
            this.lbl_TotalPagar.TabIndex = 0;
            this.lbl_TotalPagar.Text = "Total a pagar";
            // 
            // lbl_MontoPagar
            // 
            this.lbl_MontoPagar.AutoSize = true;
            this.lbl_MontoPagar.Location = new System.Drawing.Point(23, 20);
            this.lbl_MontoPagar.Name = "lbl_MontoPagar";
            this.lbl_MontoPagar.Size = new System.Drawing.Size(79, 13);
            this.lbl_MontoPagar.TabIndex = 1;
            this.lbl_MontoPagar.Text = "Monto a pagar:";
            // 
            // grb_Colores
            // 
            this.grb_Colores.Controls.Add(this.rbt_Blanco);
            this.grb_Colores.Controls.Add(this.rbt_Gris);
            this.grb_Colores.Controls.Add(this.rbt_Azul);
            this.grb_Colores.Controls.Add(this.rbt_Morado);
            this.grb_Colores.Controls.Add(this.rbt_Verde);
            this.grb_Colores.Controls.Add(this.rbt_Rojo);
            this.grb_Colores.Location = new System.Drawing.Point(26, 55);
            this.grb_Colores.Name = "grb_Colores";
            this.grb_Colores.Size = new System.Drawing.Size(210, 100);
            this.grb_Colores.TabIndex = 2;
            this.grb_Colores.TabStop = false;
            this.grb_Colores.Text = "Tarjetas";
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(40, 168);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(62, 13);
            this.lbl_Descuento.TabIndex = 6;
            this.lbl_Descuento.Text = "Descuento:";
            // 
            // rbt_Rojo
            // 
            this.rbt_Rojo.AutoSize = true;
            this.rbt_Rojo.Location = new System.Drawing.Point(9, 20);
            this.rbt_Rojo.Name = "rbt_Rojo";
            this.rbt_Rojo.Size = new System.Drawing.Size(47, 17);
            this.rbt_Rojo.TabIndex = 0;
            this.rbt_Rojo.TabStop = true;
            this.rbt_Rojo.Text = "Rojo";
            this.rbt_Rojo.UseVisualStyleBackColor = true;
            this.rbt_Rojo.CheckedChanged += new System.EventHandler(this.rbt_Rojo_CheckedChanged);
            // 
            // rbt_Verde
            // 
            this.rbt_Verde.AutoSize = true;
            this.rbt_Verde.Location = new System.Drawing.Point(9, 44);
            this.rbt_Verde.Name = "rbt_Verde";
            this.rbt_Verde.Size = new System.Drawing.Size(53, 17);
            this.rbt_Verde.TabIndex = 1;
            this.rbt_Verde.TabStop = true;
            this.rbt_Verde.Text = "Verde";
            this.rbt_Verde.UseVisualStyleBackColor = true;
            this.rbt_Verde.CheckedChanged += new System.EventHandler(this.rbt_Verde_CheckedChanged);
            // 
            // rbt_Morado
            // 
            this.rbt_Morado.AutoSize = true;
            this.rbt_Morado.Location = new System.Drawing.Point(9, 67);
            this.rbt_Morado.Name = "rbt_Morado";
            this.rbt_Morado.Size = new System.Drawing.Size(61, 17);
            this.rbt_Morado.TabIndex = 2;
            this.rbt_Morado.TabStop = true;
            this.rbt_Morado.Text = "Morado";
            this.rbt_Morado.UseVisualStyleBackColor = true;
            this.rbt_Morado.CheckedChanged += new System.EventHandler(this.rbt_Morado_CheckedChanged);
            // 
            // rbt_Azul
            // 
            this.rbt_Azul.AutoSize = true;
            this.rbt_Azul.Location = new System.Drawing.Point(106, 20);
            this.rbt_Azul.Name = "rbt_Azul";
            this.rbt_Azul.Size = new System.Drawing.Size(45, 17);
            this.rbt_Azul.TabIndex = 7;
            this.rbt_Azul.TabStop = true;
            this.rbt_Azul.Text = "Azul";
            this.rbt_Azul.UseVisualStyleBackColor = true;
            this.rbt_Azul.CheckedChanged += new System.EventHandler(this.rbt_Azul_CheckedChanged);
            // 
            // rbt_Gris
            // 
            this.rbt_Gris.AutoSize = true;
            this.rbt_Gris.Location = new System.Drawing.Point(106, 44);
            this.rbt_Gris.Name = "rbt_Gris";
            this.rbt_Gris.Size = new System.Drawing.Size(43, 17);
            this.rbt_Gris.TabIndex = 8;
            this.rbt_Gris.TabStop = true;
            this.rbt_Gris.Text = "Gris";
            this.rbt_Gris.UseVisualStyleBackColor = true;
            this.rbt_Gris.CheckedChanged += new System.EventHandler(this.rbt_Gris_CheckedChanged);
            // 
            // rbt_Blanco
            // 
            this.rbt_Blanco.AutoSize = true;
            this.rbt_Blanco.Location = new System.Drawing.Point(106, 67);
            this.rbt_Blanco.Name = "rbt_Blanco";
            this.rbt_Blanco.Size = new System.Drawing.Size(58, 17);
            this.rbt_Blanco.TabIndex = 9;
            this.rbt_Blanco.TabStop = true;
            this.rbt_Blanco.Text = "Blanco";
            this.rbt_Blanco.UseVisualStyleBackColor = true;
            this.rbt_Blanco.CheckedChanged += new System.EventHandler(this.rbt_Blanco_CheckedChanged);
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(108, 20);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(93, 20);
            this.txt_Monto.TabIndex = 7;
            this.txt_Monto.Text = "0";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(108, 168);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(93, 20);
            this.txt_Descuento.TabIndex = 8;
            this.txt_Descuento.Text = "0";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(108, 191);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(93, 20);
            this.txt_Total.TabIndex = 9;
            this.txt_Total.Text = "0";
            // 
            // frm_Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 234);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.grb_Colores);
            this.Controls.Add(this.lbl_MontoPagar);
            this.Controls.Add(this.lbl_TotalPagar);
            this.Name = "frm_Descuentos";
            this.Text = "Descuento";
            this.grb_Colores.ResumeLayout(false);
            this.grb_Colores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TotalPagar;
        private System.Windows.Forms.Label lbl_MontoPagar;
        private System.Windows.Forms.GroupBox grb_Colores;
        private System.Windows.Forms.RadioButton rbt_Blanco;
        private System.Windows.Forms.RadioButton rbt_Gris;
        private System.Windows.Forms.RadioButton rbt_Azul;
        private System.Windows.Forms.RadioButton rbt_Morado;
        private System.Windows.Forms.RadioButton rbt_Verde;
        private System.Windows.Forms.RadioButton rbt_Rojo;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.TextBox txt_Total;
    }
}


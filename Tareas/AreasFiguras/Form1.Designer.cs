namespace AreasFiguras
{
    partial class frm_Areas
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
            this.lbl_Lado1 = new System.Windows.Forms.Label();
            this.lbl_Lado2 = new System.Windows.Forms.Label();
            this.txt_Lado2 = new System.Windows.Forms.TextBox();
            this.txt_Lado1 = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.grb_Opciones = new System.Windows.Forms.GroupBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.rbt_Cuadrado = new System.Windows.Forms.RadioButton();
            this.rbt_Rectangulo = new System.Windows.Forms.RadioButton();
            this.rbt_Triangulo = new System.Windows.Forms.RadioButton();
            this.rbt_Circulo = new System.Windows.Forms.RadioButton();
            this.grb_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Lado1
            // 
            this.lbl_Lado1.AutoSize = true;
            this.lbl_Lado1.Location = new System.Drawing.Point(35, 23);
            this.lbl_Lado1.Name = "lbl_Lado1";
            this.lbl_Lado1.Size = new System.Drawing.Size(37, 13);
            this.lbl_Lado1.TabIndex = 0;
            this.lbl_Lado1.Text = "Lado :";
            // 
            // lbl_Lado2
            // 
            this.lbl_Lado2.AutoSize = true;
            this.lbl_Lado2.Location = new System.Drawing.Point(35, 49);
            this.lbl_Lado2.Name = "lbl_Lado2";
            this.lbl_Lado2.Size = new System.Drawing.Size(46, 13);
            this.lbl_Lado2.TabIndex = 1;
            this.lbl_Lado2.Text = "Lado 2: ";
            this.lbl_Lado2.Visible = false;
            // 
            // txt_Lado2
            // 
            this.txt_Lado2.Location = new System.Drawing.Point(88, 46);
            this.txt_Lado2.Name = "txt_Lado2";
            this.txt_Lado2.Size = new System.Drawing.Size(100, 20);
            this.txt_Lado2.TabIndex = 2;
            this.txt_Lado2.Visible = false;
            // 
            // txt_Lado1
            // 
            this.txt_Lado1.Location = new System.Drawing.Point(88, 20);
            this.txt_Lado1.Name = "txt_Lado1";
            this.txt_Lado1.Size = new System.Drawing.Size(100, 20);
            this.txt_Lado1.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(197, 18);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // grb_Opciones
            // 
            this.grb_Opciones.Controls.Add(this.rbt_Circulo);
            this.grb_Opciones.Controls.Add(this.rbt_Triangulo);
            this.grb_Opciones.Controls.Add(this.rbt_Rectangulo);
            this.grb_Opciones.Controls.Add(this.rbt_Cuadrado);
            this.grb_Opciones.Location = new System.Drawing.Point(38, 108);
            this.grb_Opciones.Name = "grb_Opciones";
            this.grb_Opciones.Size = new System.Drawing.Size(218, 100);
            this.grb_Opciones.TabIndex = 5;
            this.grb_Opciones.TabStop = false;
            this.grb_Opciones.Text = "Figuras";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(69, 81);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(41, 13);
            this.lbl_Area.TabIndex = 6;
            this.lbl_Area.Text = "Area = ";
            // 
            // txt_Area
            // 
            this.txt_Area.Enabled = false;
            this.txt_Area.Location = new System.Drawing.Point(116, 78);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(100, 20);
            this.txt_Area.TabIndex = 7;
            // 
            // rbt_Cuadrado
            // 
            this.rbt_Cuadrado.AutoSize = true;
            this.rbt_Cuadrado.Location = new System.Drawing.Point(22, 28);
            this.rbt_Cuadrado.Name = "rbt_Cuadrado";
            this.rbt_Cuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbt_Cuadrado.TabIndex = 0;
            this.rbt_Cuadrado.TabStop = true;
            this.rbt_Cuadrado.Text = "Cuadrado";
            this.rbt_Cuadrado.UseVisualStyleBackColor = true;
            this.rbt_Cuadrado.CheckedChanged += new System.EventHandler(this.rbt_Cuadrado_CheckedChanged);
            // 
            // rbt_Rectangulo
            // 
            this.rbt_Rectangulo.AutoSize = true;
            this.rbt_Rectangulo.Location = new System.Drawing.Point(22, 68);
            this.rbt_Rectangulo.Name = "rbt_Rectangulo";
            this.rbt_Rectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbt_Rectangulo.TabIndex = 1;
            this.rbt_Rectangulo.TabStop = true;
            this.rbt_Rectangulo.Text = "Rectangulo";
            this.rbt_Rectangulo.UseVisualStyleBackColor = true;
            this.rbt_Rectangulo.CheckedChanged += new System.EventHandler(this.rbt_Rectangulo_CheckedChanged);
            // 
            // rbt_Triangulo
            // 
            this.rbt_Triangulo.AutoSize = true;
            this.rbt_Triangulo.Location = new System.Drawing.Point(121, 28);
            this.rbt_Triangulo.Name = "rbt_Triangulo";
            this.rbt_Triangulo.Size = new System.Drawing.Size(69, 17);
            this.rbt_Triangulo.TabIndex = 2;
            this.rbt_Triangulo.TabStop = true;
            this.rbt_Triangulo.Text = "Triangulo";
            this.rbt_Triangulo.UseVisualStyleBackColor = true;
            this.rbt_Triangulo.CheckedChanged += new System.EventHandler(this.rbt_Triangulo_CheckedChanged);
            // 
            // rbt_Circulo
            // 
            this.rbt_Circulo.AutoSize = true;
            this.rbt_Circulo.Location = new System.Drawing.Point(121, 68);
            this.rbt_Circulo.Name = "rbt_Circulo";
            this.rbt_Circulo.Size = new System.Drawing.Size(57, 17);
            this.rbt_Circulo.TabIndex = 3;
            this.rbt_Circulo.TabStop = true;
            this.rbt_Circulo.Text = "Circulo";
            this.rbt_Circulo.UseVisualStyleBackColor = true;
            this.rbt_Circulo.CheckedChanged += new System.EventHandler(this.rbt_Circulo_CheckedChanged);
            // 
            // frm_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.grb_Opciones);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Lado1);
            this.Controls.Add(this.txt_Lado2);
            this.Controls.Add(this.lbl_Lado2);
            this.Controls.Add(this.lbl_Lado1);
            this.Name = "frm_Areas";
            this.Text = "Areas de figuras";
            this.grb_Opciones.ResumeLayout(false);
            this.grb_Opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lado1;
        private System.Windows.Forms.Label lbl_Lado2;
        private System.Windows.Forms.TextBox txt_Lado2;
        private System.Windows.Forms.TextBox txt_Lado1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.GroupBox grb_Opciones;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.RadioButton rbt_Cuadrado;
        private System.Windows.Forms.RadioButton rbt_Circulo;
        private System.Windows.Forms.RadioButton rbt_Triangulo;
        private System.Windows.Forms.RadioButton rbt_Rectangulo;
    }
}


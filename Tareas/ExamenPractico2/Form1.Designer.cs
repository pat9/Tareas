namespace ExamenPractico2
{
    partial class frm_persona
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
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.rtb_Info = new System.Windows.Forms.RichTextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_CodInt = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_CodInt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(125, 173);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 0;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.Items.AddRange(new object[] {
            "Cliente",
            "Vendedor"});
            this.cmb_Opcion.Location = new System.Drawing.Point(75, 137);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(177, 21);
            this.cmb_Opcion.TabIndex = 1;
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            // 
            // rtb_Info
            // 
            this.rtb_Info.Location = new System.Drawing.Point(62, 220);
            this.rtb_Info.Name = "rtb_Info";
            this.rtb_Info.Size = new System.Drawing.Size(199, 96);
            this.rtb_Info.TabIndex = 2;
            this.rtb_Info.Text = "";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(70, 26);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(152, 23);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(152, 49);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(152, 75);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 6;
            // 
            // txt_CodInt
            // 
            this.txt_CodInt.Enabled = false;
            this.txt_CodInt.Location = new System.Drawing.Point(152, 101);
            this.txt_CodInt.Name = "txt_CodInt";
            this.txt_CodInt.Size = new System.Drawing.Size(100, 20);
            this.txt_CodInt.TabIndex = 7;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(70, 52);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 8;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(72, 78);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 9;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_CodInt
            // 
            this.lbl_CodInt.AutoSize = true;
            this.lbl_CodInt.Location = new System.Drawing.Point(70, 104);
            this.lbl_CodInt.Name = "lbl_CodInt";
            this.lbl_CodInt.Size = new System.Drawing.Size(76, 13);
            this.lbl_CodInt.TabIndex = 10;
            this.lbl_CodInt.Text = "Codigo Interno";
            // 
            // frm_persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 378);
            this.Controls.Add(this.lbl_CodInt);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_CodInt);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.rtb_Info);
            this.Controls.Add(this.cmb_Opcion);
            this.Controls.Add(this.btn_Mostrar);
            this.Name = "frm_persona";
            this.Text = "Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.ComboBox cmb_Opcion;
        private System.Windows.Forms.RichTextBox rtb_Info;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_CodInt;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_CodInt;
    }
}


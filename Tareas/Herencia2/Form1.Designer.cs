namespace Herencia2
{
    partial class frm_Persona
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
            this.grb_Datos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.grb_Alumno = new System.Windows.Forms.GroupBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.grb_Empleado = new System.Windows.Forms.GroupBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Alumno = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.rbt_Info = new System.Windows.Forms.RichTextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.grb_Datos.SuspendLayout();
            this.grb_Alumno.SuspendLayout();
            this.grb_Empleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Datos
            // 
            this.grb_Datos.Controls.Add(this.txt_Edad);
            this.grb_Datos.Controls.Add(this.lbl_Edad);
            this.grb_Datos.Controls.Add(this.txt_Nombre);
            this.grb_Datos.Controls.Add(this.label1);
            this.grb_Datos.Location = new System.Drawing.Point(13, 13);
            this.grb_Datos.Name = "grb_Datos";
            this.grb_Datos.Size = new System.Drawing.Size(390, 100);
            this.grb_Datos.TabIndex = 0;
            this.grb_Datos.TabStop = false;
            this.grb_Datos.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(84, 32);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(126, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(27, 62);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(38, 13);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad: ";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(84, 59);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(126, 20);
            this.txt_Edad.TabIndex = 3;
            // 
            // grb_Alumno
            // 
            this.grb_Alumno.Controls.Add(this.txt_Matricula);
            this.grb_Alumno.Controls.Add(this.lbl_Matricula);
            this.grb_Alumno.Location = new System.Drawing.Point(13, 120);
            this.grb_Alumno.Name = "grb_Alumno";
            this.grb_Alumno.Size = new System.Drawing.Size(191, 65);
            this.grb_Alumno.TabIndex = 1;
            this.grb_Alumno.TabStop = false;
            this.grb_Alumno.Text = "Alumno";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(73, 19);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 5;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(16, 22);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(56, 13);
            this.lbl_Matricula.TabIndex = 4;
            this.lbl_Matricula.Text = "Matricula: ";
            // 
            // grb_Empleado
            // 
            this.grb_Empleado.Controls.Add(this.txt_Clave);
            this.grb_Empleado.Controls.Add(this.label2);
            this.grb_Empleado.Location = new System.Drawing.Point(212, 120);
            this.grb_Empleado.Name = "grb_Empleado";
            this.grb_Empleado.Size = new System.Drawing.Size(191, 65);
            this.grb_Empleado.TabIndex = 6;
            this.grb_Empleado.TabStop = false;
            this.grb_Empleado.Text = "Empleado";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(62, 19);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave: ";
            // 
            // btn_Alumno
            // 
            this.btn_Alumno.Location = new System.Drawing.Point(86, 191);
            this.btn_Alumno.Name = "btn_Alumno";
            this.btn_Alumno.Size = new System.Drawing.Size(75, 23);
            this.btn_Alumno.TabIndex = 7;
            this.btn_Alumno.Text = "Alumno";
            this.btn_Alumno.UseVisualStyleBackColor = true;
            this.btn_Alumno.Click += new System.EventHandler(this.btn_Alumno_Click);
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Location = new System.Drawing.Point(274, 191);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(75, 23);
            this.btn_Empleado.TabIndex = 8;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // rbt_Info
            // 
            this.rbt_Info.Location = new System.Drawing.Point(43, 250);
            this.rbt_Info.Name = "rbt_Info";
            this.rbt_Info.Size = new System.Drawing.Size(306, 96);
            this.rbt_Info.TabIndex = 9;
            this.rbt_Info.Text = "";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(53, 234);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(62, 13);
            this.lbl_Info.TabIndex = 10;
            this.lbl_Info.Text = "Informacion";
            // 
            // frm_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 374);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.rbt_Info);
            this.Controls.Add(this.btn_Empleado);
            this.Controls.Add(this.btn_Alumno);
            this.Controls.Add(this.grb_Empleado);
            this.Controls.Add(this.grb_Alumno);
            this.Controls.Add(this.grb_Datos);
            this.Name = "frm_Persona";
            this.Text = "Persona";
            this.grb_Datos.ResumeLayout(false);
            this.grb_Datos.PerformLayout();
            this.grb_Alumno.ResumeLayout(false);
            this.grb_Alumno.PerformLayout();
            this.grb_Empleado.ResumeLayout(false);
            this.grb_Empleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Datos;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_Alumno;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.GroupBox grb_Empleado;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Alumno;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.RichTextBox rbt_Info;
        private System.Windows.Forms.Label lbl_Info;
    }
}


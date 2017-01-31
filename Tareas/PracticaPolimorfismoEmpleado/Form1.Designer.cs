namespace PracticaPolimorfismoEmpleado
{
    partial class frm_Empleado
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
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.txt_SueldoHora = new System.Windows.Forms.TextBox();
            this.lbl_Horas = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.btn_SinExtra = new System.Windows.Forms.Button();
            this.btn_HorasDobles = new System.Windows.Forms.Button();
            this.btn_Triples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(119, 29);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(100, 20);
            this.txt_Horas.TabIndex = 0;
            // 
            // txt_SueldoHora
            // 
            this.txt_SueldoHora.Location = new System.Drawing.Point(119, 55);
            this.txt_SueldoHora.Name = "txt_SueldoHora";
            this.txt_SueldoHora.Size = new System.Drawing.Size(100, 20);
            this.txt_SueldoHora.TabIndex = 1;
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Location = new System.Drawing.Point(28, 32);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(41, 13);
            this.lbl_Horas.TabIndex = 2;
            this.lbl_Horas.Text = "Horas: ";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(28, 58);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(85, 13);
            this.lbl_Sueldo.TabIndex = 3;
            this.lbl_Sueldo.Text = "Sueldo Por Hora";
            // 
            // btn_SinExtra
            // 
            this.btn_SinExtra.Location = new System.Drawing.Point(77, 88);
            this.btn_SinExtra.Name = "btn_SinExtra";
            this.btn_SinExtra.Size = new System.Drawing.Size(101, 23);
            this.btn_SinExtra.TabIndex = 4;
            this.btn_SinExtra.Text = "Sin Horas Extra";
            this.btn_SinExtra.UseVisualStyleBackColor = true;
            this.btn_SinExtra.Click += new System.EventHandler(this.btn_SinExtra_Click);
            // 
            // btn_HorasDobles
            // 
            this.btn_HorasDobles.Location = new System.Drawing.Point(31, 117);
            this.btn_HorasDobles.Name = "btn_HorasDobles";
            this.btn_HorasDobles.Size = new System.Drawing.Size(84, 23);
            this.btn_HorasDobles.TabIndex = 5;
            this.btn_HorasDobles.Text = "Horas Dobles";
            this.btn_HorasDobles.UseVisualStyleBackColor = true;
            // 
            // btn_Triples
            // 
            this.btn_Triples.Location = new System.Drawing.Point(144, 117);
            this.btn_Triples.Name = "btn_Triples";
            this.btn_Triples.Size = new System.Drawing.Size(75, 23);
            this.btn_Triples.TabIndex = 6;
            this.btn_Triples.Text = "Horas Triples";
            this.btn_Triples.UseVisualStyleBackColor = true;
            // 
            // frm_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 156);
            this.Controls.Add(this.btn_Triples);
            this.Controls.Add(this.btn_HorasDobles);
            this.Controls.Add(this.btn_SinExtra);
            this.Controls.Add(this.lbl_Sueldo);
            this.Controls.Add(this.lbl_Horas);
            this.Controls.Add(this.txt_SueldoHora);
            this.Controls.Add(this.txt_Horas);
            this.Name = "frm_Empleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.TextBox txt_SueldoHora;
        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Button btn_SinExtra;
        private System.Windows.Forms.Button btn_HorasDobles;
        private System.Windows.Forms.Button btn_Triples;
    }
}


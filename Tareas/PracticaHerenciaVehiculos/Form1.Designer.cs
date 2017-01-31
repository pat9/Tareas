namespace PracticaHerenciaVehiculos
{
    partial class frm_Vehiculo
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
            this.grb_Vehiculo = new System.Windows.Forms.GroupBox();
            this.grb_Taxi = new System.Windows.Forms.GroupBox();
            this.grb_Autobus = new System.Windows.Forms.GroupBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Potencia = new System.Windows.Forms.TextBox();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Potencia = new System.Windows.Forms.Label();
            this.lbl_Licencia = new System.Windows.Forms.Label();
            this.txt_Licencia = new System.Windows.Forms.TextBox();
            this.lbl_Plazas = new System.Windows.Forms.Label();
            this.txt_Plazas = new System.Windows.Forms.TextBox();
            this.btn_Taxi = new System.Windows.Forms.Button();
            this.btn_Autobus = new System.Windows.Forms.Button();
            this.grb_Vehiculo.SuspendLayout();
            this.grb_Taxi.SuspendLayout();
            this.grb_Autobus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Vehiculo
            // 
            this.grb_Vehiculo.Controls.Add(this.lbl_Potencia);
            this.grb_Vehiculo.Controls.Add(this.lbl_Modelo);
            this.grb_Vehiculo.Controls.Add(this.lbl_Matricula);
            this.grb_Vehiculo.Controls.Add(this.txt_Potencia);
            this.grb_Vehiculo.Controls.Add(this.txt_Modelo);
            this.grb_Vehiculo.Controls.Add(this.txt_Matricula);
            this.grb_Vehiculo.Location = new System.Drawing.Point(24, 25);
            this.grb_Vehiculo.Name = "grb_Vehiculo";
            this.grb_Vehiculo.Size = new System.Drawing.Size(490, 100);
            this.grb_Vehiculo.TabIndex = 0;
            this.grb_Vehiculo.TabStop = false;
            this.grb_Vehiculo.Text = "Vehiculo";
            // 
            // grb_Taxi
            // 
            this.grb_Taxi.Controls.Add(this.lbl_Licencia);
            this.grb_Taxi.Controls.Add(this.txt_Licencia);
            this.grb_Taxi.Location = new System.Drawing.Point(24, 149);
            this.grb_Taxi.Name = "grb_Taxi";
            this.grb_Taxi.Size = new System.Drawing.Size(229, 75);
            this.grb_Taxi.TabIndex = 1;
            this.grb_Taxi.TabStop = false;
            this.grb_Taxi.Text = "Taxi";
            // 
            // grb_Autobus
            // 
            this.grb_Autobus.Controls.Add(this.lbl_Plazas);
            this.grb_Autobus.Controls.Add(this.txt_Plazas);
            this.grb_Autobus.Location = new System.Drawing.Point(309, 149);
            this.grb_Autobus.Name = "grb_Autobus";
            this.grb_Autobus.Size = new System.Drawing.Size(205, 75);
            this.grb_Autobus.TabIndex = 2;
            this.grb_Autobus.TabStop = false;
            this.grb_Autobus.Text = "AutoBus";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(157, 20);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(204, 20);
            this.txt_Matricula.TabIndex = 0;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(157, 46);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(204, 20);
            this.txt_Modelo.TabIndex = 1;
            // 
            // txt_Potencia
            // 
            this.txt_Potencia.Location = new System.Drawing.Point(157, 72);
            this.txt_Potencia.Name = "txt_Potencia";
            this.txt_Potencia.Size = new System.Drawing.Size(204, 20);
            this.txt_Potencia.TabIndex = 2;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(46, 23);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_Matricula.TabIndex = 3;
            this.lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(46, 49);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modelo.TabIndex = 4;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // lbl_Potencia
            // 
            this.lbl_Potencia.AutoSize = true;
            this.lbl_Potencia.Location = new System.Drawing.Point(46, 75);
            this.lbl_Potencia.Name = "lbl_Potencia";
            this.lbl_Potencia.Size = new System.Drawing.Size(49, 13);
            this.lbl_Potencia.TabIndex = 5;
            this.lbl_Potencia.Text = "Potencia";
            // 
            // lbl_Licencia
            // 
            this.lbl_Licencia.AutoSize = true;
            this.lbl_Licencia.Location = new System.Drawing.Point(15, 22);
            this.lbl_Licencia.Name = "lbl_Licencia";
            this.lbl_Licencia.Size = new System.Drawing.Size(98, 13);
            this.lbl_Licencia.TabIndex = 5;
            this.lbl_Licencia.Text = "Numero de licencia";
            // 
            // txt_Licencia
            // 
            this.txt_Licencia.Location = new System.Drawing.Point(18, 38);
            this.txt_Licencia.Name = "txt_Licencia";
            this.txt_Licencia.Size = new System.Drawing.Size(135, 20);
            this.txt_Licencia.TabIndex = 4;
            // 
            // lbl_Plazas
            // 
            this.lbl_Plazas.AutoSize = true;
            this.lbl_Plazas.Location = new System.Drawing.Point(21, 22);
            this.lbl_Plazas.Name = "lbl_Plazas";
            this.lbl_Plazas.Size = new System.Drawing.Size(92, 13);
            this.lbl_Plazas.TabIndex = 5;
            this.lbl_Plazas.Text = "Numero de plazas";
            // 
            // txt_Plazas
            // 
            this.txt_Plazas.Location = new System.Drawing.Point(24, 38);
            this.txt_Plazas.Name = "txt_Plazas";
            this.txt_Plazas.Size = new System.Drawing.Size(157, 20);
            this.txt_Plazas.TabIndex = 4;
            // 
            // btn_Taxi
            // 
            this.btn_Taxi.Location = new System.Drawing.Point(57, 245);
            this.btn_Taxi.Name = "btn_Taxi";
            this.btn_Taxi.Size = new System.Drawing.Size(104, 23);
            this.btn_Taxi.TabIndex = 3;
            this.btn_Taxi.Text = "Datos del Taxi";
            this.btn_Taxi.UseVisualStyleBackColor = true;
            this.btn_Taxi.Click += new System.EventHandler(this.btn_Taxi_Click);
            // 
            // btn_Autobus
            // 
            this.btn_Autobus.Location = new System.Drawing.Point(333, 245);
            this.btn_Autobus.Name = "btn_Autobus";
            this.btn_Autobus.Size = new System.Drawing.Size(104, 23);
            this.btn_Autobus.TabIndex = 4;
            this.btn_Autobus.Text = "Datos del AutoBus";
            this.btn_Autobus.UseVisualStyleBackColor = true;
            this.btn_Autobus.Click += new System.EventHandler(this.btn_Autobus_Click);
            // 
            // frm_Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 324);
            this.Controls.Add(this.btn_Autobus);
            this.Controls.Add(this.btn_Taxi);
            this.Controls.Add(this.grb_Autobus);
            this.Controls.Add(this.grb_Taxi);
            this.Controls.Add(this.grb_Vehiculo);
            this.Name = "frm_Vehiculo";
            this.Text = "Vehiculos";
            this.grb_Vehiculo.ResumeLayout(false);
            this.grb_Vehiculo.PerformLayout();
            this.grb_Taxi.ResumeLayout(false);
            this.grb_Taxi.PerformLayout();
            this.grb_Autobus.ResumeLayout(false);
            this.grb_Autobus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Vehiculo;
        private System.Windows.Forms.GroupBox grb_Taxi;
        private System.Windows.Forms.GroupBox grb_Autobus;
        private System.Windows.Forms.Label lbl_Potencia;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.TextBox txt_Potencia;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label lbl_Licencia;
        private System.Windows.Forms.TextBox txt_Licencia;
        private System.Windows.Forms.Label lbl_Plazas;
        private System.Windows.Forms.TextBox txt_Plazas;
        private System.Windows.Forms.Button btn_Taxi;
        private System.Windows.Forms.Button btn_Autobus;
    }
}


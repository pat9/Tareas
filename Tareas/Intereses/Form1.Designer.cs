namespace Intereses
{
    partial class frm_CapInte
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
            this.lbl_Cap = new System.Windows.Forms.Label();
            this.lbl_PorIn = new System.Windows.Forms.Label();
            this.lbl_IntPro = new System.Windows.Forms.Label();
            this.lbl_CapAcomu = new System.Windows.Forms.Label();
            this.txt_Cap = new System.Windows.Forms.TextBox();
            this.txt_PorInt = new System.Windows.Forms.TextBox();
            this.txt_IntPro = new System.Windows.Forms.TextBox();
            this.txt_CapAcom = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Cap
            // 
            this.lbl_Cap.AutoSize = true;
            this.lbl_Cap.Location = new System.Drawing.Point(35, 31);
            this.lbl_Cap.Name = "lbl_Cap";
            this.lbl_Cap.Size = new System.Drawing.Size(42, 13);
            this.lbl_Cap.TabIndex = 0;
            this.lbl_Cap.Text = "Capital:";
            // 
            // lbl_PorIn
            // 
            this.lbl_PorIn.AutoSize = true;
            this.lbl_PorIn.Location = new System.Drawing.Point(35, 57);
            this.lbl_PorIn.Name = "lbl_PorIn";
            this.lbl_PorIn.Size = new System.Drawing.Size(64, 13);
            this.lbl_PorIn.TabIndex = 1;
            this.lbl_PorIn.Text = "% de interes";
            // 
            // lbl_IntPro
            // 
            this.lbl_IntPro.AutoSize = true;
            this.lbl_IntPro.Location = new System.Drawing.Point(32, 106);
            this.lbl_IntPro.Name = "lbl_IntPro";
            this.lbl_IntPro.Size = new System.Drawing.Size(89, 13);
            this.lbl_IntPro.TabIndex = 2;
            this.lbl_IntPro.Text = "Interes producido";
            // 
            // lbl_CapAcomu
            // 
            this.lbl_CapAcomu.AutoSize = true;
            this.lbl_CapAcomu.Location = new System.Drawing.Point(32, 132);
            this.lbl_CapAcomu.Name = "lbl_CapAcomu";
            this.lbl_CapAcomu.Size = new System.Drawing.Size(94, 13);
            this.lbl_CapAcomu.TabIndex = 3;
            this.lbl_CapAcomu.Text = "Capital acomulado";
            // 
            // txt_Cap
            // 
            this.txt_Cap.Location = new System.Drawing.Point(150, 28);
            this.txt_Cap.Name = "txt_Cap";
            this.txt_Cap.Size = new System.Drawing.Size(100, 20);
            this.txt_Cap.TabIndex = 4;
            // 
            // txt_PorInt
            // 
            this.txt_PorInt.Location = new System.Drawing.Point(150, 54);
            this.txt_PorInt.Name = "txt_PorInt";
            this.txt_PorInt.Size = new System.Drawing.Size(100, 20);
            this.txt_PorInt.TabIndex = 5;
            // 
            // txt_IntPro
            // 
            this.txt_IntPro.Location = new System.Drawing.Point(150, 103);
            this.txt_IntPro.Name = "txt_IntPro";
            this.txt_IntPro.Size = new System.Drawing.Size(100, 20);
            this.txt_IntPro.TabIndex = 6;
            // 
            // txt_CapAcom
            // 
            this.txt_CapAcom.Location = new System.Drawing.Point(150, 129);
            this.txt_CapAcom.Name = "txt_CapAcom";
            this.txt_CapAcom.Size = new System.Drawing.Size(100, 20);
            this.txt_CapAcom.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(150, 155);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_CapInte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 209);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_CapAcom);
            this.Controls.Add(this.txt_IntPro);
            this.Controls.Add(this.txt_PorInt);
            this.Controls.Add(this.txt_Cap);
            this.Controls.Add(this.lbl_CapAcomu);
            this.Controls.Add(this.lbl_IntPro);
            this.Controls.Add(this.lbl_PorIn);
            this.Controls.Add(this.lbl_Cap);
            this.Name = "frm_CapInte";
            this.Text = "Capital e intereses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cap;
        private System.Windows.Forms.Label lbl_PorIn;
        private System.Windows.Forms.Label lbl_IntPro;
        private System.Windows.Forms.Label lbl_CapAcomu;
        private System.Windows.Forms.TextBox txt_Cap;
        private System.Windows.Forms.TextBox txt_PorInt;
        private System.Windows.Forms.TextBox txt_IntPro;
        private System.Windows.Forms.TextBox txt_CapAcom;
        private System.Windows.Forms.Button btn_Calcular;
    }
}


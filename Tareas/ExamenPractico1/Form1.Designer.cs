namespace ExamenPractico1
{
    partial class frm_Hospital
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
            this.lbl_PresupuestoA = new System.Windows.Forms.Label();
            this.lbl_Gineco = new System.Windows.Forms.Label();
            this.lbl_Trauma = new System.Windows.Forms.Label();
            this.lbl_Ped = new System.Windows.Forms.Label();
            this.txt_PresupuestoA = new System.Windows.Forms.TextBox();
            this.txt_PresupuestoG = new System.Windows.Forms.TextBox();
            this.txt_PresupuestoT = new System.Windows.Forms.TextBox();
            this.txt_PresupestoP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(98, 153);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_PresupuestoA
            // 
            this.lbl_PresupuestoA.AutoSize = true;
            this.lbl_PresupuestoA.Location = new System.Drawing.Point(31, 29);
            this.lbl_PresupuestoA.Name = "lbl_PresupuestoA";
            this.lbl_PresupuestoA.Size = new System.Drawing.Size(96, 13);
            this.lbl_PresupuestoA.TabIndex = 1;
            this.lbl_PresupuestoA.Text = "Presupuesto Anual";
            // 
            // lbl_Gineco
            // 
            this.lbl_Gineco.AutoSize = true;
            this.lbl_Gineco.Location = new System.Drawing.Point(31, 55);
            this.lbl_Gineco.Name = "lbl_Gineco";
            this.lbl_Gineco.Size = new System.Drawing.Size(63, 13);
            this.lbl_Gineco.TabIndex = 2;
            this.lbl_Gineco.Text = "Ginecologia";
            // 
            // lbl_Trauma
            // 
            this.lbl_Trauma.AutoSize = true;
            this.lbl_Trauma.Location = new System.Drawing.Point(31, 81);
            this.lbl_Trauma.Name = "lbl_Trauma";
            this.lbl_Trauma.Size = new System.Drawing.Size(74, 13);
            this.lbl_Trauma.TabIndex = 3;
            this.lbl_Trauma.Text = "Traumatologia";
            // 
            // lbl_Ped
            // 
            this.lbl_Ped.AutoSize = true;
            this.lbl_Ped.Location = new System.Drawing.Point(31, 107);
            this.lbl_Ped.Name = "lbl_Ped";
            this.lbl_Ped.Size = new System.Drawing.Size(48, 13);
            this.lbl_Ped.TabIndex = 4;
            this.lbl_Ped.Text = "Pediatria";
            // 
            // txt_PresupuestoA
            // 
            this.txt_PresupuestoA.Location = new System.Drawing.Point(134, 26);
            this.txt_PresupuestoA.Name = "txt_PresupuestoA";
            this.txt_PresupuestoA.Size = new System.Drawing.Size(100, 20);
            this.txt_PresupuestoA.TabIndex = 5;
            // 
            // txt_PresupuestoG
            // 
            this.txt_PresupuestoG.Location = new System.Drawing.Point(134, 52);
            this.txt_PresupuestoG.Name = "txt_PresupuestoG";
            this.txt_PresupuestoG.Size = new System.Drawing.Size(100, 20);
            this.txt_PresupuestoG.TabIndex = 6;
            // 
            // txt_PresupuestoT
            // 
            this.txt_PresupuestoT.Location = new System.Drawing.Point(134, 78);
            this.txt_PresupuestoT.Name = "txt_PresupuestoT";
            this.txt_PresupuestoT.Size = new System.Drawing.Size(100, 20);
            this.txt_PresupuestoT.TabIndex = 7;
            // 
            // txt_PresupestoP
            // 
            this.txt_PresupestoP.Location = new System.Drawing.Point(134, 104);
            this.txt_PresupestoP.Name = "txt_PresupestoP";
            this.txt_PresupestoP.Size = new System.Drawing.Size(100, 20);
            this.txt_PresupestoP.TabIndex = 8;
            // 
            // frm_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 210);
            this.Controls.Add(this.txt_PresupestoP);
            this.Controls.Add(this.txt_PresupuestoT);
            this.Controls.Add(this.txt_PresupuestoG);
            this.Controls.Add(this.txt_PresupuestoA);
            this.Controls.Add(this.lbl_Ped);
            this.Controls.Add(this.lbl_Trauma);
            this.Controls.Add(this.lbl_Gineco);
            this.Controls.Add(this.lbl_PresupuestoA);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "frm_Hospital";
            this.Text = "Presupuesto del Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_PresupuestoA;
        private System.Windows.Forms.Label lbl_Gineco;
        private System.Windows.Forms.Label lbl_Trauma;
        private System.Windows.Forms.Label lbl_Ped;
        private System.Windows.Forms.TextBox txt_PresupuestoA;
        private System.Windows.Forms.TextBox txt_PresupuestoG;
        private System.Windows.Forms.TextBox txt_PresupuestoT;
        private System.Windows.Forms.TextBox txt_PresupestoP;
    }
}


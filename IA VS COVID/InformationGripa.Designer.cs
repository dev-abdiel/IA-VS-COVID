namespace IA_VS_COVID
{
    partial class InformationGripa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBtn_Reiniciar = new IA_VS_COVID.Constants.RoundedButton();
            this.RBtn_Cerrar = new IA_VS_COVID.Constants.RoundedButton();
            this.SuspendLayout();
            // 
            // RBtn_Reiniciar
            // 
            this.RBtn_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBtn_Reiniciar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBtn_Reiniciar.ForeColor = System.Drawing.Color.White;
            this.RBtn_Reiniciar.Location = new System.Drawing.Point(257, 247);
            this.RBtn_Reiniciar.Name = "RBtn_Reiniciar";
            this.RBtn_Reiniciar.Size = new System.Drawing.Size(128, 52);
            this.RBtn_Reiniciar.TabIndex = 5;
            this.RBtn_Reiniciar.Text = "Reiniciar Test";
            this.RBtn_Reiniciar.UseVisualStyleBackColor = true;
            // 
            // RBtn_Cerrar
            // 
            this.RBtn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBtn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RBtn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.RBtn_Cerrar.Location = new System.Drawing.Point(403, 247);
            this.RBtn_Cerrar.Name = "RBtn_Cerrar";
            this.RBtn_Cerrar.Size = new System.Drawing.Size(119, 52);
            this.RBtn_Cerrar.TabIndex = 4;
            this.RBtn_Cerrar.Text = "Cerrar";
            this.RBtn_Cerrar.UseVisualStyleBackColor = true;
            this.RBtn_Cerrar.Click += new System.EventHandler(this.RBtn_Cerrar_Click);
            // 
            // InformationGripa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.RBtn_Reiniciar);
            this.Controls.Add(this.RBtn_Cerrar);
            this.Name = "InformationGripa";
            this.Text = "InformationGripa";
            this.ResumeLayout(false);

        }

        #endregion

        private Constants.RoundedButton RBtn_Reiniciar;
        private Constants.RoundedButton RBtn_Cerrar;
    }
}
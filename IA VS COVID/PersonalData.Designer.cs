
namespace IA_VS_COVID
{
    partial class PersonalData
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
<<<<<<< HEAD
            this.Btn_Aceptar = new IA_VS_COVID.Constants.RoundedButton();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Edad = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Edad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Location = new System.Drawing.Point(71, 325);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(142, 58);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.Text = "roundedButton1";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nombre.Location = new System.Drawing.Point(40, 157);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Nombre.TabIndex = 3;
            this.Lbl_Nombre.Text = "label1";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Edad.Location = new System.Drawing.Point(40, 237);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Edad.TabIndex = 4;
            this.Lbl_Edad.Text = "label2";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(126, 157);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(182, 23);
            this.Txt_Nombre.TabIndex = 5;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // Txt_Edad
            // 
            this.Txt_Edad.Location = new System.Drawing.Point(126, 237);
            this.Txt_Edad.Name = "Txt_Edad";
            this.Txt_Edad.Size = new System.Drawing.Size(87, 23);
            this.Txt_Edad.TabIndex = 6;
            // 
            // PersonalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Edad);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Btn_Aceptar);
            this.Name = "PersonalData";
            this.Text = "PersonalData";
            this.Load += new System.EventHandler(this.PersonalData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Constants.RoundedButton Btn_Aceptar;
        private Label Lbl_Nombre;
        private Label Lbl_Edad;
        private TextBox Txt_Nombre;
        private TextBox Txt_Edad;
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "PersonalData";
        }

        #endregion
>>>>>>> origin/dev
    }
}
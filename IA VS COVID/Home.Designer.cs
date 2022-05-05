using IA_VS_COVID.Constants;

namespace IA_VS_COVID
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBtn_Comenzar = new IA_VS_COVID.Constants.RoundedButton();
            this.Pb_Informacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Informacion)).BeginInit();
            this.SuspendLayout();
            // 
            // RBtn_Comenzar
            // 
            this.RBtn_Comenzar.FlatAppearance.BorderSize = 0;
            this.RBtn_Comenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBtn_Comenzar.Location = new System.Drawing.Point(224, 342);
            this.RBtn_Comenzar.Margin = new System.Windows.Forms.Padding(0);
            this.RBtn_Comenzar.Name = "RBtn_Comenzar";
            this.RBtn_Comenzar.Size = new System.Drawing.Size(142, 58);
            this.RBtn_Comenzar.TabIndex = 1;
            this.RBtn_Comenzar.Text = "roundedButton1";
            this.RBtn_Comenzar.UseVisualStyleBackColor = true;
           // this.RBtn_Comenzar.Click += new System.EventHandler(this.RBtn_Comenzar_Click_1);
            // 
            // Pb_Informacion
            // 
            this.Pb_Informacion.BackColor = System.Drawing.Color.White;
            this.Pb_Informacion.Location = new System.Drawing.Point(1, 338);
            this.Pb_Informacion.Name = "Pb_Informacion";
            this.Pb_Informacion.Size = new System.Drawing.Size(115, 115);
            this.Pb_Informacion.TabIndex = 2;
            this.Pb_Informacion.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pb_Informacion);
            this.Controls.Add(this.RBtn_Comenzar);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Informacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton RBtn_Comenzar;
        private PictureBox Pb_Informacion;
    }
}
using IA_VS_COVID.Constants;

namespace IA_VS_COVID
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RBtn_Comenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton RBtn_Comenzar;
        private PictureBox pictureBox1;
    }
}
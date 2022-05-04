using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IA_VS_COVID.Constants;

namespace IA_VS_COVID
{
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(AppGraphics.PERSONAL_DATA);
            BackgroundImageLayout = ImageLayout.Stretch;
            //Lbl_Nombre.BackColor = AppColors.;
            Lbl_Nombre.Text = AppTexts.NOMBRE;
            Lbl_Nombre.ForeColor = AppColors.black;
            Lbl_Nombre.Font = new Font(Lbl_Nombre.Font.Name, 14, FontStyle.Bold);

            Lbl_Edad.Text = AppTexts.EDAD;
            Lbl_Edad.ForeColor = AppColors.black;
            Lbl_Edad.Font = new Font(Lbl_Nombre.Font.Name, 14, FontStyle.Bold);

            Btn_Aceptar.Text = AppTexts.CONTINUAR;
            Btn_Aceptar.ForeColor = AppColors.black;
            Btn_Aceptar.Font = new Font(Lbl_Nombre.Font.Name, 14, FontStyle.Bold);

        }

       
       
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
           

            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Edad.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor escriba solo numeros.");
                Txt_Edad.Text = Txt_Edad.Text.Remove(Txt_Edad.Text.Length - 1);
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Nombre.Text, "[^a-z]"))
            {
                MessageBox.Show("Por favor escriba solo letras.");
                Txt_Nombre.Text = Txt_Nombre.Text.Remove(Txt_Nombre.Text.Length);
            }

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void PersonalData_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(AppGraphics.COVID_EXPLANATION);
            BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Regresar.BackgroundImage = Image.FromFile(AppGraphics.BTN_REGRESAR);
            Btn_Regresar.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
        }
    }
}

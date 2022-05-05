using IA_VS_COVID.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_VS_COVID
{
    public partial class InformationDelta : Form
    {
        public InformationDelta()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(AppGraphics.INFORMATIONDELTA);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            RBtn_Cerrar.BackColor = AppColors.blue;
            RBtn_Reiniciar.BackColor = AppColors.blue;
        }

        private void RBtn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

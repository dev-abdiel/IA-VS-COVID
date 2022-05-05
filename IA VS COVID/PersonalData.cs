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
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(AppGraphics.PERSONAL_DATA);

            label firstlab = new label();
            firstlab.Text = ("NOMBRE:  ");
            firstlab.Location = new Point(222, 90);

            TextBox txtBox = new TextBox();








        }

    }
}

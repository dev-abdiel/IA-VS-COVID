using IA_VS_COVID.Constants;

namespace IA_VS_COVID
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(AppGraphics.HOME);
            RBtn_Comenzar.BackColor = AppColors.blue;
            Pb_Informacion.BackgroundImage = Image.FromFile(AppGraphics.VIRUS);
            Pb_Informacion.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
    }
}
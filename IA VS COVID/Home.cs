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
            RBtn_Comenzar.Text = AppTexts.COMENZAR;
            RBtn_Comenzar.ForeColor = AppColors.white;
            RBtn_Comenzar.Font = new Font(RBtn_Comenzar.Font.Name, 14, FontStyle.Bold);
            Pb_Informacion.BackgroundImage = Image.FromFile(AppGraphics.VIRUS);
            Pb_Informacion.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
    }
}
using IA_VS_COVID.Constants;

namespace IA_VS_COVID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(AppGraphics.HOME);
            RBtn_Comenzar.BackColor = AppColors.blue;
            pictureBox1.BackgroundImage = Image.FromFile(AppGraphics.VIRUS);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
    }
}
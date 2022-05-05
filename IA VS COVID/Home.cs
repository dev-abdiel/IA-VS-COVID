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
            RBtn_Comenzar.Click += this.RBtn_Comenzar_Click;
            Pb_Informacion.BackgroundImage = Image.FromFile(AppGraphics.VIRUS);
            Pb_Informacion.BackgroundImageLayout = ImageLayout.Stretch;
            Pb_Informacion.Click += new System.EventHandler(this.Pb_Informacion_Click);
        }
<<<<<<< HEAD

        private void Pb_Informacion_Click(object? sender, EventArgs e)
        {
            Information form = new Information();
            form.Show();
            
        }


=======
        private void RBtn_Comenzar_Click(object? sender, EventArgs? e)
        {
            PersonalData form = new PersonalData();
            form.Show();

        }
>>>>>>> origin/dev
    }
}
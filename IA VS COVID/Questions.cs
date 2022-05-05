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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(AppGraphics.BACKGROUND);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            RBtn_Siguiente.BackColor = AppColors.blue;
            RBtn_Siguiente.Text = AppTexts.SIGUIENTE;
            showQuestions();
        }
        int i=0;
        string[] answers=new string[14];
        string[] questions = {
            "¿Ha tenido contacto con algún paciente con coronavirus?",
            "¿Considera usted que ha presentado fiebre o temperatura arriba de 38 grados?",
            "¿Presenta tos seca y persistente?",
            "¿Ha tenido o presenta dolor de cabeza y/o garganta?",
            "¿Ha tenido perdida de olfato y gusto?",
            "¿Presenta cansancio y/o dolor corporal?",
            "¿Ha tenido dificultad para respirar?",
            "¿Presenta dolor en pecho? (tórax)",
            "¿Padece Hipertensión (presión alta), Diabetes (Azúcar elevada), Asma u Obesidad / sobrepeso?",
            "¿Presenta secreción nasal?",
            "¿Presenta congestión nasal?",
            "¿Padece de estornudos?",
            "¿Ha presentado sudores nocturnos?",
            "¿Has recibido alguna vacuna contra el covid-19 en los últimos 6 meses?"};
        private void showQuestions()
        {
            Gb_TopQuestion.Text = questions[i];
            Gb_BottomQuestion.Text = questions[i + 1];
            Rb1_Gb1.Checked = false;
            Rb2_Gb1.Checked = false;
            Rb1_Gb2.Checked = false;
            Rb2_Gb2.Checked = false;

        }
        int covid = 0, delta = 0, omicron = 0, gripa = 0;

        private void RBtn_Siguiente_Click(object sender, EventArgs e)
        {
            if ((Rb1_Gb1.Checked == true || Rb2_Gb1.Checked == true) && (Rb1_Gb2.Checked == true || Rb2_Gb2.Checked == true))
            {
                if (Rb1_Gb1.Checked == true)
                    answers[i] = Rb1_Gb1.Text;
                else if (Rb2_Gb1.Checked == true)
                    answers[i] = Rb2_Gb1.Text;
                if (Rb1_Gb2.Checked == true)
                    answers[i + 1] = Rb1_Gb2.Text;
                else if (Rb2_Gb2.Checked == true)
                    answers[i + 1] = Rb2_Gb2.Text;
                if (i < 12)
                {
                    i += 2;
                    showQuestions();
                }
                else
                {
                    RBtn_Siguiente.Enabled = false;
                    checkanswers();
                }
            }
            else MessageBox.Show("Por favor de Contestar todas las preguntas","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void checkanswers()
        {
            int cont = 0;
            foreach (var answer in answers)
            {
                if (cont == 1 && answer =="Si")
                {
                    covid++;
                    delta++;
                    omicron++;
                }
                else if (cont == 2 && answer == "Si")
                {
                    gripa++;
                    covid++;
                    delta++;
                }
                else if(cont == 3 && answer == "Si")
                {
                    delta++;
                    omicron++;
                    gripa++;
                }
                else if (cont == 4 && answer == "Si")
                {
                    covid++;
                    delta++;
                }
                else if(cont == 5 && answer == "Si")
                {
                    omicron++;
                    covid++;
                }
                else if (cont == 6 && answer == "Si")
                {
                    covid++;
                }
                else if(cont == 9 && answer == "Si")
                {
                    omicron++;
                    gripa++;
                }
                else if(cont == 10 && answer == "Si")
                {
                    gripa++;
                }
                else if (cont == 11 && answer == "Si")
                {
                    delta++;
                }
                else if(cont == 12 && answer == "Si")
                {
                    omicron++;
                }
                cont++;
            }
            if (omicron >= 5)
            {
                Form form = new InformationOmicron();
                form.ShowDialog();
                this.Dispose();
            }
            else if(covid >= 5)
            {
                Form form = new InformationCovid();
                form.ShowDialog();
                this.Dispose();
            }
            else if (delta >= 5)
            {
                Form form = new InformationDelta();
                form.ShowDialog();
                this.Dispose();
            }
            else if(gripa>= 4)
            {
                Form form = new InformationGripa();
                form.ShowDialog();
                this.Dispose();
            }
            else if(omicron>delta && omicron>covid && omicron > gripa)
            {
                Form form = new InformationOmicron();
                form.ShowDialog();
                this.Dispose();
            }
            else if (delta > omicron && delta > covid && delta > gripa)
            {
                Form form = new InformationDelta();
                form.ShowDialog();
                this.Dispose();
            }
            else if (covid > delta && covid > omicron && covid > gripa)
            {
                Form form = new InformationCovid();
                form.ShowDialog();
                this.Dispose();
            }
            else if (gripa > delta && gripa > omicron && gripa > covid)
            {
                Form form = new InformationGripa();
                form.ShowDialog();
                this.Dispose();
            }
            else
            {
                Form form = new InformationSinSintomas();
                form.ShowDialog();
                this.Dispose();
            }

        }

    }
}

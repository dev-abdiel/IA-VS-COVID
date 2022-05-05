using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_VS_COVID.Constants
{
    public abstract class AppGraphics
    {
        private readonly static String _prefix = "../../../Assets/";

        public readonly static String APP_ICON = $"{_prefix}/app_icon.png";
        public readonly static String HOME = $"{_prefix}/1.png";
        public readonly static String COVID_EXPLANATION = $"{_prefix}/2.png";
        public readonly static String PERSONAL_DATA = $"{_prefix}/3.png";
        public readonly static String BACKGROUND = $"{_prefix}/4.png";
        public readonly static String VIRUS = $"{_prefix}/virus.png";
<<<<<<< HEAD
        public readonly static String INFORMATIONCOVID = $"{_prefix}/5.png";
        public readonly static String INFORMATIONOMICRON = $"{_prefix}/7.png";
        public readonly static String INFORMATIONDELTA = $"{_prefix}/6.png";
        public readonly static String INFORMATIONGRIPA = $"{_prefix}/8.png";
        public readonly static String INFORMATIONSINSINTOMAS = $"{_prefix}/9.png";
=======
        public readonly static String BTN_REGRESAR = $"{_prefix}/regreso.png";
>>>>>>> origin/dev
    }
}

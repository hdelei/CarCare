using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCare.Properties;

namespace CarCare.Controller
{
    class Icon
    {
        static Dictionary<string, object> formattedIcon = new Dictionary<string, object>();

        static Dictionary<string, Image> icons = new Dictionary<string, Image>()
        {
            { "carro", Resources.car },
            { "moto", Resources.moto },
            { "caminhão", Resources.truck },
            { "balão", Resources.balloon },
            { "submarino", Resources.submarine },
            { "bicicleta", Resources.bike },
            { "helicóptero", Resources.helicopter },
            { "barco", Resources.boat }    
        };

        static Dictionary<string, Color> backColors = new Dictionary<string, Color>()
        {
            { "carro", Color.FromArgb(66,134,244) },
            { "moto", Color.FromArgb(56,23,89) },
            { "caminhão", Color.FromArgb(128,38,142) },
            { "balão", Color.FromArgb(28,26,26) },
            { "submarino", Color.FromArgb(244,150,40) },
            { "bicicleta", Color.FromArgb(31,142,14) },
            { "helicóptero", Color.FromArgb(181,39,27) },
            { "barco", Color.FromArgb(175,59,59) }
        };

        static Dictionary<string, Color> fontColors = new Dictionary<string, Color>()
        {
            { "carro", Color.FromArgb(28,26,26) },
            { "moto", Color.FromArgb(28,26,26) },
            { "caminhão", Color.FromArgb(28,26,26) },
            { "balão", Color.FromArgb(28,26,26) },
            { "submarino", Color.FromArgb(28,26,26) },
            { "bicicleta", Color.FromArgb(28,26,26) },
            { "helicóptero", Color.FromArgb(28,26,26) },
            { "barco", Color.FromArgb(28,26,26) }
        };

        public static void SetIcon(string vehicle)
        {
            formattedIcon.Clear();
            formattedIcon.Add("icon", icons[vehicle]);
            formattedIcon.Add("backColor", backColors[vehicle]);
            formattedIcon.Add("fontColor", fontColors[vehicle]);
        }

        public static Dictionary<string, object> GetIcon()
        {
            return formattedIcon;
        }
    }
}

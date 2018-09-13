using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Xamarin.Forms;

namespace Mato.Utils
{
    public class ColorHelper
    {
        public static Color GetColorFromHEX(object value)
        {
            uint color = System.Convert.ToUInt32(value.ToString(), fromBase: 16);
            byte A = (byte)((color & 0xFF000000) >> 24);
            byte R = (byte)((color & 0x00FF0000) >> 16);
            byte G = (byte)((color & 0x0000FF00) >> 8);
            byte B = (byte)((color & 0x000000FF) >> 0);
            Color col = Color.FromRgba(R, G, B, A);


            return col;
        }
    }
}

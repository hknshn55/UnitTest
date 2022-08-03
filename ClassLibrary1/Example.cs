using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Example
    {
        public static string TrimRemoved(string value)
        {
            //gelen değerin başındaki ve sonundaki boşlukları sil
            //içerideki fazla bolukları sil
            value = value.Trim();
            string newValue = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ' && value[i + 1] == ' ')
                    continue;
                newValue += value[i]; 
            }
            return newValue;
        }
    }
}

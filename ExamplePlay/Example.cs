using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePlay
{
    public class Example
    {
        public string TrimRemoved(string value)
        {
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

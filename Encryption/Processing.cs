using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Encryption
{
    class Processing
    {
        public static int AppplyShift(string input, int shift)
        {
            int y;                                                                              //last edit
            for (int i = 0; i < input.Length; i++)
            {
                char x = Convert.ToChar(input.Substring(0, 1));
                y = (int)x;
            }

            return y;
            
        }
    }
}

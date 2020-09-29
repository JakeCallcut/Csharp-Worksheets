using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Subroutines
{
    class InputProcessing
    {

        public static bool NoErrors(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = Convert.ToChar(input.Substring(i, 1));

                if (currChar == '1') { }
                else if (currChar == '2') { }
                else if (currChar == '3') { }
                else if (currChar == '4') { }
                else if (currChar == '5') { }
                else if (currChar == '6') { }
                else if (currChar == '7') { }
                else if (currChar == '8') { }
                else if (currChar == '9') { }
                else if (currChar == '.') { }
                else if (currChar == ',') { }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}

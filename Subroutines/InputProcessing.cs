﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Subroutines
{
    class InputProcessing
    {
        public static double FindHighest(List<double> list)
        {
            double currHigh = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > currHigh)
                {
                    currHigh = list[i];
                }
            }

            return currHigh;
        }

        public static double FindLowest(List<double> list)
        {
            double currLow = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < currLow)
                {
                    currLow = list[i];
                }
            }

            return currLow;
        }

        public static double FindMean(List<double> list)
        {
            double total = 0;

            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }

            double mean = total / list.Count;

            return mean;
        }

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

using System;
using System.Linq;
using System.Threading;

namespace KursWorkOPR
{
    class ConverterFromIntToBin
    {
        Random randc = new Random();
        public int N = 0;
        public int numberIndividual = 0;
        public string X1;
        public string X2;
        public int numberOfGeneration = 0;

        public string X1X2;

        public int Celoe(int left, int right)
        {
            Thread.Sleep(100);
            return randc.Next(left, right);
        }

        public int Decytichnoe()
        {
            Thread.Sleep(100);
            return randc.Next(0, 9);
        }


        public string Trans(int cheloe, int desytoe)
        {
            string f = cheloe.ToString();
            string r = desytoe.ToString();
            string result = f +","+ r;
            return result;
        }

      


        public string[] getIntNumbersFronBin(string inputBinString)
        {
          //  string[] str = inputBinString.Split(',');

            int intNumber1 = Convert.ToInt32(inputBinString.Substring(0,8), 2);
            int intNumber2 = Convert.ToInt32(inputBinString.Substring(8), 2);
            
            return  new []
            {
              intNumber1.ToString() ,
              intNumber2.ToString()
            } ;
        }

        public string helloDvoichnoe(int cheloe, int desytoe)
        {
            string leftPart = Convert.ToString(cheloe, 2);
            string rightPart = Convert.ToString(desytoe, 2);
            int len1 = leftPart.Length;
            int len2 = rightPart.Length;
            if (len1==3)
            {
                leftPart = "0" + leftPart;
            }else if (len1==2)
            {
                leftPart = "00" + leftPart;
            }
            else if (len1 == 1)
            {
                leftPart = "000" + leftPart;
            }

            if (len2 == 3)
            {
                rightPart = "0" + rightPart;
            }
            else if (len2 == 2)
            {
                rightPart = "00" + rightPart;
            }
            else if (len2 == 1)
            {
                rightPart = "000" + rightPart;
            }
            string result = leftPart+rightPart;
            return result;
        }

        public string HelloX1X2(string x1, string x2)
        {
            return x1 + x2;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWorkOPR
{
    class Crossing
    {
        private Random rand = new Random();
        public  Form1 _form;
        public Crossing(Form1 form)
        {
            _form = form;
        }

        public List<SearchRankPoint> Cross(List<SearchRankPoint> individs)
        {
            int numberCross = Convert.ToInt32(_form.textBoxForCrossing.Text);
            var first = individs[0].X1X2Bin;
            var second = individs[1].X1X2Bin;
            var newSecondLine = "";
            var newFirstLine = "";

            for (int i = 0; i < first.Length; i++)
            {
                if (i < numberCross)
                {
                    newSecondLine = newSecondLine + second[i];
                    newFirstLine = newFirstLine + first[i];
                }
                else
                {
                    newSecondLine = newSecondLine + first[i];
                    newFirstLine = newFirstLine + second[i];
                }
            }

            var newPoint1 = new SearchRankPoint()
            {
                valueFunction = individs[0].valueFunction,
                X1X2Bin = newFirstLine,
                Number = individs[0].Number,
                Generation = individs[0].Generation
            };

            ConverterFromIntToBin ind = new ConverterFromIntToBin();
   
            var newPoint2 = new SearchRankPoint()
            {
                valueFunction = individs[1].valueFunction,
                X1X2Bin = newSecondLine,
                Number = individs[1].Number,
                Generation = individs[1].Generation
            };
            var result = new List<SearchRankPoint>();
            result.Add(newPoint1);
            result.Add(newPoint2);
            return result;
        }

    }
}

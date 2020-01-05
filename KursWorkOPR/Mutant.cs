 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Threading;
 using System.Threading.Tasks;
 using System.Windows.Forms;

namespace KursWorkOPR
{
    class Mutant
    {
        private Random rand = new Random();
        public  Form1 _form;
        public Mutant(Form1 form)
        {
            _form = form;
        }

        public List<SearchRankPoint> Mutating(List<SearchRankPoint> individs)
        {
            int chance = Convert.ToInt32(_form.chanceOfMutate.Value);
            
            Thread.Sleep(50);


            var newPoint1 = new SearchRankPoint()
            {
                valueFunction = individs[0].valueFunction,
                X1X2Bin = individs[0].X1X2Bin,
               Number = individs[0].Number,
               Generation = individs[0].Generation
               
            };

          

            var newPoint2 = new SearchRankPoint()
            {
                valueFunction = individs[1].valueFunction,
                X1X2Bin = individs[1].X1X2Bin,
                Number = individs[1].Number,
                Generation = individs[1].Generation
            };

          

            var result = new List<SearchRankPoint>();
            result.Add(newPoint1);
            result.Add(newPoint2);

            foreach (var individ in result)
            {
                StringBuilder bin = new StringBuilder();
                bin.Append(individ.X1X2Bin);
                for (int i = 0; i < bin.Length; i++)
                {
                    int a = rand.Next(0, 100);
                    if (chance > a)
                    {
                        if (bin[i]=='0')
                        {
                            bin[i] = '1';       
                        }
                        else
                        {
                            bin[i] = '0';
                        }
                    }
                }
                individ.X1X2Bin = bin.ToString();
            }
            ConverterFromIntToBin ind = new ConverterFromIntToBin();
            return result;
        }

    }
}

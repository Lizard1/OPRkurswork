using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace KursWorkOPR
{
    internal class Setka
    {
        private Random randc = new Random();
        private Form1 _form;

        public List<Point> points = new List<Point>();
        private Point node;
        private int numberNodes;
        private int ai, aj;

        public Setka(Form1 form)
        {
            _form = form;
        }
        
        public void dropperSharp(int x1left, int x1right, int x2left, int x2right)
        {
            var xLenght = x1right - x1left;
            var yLenght = x2right - x2left;
            xLenght = xLenght*3;
            yLenght = yLenght*3;

            var xPixelsWeight = 0;
            var yPixelsWeight = 0;

            int numberPoint = Int32.Parse(_form.Npoints.Text);

            if ((numberPoint>=4) && (numberPoint<10))
            {
                ai = 3;
                aj = 3;
                xPixelsWeight = xLenght/ai;
                yPixelsWeight = yLenght/aj;
                numberNodes = ai*aj;
            }
            else if ((numberPoint >= 10) && (numberPoint < 13))
            {
                ai = 4;
                aj = 3;
                xPixelsWeight = xLenght /ai;;
                yPixelsWeight = yLenght /aj;;
                numberNodes = ai*aj;
            }
            if ((numberPoint >=13) && (numberPoint <17))
            {
                ai = 4;
                aj = 4;
                xPixelsWeight = xLenght / ai;
                yPixelsWeight = yLenght / aj;
                numberNodes = ai*aj;
            }

            for (int i = 0; i < numberPoint; i++)
            {
                points.Add(new Point());
            }
            
            
            var nodes = new List<int>(ai*aj);
            for (int i = 0; i < ai*aj; i++)
            {
                nodes.Add(i);
            }

            foreach (var point in points)
            {
                int randomNumberIndex = randc.Next(0, nodes.Count);
                int randomNumber = nodes[randomNumberIndex];
                nodes.RemoveAt(randomNumberIndex);

                var counter = 0;
                for (int i = 0; i < ai; i++)
                {
                    for (int j = 0; j < aj; j++)
                    {
                        if (counter == randomNumber)
                        {
                            point.X1 = i * xPixelsWeight;
                            point.X2 = j * yPixelsWeight;
                            point.X1NodeNumber = i;
                            point.X2NodeNumber = j;
                            point.NodeNumber = randomNumber;
                        }
                        counter++;
                    }
                }
            }
        }

        public void pointsInfo()
        {
            foreach (var point in points)
            {
                MessageBox.Show(point.X1.ToString()+" "+point.X2.ToString());
            }
        }
        public void drawPoints()
        {
            _form.pictureBox1.Refresh();
           foreach (var point in points)
            {
                _form.pictureBox1.CreateGraphics().FillEllipse(new SolidBrush(Color.Green), ((float)point.X1) * 15, ((float)point.X2) * 15, 7, 7);    
            }
        }
    }
}

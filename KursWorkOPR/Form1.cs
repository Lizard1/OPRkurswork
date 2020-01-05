using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace KursWorkOPR
{
    public partial class Form1 : Form
    {
        public List<string> valuesOfFunction = new List<string>();
        private List<SearchRankPoint> PointsForSorting = new List<SearchRankPoint>();
        private List<SearchRankPoint> PointsForSortingSetka = new List<SearchRankPoint>();
        private List<SearchRankPoint> pointForMutate = new List<SearchRankPoint>();
        public float xb1, xb2;

        private ConverterFromIntToBin DeleteTHISobject = new ConverterFromIntToBin();

        private Setka setka ;
        private List<Point> points = new List<Point>();
        private List<Point> pointsForSetka = new List<Point>();

        private string Method = "";
        public TextBox TextBoxForFunction {
            get { return textBoxForFunction; }
        }
        public DataGridView DataForGenerations
        {
            get { return dataForGenerations; }
        }

    #region form
        public Form1()
        {
            InitializeComponent();
           List<SearchRankPoint> sortingPoint = new List<SearchRankPoint>();
            setka = new Setka(this);
        }
#endregion
        //отбор точек
        private void button1_Click(object sender, EventArgs e)
        {
           Rank ppppp = new Rank(this);
            Mutant mut = new Mutant(this);
           IEnumerable<SearchRankPoint> listForDraw = ppppp.Get2BestPersonFromLastGeneration(PointsForSorting);
            pointForMutate = ppppp.Get2BestPersonFromLastGeneration(PointsForSorting).ToList();
            mut.Mutating(pointForMutate);
           ppppp.drawPoints(listForDraw);


           Crossing fd = new Crossing(this);
            fd.Cross(pointForMutate);
        }

        //наброс точек
        private void butPointGener_Click(object sender, EventArgs e)
        {
            Method = "Случайный наброс";

            var border = GetBorder();

            for (int j = 0; j < Convert.ToInt32(Npoints.Text); j++)
            {
                ConverterFromIntToBin ind = new ConverterFromIntToBin();

               // ind.N = border.numberOfPoint;
                ind.numberIndividual = j;
                ind.numberOfGeneration = Convert.ToInt32(textBoxForP.Text);
               

                int celoeForX1 = ind.Celoe(border.scopeX1Left, border.scopeX1Right);

                int celoeForX2 = ind.Celoe(Int32.Parse(border.scopeX2Left.ToString()),
                    Int32.Parse(border.scopeX2Right.ToString()));

                int decForX1 = ind.Decytichnoe();
                int decForX2 = ind.Decytichnoe();

                ind.X1 = ind.Trans(celoeForX1, decForX1);
                ind.X2 = ind.Trans(celoeForX2, decForX2);
                string X1Dvoichnoe = ind.helloDvoichnoe(celoeForX1, decForX1);
                string X2Dvoichnoe = ind.helloDvoichnoe(celoeForX2, decForX2);
                ind.X1X2 = ind.HelloX1X2(X1Dvoichnoe, X2Dvoichnoe);
                Point point = new Point();
                dataForGenerations.Rows.Add();

                dataForGenerations.Rows[j].Cells[0].Value = 0;
                //dataForGenerations.Rows[j].Cells[1].Value = ind.N;
                dataForGenerations.Rows[j].Cells[2].Value = ind.numberIndividual;
                dataForGenerations.Rows[j].Cells[3].Value = ind.X1;
                dataForGenerations.Rows[j].Cells[4].Value = ind.X2;
                dataForGenerations.Rows[j].Cells[5].Value = ind.X1X2;

          
                point.X1 = Convert.ToDouble(ind.X1);
                point.X2 = Convert.ToDouble(ind.X2);
                points.Add(point);

            }

            var result = border.valueOfFunction();


            if (result.OK == false)
            {
                MessageBox.Show(result.Message);
                return;
            }

            for (int j = 0; j < Convert.ToInt32(Npoints.Text); j++)
            {
                SearchRankPoint sortPoint = new SearchRankPoint();
                dataForGenerations.Rows[j].Cells[6].Value = result.Result[j];
                sortPoint.X1 = dataForGenerations.Rows[j].Cells[3].Value.ToString();
                sortPoint.X2 = dataForGenerations.Rows[j].Cells[4].Value.ToString();
                sortPoint.X1X2Bin = dataForGenerations.Rows[j].Cells[5].Value.ToString();
                sortPoint.valueFunction = Convert.ToDouble(result.Result[j]);
                sortPoint.Generation = 0;
                sortPoint.Number = j;
                PointsForSorting.Add(sortPoint);
            }           
        }

        private Borders GetBorder()
        {
            Borders border = new Borders(this);
            int var1 = Convert.ToInt32(X1Rest1.Text);
            int var2 = Convert.ToInt32(X1Rest2.Text);
            int var3 = Convert.ToInt32(X2Rest1.Text);
            int var4 = Convert.ToInt32(X2Rest2.Text);
            int var5 = Convert.ToInt32(Npoints.Text);
            int var6 = Convert.ToInt32(textBoxForP.Text);

            border.FullingBorder(var1, var2, var3, var4, var5, var6);
            return border;
        }
        private void redrawGrid()
        {
           
            dataForGenerations.Rows.Clear();
            for (int j = 0; j < PointsForSorting.Count; j++)
            {
                var person = PointsForSorting[j];
                dataForGenerations.Rows.Add();

                dataForGenerations.Rows[j].Cells[0].Value = person.Generation;
                if (person.BestPerson)
                {
                    dataForGenerations.Rows[j].Cells[1].Value = "*";
                }
                dataForGenerations.Rows[j].Cells[2].Value = person.Number;
                dataForGenerations.Rows[j].Cells[3].Value = person.X1;
                dataForGenerations.Rows[j].Cells[4].Value = person.X2;
                dataForGenerations.Rows[j].Cells[5].Value = person.X1X2Bin;
            }
            var border = GetBorder();
            var result = border.valueOfFunction();
            for (int j = 0; j < result.Result.Count; j++)
            {
                PointsForSorting[j].valueFunction = double.Parse(result.Result[j]);

                dataForGenerations.Rows[j].Cells[6].Value = result.Result[j];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (var point in points)
               pictureBox1.CreateGraphics().FillEllipse(new SolidBrush(Color.Green), ((float)point.X1)*15, ((float)point.X2)*15, 7, 7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method = "Метод сетки";

            setka = new Setka(this);
            Borders border = new Borders(this);
            int var1 = Convert.ToInt32(X1Rest1.Text);
            int var2 = Convert.ToInt32(X1Rest2.Text);
            int var3 = Convert.ToInt32(X2Rest1.Text);
            int var4 = Convert.ToInt32(X2Rest2.Text);
            int pointNumber = Convert.ToInt32(Npoints.Text);
            int populationsNumber = Convert.ToInt32(textBoxForP.Text);

            setka.dropperSharp(var1, var2, var3, var4);
            setka.drawPoints();

            border.FullingBorder(var1, var2, var3, var4, pointNumber, populationsNumber);

            for (int j = 0; j < pointNumber; j++)
            {
                ConverterFromIntToBin ind = new ConverterFromIntToBin();
                ind.numberIndividual = pointNumber;
                ind.numberOfGeneration = populationsNumber;

                Point pointS = new Point();
                dataForGenerations.Rows.Add();
                var x1 = ind.helloDvoichnoe(Convert.ToInt32(setka.points[j].X1), 0);
                var x2 = ind.helloDvoichnoe(Convert.ToInt32(setka.points[j].X2), 0);
                setka.points[j].X1X2Bin = x1 + x2;
                //setka.points[j].X1X2Bin = ind.helloDvoichnoe(Convert.ToInt32(setka.points[j].X1), Convert.ToInt32(setka.points[j].X2));
            
                dataForGenerations.Rows[j].Cells[0].Value = j;
                dataForGenerations.Rows[j].Cells[1].Value = ind.N;
                dataForGenerations.Rows[j].Cells[2].Value = j;
                dataForGenerations.Rows[j].Cells[3].Value = setka.points[j].X1;
                dataForGenerations.Rows[j].Cells[4].Value = setka.points[j].X2;
                dataForGenerations.Rows[j].Cells[5].Value = setka.points[j].X1X2Bin;
                
                pointS.X1 = Convert.ToDouble(ind.X1);
                pointS.X2 = Convert.ToDouble(ind.X2);
                pointsForSetka.Add(pointS);
            }

            var result = border.valueOfFunction();

            if (result.OK == false)
            {
                MessageBox.Show(result.Message);
                return;
            }

            for (int j = 0; j < Convert.ToInt32(Npoints.Text); j++)
            {
                SearchRankPoint sortPoint = new SearchRankPoint();
                dataForGenerations.Rows[j].Cells[6].Value = result.Result[j];
                sortPoint.X1 = dataForGenerations.Rows[j].Cells[3].Value.ToString();
                sortPoint.X2 = dataForGenerations.Rows[j].Cells[4].Value.ToString();
                sortPoint.X1X2Bin = dataForGenerations.Rows[j].Cells[5].Value.ToString();
                sortPoint.Number = j;
                sortPoint.valueFunction = Convert.ToDouble(result.Result[j]);
                PointsForSortingSetka.Add(sortPoint);
            }

            PointsForSorting = PointsForSortingSetka;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxForCrossing_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rank rankSearch = new Rank(this);

            var listForDrawS = rankSearch.Get2BestPersonFromLastGeneration(PointsForSortingSetka);
            pointForMutate = rankSearch.Get2BestPersonFromLastGeneration(PointsForSortingSetka).ToList();
            rankSearch.drawPoints(listForDrawS);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < numericUpDownIterationsCount.Value; x++)
            {
                Rank rank = new Rank(this);
                Mutant mut = new Mutant(this);
                Crossing crossing = new Crossing(this);
                ConverterFromIntToBin ind = new ConverterFromIntToBin();
                pointForMutate = rank.Get2BestPersonFromLastGeneration(PointsForSorting).ToList();

                foreach (var per in pointForMutate)
                {
                    per.BestPerson = true;
                }
                var newMutatedPoints = mut.Mutating(pointForMutate);
                var newMutatedAndCrossedPoints = crossing.Cross(newMutatedPoints);

                List<SearchRankPoint> newGeneration = new List<SearchRankPoint>();
                var twoLoosers = rank.Get2WorsePersonFromLastGeneration(PointsForSorting);

                foreach (var searchRankPoint in rank.GetLastGenerationWithout2Loosers(PointsForSorting))
                {
                    newGeneration.Add(new SearchRankPoint
                        {
                            X1 = searchRankPoint.X1,
                            X2 = searchRankPoint.X2,
                            Number = searchRankPoint.Number,
                            Generation = searchRankPoint.Generation + 1,
                            X1X2Bin = searchRankPoint.X1X2Bin,
                            valueFunction = searchRankPoint.valueFunction
                        });
                }
                var i = 0;
                foreach (var newMutatedAndCrossedPoint in newMutatedAndCrossedPoints)
                {
                    var X1X2 = ind.getIntNumbersFronBin(newMutatedAndCrossedPoint.X1X2Bin);
                    newGeneration.Add(new SearchRankPoint
                    {
                        X1 = X1X2[0],
                        X2 = X1X2[1],
                        Number = twoLoosers[i].Number,
                        Generation = newMutatedAndCrossedPoint.Generation + 1,
                        X1X2Bin = newMutatedAndCrossedPoint.X1X2Bin,
                        valueFunction = newMutatedAndCrossedPoint.valueFunction
                    });
                    i++;
                }
                PointsForSorting.AddRange(newGeneration);
                rank.drawPoints(newGeneration);
                redrawGrid();
            }
            var bestPerson = PointsForSorting.OrderByDescending(point => point.valueFunction).First();
            dataGridViewBestPerson.Rows.Add();
            dataGridViewBestPerson.Rows[0].Cells[0].Value = bestPerson.Generation;
            dataGridViewBestPerson.Rows[0].Cells[1].Value = chanceOfMutate.Value;
            dataGridViewBestPerson.Rows[0].Cells[2].Value = textBoxForCrossing.Text;
            dataGridViewBestPerson.Rows[0].Cells[3].Value = textBoxForFunction.Text;
            dataGridViewBestPerson.Rows[0].Cells[4].Value = Method;
            dataGridViewBestPerson.Rows[0].Cells[5].Value = bestPerson.valueFunction.ToString();
            pictureBox1.Refresh();
            pictureBox1.CreateGraphics().FillEllipse(new SolidBrush(Color.Red), (float.Parse(bestPerson.X1))*2, float.Parse(bestPerson.X2)*2, 7, 7);
        }
    }
}
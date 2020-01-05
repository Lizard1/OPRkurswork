using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWorkOPR
{
    internal class Rank
    {
        IEnumerable<SearchRankPoint> sortedPoints = new List<SearchRankPoint>();
       private Form1 _form;
        public Rank(Form1 form)
        {
            _form = form;
        }
        public List<SearchRankPoint> Get2BestPersonFromLastGeneration(List<SearchRankPoint> PointsForSorting)
        {
               sortedPoints = 
                   PointsForSorting
                   .OrderByDescending(u => u.Generation)
                   .ThenByDescending(u => u.valueFunction);
             
            var bestPoints = sortedPoints.Take(2);
            return bestPoints.ToList();
        }

        public List<SearchRankPoint> GetLastGeneration(List<SearchRankPoint> PointsForSorting)
        {
            var maxGenerationNumber = PointsForSorting.Max(point => point.Generation);

            sortedPoints =
                PointsForSorting
                .Where(u => u.Generation == maxGenerationNumber);

          return sortedPoints.ToList();
        }
        public List<SearchRankPoint> GetLastGenerationWithout2Loosers(List<SearchRankPoint> PointsForSorting)
        {
            return GetLastGeneration(PointsForSorting)
                .OrderBy(point => point.valueFunction)
                .Skip(2)
                .ToList();
        }
      

        public List<SearchRankPoint> Get2WorsePersonFromLastGeneration(List<SearchRankPoint> PointsForSorting)
        {
            sortedPoints =
                PointsForSorting
                .OrderByDescending(u => u.Generation)
                .ThenBy(u => u.valueFunction);

            var bestPoints = sortedPoints.Take(2);
            return bestPoints.ToList();
        }

        public void drawPoints(IEnumerable<SearchRankPoint>  bestPoints)
        {
            float xb1, xb2;
            foreach (var bestPoin in bestPoints)
            {
                xb1 = float.Parse(bestPoin.X1);
                xb2 = float.Parse(bestPoin.X2);
                _form.pictureBox1.CreateGraphics().FillEllipse(new SolidBrush(Color.Chartreuse),
                    xb1 * 15, xb2 * 15, 7, 7);
            }
        }


    }
}

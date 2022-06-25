using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChart.Figure
{
    public class NinyRectangle : BaseFigure, IFigure
    {
        public NinyRectangle(string name) : base (FigureType.Rectangle, name){}

        public void Paint(Graphics g)
        {
            var w = pointEnd.X - pointStart.X;
            var h = pointEnd.Y - pointStart.Y;
            var rec = new Rectangle(pointStart.X, pointStart.Y, w, h);

            try
            {
                if (pen != null)
                {
                    g.DrawRectangle(pen, rec);
                }
                if( brush != null)
                {
                    g.FillRectangle(brush, rec);
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

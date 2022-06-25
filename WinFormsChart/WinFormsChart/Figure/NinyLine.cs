using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChart.Figure
{
    public class NinyLine : BaseFigure, IFigure
    {
        public NinyLine(string name) : base(FigureType.Line, name) { }
        public void Paint(Graphics g)
        {
            if (pen == null) return;
            try
            {
                g.DrawLine(pen, pointStart, pointEnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

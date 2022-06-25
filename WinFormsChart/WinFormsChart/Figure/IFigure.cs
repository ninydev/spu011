using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChart.Figure
{
    public interface IFigure
    {
        // Обязывает программиста описать, как фигура выводится на экран
        void Paint(Graphics g);
    }
}

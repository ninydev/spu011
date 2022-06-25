using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsChart.Figure
{
    public abstract class BaseFigure
    {
        public BaseFigure (
            FigureType type, string name, 
            Point pointStart, Point pointEnd, 
            Pen pen = null, Brush brush = null)
        {
            Type = type;
            Name = name;
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
            this.pen = pen;
            this.brush = brush;
        }

        public BaseFigure(FigureType type, string name)
        {
            Type = type;
            Name = name;
        }


        // Тип примитива
        protected FigureType Type { get; }
        // Название примитива (в коллекции)
        private string Name { get; } = "New Figure";

        // Начальная точка
        public Point pointStart { get; set; } = Point.Empty;

        // Конечная точка
        public Point pointEnd { get; set; } =  Point.Empty;

        // Обводка (если NULL) - то нет обводки
        public Pen pen { get; set; }

        // Заливка (если NULL) - то нет заливки
        public Brush brush { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}

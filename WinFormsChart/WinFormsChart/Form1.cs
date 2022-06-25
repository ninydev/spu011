namespace WinFormsChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запускается каждый раз, когда необходимо перерисовать элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Получение доступа к графике

            var p = (sender as Panel);
            var startX =  p.Width / 4;
            var startY =  p.Height / 4;
            var endX = 3 *  p.Width / 4;
            var endY = 3 * p.Height / 4;

            List<Figure.IFigure> elements = new List<Figure.IFigure>();

            var myRec = new Figure.NinyRectangle("My First Rec");
            myRec.pen = new Pen(Color.Red, 2);
            myRec.brush = new SolidBrush(Color.Black);
            myRec.pointStart = new Point(startX, startY);
            myRec.pointEnd = new Point(endX, endY);

            var myLine = new Figure.NinyLine("My First Line");
            myLine.pen = new Pen(Color.Green, 2);
            myLine.brush = new SolidBrush(Color.Black);
            myLine.pointStart = new Point(startX, startY);
            myLine.pointEnd = new Point(endX, endY);

            elements.Add(myRec);
            elements.Add(myLine);

            foreach (var item in elements)
            {
                item.Paint(g);
            }

            //var p = (sender as Panel);

            //var startX = 25; // p.Width / 4;
            //var startY = 25; // p.Height / 4;
            //var width = 100; // p.Width / 2;
            //var height = 100; // p.Height / 2;

            //var rec = new Rectangle(startX, startY, width, height);

            // Pen blackPen = new Pen(Color.Red, 2);
            // SolidBrush solidBrush = new SolidBrush(Color.Black);

            //g.FillRectangle(solidBrush, rec);
            //g.DrawRectangle(blackPen, rec);

            //blackPen.Dispose();
            //solidBrush.Dispose();

            g.Dispose();


            // MessageBox.Show("Paint Work");
        }
    }
}
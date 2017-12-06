using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _05_horizontal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

            DrawLines(foxDraw, 0, 100);
            DrawLines(foxDraw, 100, 10);
            DrawLines(foxDraw, 50, 300);
        }
        public static void DrawLines(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            var startPoint = new Point(x, y);
            var endPoint = new Point(x + 50, y);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}

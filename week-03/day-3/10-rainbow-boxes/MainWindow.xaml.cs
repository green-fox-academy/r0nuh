using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _10_rainbow_boxes
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
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            DrawRectangle(foxDraw, 350);
            DrawRectangle(foxDraw, 300);
            DrawRectangle(foxDraw, 250);
            DrawRectangle(foxDraw, 200);
            DrawRectangle(foxDraw, 150);
            DrawRectangle(foxDraw, 100);
            DrawRectangle(foxDraw, 50);


        }
        static void DrawRectangle(FoxDraw foxDraw, int size)
        {
            //var colors = new <> { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };
            //foxDraw.FillColor(Colors.Red);
            foxDraw.DrawRectangle(263 - (size / 2), 175 - (size / 2), size, size);
           
        }
    }
}

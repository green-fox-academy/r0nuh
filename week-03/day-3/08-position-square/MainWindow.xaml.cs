using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _08_position_square
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
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function. 

            DrawRectangles(foxDraw, 300, 300);
            DrawRectangles(foxDraw, 30, 80);
            DrawRectangles(foxDraw, 150, 200);

        }
        static void DrawRectangles(FoxDraw foxDraw, int x, int y)
        {
            //foxDraw.BackgroundColor(Colors.LightGray);
            foxDraw.FillColor(Colors.Aquamarine);
            foxDraw.DrawRectangle(x, y, 50, 50);

            //foxDraw.FillColor(Colors.LemonChiffon);
            //foxDraw.DrawRectangle(x + 210, y + 85, 50, 50);

            //foxDraw.FillColor(Colors.Red);
            //foxDraw.DrawRectangle(x + 140, y + 180, 50, 50);
        }
    }
}

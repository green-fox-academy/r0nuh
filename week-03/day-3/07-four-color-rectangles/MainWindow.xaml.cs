using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _07_four_color_rectangles
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
            // draw four different size and color rectangles.

            DrawRectangles(foxDraw);
        }
        static void DrawRectangles(FoxDraw foxDraw)
        {
            foxDraw.FillColor(Colors.LightSalmon);
            foxDraw.DrawRectangle(211, 124, 100, 100);

            foxDraw.FillColor(Colors.Aquamarine);
            foxDraw.DrawRectangle(162, 75, 50, 50);

            foxDraw.FillColor(Colors.LemonChiffon);
            foxDraw.DrawRectangle(310, 85, 30, 40);

            foxDraw.FillColor(Colors.Red);
            foxDraw.DrawRectangle(140, 270, 230, 40);
        }
    }
}

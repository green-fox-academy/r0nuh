using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace _09_centered_boxes
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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

            DrawRectangle(foxDraw, 100);
            DrawRectangle(foxDraw, 50);
            DrawRectangle(foxDraw, 10);
        }
        static void DrawRectangle(FoxDraw foxDraw, int size)
        {
            foxDraw.DrawRectangle(263 - (size / 2), 175 - (size / 2), size, size);
        }
    }
}

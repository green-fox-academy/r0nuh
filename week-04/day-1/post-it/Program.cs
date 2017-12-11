using System;


namespace post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt();
            postIt1.BackgroundColor = "orange";
            postIt1.Text = "Idea 1";
            postIt1.TextColor = "blue";

            PostIt postIt2 = new PostIt();
            postIt2.BackgroundColor = "orange";
            postIt2.Text = "Awesome";
            postIt2.TextColor = "blue";

            PostIt postIt3 = new PostIt();
            postIt3.BackgroundColor = "orange";
            postIt3.Text = "Superb!";
            postIt3.TextColor = "blue";
        }
    }
}

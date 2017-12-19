using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var list = new Fleet();
            
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            list.Add(new Thing("Get milk"));
            list.Add(new Thing("Remove the obstacle"));
            list.Add(new Thing("Stand up"));
            list.Add(new Thing("Eat lunch"));

            list.Things[2].Complete();
            list.Things[3].Complete();

            Print(list);
            Console.Read();
        }

        static void Print(Fleet list)
        {
            int i = 0;
            foreach (var item in list.Things)
            {
                if (item.Completed == false)
                {
                    ++i;
                    Console.WriteLine("{0}. [ ] {1}", i, item.Name);
                }
                else
                {
                    ++i;
                    Console.WriteLine("{0}. [X] {1}", i, item.Name);
                }

            }


        }
    }
}

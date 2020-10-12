using System;

namespace slagsmålspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            string warrior1;
            int warrior1hp = generator.Next(100, 151);
            int warrior1dmg = generator.Next(15, 26);
            string warrior2;
            int warrior2hp = generator.Next(100, 151);
            int warrior2dmg = generator.Next(15, 26);
            int round = 1;


            Console.WriteLine("hello player choose a name for warrior 1:");
            warrior1 = Console.ReadLine();

            Console.WriteLine("very good now choose a name for warrior 2:");
            warrior2 = Console.ReadLine();

            Console.WriteLine(warrior1 + " Will be fighting " + warrior2);

            Console.WriteLine(warrior1 + " hp: " + warrior1hp);
            Console.WriteLine(warrior1 + " dmg: " + warrior1dmg);
            Console.WriteLine(warrior2 + " hp: " + warrior2hp);
            Console.WriteLine(warrior2 + " dmg: " + warrior2dmg);


            while (warrior1hp > 0 && warrior2hp > 0)
            {
                Console.WriteLine("round " + round);
                warrior1hp = warrior1hp - warrior2dmg;
                warrior2hp = warrior2hp - warrior1dmg;

                Console.WriteLine(warrior1 + " has " + warrior1hp + "hp left");

                Console.WriteLine(warrior2 + " has " + warrior2hp + "hp left");

                Console.WriteLine("press enter for next round");

                Console.ReadLine();
                round = round + 1;


            }

            if (warrior1hp < 0)
            {
                Console.WriteLine(warrior2 + " winns");

            }

            if (warrior2hp < 0)
            {
                Console.WriteLine(warrior1 + " winns");


            }
            if (warrior1hp < 0 && warrior2hp < 0)
            {

                Console.WriteLine("Draw");

            }



            Console.ReadLine();
        }
    }
}

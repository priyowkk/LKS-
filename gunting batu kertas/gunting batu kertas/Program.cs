using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playagain = true;
        string player;
        string computer;

        while (playagain)
        {
            player = "";
            computer = "";
            while (player != "BATU" && player != "KERTAS" && player != "GUNTING")
            {
                Console.Write("GUNTING,BATU,KERTAS :");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "BATU";
                    break;
                case 2:
                    computer = "KERTAS";
                    break;
                case 3:
                    computer = "GUNTING";
                    break;


            }
            Console.WriteLine("player: " + player);
            Console.WriteLine("computer: " + computer);

            switch (player)
            {
                case "BATU":
                    if (computer == "BATU")
                    {
                        Console.WriteLine("SERIII!!!");
                    }
                    else if (computer == "KERTAS")
                    {
                        Console.WriteLine("YAHH KALAHH");
                    }
                    else
                    {
                        Console.WriteLine("KAMU MENANGGG!!!");
                    }
                    break;

                case "KERTAS":
                    if (computer == "BATU")
                    {
                        Console.WriteLine("KAMU MENANGGG!!!");
                    }
                    else if (computer == "KERTAS")
                    {
                        Console.WriteLine("SERIII!!!");
                    }
                    else
                    {
                        Console.WriteLine("YAHH KALAHH");
                    }
                    break;
                case "GUNTING":
                    if (computer == "BATU")
                    {
                        Console.WriteLine("YAHH KALAHH");
                    }
                    else if (computer == "KERTAS")
                    {
                        Console.WriteLine("KAMU MENANGGG!!!");
                    }
                    else
                    {
                        Console.WriteLine("SERIII!!!");
                    }
                    break;
                    break;

            }
        }

        Console.ReadKey();
    }
}

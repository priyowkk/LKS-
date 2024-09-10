using System;

class Program
{
    static void Main()
    {
        
        Console.Write("who??"); 
        
        string name = Console.ReadLine();
        


        string capital = name.ToUpper();
       // Console.WriteLine(capital);


        singhappybirthday(capital);
        Console.ReadKey();
    } 
    static void singhappybirthday(string capital)
    {
        Console.WriteLine("HAPPY BIRTH DAY TO YOUUUUU!!!!!");
        Console.WriteLine("HAPPY BIRTH DAY TO YOUUUUU!!!!!");
        Console.WriteLine("HAPPY BIRTH DAY TO YOUUUUU!!!!!");
        Console.WriteLine("HAPPY BIRTH DAY DEAR YOUUUUU!!!!!" + capital);
        Console.WriteLine("HAPPY BIRTH DAY TO YOUUUUU!!!!!");
    }
}
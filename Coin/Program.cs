using System;
class Program
{
    static void Main()
    {
        int counter = 0;
        int win = 0;
        Console.WriteLine("Игра началась!");
        string input = Console.ReadLine();
        int player = int.Parse(input);
        if ((player == 0 || player == 1 )&& Coin.Coin.Flip(player))
        {
            counter++;
            win++;
        }

        else if (player == 0 || player == 1)
            counter++;
        while (player == 0 || player == 1)
        {
            Console.WriteLine("Введите число: ");
            input = Console.ReadLine();
            player = int.Parse(input);
            if ((player == 0 || player == 1) && Coin.Coin.Flip(player))
            {
                counter++;
                win++;
            }
            else if (player == 0 || player == 1)
                counter++;
        }
        float result = win*100 / counter;
        Console.WriteLine("Игра окончена со счётом " + win + ", угадано " + result + "% бросков");

    }
}
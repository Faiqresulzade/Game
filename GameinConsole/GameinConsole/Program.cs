using System;

namespace GameinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "Salam", "Faig", "resulzade", "Samir", "Manafov" };
           
            for (int i = 0; i < word.Length; i++)
            {
            Head:
                for (int j = 0; j < word[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(word[i][j]);
                    }
                    if (j == word[i].Length - 1)
                    {
                        Console.Write(word[i][j]);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                for (int j = 0; j < word[i].Length-2; j++)
                {
                     InputLetter:
                    string letter = Console.ReadLine();
                    if (letter == word[i][j+1].ToString())
                    {
                        Console.WriteLine("ela");
                        j++;
                        if (j== word[i].Length-2)
                        {
                            Console.WriteLine("Tebriklerrrr");
                            i++;
                            goto Head;
                        }
                        goto InputLetter;
                    }
                    if(letter != word[i][j + 1].ToString())
                    {
                        Console.WriteLine("Duzgun daxil edin!");
                        goto InputLetter;
                    }
                }
            }
        }
    }
}

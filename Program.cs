using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Sentence!");
            string Sentence = Console.ReadLine();
            string sen = Sentence.Trim();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Enter a Character you want to find in Sentence!");
            char FindCharacter = Console.ReadLine()[0];

            Console.WriteLine("-----------------------");
            Console.WriteLine("This is the character you want to find in a sentence");
            Console.WriteLine(FindCharacter);
            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i] == FindCharacter)
                {
                    Console.WriteLine("The char is at " + i);
                }
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("length of sentence without trim :" + Sentence.Length);
            Console.WriteLine("-----------------------");
            Console.WriteLine("lenght of sentence with trim : " + sen.Length);
            Console.WriteLine("-----------------------");
            Console.WriteLine("The Sentence you entered without trim is: " + Sentence + ".");
            Console.WriteLine("-----------------------");
            Console.WriteLine("The Sentence you entered with trim is:" + sen + ".");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Lower Case :" + sen.ToLower());
            Console.WriteLine("Upper Case :" + sen.ToUpper());
            string sen2 = "";
            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i] != FindCharacter)
                {
                    sen2 += sen[i];
                }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("With out character the sentence is:" + sen2);
            string sen3 = "";
            for (int i = 0; i < sen2.Length; i++)
            {
                if (sen2[i] == ' ')
                {
                    sen3 += "\n";
                }
                sen3 += sen2[i];
            }
            Console.WriteLine(sen3);

            // Part no 2 of the task

            String[] names = new String[5];
            // getting input names from user
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 5; i++)
            {
                int size = 0;
                Console.WriteLine("Enter a name:");
                names[i] = Console.ReadLine();
                size = names[i].Length;
                while (size > 10)
                {
                    Console.WriteLine("oops your name is greater than 10 please enter again?");
                    names[i] = Console.ReadLine();
                    size = names[i].Length;
                }
            }
            // putting * in names
            for (int i = 0; i < 5; i++)
            {
                int times = names[i].Length;
                for (int j = times; j < 10; j++)
                {
                    names[i] += "*";
                }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("The names with printing stars are:");
            // printing names
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

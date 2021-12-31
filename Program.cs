using System;

namespace ItaniRalephataInterview
{
    public class Program
    {
        //static int maxCHARS = 256;
        //static void calculate(String s, int[] cal)
        //{

        //    for (int i = 0; i < s.Length; i++)
        //        cal[s[i]]++;
        //}
        public static void Main(string[] args)
        {
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Duplicate Check");
            Console.WriteLine("2) Count the number of vowels");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DuplicatedText();
                    return true;
                case "2":
                    NumberOfVowels();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the text to be anaylsed: ");
            return Console.ReadLine();
        }

        private static void DuplicatedText()
        {
            Console.Clear();
            Console.WriteLine("Duplicated Text");
            string s = CaptureInput();
            for (int i = 0; i < s.Length - 1; i++)
            {

                int count = 1;
                while (s[i] == s[i + 1])
                {
                    i++;
                    count++;
                    if (i + 1 == s.Length)
                        break;
                }
                Console.Write(s[i] + "" + count);
            }

        }

        private static void NumberOfVowels()
        {
            Console.Clear();
            Console.WriteLine("Number of Vowels");
            string str = CaptureInput();

            int i, len, vowel;
            vowel = 0;
            
            len = str.Length;
          
            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
 
            }
            Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
           
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
    }


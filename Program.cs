using System;
using System.Collections.Generic;

namespace TrashLang
{
    class MainClass
    {
        public static List<char> commands = new List<char>()
        {
            '?', //start loop
            '>', //end loop
            '+', //loop++
            '-', //loop--
            '%', //write
            '*' //print new line
        };

        public static bool DevMode = false;

        public static void Main(string[] args)
        {
            //access command line arguments to check for dev mode or basic mode
            foreach (string arg in args)
            {
                if (arg == "dev")
                {
                    try
                    {
                        DevMode = true;
                        System.Console.WriteLine("Entered Dev Mode");
                    }
                    catch
                    {
                        DevMode = true;
                        System.Console.WriteLine("Some kind of error has happened in entering dev mode");
                    }
                }
            }
            while (true)
            {
                System.Console.Write("TrashLang > ");
                string input = System.Console.ReadLine();
                if (DevMode) { System.Console.WriteLine(input); }
                GetTokens(input);
            }
        }

        public static void GetTokens(string input)
        {
            for (int charIndex = 0; charIndex < input.Length; charIndex++)
            {
                char CurrentChar = input[charIndex];
                switch (CurrentChar)
                {
                    case '%': //if this character is detected start the "write" function
                        MakeWrite(input, charIndex);
                        break;
                    case '?':
                        break;
                    case '+':
                        break;
                    case '-':
                        break;
                    case '>':
                        break;
                    case '*':
                        System.Console.Write("\n");
                        break;
                }
            }
            System.Console.Write("\n");
        }

        public static void MakeWrite(string input, int CharIndex)
        {
            if (input[CharIndex + 1] == '?')
            {
                if (DevMode)
                {
                    System.Console.WriteLine("Detected loop start");
                }

                int LoopOps = 0;
                char PlusOrMinus = '+';

                for (int x = CharIndex; x < input.Length; x++)
                {
                    if (input[x] == PlusOrMinus)
                    {
                        LoopOps += 1;
                        if (DevMode)
                        {
                            System.Console.WriteLine("+=1 LoopOps");
                        }
                    }
                    else if (input[x] == '>') //end the loop
                    {
                        if (DevMode)
                        {
                            System.Console.WriteLine("Ending loop");
                        }
                        break;
                    }
                }

                char CharToPrint = ' ';

                switch (LoopOps) //to make this extra annoying perhaps change around the characters to make say 2 plus an h and 3 plus a z?
                {
                    case 1:
                        CharToPrint = 'a';
                        break;
                    case 2:
                        CharToPrint = 'b';
                        break;
                    case 3:
                        CharToPrint = 'c';
                        break;
                    case 4:
                        CharToPrint = 'd';
                        break;
                    case 5:
                        CharToPrint = 'e';
                        break;
                    case 6:
                        CharToPrint = 'f';
                        break;
                    case 7:
                        CharToPrint = 'g';
                        break;
                    case 8:
                        CharToPrint = 'h';
                        break;
                    case 9:
                        CharToPrint = 'i';
                        break;
                    case 10:
                        CharToPrint = 'j';
                        break;
                    case 11:
                        CharToPrint = 'k';
                        break;
                    case 12:
                        CharToPrint = 'l';
                        break;
                    case 13:
                        CharToPrint = 'm';
                        break;
                    case 14:
                        CharToPrint = 'n';
                        break;
                    case 15:
                        CharToPrint = 'o';
                        break;
                    case 16:
                        CharToPrint = 'p';
                        break;
                    case 17:
                        CharToPrint = 'q';
                        break;
                    case 18:
                        CharToPrint = 'r';
                        break;
                    case 19:
                        CharToPrint = 's';
                        break;
                    case 20:
                        CharToPrint = 't';
                        break;
                    case 21:
                        CharToPrint = 'u';
                        break;
                    case 22:
                        CharToPrint = 'v';
                        break;
                    case 23:
                        CharToPrint = 'w';
                        break;
                    case 24:
                        CharToPrint = 'x';
                        break;
                    case 25:
                        CharToPrint = 'y';
                        break;
                    case 26:
                        CharToPrint = 'z';
                        break;
                    case 27:
                        CharToPrint = '+';
                        break;
                    case 28:
                        CharToPrint = '-';
                        break;
                    case 29:
                        CharToPrint = '@';
                        break;
                    case 30:
                        CharToPrint = '!';
                        break;
                    case 31:
                        CharToPrint = '#';
                        break;
                    case 32:
                        CharToPrint = '$';
                        break;
                    case 33:
                        CharToPrint = '&';
                        break;
                    case 34:
                        CharToPrint = ' ';
                        break;
                }

                System.Console.Write(Convert.ToString(CharToPrint));
            }
            else
            {
                Console.WriteLine("Error in code");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace TrashLang
{
    class MainClass
    {
        public static List<char> commands = new List<char>() //code doesnt even use this list at all but whatever i dont care
        {
            '?', //start loop
            '>', //end loop
            ',', //loop++
            '+', //print numbers
            '%', //write
            '*', //print new line
            '[', //input char one
            '&', //input char two
            '^', //input char three
            '#', //input char four
            ']', //input char five
            '|', //print recent console input char one([|\/])
            '\\', //print recent console input char two
            '/', //print recent console input char three
            '=', //print input as print command char one
            '.', //print input as print command char two
            ':', //print input as print command char three
            '&', //character to add numbers
            '$', //character to subtract numbers
            '}' //comment key, no idea why there should be a comment key but whatever
        };

        public static bool DevMode = false;

        public static string Cin;

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
                    case '*':
                        System.Console.Write("\n");
                        break;
                    case '[':
                        CheckBracketCommand(input, charIndex);
                        break;
                    case '&':
                        NumbersOps(input, charIndex, 0);
                        charIndex = input.Length + 1; //skip the rest of the line
                        break;
                    case '$':
                        NumbersOps(input, charIndex, 1);
                        charIndex = input.Length + 1; //skip the rest of the line
                        break;
                    case '/':
                        NumbersOps(input, charIndex, 3);
                        charIndex = input.Length + 1; //skip the rest of the line
                        break;
                    case '`':
                        NumbersOps(input, charIndex, 2);
                        charIndex = input.Length + 1; //skip the rest of the line
                        break;
                    case '}':
                        charIndex = input.Length + 1; //skip the rest of the line
                        break;
                }
            }
            System.Console.Write("\n");
        }

        public static void NumbersOps(string input, int CharIndex, int op)
        {
            if(input[CharIndex+1] == '[')
            {
                int NumOne = 0;
                int NumTwo = 0;
                int LoopOps = 0;
                int StopPoint = 0;

                for (int i=2; i<input.Length; i++)
                {
                    if(input[i] == '+')
                    {
                        LoopOps += 1;
                    }
                    if (input[i] == ']')
                    {
                        StopPoint = i;
                        break;
                    }
                }
                NumOne = LoopOps;
                LoopOps = 0;
                for (int i = StopPoint+1; i < input.Length; i++)
                {
                    if (input[i] == '+')
                    {
                        LoopOps += 1;
                    }
                    if (input[i] == ']')
                    {
                        break;
                    }
                }
                NumTwo = LoopOps;
                switch (op)
                {
                    case 0:
                        System.Console.Write(NumOne + NumTwo);
                        break;
                    case 1:
                        System.Console.Write(NumOne - NumTwo);
                        break;
                    case 2:
                        System.Console.Write(NumOne * NumTwo);
                        break;
                    case 3:
                        System.Console.Write(NumOne / NumTwo);
                        break;
                    default:
                        System.Console.Write("Error on the backend, this is not your fault!");
                        break;
                }
            }
        }

        public static void CheckBracketCommand(string input, int CharIndex)
        {
            switch (input[CharIndex + 1])
            {
                case '&':
                    GetInput(input, CharIndex);
                    break;
                case '|':
                    PrintMostRecentCin(input, CharIndex);
                    break;
                case '+':
                    PrintNumber(input, CharIndex);
                    break;
                case '=':
                    PrintInputAsPrintCommand(input, CharIndex);
                    break;
                default:
                    System.Console.WriteLine("Error in code");
                    break;
            }
        }

        public static void PrintInputAsPrintCommand(string input, int CharIndex)
        {
            if(input[CharIndex + 2] == '.')
            {
                if(input[CharIndex + 3] == ':')
                {
                    if (input[CharIndex + 4] == ']')
                    {
                        string Cin = System.Console.ReadLine();
                        for(int i=0;i<Cin.Length; i++)
                        {
                            string StringToPrint = "";
                            string NumToPrint = "";
                            switch (Cin[i])
                            {
                                case 'a':
                                    StringToPrint = PrintCommas(1);
                                    break;
                                case 'b':
                                    StringToPrint = PrintCommas(2);
                                    break;
                                case 'c':
                                    StringToPrint = PrintCommas(3);
                                    break;
                                case 'd':
                                    StringToPrint = PrintCommas(4);
                                    break;
                                case 'e':
                                    StringToPrint = PrintCommas(5);
                                    break;
                                case 'f':
                                    StringToPrint = PrintCommas(6);
                                    break;
                                case 'g':
                                    StringToPrint = PrintCommas(7);
                                    break;
                                case 'h':
                                    StringToPrint = PrintCommas(8);
                                    break;
                                case 'i':
                                    StringToPrint = PrintCommas(9);
                                    break;
                                case 'j':
                                    StringToPrint = PrintCommas(10);
                                    break;
                                case 'k':
                                    StringToPrint = PrintCommas(11);
                                    break;
                                case 'l':
                                    StringToPrint = PrintCommas(12);
                                    break;
                                case 'm':
                                    StringToPrint = PrintCommas(13);
                                    break;
                                case 'n':
                                    StringToPrint = PrintCommas(14);
                                    break;
                                case 'o':
                                    StringToPrint = PrintCommas(15);
                                    break;
                                case 'p':
                                    StringToPrint = PrintCommas(16);
                                    break;
                                case 'q':
                                    StringToPrint = PrintCommas(17);
                                    break;
                                case 'r':
                                    StringToPrint = PrintCommas(18);
                                    break;
                                case 's':
                                    StringToPrint = PrintCommas(19);
                                    break;
                                case 't':
                                    StringToPrint = PrintCommas(20);
                                    break;
                                case 'u':
                                    StringToPrint = PrintCommas(21);
                                    break;
                                case 'v':
                                    StringToPrint = PrintCommas(22);
                                    break;
                                case 'w':
                                    StringToPrint = PrintCommas(23);
                                    break;
                                case 'x':
                                    StringToPrint = PrintCommas(24);
                                    break;
                                case 'y':
                                    StringToPrint = PrintCommas(25);
                                    break;
                                case 'z':
                                    StringToPrint = PrintCommas(26);
                                    break;
                                case ' ':
                                    StringToPrint = PrintCommas(34);
                                    break;
                                case '0':
                                    NumToPrint = WriteNumber(0);
                                    break;
                                case '1':
                                    NumToPrint = WriteNumber(1);
                                    break;
                                case '2':
                                    NumToPrint = WriteNumber(2);
                                    break;
                                case '3':
                                    NumToPrint = WriteNumber(3);
                                    break;
                                case '4':
                                    NumToPrint = WriteNumber(4);
                                    break;
                                case '5':
                                    NumToPrint = WriteNumber(5);
                                    break;
                                case '6':
                                    NumToPrint = WriteNumber(6);
                                    break;
                                case '7':
                                    NumToPrint = WriteNumber(7);
                                    break;
                                case '8':
                                    NumToPrint = WriteNumber(8);
                                    break;
                                case '9':
                                    NumToPrint = WriteNumber(9);
                                    break;
                            }
                            if(StringToPrint != "")
                            {
                                Console.Write("%?" + StringToPrint + ">");
                            }
                            else
                            {
                                Console.Write(NumToPrint);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error in code");
            }
        }

        public static void PrintNumber(string input, int CharIndex)
        {
            char Plus = '+';
            int PlusOps = 0;

            for(int x = CharIndex; x < input.Length; x++)
            {
                if(input[x] == Plus)
                {
                    PlusOps += 1;
                }
                else if(input[x] == ']')
                {
                    if (DevMode) { System.Console.WriteLine("Detected right bracket"); }
                    break;
                }
            }
            System.Console.Write(PlusOps);
        }

        public static void PrintMostRecentCin(string input, int CharIndex)
        {
            if(input[CharIndex + 2] == '\\')
            {
                if(input[CharIndex + 3] == '/')
                {
                    if(input[CharIndex + 4] == ']')
                    {
                        System.Console.WriteLine();
                        if (DevMode) { System.Console.WriteLine("Detected print recent input"); }
                        if(Cin != null)
                        {
                            System.Console.WriteLine(Cin);
                        }
                    }
                }
            }
        }

        public static void GetInput(string input, int CharIndex)
        {
            if (input[CharIndex + 2] == '^')
            {
                if (input[CharIndex + 3] == '#')
                {
                    if (input[CharIndex + 4] == ']')
                    {
                        System.Console.WriteLine();
                        if (DevMode) { System.Console.WriteLine("Detected input statement"); }
                        Cin = System.Console.ReadLine();
                    }
                }
            }

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
                char Comma = ',';

                for (int x = CharIndex; x < input.Length; x++)
                {
                    if (input[x] == Comma)
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

                string CharString = " abcdefghijklmnopqrstuvwxyz+-@!#$& ,. ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if(LoopOps != 37)
                {
                    System.Console.Write(CharString[LoopOps]);
                }
                else if(LoopOps == 37)
                {
                    System.Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Error in code");
            }
        }

        static string PrintCommas(int amount)
        {
            string ReturnValue = "";
            for(int i=0; i<amount; i++)
            {
                ReturnValue += ",";
            }
            return ReturnValue;
        }

        static string WriteNumber(int number)
        {
            string ReturnValue = "[";
            for(int i=0; i< number; i++)
            {
                ReturnValue += "+";
            }
            ReturnValue += "]";
            return ReturnValue;
        }
    }
}

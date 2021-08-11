using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestZevit
{
    class Program
    {
        public static bool isAlphaNumeric(string input)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(input.ToString());
        }
        static void Main(string[] args)
        {

            // FirstTask();
            // SecondTask()
            // Task3();
            // Task4(); // Replace String value
            // Task5(); // Split link
            // Task6(); // to uper word / words not done finally
            // Task7(); // Secret word to ******
            // Task8(); // To upperCase each inputed char
            // Task9(); // +1 to each element



        }

        static void FirstTask()
        {
            // First input
            double firstNum;
            Console.WriteLine(" Please input X: ");
            string firstInput = Console.ReadLine();
            bool canParseFirst = Double.TryParse(firstInput, out firstNum);

            // Second input
            double secondNum;
            Console.WriteLine(" Please input Y: ");
            string secondInput = Console.ReadLine();
            bool canParseSecond = Double.TryParse(secondInput, out secondNum);

            // Operator
            Console.WriteLine("Please choose operation: +, -, *, / ");
            var op = Console.ReadLine();
            if (canParseFirst && canParseSecond)
            {
                switch (op)
                {
                    case "+":
                        var sum = firstNum + secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
                        Console.ResetColor();
                        break;
                    case "-":
                        var result1 = firstNum - secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{firstNum} - {secondNum} = {result1}");
                        Console.ResetColor();
                        break;
                    case "*":
                        var result2 = firstNum * secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{firstNum} * {secondNum} = {result2}");
                        Console.ResetColor();
                        break;
                    case "/":
                        var divid = firstNum / secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{firstNum} * {secondNum} = {divid}");
                        Console.ResetColor();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Undifinded operator!!!");
                        return;
                }
            }
        }
        static void SecondTask()
        {
            Console.WriteLine(" Please input Decimal number");
            int myNum;
            string inputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(inputNumber, out myNum);
            int value;
            string a = string.Empty;
            if (isNumber)
            {

                while (myNum >= 1)
                {
                    value = myNum / 2;
                    a += (myNum % 2).ToString();
                    Console.WriteLine($" {myNum} / 2 = {myNum % 2} Reminer");
                    myNum = value;
                }
                string binValue = string.Empty;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    binValue = binValue + a[i];

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Decimal: {0}", inputNumber);
                Console.WriteLine(" Binary: {0}", binValue);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Undifinded input !!!");
                Console.ResetColor();
                return;
            }
            Console.ReadLine();
        }
        public static void Task3()
        {
            Console.WriteLine(" Please input Binary number: ");
            int myNum;
            string inputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(inputNumber, out myNum);
            if (isNumber)
            {
                int binVal, decVal = 0, baseVal = 1, remine;
                binVal = myNum;
                while (myNum > 0)
                {
                    remine = myNum % 10;
                    decVal = decVal + remine * baseVal;
                    myNum = myNum / 10;
                    baseVal = baseVal * 2;
                    string scope = decVal.ToString();
                    Console.Write($"({inputNumber})2 = ({scope}) = {baseVal} ");
                }
                Console.Write("Binary Number: " + binVal);
                Console.Write("\n Decimal: " + decVal);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Undifinded input");
                Console.ResetColor();
                return;
            }
            Console.ReadLine();
        }
        public static void Task4()
        {
            Console.WriteLine(" Please input some string:");
            var input = Console.ReadLine();
            var result = string.Empty;
            var replacedValue = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                replacedValue = result + input[i];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(replacedValue);
                Console.ResetColor();
            }

            Console.ReadLine();
        }
        public static void Task5()
        {
            Console.WriteLine(" Please input your URL:");
            var input = Console.ReadLine();

            var proto = input.Substring(0, input.IndexOf(":"));
            string server = input.Substring(input.IndexOf(":") + 3, input.Length - (input.LastIndexOf("/") - input.IndexOf("/")));
            string resource = input.Substring(input.LastIndexOf("/") + 1, input.Length - 1 - input.LastIndexOf("/"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Protocol: {0}", proto);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Server: {0}", server);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Resources: {0}", resource);
            Console.ResetColor();

            Console.ReadLine();
        }

        public static void Task6()
        {
            Console.WriteLine(" Please write your text here:");
            var input = Console.ReadLine();

            var output = string.Empty;
            var uperWords = string.Empty;

            var upText = input.Substring(input.IndexOf(">") + 1, input.IndexOf("/") - 2 - input.IndexOf(">"));

            if (input.Contains(upText))
            {
                output = input.Replace(upText, upText.ToUpper());
                string result1 = output.Replace("<upcase>", string.Empty);
                string result = result1.Replace("</upcase>", string.Empty);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        public static void Task7()
        {
            Console.WriteLine(" Please write here your uncoded text:");
            var input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" Please write here your secret keywords: ");
            var secWord = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Don't forget your inputed words!");
            Console.ResetColor();

            var output = string.Empty;

            if (input.Contains(secWord))
            {
                var str = new string('*', secWord.Length);
                output = input.Replace(secWord, str);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(" Word not found !");
                return;
            }

            Console.ReadLine();
        }
        public static void Task8()
        {
            Console.WriteLine(" Hello, please input char which you want to make UpperCase: \n");
            while (true)
            {
                Console.WriteLine(" Next Char: \n");
                var input = Console.ReadLine();
                while (true)
                {
                    if (isAlphaNumeric(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" Upper char is: {input.ToUpper()}");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.Beep(5000, 1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a string");
                        Console.ResetColor();
                        break;
                    }
                }
            }
        }

        public static void Task9()
        {

            Console.WriteLine(" Please input array's length ");
            var lgth = Convert.ToInt32(Console.ReadLine());
            var arr = new int[lgth];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($" Please input array's {i + 1} member: \n");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("New array = ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i]);
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}

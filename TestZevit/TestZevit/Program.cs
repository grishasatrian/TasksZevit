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
            // ArrayTask2(); // Sum of array
            // Arraytask3(); // Duplicate
            // ArrayTask4(); // is Equal arrays or not?
            // ArrayTask5(); // rectangle  
            // SwapTask(); //Swap
            // PrintTringle(); // printing tringle
            // Factorial(); // n!, n^m, sqrt(n)

            Console.WriteLine("Please input number to count fac:");
            var fctr = Console.ReadLine();
            

            //for (int i = 0; i < fac; i++)
            //{

            //}





        }
        public static void FirstTask()
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
        public static void SecondTask()
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


        public static void ArrayTask2()
        {
            Console.WriteLine(" Please input array's length");
            var lgth = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[lgth];
            Console.WriteLine(" Please input array's members:");
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine($" The sum of array's members is: {sum}");

            Console.ReadLine();
        }


        public static void Arraytask3()
        {
            int i, j, num, count = 0;

            Console.WriteLine(" Please input array's length: ");
            num = Convert.ToInt32(Console.ReadLine());
            var arr = new int[num];

            Console.WriteLine(" Please input elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements in array is:" + count);
            Console.ReadLine();
        }
        public static void ArrayTask4()
        {
            Console.WriteLine(" Please input array's length");
            var arr1 = Convert.ToInt32(Console.ReadLine());
            int[] firstArr = new int[arr1];
            Console.WriteLine(" Please input array's members:");

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" Please input second arrays length");
            var arr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please input array's members:");
            int[] secondArr = new int[arr2];
            for (int j = 0; j < secondArr.Length; j++)
            {
                secondArr[j] = Convert.ToInt32(Console.ReadLine());
            }
            if (arr1 != arr2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Arrays are not Equal !");
                Console.ResetColor();
            }
            if (firstArr.Length == secondArr.Length)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[i])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n not equal!!!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n not equal 'Length'");
            }

            Console.ReadLine();

        }
        public static void ArrayTask5()
        {
            Console.Write("Height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Char: ");
            var symbol = Convert.ToChar(Console.ReadLine());
            var rectangle = new char[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    rectangle[i, j] = symbol;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(rectangle[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void SwapTask()
        {
            Console.WriteLine("Please input first number:");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            var b = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"Before -  a:{a}, b = {b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write($"After - a:{a}, b = {b}");
            Console.ReadLine();
        }
        public static void PrintTringle()
        {
            Console.WriteLine("Please insert tringle's hight:");
            var hight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Char: ");
            var symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i <= hight; i++)
            {
                var tringle = new string(symbol, i);
                var result = tringle.PadLeft(hight, '-');
                var result2 = tringle.PadRight(hight, '-');
                Console.WriteLine(result + "*" + result2);
            }

            Console.ReadLine();
        }
    }
}

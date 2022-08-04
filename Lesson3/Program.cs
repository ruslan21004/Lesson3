//if (20 > 18)
//{
//    Console.WriteLine("20 is greater than 18");
//}

//int x = 20;
//int y = 18;
//if (x > y)
//{
//    Console.WriteLine("x is greater than y");
//}


//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}



//int time = 22;
//if (time < 10)
//{
//    Console.WriteLine("Good morning.");
//}
//else if (time < 20)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}



//int day = 8;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Wrond input");
//            break;
//}


//int day = 4;
//switch (day)
//{
//    case 6:
//        Console.WriteLine("Today is Saturday.");
//        break;
//    case 7:
//        Console.WriteLine("Today is Sunday.");
//        break;
//    default:
//        Console.WriteLine("Looking forward to the Weekend.");
//        break;
//}

//int b = a == 1 ? 10 : 15;

//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}

//int a = 20;
//int b = 18;

//string c = a < b ? "Good day." : "Good evening.";

//Console.WriteLine(c);


//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}


//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 5);

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

//for (var i = 0; i < 10; i++)
//{
//    if (i > 5) break;
//    Console.Write(i);
//}

//for (var i = 0; i < 10; i++)
//{
//    if (i == 5) continue;
//    Console.Write(i);
//}

//while (false)
//{
//    Console.WriteLine("Hello, World");
//}

//for (var i = 10; i < 15; ++i)
//{
//    Console.Write('a');
//}

//i = i + 1
//i++

//i + 1 = i
//++i

//string s = "Hello World!";
//if (s =="Hello World!");
//{
//    Console.WriteLine("Hi!");
//};

//switch (s)

//{
//    case "Hey":
//    Console.WriteLine(s);
//    break;
//    default:
//        Console.WriteLine("Hi!");
//    break;
//}


//int sum = 0;
//for (int i = 2; i < 10; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);


//int sum = 0;
//int i = 1;
//while (i<9)
//{
//    i++;
//    sum += i;
//}
//Console.WriteLine(sum);

//int sum = 0;
//int i = 1;
//do
//{
//    i++;
//    sum += i;
//} while (i<9);
//Console.WriteLine(sum);


using System;

public class Lesson3
{
    public static void Main()
    {
        Console.WriteLine("Введите первое значение");
        int X;
        if (!Int32.TryParse(Console.ReadLine(), out X))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

        Console.WriteLine("Введите второе значение");
        int Y;
        if (!Int32.TryParse(Console.ReadLine(), out Y))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

    }
}


int X = 8;
int Y = 13;
int Sum = 8 + 9 + 10 + 11 + 12 + 13;
if (X == Y)
{
    Console.WriteLine(Y);
}
else
{
    Console.WriteLine($"Сумма равна  {Sum}");

}





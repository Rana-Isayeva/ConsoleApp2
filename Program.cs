using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter number : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());


            //Task-1~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //if (num1 != 0)
            //{
            //    if (num1 % 2 == 1)
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The zero is neither odd nor even.");
            //}


            //Task-2~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //if (num1 % 2 == 0 && num1 % 5 == 0)
            //{
            //    Console.WriteLine("Number is divided both 2 and 5.");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not divided both 2 and 5.");
            //}

            //Task-3~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Enter second number : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter third number : ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num3 && num2 > num3)
            //{
            //    Console.WriteLine("First two numbers are greater than third number.");
            //}
            //else
            //{
            //    Console.WriteLine("First two numbers are not greater than third number.");
            //}


            //Task-4~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Enter your age : ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //while (true)
            //{
            //    if (age < 17 || age > 70)
            //    {
            //        Console.WriteLine("Invalid input! The student age cannot less than 17 and greater than 70.");
            //        Console.WriteLine("Enter your age again : ");
            //        age = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student age is correct!");
            //        break;
            //    }
            //}

            //if (age == 17)
            //{
            //    Console.WriteLine("The student is called up for military service.");
            //}



            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Lesson_2//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Task-1~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("_____________The sum of odd numbers from 1 to 100_____________");
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);


            //Task-2~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("\n\nThe years from 1945 to present year");
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //for (int i = 1945; i <= 2024; i++)
            //{
            //    if(i < 1990 || i > 1992)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task-3~~~~~~~~~~~~~~~~~~~~~~~~
            //int[] nums = { 3, 1, 7, 0, 1, 2, 3, 4, 5, 6, 7, 2, 1, 9, 8};
            //int[] odd = new int[1];
            //int[] even = new int[1];
            //int j = 0;
            //int k = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Array.Resize(ref even, even.Length + 1);
            //        even[j] += nums[i];
            //        j++;
            //    }
            //    else
            //    {
            //        Array.Resize(ref odd, odd.Length+1);
            //        odd[k] += nums[i];
            //        k++;
            //    }

            //}

            //Console.WriteLine("\n\nThe odd and even arrays");
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("The even numbers array length" + even.Length);
            //Console.WriteLine("The odd numbers array length" + odd.Length);

            //Console.WriteLine("\nEven numbers:");
            //for (int i = 0; i < even.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ".  " + even[i]);
            //}

            //Console.WriteLine("\nOdd numbers:");
            //for (int i = 0; i < odd.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ".  " + odd[i]);
            //}

            //Task-4~~~~~~~~~~~~~~~~~~~~~~~~
            //string correctUsername = "admin";
            //int correctPassword = 123;

            //while(true)
            //{
            //    Console.WriteLine("Enter username: ");
            //    string username = Console.ReadLine();

            //    Console.WriteLine("\nEnter password: ");
            //    int password = Convert.ToInt32(Console.ReadLine());

            //    if (username.Equals(correctUsername) && password.Equals(correctPassword))
            //    {
            //        Console.WriteLine("\nLogin succesfull!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInvalid input! Password cannot be less than 8.");
            //    }
            //}
            //Console.WriteLine();

            //Task-5~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Changing max number and min number in array.");
            //Console.WriteLine();
            //int[] numbers = { 34, 23, 9, 10, 89, 45, 9, 78, 90, 22, 78, 69, 92, 29 };

            //int maxIndex = 0;
            //int minIndex = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < numbers[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //    if (numbers[i] > numbers[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //}

            //int temp = numbers[minIndex];
            //numbers[minIndex] = numbers[maxIndex];
            //numbers[maxIndex] = temp;

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number + " ");
            //}
            //Console.WriteLine();

            //Task-6~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Converting negative numbers to the positive numbers");
            //Console.WriteLine();
            //int[] datas = { 27, -23, 59, 39, -69, 90, -55 };

            //for (int i = 0; i < datas.Length; i++)
            //{
            //    if (datas[i] < 0)
            //    {
            //        datas[i] = datas[i] * (-1);
            //    }
            //}

            //foreach (int data in datas)
            //{
            //    Console.WriteLine(data + " ");
            //}

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Lesson_2//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            //Task-1~~~~~~~~~~~~~~~~~~~~~~~~
            double squareArea = Area(5);
            double rectangleArea = Area(5, 10);
            double circleArea = Area(7, true);

            Console.WriteLine("Area of square: " + squareArea);
            Console.WriteLine("Area of rectangle: " + rectangleArea);
            Console.WriteLine("Area of circle: " + circleArea);

            //Task-2~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Please enter width of parallelepiped: ");
            //double width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter length of parallelepiped: ");
            //double length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter height of parallelepiped: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double rectangulerParallelepipedArea = parallelepipedArea(length, width, height);
            //Console.WriteLine("Area of rectangular parallelepiped: " + rectangulerParallelepipedArea);

            //Task-3~~~~~~~~~~~~~~~~~~~~~~~~
            //Console.WriteLine("Please enter first side of triangle: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter second side of triangle: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter third side of triangle: ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please enter radius of circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //double triangleCircleArea = triangleArea(a, b, c, radius);
            //Console.WriteLine("The area of ​​a circle inscribed in a triangle: " + triangleCircleArea);

            //Task-4~~~~~~~~~~~~~~~~~~~~~~~~
            //string sentence = "This is a sample sentence.";

            //Console.WriteLine("Enter a letter to search for: ");
            //char letter = Console.ReadLine()[0]; 

            //bool result = hasLetter(letter, sentence);

            //if (result)
            //{
            //    Console.WriteLine($"The letter '{letter}' is present in the sentence.");
            //}
            //else
            //{
            //    Console.WriteLine($"The letter '{letter}' is not present in the sentence.");
            //}

        }

        static double Area(double side)
        {
            return side * side;
        }

        static double Area(double length, double width)
        {
            return length * width;
        }

        static double Area(double radius, bool isCircle)
        {
            if (isCircle)
            {
                return Math.PI * radius * radius;
            }
            else
            {
                return 0;
            }
        }

        static double parallelepipedArea(double length, double width, double height)
        {
            return 2 * (length * width + length * height + width * height);
        }

        static double triangleArea(double a, double b, double c, double radius)
        {
            return 0.5 * radius * (a + b + c);
        }

        static bool hasLetter(char letter, String sentence)
        {
            return sentence.IndexOf(letter) != -1;
        }
    }
}


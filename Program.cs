
#region the frist question
//try
//{
//    Console.WriteLine("Enter the first number:");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter the second number:");
//    int num2 = int.Parse(Console.ReadLine());

//    int result = num1 / num2;
//    Console.WriteLine($"Result: {result}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Error: Cannot divide by zero.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: Invalid input. Please enter integers only.");
//}
//finally
//{
//    Console.WriteLine("Operation complete.");
//}


//// Question: What is the purpose of the finally block?

////بص يا باشا، الكود اللي جوه  بيتنفذ دايمًا مهما حصل في الكود اللي قبله، سواء العملية نجحت أو حصلت مشكلة زي قسمة على صفر أو إدخال غلط.

////يعني إيه؟
////لو عندك حاجة لازم تحصل مهما كان (زي تنظيف ملف فتحته، أو إنك تقفل اتصال بعد ما تخلص)، بتحطها جوه 
////بمعنى أصح:  هو ضمان إن فيه خطوة معينة هتتنفذ تحت أي ظرف!
#endregion


#region the second problem

//using System;
//class Program
//{
//    static void Main()
//    {
//        TestDefensiveCode();
//    }

//    static void TestDefensiveCode()
//    {
//        int x, y;

//        Console.Write("Enter a positive integer for X: ");
//        while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
//        {
//            Console.Write("Invalid input. Enter a positive integer for X: ");
//        }

//        Console.Write("Enter a positive integer greater than 1 for Y: ");
//        while (!int.TryParse(Console.ReadLine(), out y) || y <= 1)
//        {
//            Console.Write("Invalid input. Enter a positive integer greater than 1 for Y: ");
//        }

//        Console.WriteLine($"X: {x}, Y: {y}");
//    }

//}


////int.Parse(): مش بيقبل إلا النص اللي بيكون رقم صحيح 100%. لو النص ماكانش رقم، البرنامج هيفشل ويظهر خطأ.

////int.TryParse(): بتحاول تحول النص لرقم صحيح، ولو ما نجحش التحويل مش بتوقف البرنامج، وبتديك فرصة تتعامل مع المشكلة بشكل سلس.

#endregion


#region the third problem


//using System;

//class Program
//{
//    static void Main()
//    {
//        int? nullableInt = null;

//        int defaultValue = nullableInt ?? 10;

//        Console.WriteLine($"Nullable Integer (before assigning): {nullableInt}");
//        Console.WriteLine($"Default Value (if null): {defaultValue}");

//        nullableInt = 20;

//        if (nullableInt.HasValue)
//        {
//            Console.WriteLine($"Nullable Integer (after assigning): {nullableInt.Value}");
//        }
//        else
//        {
//            Console.WriteLine("The nullable integer has no value.");
//        }
//    }
//}



////InvalidOperationException is thrown.This exception indicates that the Nullable<T> does not have a value.

#endregion


#region the fourth problem

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

//class Program
//{
//    static void Main()
//    {
//        // Declare a 1D array of size 5
//        int[] array = new int[5] { 1, 2, 3, 4, 5 };

//        try
//        {
//            // Try accessing an index out of bounds
//            int outOfBoundsValue = array[10];
//        }
//        catch (IndexOutOfRangeException e)
//        {
//            // Handle the exception and display an appropriate message
//            Console.WriteLine("Error: Index out of bounds.");
//            Console.WriteLine(e.Message);
//        }
//    }
//}



//Prevent Errors: Accessing an array element outside its valid range (e.g., negative index or an index greater than or equal to the array length)
//causes an IndexOutOfRangeException. This can crash your program if not properly handled, leading to a poor user experience.

#endregion


#region the fifth problem


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] array = new int[3, 3];

//        Console.WriteLine("Enter values for the 3x3 array:");
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                Console.Write($"Enter value for array[{i},{j}]: ");
//                array[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine("Sum of each row:");
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            int rowSum = 0;
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                rowSum += array[i, j];
//            }
//            Console.WriteLine($"Row {i} sum: {rowSum}");
//        }
//        Console.WriteLine("Sum of each column:");
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            int colSum = 0;
//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                colSum += array[i, j];
//            }
//            Console.WriteLine($"Column {j} sum: {colSum}");
//        }
//    }
//}


//The GetLength(dimension) method is used to obtain the number of elements in a specified dimension of a multi-dimensional array.

//For a 2D array, GetLength(0) returns the number of rows, and GetLength(1) returns the number of columns.
//This method is particularly useful when iterating through arrays dynamically, as it provides a way to access the array's dimensions without hardcoding their sizes.

//In the code above:

//array.GetLength(0) is used to get the number of rows in the array.

//array.GetLength(1) is used to get the number of columns in the array.

#endregion


#region the sixth problem


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[][] jaggedArray = new int[3][];
//        jaggedArray[0] = new int[2];
//        jaggedArray[1] = new int[3];
//        jaggedArray[2] = new int[4];

//        for (int i = 0; i < jaggedArray.Length; i++)
//        {
//            Console.WriteLine($"Enter {jaggedArray[i].Length} values for row {i}:");
//            for (int j = 0; j < jaggedArray[i].Length; j++)
//            {
//                Console.Write($"Value[{i}][{j}]: ");
//                jaggedArray[i][j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("Jagged array values:");
//        for (int i = 0; i < jaggedArray.Length; i++)
//        {
//            Console.Write($"Row {i}: ");
//            for (int j = 0; j < jaggedArray[i].Length; j++)
//            {
//                Console.Write(jaggedArray[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//Jagged Arrays provide flexibility in row sizes but may lead to non-contiguous memory allocation.

//Rectangular Arrays ensure a uniform shape with contiguous memory allocation, which can be more efficient for certain operations.


#endregion


#region  the seventh problem


//using System;

//class Program
//{
//    static void Main()
//    {
//        string? nullableString;
//        Console.Write("Enter a string : ");
//        string input = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(input))
//        {
//            nullableString = null;
//        }
//        else
//        {
//            nullableString = input;
//        }

//        Console.WriteLine("You entered: " + nullableString!);
//    }
//}



//Purpose of Nullable Reference Types:
//Nullable reference types (?) were introduced to improve code safety and help developers avoid NullReferenceException by making nullability explicit.
//They allow the compiler to provide better warnings and error messages about potential null reference issues, encouraging developers to handle nulls more explicitly and safely.
//This helps in writing more robust, maintainable, and reliable code by reducing the likelihood of runtime errors caused by unexpected null values

#endregion


#region the eight problem


//using System;

//class Program
//{
//    static void Main()
//    {

//        int value = 123;
//        object boxedValue = value; 

//        Console.WriteLine($"Boxed value: {boxedValue}");

//        try
//        {
//            int unboxedValue = (int)boxedValue; 
//            Console.WriteLine($"Unboxed value: {unboxedValue}");

//            object invalidBoxedValue = "Not an integer";
//            int invalidUnboxedValue = (int)invalidBoxedValue;
//        }
//        catch (InvalidCastException e)
//        {
//            Console.WriteLine("Error: Invalid cast during unboxing.");
//            Console.WriteLine(e.Message);
//        }
//    }
//}


//boxing and unboxing can degrade performance because they involve additional memory allocations and type conversions.
//Frequent boxing and unboxing operations can lead to increased memory usage and slower execution times. To mitigate these impacts,
//it's generally advisable to minimize boxing and unboxing, especially in performance-critical applications.

#endregion


#region  the ninth problem

//using System;

//class Program
//{
//    static void Main()
//    {
//        int sum, product;

//        SumAndMultiply(5, 10, out sum, out product);

//        Console.WriteLine($"Sum: {sum}");
//        Console.WriteLine($"Product: {product}");
//    }

//    static void SumAndMultiply(int a, int b, out int sum, out int product)
//    {
//        sum = a + b;
//        product = a * b;
//    }
//}



////out parameters must be initialized inside the method because they are intended to return values from the method back to the caller.
////When a parameter is defined as out, it means that the method guarantees to assign a value to that parameter before the method returns.

#endregion


#region  the problem number 10 


//using System;

//class Program
//{
//    static void Main()
//    {
//        PrintStringMultipleTimes(message: "Hello, world!", count: 3);

//        PrintStringMultipleTimes("Hello again!");
//    }

//    static void PrintStringMultipleTimes(string message, int count = 5)
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine(message);
//        }
//    }
//}



//Optional parameters must appear at the end of a method's parameter list because it ensures that all required parameters are provided when the method is called. 
//If optional parameters were allowed at the beginning or middle of the parameter list, it would create ambiguity and confusion about which parameters are being supplied,
//especially when using named arguments.

//This rule simplifies the method call syntax and ensures clarity in which parameters are required and which are optional, making the code more readable and maintainable.


# endregion


#region the problem number 11

//using System;

//class Program
//{
//    static void Main()
//    {
//        int?[] nullableArray = null;

//        int? length = nullableArray?.Length;

//        Console.WriteLine($"Array Length: {length}");

//        nullableArray = new int?[] { 1, 2, 3, null, 5 };

//        for (int i = 0; i < (nullableArray?.Length ?? 0); i++)
//        {
//            Console.WriteLine($"Element {i}: {nullableArray?[i]}");
//        }
//    }
//}

////The null propagation operator (?.) allows you to safely access members (properties, methods) of an object that might be null.
////    When you use ?., if the object on the left side of the operator is null, 
////    the entire expression evaluates to null instead of throwing a NullReferenceException.

////This operator is particularly useful for preventing runtime errors when dealing with nullable types or objects that may not always be initialized.
////    It simplifies code by eliminating the need for explicit null checks and ensures safer access to object members.

#endregion


#region  the problem number 12

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a day of the week: ");
//        string dayOfWeek = Console.ReadLine();

//        int dayNumber = dayOfWeek switch
//        {
//            "Monday" => 1,
//            "Tuesday" => 2,
//            "Wednesday" => 3,
//            "Thursday" => 4,
//            "Friday" => 5,
//            "Saturday" => 6,
//            "Sunday" => 7,
//            _ => 0 
//        };

//        if (dayNumber == 0)
//        {
//            Console.WriteLine("Invalid day of the week.");
//        }
//        else
//        {
//            Console.WriteLine($"{dayOfWeek} corresponds to number {dayNumber}");
//        }
//    }
//}


//Clarity and Readability: Simplifies multiple condition checks into a concise format.
//Pattern Matching: Supports complex and expressive conditions.
//Exhaustiveness: Ensures all cases are handled, reducing the risk of missed conditions.
//Single Expression: Evaluates to a single value, suitable for inline assignments.
//Performance: May offer better compiler optimizations compared to multiple if-else statements.


#endregion


#region the problem number 13

//using System;
//using System.Net.NetworkInformation;

//class Program
//{
//    static void Main()
//    {
//        int sum1 = SumArray(1, 2, 3, 4, 5);
//        Console.WriteLine($"Sum of individual values: {sum1}");

//        int[] numbers = { 6, 7, 8, 9, 10 };
//        int sum2 = SumArray(numbers);
//        Console.WriteLine($"Sum of array values: {sum2}");
//    }

//    static int SumArray(params int[] numbers)
//    {
//        int sum = 0;
//        foreach (int number in numbers)
//        {
//            sum += number;
//        }
//        return sum;
//    }
//}

//Only One params Parameter: A method can have only one params parameter, and it must be the last parameter in the method's parameter list.
//Type Consistency: All arguments passed to a params parameter must be of the same type or a type that can be implicitly converted to the params array element type.
//Performance Consideration: Using the params keyword involves array allocation, which might impact performance when called frequently in performance-critical applications.
//Order of Parameters: When using the params keyword, all non-params parameters must be defined before the params parameter, 
//    ensuring that the params parameter is always the last in the list.

#endregion


// part 02


#region the first problem

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a positive integer: ");
//        int number;

//        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
//        {
//            Console.Write("Invalid input. Please enter a positive integer: ");
//        }

//        for (int i = 1; i <= number; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


#endregion


#region  the socond problem

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a positive integer: ");
//        int number;

//        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
//        {
//            Console.Write("Invalid input. Please enter a positive integer: ");
//        }

//        for (int i = 1; i <= number; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


#endregion


#region  the third problem

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ask the user to enter a number
//        Console.Write("Enter a number: ");
//        int number;

//        // Validate user input to ensure it's a valid integer
//        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
//        {
//            Console.Write("Invalid input. Please enter a positive integer: ");
//        }

//        // Print all even numbers between 1 and the entered number
//        Console.WriteLine("Even numbers:");
//        for (int i = 2; i <= number; i += 2)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


#endregion


#region the fourth problem

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the base number: ");
//        int baseNumber = int.Parse(Console.ReadLine());

//        Console.Write("Enter the exponent: ");
//        int exponent = int.Parse(Console.ReadLine());

//        int result = (int)Math.Pow(baseNumber, exponent);

//        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
//    }
//}


#endregion


#region the fifth problem


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a string: ");
//        string input = Console.ReadLine();

//        string reversedString = ReverseString(input);

//        Console.WriteLine($"Reversed string: {reversedString}");
//    }

//    static string ReverseString(string s)
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}


#endregion


#region the sixth problem 

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter an integer: ");
//        int number = int.Parse(Console.ReadLine());

//        int reversedNumber = ReverseInteger(number);

//        Console.WriteLine($"Reversed integer: {reversedNumber}");
//    }

//    static int ReverseInteger(int num)
//    {
//        int reversed = 0;
//        while (num != 0)
//        {
//            int digit = num % 10;
//            reversed = reversed * 10 + digit;
//            num /= 10;
//        }
//        return reversed;
//    }
//}


#endregion


#region the seventh problem 

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the size of the array: ");
//        int size = int.Parse(Console.ReadLine());

//        int[] array = new int[size];

//        Console.WriteLine("Enter the array elements:");
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int longestDistance = FindLongestDistance(array);

//        Console.WriteLine($"The longest distance between two identical elements is: {longestDistance}");
//    }

//    static int FindLongestDistance(int[] array)
//    {
//        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
//        int maxDistance = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (firstOccurrence.ContainsKey(array[i]))
//            {
//                int distance = i - firstOccurrence[array[i]] - 1;

//                if (distance > maxDistance)
//                {
//                    maxDistance = distance;
//                }
//            }
//            else
//            {
//                firstOccurrence[array[i]] = i;
//            }
//        }

//        return maxDistance;
//    }
//}


#endregion


#region the problem number 8

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a sentence: ");
//        string sentence = Console.ReadLine();

//        string[] words = sentence.Split(' ');

//        Array.Reverse(words);

//        string reversedSentence = string.Join(" ", words);

//        Console.WriteLine(reversedSentence);
//    }
//}


#endregion
































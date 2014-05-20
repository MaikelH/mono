using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class RangeSuite
{
    public static void Main (string[] args)
    {
        // Print some information on the runtome
        Type t = Type.GetType ("Mono.Runtime");
        if(t != null)
        {
            Console.WriteLine("Mono runtime - {0} ", System.Environment.Version);
        }
        else
        {
            Console.WriteLine("Other runtime - {0} ", System.Environment.Version);
        }

        TestRunner(1000000);
    }

    public static void TestRunner(int nrOfTests)
    {
        Test1(nrOfTests);
        Test2(nrOfTests);
        Test3(nrOfTests);
        Test4(nrOfTests);
        //Test5(nrOfTests);
        //Test6(nrOfTests);
    }

    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    public static void TestFunction()
    {

    }

    public static void Test1(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {24, 25, 70, 71};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (input.Length)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
            case 24:
            case 25:
                TestFunction();
                break;
            case 70:
            case 71:
                TestFunction();
                break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rang #1: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test2(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {12, 13, 26, 27, 70, 71, 92, 93};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (input.Length)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 12:
                case 13:
                    TestFunction();
                    break;
                case 26:
                case 27:
                    TestFunction();
                    break;
                case 70:
                case 71:
                    TestFunction();
                    break;
                case 92:
                case 93:
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rang #2: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test3(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {24, 25, 26, 27, 70, 71, 72, 73};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (input.Length)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 24:
                case 25:
                case 26:
                case 27:
                    TestFunction();
                    break;
                case 70:
                case 71:
                case 72:
                case 73:
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rang #3: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test4(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {24, 25, 26, 27, 70, 71, 72, 73, 129,130,131,132,197,198,199,200};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (input.Length)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 24:
                case 25:
                case 26:
                case 27:
                    TestFunction();
                    break;
                case 70:
                case 71:
                case 72:
                case 73:
                    TestFunction();
                    break;
                case 129:
                case 130:
                case 131:
                case 132:
                    TestFunction();
                    break;
                case 197:
                case 198:
                case 199:
                case 200:
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rang #4: " + stopWatch.Elapsed.TotalMilliseconds);
    }
}
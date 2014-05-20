using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class ConsecutiveSuite
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
        Test5(nrOfTests);
        Test6(nrOfTests);
    }

    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    public static void TestFunction()
    {

    }
    
    public static void Test1(int runs)
    {
        // Generate the numbers needed for testing
        Random rand = new Random ();
        Stopwatch stopWatch = new Stopwatch();
        int[] numbers = new int[runs];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (4);
        }

        stopWatch.Start();
        for(int i = 0; i < runs; i++)
        {
            switch (numbers[i]) {
                case 0:
                    TestFunction();
                    break;
                case 1:
                    TestFunction();
                    break;
                case 2:
                    TestFunction();
                    break;
                case 3:
                    TestFunction();
                    break;
            }  
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 1: {0}", stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test2(int number)
    {
        Random rand = new Random ();
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (8);
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Timespan or Timer
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 0:
                    TestFunction();
                    break;
                case 1:
                    TestFunction();
                    break;
                case 2:
                    TestFunction();
                    break;
                case 3:
                    TestFunction();
                    break;
                case 4:
                    TestFunction();
                    break;
                case 5:
                    TestFunction();
                    break;
                case 6:
                    TestFunction();
                    break;
                case 7:
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 2: " +stopWatch.Elapsed.TotalMilliseconds); 
    }

    public static void Test3(int number)
    {
        Random rand = new Random ();
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (16);
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 0: 
                    TestFunction();
                    break;
                case 1: 
                    TestFunction();
                    break;
                case 2: 
                    TestFunction();
                    break;
                case 3: 
                    TestFunction();
                    break;
                case 4: 
                    TestFunction();
                    break;
                case 5: 
                    TestFunction();
                    break;
                case 6: 
                    TestFunction();
                    break;
                case 7: 
                    TestFunction();
                    break;
                case 8: 
                    TestFunction();
                    break;
                case 9: 
                    TestFunction();
                    break;
                case 10: 
                    TestFunction();
                    break;
                case 11: 
                    TestFunction();
                    break;
                case 12: 
                    TestFunction();
                    break;
                case 13: 
                    TestFunction();
                    break;
                case 14: 
                    TestFunction();
                    break;
                case 15: 
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 3: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test4(int number)
    {
        Random rand = new Random ();
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (32);
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 0: 
                    TestFunction();
                    break;
                case 1: 
                    TestFunction();
                    break;
                case 2: 
                    TestFunction();
                    break;
                case 3: 
                    TestFunction();
                    break;
                case 4: 
                    TestFunction();
                    break;
                case 5: 
                    TestFunction();
                    break;
                case 6: 
                    TestFunction();
                    break;
                case 7: 
                    TestFunction();
                    break;
                case 8: 
                    TestFunction();
                    break;
                case 9: 
                    TestFunction();
                    break;
                case 10: 
                    TestFunction();
                    break;
                case 11: 
                    TestFunction();
                    break;
                case 12: 
                    TestFunction();
                    break;
                case 13: 
                    TestFunction();
                    break;
                case 14: 
                    TestFunction();
                    break;
                case 15: 
                    TestFunction();
                    break;
                case 16: 
                    TestFunction();
                    break;
                case 17: 
                    TestFunction();
                    break;
                case 18: 
                    TestFunction();
                    break;
                case 19: 
                    TestFunction();
                    break;
                case 20: 
                    TestFunction();
                    break;
                case 21: 
                    TestFunction();
                    break;
                case 22: 
                    TestFunction();
                    break;
                case 23: 
                    TestFunction();
                    break;
                case 24: 
                    TestFunction();
                    break;
                case 25: 
                    TestFunction();
                    break;
                case 26: 
                    TestFunction();
                    break;
                case 27: 
                    TestFunction();
                    break;
                case 28: 
                    TestFunction();
                    break;
                case 29: 
                    TestFunction();
                    break;
                case 30: 
                    TestFunction();
                    break;
                case 31: 
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 4: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test5(int number)
    {
        Random rand = new Random ();
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (128);
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 0: 
                    TestFunction();
                    break;
                case 1: 
                    TestFunction();
                    break;
                case 2: 
                    TestFunction();
                    break;
                case 3: 
                    TestFunction();
                    break;
                case 4: 
                    TestFunction();
                    break;
                case 5: 
                    TestFunction();
                    break;
                case 6: 
                    TestFunction();
                    break;
                case 7: 
                    TestFunction();
                    break;
                case 8: 
                    TestFunction();
                    break;
                case 9: 
                    TestFunction();
                    break;
                case 10: 
                    TestFunction();
                    break;
                case 11: 
                    TestFunction();
                    break;
                case 12: 
                    TestFunction();
                    break;
                case 13: 
                    TestFunction();
                    break;
                case 14: 
                    TestFunction();
                    break;
                case 15: 
                    TestFunction();
                    break;
                case 16: 
                    TestFunction();
                    break;
                case 17: 
                    TestFunction();
                    break;
                case 18: 
                    TestFunction();
                    break;
                case 19: 
                    TestFunction();
                    break;
                case 20: 
                    TestFunction();
                    break;
                case 21: 
                    TestFunction();
                    break;
                case 22: 
                    TestFunction();
                    break;
                case 23: 
                    TestFunction();
                    break;
                case 24: 
                    TestFunction();
                    break;
                case 25: 
                    TestFunction();
                    break;
                case 26: 
                    TestFunction();
                    break;
                case 27: 
                    TestFunction();
                    break;
                case 28: 
                    TestFunction();
                    break;
                case 29: 
                    TestFunction();
                    break;
                case 30: 
                    TestFunction();
                    break;
                case 31: 
                    TestFunction();
                    break;
                case 32: 
                    TestFunction();
                    break;
                case 33: 
                    TestFunction();
                    break;
                case 34: 
                    TestFunction();
                    break;
                case 35: 
                    TestFunction();
                    break;
                case 36: 
                    TestFunction();
                    break;
                case 37: 
                    TestFunction();
                    break;
                case 38: 
                    TestFunction();
                    break;
                case 39: 
                    TestFunction();
                    break;
                case 40: 
                    TestFunction();
                    break;
                case 41: 
                    TestFunction();
                    break;
                case 42: 
                    TestFunction();
                    break;
                case 43: 
                    TestFunction();
                    break;
                case 44: 
                    TestFunction();
                    break;
                case 45: 
                    TestFunction();
                    break;
                case 46: 
                    TestFunction();
                    break;
                case 47: 
                    TestFunction();
                    break;
                case 48: 
                    TestFunction();
                    break;
                case 49: 
                    TestFunction();
                    break;
                case 50: 
                    TestFunction();
                    break;
                case 51: 
                    TestFunction();
                    break;
                case 52: 
                    TestFunction();
                    break;
                case 53: 
                    TestFunction();
                    break;
                case 54: 
                    TestFunction();
                    break;
                case 55: 
                    TestFunction();
                    break;
                case 56: 
                    TestFunction();
                    break;
                case 57: 
                    TestFunction();
                    break;
                case 58: 
                    TestFunction();
                    break;
                case 59: 
                    TestFunction();
                    break;
                case 60: 
                    TestFunction();
                    break;
                case 61: 
                    TestFunction();
                    break;
                case 62: 
                    TestFunction();
                    break;
                case 63: 
                    TestFunction();
                    break;
                case 64: 
                    TestFunction();
                    break;
                case 65: 
                    TestFunction();
                    break;
                case 66: 
                    TestFunction();
                    break;
                case 67: 
                    TestFunction();
                    break;
                case 68: 
                    TestFunction();
                    break;
                case 69: 
                    TestFunction();
                    break;
                case 70: 
                    TestFunction();
                    break;
                case 71: 
                    TestFunction();
                    break;
                case 72: 
                    TestFunction();
                    break;
                case 73: 
                    TestFunction();
                    break;
                case 74: 
                    TestFunction();
                    break;
                case 75: 
                    TestFunction();
                    break;
                case 76: 
                    TestFunction();
                    break;
                case 77: 
                    TestFunction();
                    break;
                case 78: 
                    TestFunction();
                    break;
                case 79: 
                    TestFunction();
                    break;
                case 80: 
                    TestFunction();
                    break;
                case 81: 
                    TestFunction();
                    break;
                case 82: 
                    TestFunction();
                    break;
                case 83: 
                    TestFunction();
                    break;
                case 84: 
                    TestFunction();
                    break;
                case 85: 
                    TestFunction();
                    break;
                case 86: 
                    TestFunction();
                    break;
                case 87: 
                    TestFunction();
                    break;
                case 88: 
                    TestFunction();
                    break;
                case 89: 
                    TestFunction();
                    break;
                case 90: 
                    TestFunction();
                    break;
                case 91: 
                    TestFunction();
                    break;
                case 92: 
                    TestFunction();
                    break;
                case 93: 
                    TestFunction();
                    break;
                case 94: 
                    TestFunction();
                    break;
                case 95: 
                    TestFunction();
                    break;
                case 96: 
                    TestFunction();
                    break;
                case 97: 
                    TestFunction();
                    break;
                case 98: 
                    TestFunction();
                    break;
                case 99: 
                    TestFunction();
                    break;
                case 100: 
                    TestFunction();
                    break;
                case 101: 
                    TestFunction();
                    break;
                case 102: 
                    TestFunction();
                    break;
                case 103: 
                    TestFunction();
                    break;
                case 104: 
                    TestFunction();
                    break;
                case 105: 
                    TestFunction();
                    break;
                case 106: 
                    TestFunction();
                    break;
                case 107: 
                    TestFunction();
                    break;
                case 108: 
                    TestFunction();
                    break;
                case 109: 
                    TestFunction();
                    break;
                case 110: 
                    TestFunction();
                    break;
                case 111: 
                    TestFunction();
                    break;
                case 112: 
                    TestFunction();
                    break;
                case 113: 
                    TestFunction();
                    break;
                case 114: 
                    TestFunction();
                    break;
                case 115: 
                    TestFunction();
                    break;
                case 116: 
                    TestFunction();
                    break;
                case 117: 
                    TestFunction();
                    break;
                case 118: 
                    TestFunction();
                    break;
                case 119: 
                    TestFunction();
                    break;
                case 120: 
                    TestFunction();
                    break;
                case 121: 
                    TestFunction();
                    break;
                case 122: 
                    TestFunction();
                    break;
                case 123: 
                    TestFunction();
                    break;
                case 124: 
                    TestFunction();
                    break;
                case 125: 
                    TestFunction();
                    break;
                case 126: 
                    TestFunction();
                    break;
                case 127: 
                    TestFunction();
                    break;

            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 5: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test6(int number)
    {
        Random rand = new Random ();
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers [i] = rand.Next (1024);
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 0: 
                    TestFunction();
                    break;
                case 1: 
                    TestFunction();
                    break;
                case 2: 
                    TestFunction();
                    break;
                case 3: 
                    TestFunction();
                    break;
                case 4: 
                    TestFunction();
                    break;
                case 5: 
                    TestFunction();
                    break;
                case 6: 
                    TestFunction();
                    break;
                case 7: 
                    TestFunction();
                    break;
                case 8: 
                    TestFunction();
                    break;
                case 9: 
                    TestFunction();
                    break;
                case 10: 
                    TestFunction();
                    break;
                case 11: 
                    TestFunction();
                    break;
                case 12: 
                    TestFunction();
                    break;
                case 13: 
                    TestFunction();
                    break;
                case 14: 
                    TestFunction();
                    break;
                case 15: 
                    TestFunction();
                    break;
                case 16: 
                    TestFunction();
                    break;
                case 17: 
                    TestFunction();
                    break;
                case 18: 
                    TestFunction();
                    break;
                case 19: 
                    TestFunction();
                    break;
                case 20: 
                    TestFunction();
                    break;
                case 21: 
                    TestFunction();
                    break;
                case 22: 
                    TestFunction();
                    break;
                case 23: 
                    TestFunction();
                    break;
                case 24: 
                    TestFunction();
                    break;
                case 25: 
                    TestFunction();
                    break;
                case 26: 
                    TestFunction();
                    break;
                case 27: 
                    TestFunction();
                    break;
                case 28: 
                    TestFunction();
                    break;
                case 29: 
                    TestFunction();
                    break;
                case 30: 
                    TestFunction();
                    break;
                case 31: 
                    TestFunction();
                    break;
                case 32: 
                    TestFunction();
                    break;
                case 33: 
                    TestFunction();
                    break;
                case 34: 
                    TestFunction();
                    break;
                case 35: 
                    TestFunction();
                    break;
                case 36: 
                    TestFunction();
                    break;
                case 37: 
                    TestFunction();
                    break;
                case 38: 
                    TestFunction();
                    break;
                case 39: 
                    TestFunction();
                    break;
                case 40: 
                    TestFunction();
                    break;
                case 41: 
                    TestFunction();
                    break;
                case 42: 
                    TestFunction();
                    break;
                case 43: 
                    TestFunction();
                    break;
                case 44: 
                    TestFunction();
                    break;
                case 45: 
                    TestFunction();
                    break;
                case 46: 
                    TestFunction();
                    break;
                case 47: 
                    TestFunction();
                    break;
                case 48: 
                    TestFunction();
                    break;
                case 49: 
                    TestFunction();
                    break;
                case 50: 
                    TestFunction();
                    break;
                case 51: 
                    TestFunction();
                    break;
                case 52: 
                    TestFunction();
                    break;
                case 53: 
                    TestFunction();
                    break;
                case 54: 
                    TestFunction();
                    break;
                case 55: 
                    TestFunction();
                    break;
                case 56: 
                    TestFunction();
                    break;
                case 57: 
                    TestFunction();
                    break;
                case 58: 
                    TestFunction();
                    break;
                case 59: 
                    TestFunction();
                    break;
                case 60: 
                    TestFunction();
                    break;
                case 61: 
                    TestFunction();
                    break;
                case 62: 
                    TestFunction();
                    break;
                case 63: 
                    TestFunction();
                    break;
                case 64: 
                    TestFunction();
                    break;
                case 65: 
                    TestFunction();
                    break;
                case 66: 
                    TestFunction();
                    break;
                case 67: 
                    TestFunction();
                    break;
                case 68: 
                    TestFunction();
                    break;
                case 69: 
                    TestFunction();
                    break;
                case 70: 
                    TestFunction();
                    break;
                case 71: 
                    TestFunction();
                    break;
                case 72: 
                    TestFunction();
                    break;
                case 73: 
                    TestFunction();
                    break;
                case 74: 
                    TestFunction();
                    break;
                case 75: 
                    TestFunction();
                    break;
                case 76: 
                    TestFunction();
                    break;
                case 77: 
                    TestFunction();
                    break;
                case 78: 
                    TestFunction();
                    break;
                case 79: 
                    TestFunction();
                    break;
                case 80: 
                    TestFunction();
                    break;
                case 81: 
                    TestFunction();
                    break;
                case 82: 
                    TestFunction();
                    break;
                case 83: 
                    TestFunction();
                    break;
                case 84: 
                    TestFunction();
                    break;
                case 85: 
                    TestFunction();
                    break;
                case 86: 
                    TestFunction();
                    break;
                case 87: 
                    TestFunction();
                    break;
                case 88: 
                    TestFunction();
                    break;
                case 89: 
                    TestFunction();
                    break;
                case 90: 
                    TestFunction();
                    break;
                case 91: 
                    TestFunction();
                    break;
                case 92: 
                    TestFunction();
                    break;
                case 93: 
                    TestFunction();
                    break;
                case 94: 
                    TestFunction();
                    break;
                case 95: 
                    TestFunction();
                    break;
                case 96: 
                    TestFunction();
                    break;
                case 97: 
                    TestFunction();
                    break;
                case 98: 
                    TestFunction();
                    break;
                case 99: 
                    TestFunction();
                    break;
                case 100: 
                    TestFunction();
                    break;
                case 101: 
                    TestFunction();
                    break;
                case 102: 
                    TestFunction();
                    break;
                case 103: 
                    TestFunction();
                    break;
                case 104: 
                    TestFunction();
                    break;
                case 105: 
                    TestFunction();
                    break;
                case 106: 
                    TestFunction();
                    break;
                case 107: 
                    TestFunction();
                    break;
                case 108: 
                    TestFunction();
                    break;
                case 109: 
                    TestFunction();
                    break;
                case 110: 
                    TestFunction();
                    break;
                case 111: 
                    TestFunction();
                    break;
                case 112: 
                    TestFunction();
                    break;
                case 113: 
                    TestFunction();
                    break;
                case 114: 
                    TestFunction();
                    break;
                case 115: 
                    TestFunction();
                    break;
                case 116: 
                    TestFunction();
                    break;
                case 117: 
                    TestFunction();
                    break;
                case 118: 
                    TestFunction();
                    break;
                case 119: 
                    TestFunction();
                    break;
                case 120: 
                    TestFunction();
                    break;
                case 121: 
                    TestFunction();
                    break;
                case 122: 
                    TestFunction();
                    break;
                case 123: 
                    TestFunction();
                    break;
                case 124: 
                    TestFunction();
                    break;
                case 125: 
                    TestFunction();
                    break;
                case 126: 
                    TestFunction();
                    break;
                case 127: 
                    TestFunction();
                    break;
                case 128: 
                    TestFunction();
                    break;
                case 129: 
                    TestFunction();
                    break;
                case 130: 
                    TestFunction();
                    break;
                case 131: 
                    TestFunction();
                    break;
                case 132: 
                    TestFunction();
                    break;
                case 133: 
                    TestFunction();
                    break;
                case 134: 
                    TestFunction();
                    break;
                case 135: 
                    TestFunction();
                    break;
                case 136: 
                    TestFunction();
                    break;
                case 137: 
                    TestFunction();
                    break;
                case 138: 
                    TestFunction();
                    break;
                case 139: 
                    TestFunction();
                    break;
                case 140: 
                    TestFunction();
                    break;
                case 141: 
                    TestFunction();
                    break;
                case 142: 
                    TestFunction();
                    break;
                case 143: 
                    TestFunction();
                    break;
                case 144: 
                    TestFunction();
                    break;
                case 145: 
                    TestFunction();
                    break;
                case 146: 
                    TestFunction();
                    break;
                case 147: 
                    TestFunction();
                    break;
                case 148: 
                    TestFunction();
                    break;
                case 149: 
                    TestFunction();
                    break;
                case 150: 
                    TestFunction();
                    break;
                case 151: 
                    TestFunction();
                    break;
                case 152: 
                    TestFunction();
                    break;
                case 153: 
                    TestFunction();
                    break;
                case 154: 
                    TestFunction();
                    break;
                case 155: 
                    TestFunction();
                    break;
                case 156: 
                    TestFunction();
                    break;
                case 157: 
                    TestFunction();
                    break;
                case 158: 
                    TestFunction();
                    break;
                case 159: 
                    TestFunction();
                    break;
                case 160: 
                    TestFunction();
                    break;
                case 161: 
                    TestFunction();
                    break;
                case 162: 
                    TestFunction();
                    break;
                case 163: 
                    TestFunction();
                    break;
                case 164: 
                    TestFunction();
                    break;
                case 165: 
                    TestFunction();
                    break;
                case 166: 
                    TestFunction();
                    break;
                case 167: 
                    TestFunction();
                    break;
                case 168: 
                    TestFunction();
                    break;
                case 169: 
                    TestFunction();
                    break;
                case 170: 
                    TestFunction();
                    break;
                case 171: 
                    TestFunction();
                    break;
                case 172: 
                    TestFunction();
                    break;
                case 173: 
                    TestFunction();
                    break;
                case 174: 
                    TestFunction();
                    break;
                case 175: 
                    TestFunction();
                    break;
                case 176: 
                    TestFunction();
                    break;
                case 177: 
                    TestFunction();
                    break;
                case 178: 
                    TestFunction();
                    break;
                case 179: 
                    TestFunction();
                    break;
                case 180: 
                    TestFunction();
                    break;
                case 181: 
                    TestFunction();
                    break;
                case 182: 
                    TestFunction();
                    break;
                case 183: 
                    TestFunction();
                    break;
                case 184: 
                    TestFunction();
                    break;
                case 185: 
                    TestFunction();
                    break;
                case 186: 
                    TestFunction();
                    break;
                case 187: 
                    TestFunction();
                    break;
                case 188: 
                    TestFunction();
                    break;
                case 189: 
                    TestFunction();
                    break;
                case 190: 
                    TestFunction();
                    break;
                case 191: 
                    TestFunction();
                    break;
                case 192: 
                    TestFunction();
                    break;
                case 193: 
                    TestFunction();
                    break;
                case 194: 
                    TestFunction();
                    break;
                case 195: 
                    TestFunction();
                    break;
                case 196: 
                    TestFunction();
                    break;
                case 197: 
                    TestFunction();
                    break;
                case 198: 
                    TestFunction();
                    break;
                case 199: 
                    TestFunction();
                    break;
                case 200: 
                    TestFunction();
                    break;
                case 201: 
                    TestFunction();
                    break;
                case 202: 
                    TestFunction();
                    break;
                case 203: 
                    TestFunction();
                    break;
                case 204: 
                    TestFunction();
                    break;
                case 205: 
                    TestFunction();
                    break;
                case 206: 
                    TestFunction();
                    break;
                case 207: 
                    TestFunction();
                    break;
                case 208: 
                    TestFunction();
                    break;
                case 209: 
                    TestFunction();
                    break;
                case 210: 
                    TestFunction();
                    break;
                case 211: 
                    TestFunction();
                    break;
                case 212: 
                    TestFunction();
                    break;
                case 213: 
                    TestFunction();
                    break;
                case 214: 
                    TestFunction();
                    break;
                case 215: 
                    TestFunction();
                    break;
                case 216: 
                    TestFunction();
                    break;
                case 217: 
                    TestFunction();
                    break;
                case 218: 
                    TestFunction();
                    break;
                case 219: 
                    TestFunction();
                    break;
                case 220: 
                    TestFunction();
                    break;
                case 221: 
                    TestFunction();
                    break;
                case 222: 
                    TestFunction();
                    break;
                case 223: 
                    TestFunction();
                    break;
                case 224: 
                    TestFunction();
                    break;
                case 225: 
                    TestFunction();
                    break;
                case 226: 
                    TestFunction();
                    break;
                case 227: 
                    TestFunction();
                    break;
                case 228: 
                    TestFunction();
                    break;
                case 229: 
                    TestFunction();
                    break;
                case 230: 
                    TestFunction();
                    break;
                case 231: 
                    TestFunction();
                    break;
                case 232: 
                    TestFunction();
                    break;
                case 233: 
                    TestFunction();
                    break;
                case 234: 
                    TestFunction();
                    break;
                case 235: 
                    TestFunction();
                    break;
                case 236: 
                    TestFunction();
                    break;
                case 237: 
                    TestFunction();
                    break;
                case 238: 
                    TestFunction();
                    break;
                case 239: 
                    TestFunction();
                    break;
                case 240: 
                    TestFunction();
                    break;
                case 241: 
                    TestFunction();
                    break;
                case 242: 
                    TestFunction();
                    break;
                case 243: 
                    TestFunction();
                    break;
                case 244: 
                    TestFunction();
                    break;
                case 245: 
                    TestFunction();
                    break;
                case 246: 
                    TestFunction();
                    break;
                case 247: 
                    TestFunction();
                    break;
                case 248: 
                    TestFunction();
                    break;
                case 249: 
                    TestFunction();
                    break;
                case 250: 
                    TestFunction();
                    break;
                case 251: 
                    TestFunction();
                    break;
                case 252: 
                    TestFunction();
                    break;
                case 253: 
                    TestFunction();
                    break;
                case 254: 
                    TestFunction();
                    break;
                case 255: 
                    TestFunction();
                    break;
                case 256: 
                    TestFunction();
                    break;
                case 257: 
                    TestFunction();
                    break;
                case 258: 
                    TestFunction();
                    break;
                case 259: 
                    TestFunction();
                    break;
                case 260: 
                    TestFunction();
                    break;
                case 261: 
                    TestFunction();
                    break;
                case 262: 
                    TestFunction();
                    break;
                case 263: 
                    TestFunction();
                    break;
                case 264: 
                    TestFunction();
                    break;
                case 265: 
                    TestFunction();
                    break;
                case 266: 
                    TestFunction();
                    break;
                case 267: 
                    TestFunction();
                    break;
                case 268: 
                    TestFunction();
                    break;
                case 269: 
                    TestFunction();
                    break;
                case 270: 
                    TestFunction();
                    break;
                case 271: 
                    TestFunction();
                    break;
                case 272: 
                    TestFunction();
                    break;
                case 273: 
                    TestFunction();
                    break;
                case 274: 
                    TestFunction();
                    break;
                case 275: 
                    TestFunction();
                    break;
                case 276: 
                    TestFunction();
                    break;
                case 277: 
                    TestFunction();
                    break;
                case 278: 
                    TestFunction();
                    break;
                case 279: 
                    TestFunction();
                    break;
                case 280: 
                    TestFunction();
                    break;
                case 281: 
                    TestFunction();
                    break;
                case 282: 
                    TestFunction();
                    break;
                case 283: 
                    TestFunction();
                    break;
                case 284: 
                    TestFunction();
                    break;
                case 285: 
                    TestFunction();
                    break;
                case 286: 
                    TestFunction();
                    break;
                case 287: 
                    TestFunction();
                    break;
                case 288: 
                    TestFunction();
                    break;
                case 289: 
                    TestFunction();
                    break;
                case 290: 
                    TestFunction();
                    break;
                case 291: 
                    TestFunction();
                    break;
                case 292: 
                    TestFunction();
                    break;
                case 293: 
                    TestFunction();
                    break;
                case 294: 
                    TestFunction();
                    break;
                case 295: 
                    TestFunction();
                    break;
                case 296: 
                    TestFunction();
                    break;
                case 297: 
                    TestFunction();
                    break;
                case 298: 
                    TestFunction();
                    break;
                case 299: 
                    TestFunction();
                    break;
                case 300: 
                    TestFunction();
                    break;
                case 301: 
                    TestFunction();
                    break;
                case 302: 
                    TestFunction();
                    break;
                case 303: 
                    TestFunction();
                    break;
                case 304: 
                    TestFunction();
                    break;
                case 305: 
                    TestFunction();
                    break;
                case 306: 
                    TestFunction();
                    break;
                case 307: 
                    TestFunction();
                    break;
                case 308: 
                    TestFunction();
                    break;
                case 309: 
                    TestFunction();
                    break;
                case 310: 
                    TestFunction();
                    break;
                case 311: 
                    TestFunction();
                    break;
                case 312: 
                    TestFunction();
                    break;
                case 313: 
                    TestFunction();
                    break;
                case 314: 
                    TestFunction();
                    break;
                case 315: 
                    TestFunction();
                    break;
                case 316: 
                    TestFunction();
                    break;
                case 317: 
                    TestFunction();
                    break;
                case 318: 
                    TestFunction();
                    break;
                case 319: 
                    TestFunction();
                    break;
                case 320: 
                    TestFunction();
                    break;
                case 321: 
                    TestFunction();
                    break;
                case 322: 
                    TestFunction();
                    break;
                case 323: 
                    TestFunction();
                    break;
                case 324: 
                    TestFunction();
                    break;
                case 325: 
                    TestFunction();
                    break;
                case 326: 
                    TestFunction();
                    break;
                case 327: 
                    TestFunction();
                    break;
                case 328: 
                    TestFunction();
                    break;
                case 329: 
                    TestFunction();
                    break;
                case 330: 
                    TestFunction();
                    break;
                case 331: 
                    TestFunction();
                    break;
                case 332: 
                    TestFunction();
                    break;
                case 333: 
                    TestFunction();
                    break;
                case 334: 
                    TestFunction();
                    break;
                case 335: 
                    TestFunction();
                    break;
                case 336: 
                    TestFunction();
                    break;
                case 337: 
                    TestFunction();
                    break;
                case 338: 
                    TestFunction();
                    break;
                case 339: 
                    TestFunction();
                    break;
                case 340: 
                    TestFunction();
                    break;
                case 341: 
                    TestFunction();
                    break;
                case 342: 
                    TestFunction();
                    break;
                case 343: 
                    TestFunction();
                    break;
                case 344: 
                    TestFunction();
                    break;
                case 345: 
                    TestFunction();
                    break;
                case 346: 
                    TestFunction();
                    break;
                case 347: 
                    TestFunction();
                    break;
                case 348: 
                    TestFunction();
                    break;
                case 349: 
                    TestFunction();
                    break;
                case 350: 
                    TestFunction();
                    break;
                case 351: 
                    TestFunction();
                    break;
                case 352: 
                    TestFunction();
                    break;
                case 353: 
                    TestFunction();
                    break;
                case 354: 
                    TestFunction();
                    break;
                case 355: 
                    TestFunction();
                    break;
                case 356: 
                    TestFunction();
                    break;
                case 357: 
                    TestFunction();
                    break;
                case 358: 
                    TestFunction();
                    break;
                case 359: 
                    TestFunction();
                    break;
                case 360: 
                    TestFunction();
                    break;
                case 361: 
                    TestFunction();
                    break;
                case 362: 
                    TestFunction();
                    break;
                case 363: 
                    TestFunction();
                    break;
                case 364: 
                    TestFunction();
                    break;
                case 365: 
                    TestFunction();
                    break;
                case 366: 
                    TestFunction();
                    break;
                case 367: 
                    TestFunction();
                    break;
                case 368: 
                    TestFunction();
                    break;
                case 369: 
                    TestFunction();
                    break;
                case 370: 
                    TestFunction();
                    break;
                case 371: 
                    TestFunction();
                    break;
                case 372: 
                    TestFunction();
                    break;
                case 373: 
                    TestFunction();
                    break;
                case 374: 
                    TestFunction();
                    break;
                case 375: 
                    TestFunction();
                    break;
                case 376: 
                    TestFunction();
                    break;
                case 377: 
                    TestFunction();
                    break;
                case 378: 
                    TestFunction();
                    break;
                case 379: 
                    TestFunction();
                    break;
                case 380: 
                    TestFunction();
                    break;
                case 381: 
                    TestFunction();
                    break;
                case 382: 
                    TestFunction();
                    break;
                case 383: 
                    TestFunction();
                    break;
                case 384: 
                    TestFunction();
                    break;
                case 385: 
                    TestFunction();
                    break;
                case 386: 
                    TestFunction();
                    break;
                case 387: 
                    TestFunction();
                    break;
                case 388: 
                    TestFunction();
                    break;
                case 389: 
                    TestFunction();
                    break;
                case 390: 
                    TestFunction();
                    break;
                case 391: 
                    TestFunction();
                    break;
                case 392: 
                    TestFunction();
                    break;
                case 393: 
                    TestFunction();
                    break;
                case 394: 
                    TestFunction();
                    break;
                case 395: 
                    TestFunction();
                    break;
                case 396: 
                    TestFunction();
                    break;
                case 397: 
                    TestFunction();
                    break;
                case 398: 
                    TestFunction();
                    break;
                case 399: 
                    TestFunction();
                    break;
                case 400: 
                    TestFunction();
                    break;
                case 401: 
                    TestFunction();
                    break;
                case 402: 
                    TestFunction();
                    break;
                case 403: 
                    TestFunction();
                    break;
                case 404: 
                    TestFunction();
                    break;
                case 405: 
                    TestFunction();
                    break;
                case 406: 
                    TestFunction();
                    break;
                case 407: 
                    TestFunction();
                    break;
                case 408: 
                    TestFunction();
                    break;
                case 409: 
                    TestFunction();
                    break;
                case 410: 
                    TestFunction();
                    break;
                case 411: 
                    TestFunction();
                    break;
                case 412: 
                    TestFunction();
                    break;
                case 413: 
                    TestFunction();
                    break;
                case 414: 
                    TestFunction();
                    break;
                case 415: 
                    TestFunction();
                    break;
                case 416: 
                    TestFunction();
                    break;
                case 417: 
                    TestFunction();
                    break;
                case 418: 
                    TestFunction();
                    break;
                case 419: 
                    TestFunction();
                    break;
                case 420: 
                    TestFunction();
                    break;
                case 421: 
                    TestFunction();
                    break;
                case 422: 
                    TestFunction();
                    break;
                case 423: 
                    TestFunction();
                    break;
                case 424: 
                    TestFunction();
                    break;
                case 425: 
                    TestFunction();
                    break;
                case 426: 
                    TestFunction();
                    break;
                case 427: 
                    TestFunction();
                    break;
                case 428: 
                    TestFunction();
                    break;
                case 429: 
                    TestFunction();
                    break;
                case 430: 
                    TestFunction();
                    break;
                case 431: 
                    TestFunction();
                    break;
                case 432: 
                    TestFunction();
                    break;
                case 433: 
                    TestFunction();
                    break;
                case 434: 
                    TestFunction();
                    break;
                case 435: 
                    TestFunction();
                    break;
                case 436: 
                    TestFunction();
                    break;
                case 437: 
                    TestFunction();
                    break;
                case 438: 
                    TestFunction();
                    break;
                case 439: 
                    TestFunction();
                    break;
                case 440: 
                    TestFunction();
                    break;
                case 441: 
                    TestFunction();
                    break;
                case 442: 
                    TestFunction();
                    break;
                case 443: 
                    TestFunction();
                    break;
                case 444: 
                    TestFunction();
                    break;
                case 445: 
                    TestFunction();
                    break;
                case 446: 
                    TestFunction();
                    break;
                case 447: 
                    TestFunction();
                    break;
                case 448: 
                    TestFunction();
                    break;
                case 449: 
                    TestFunction();
                    break;
                case 450: 
                    TestFunction();
                    break;
                case 451: 
                    TestFunction();
                    break;
                case 452: 
                    TestFunction();
                    break;
                case 453: 
                    TestFunction();
                    break;
                case 454: 
                    TestFunction();
                    break;
                case 455: 
                    TestFunction();
                    break;
                case 456: 
                    TestFunction();
                    break;
                case 457: 
                    TestFunction();
                    break;
                case 458: 
                    TestFunction();
                    break;
                case 459: 
                    TestFunction();
                    break;
                case 460: 
                    TestFunction();
                    break;
                case 461: 
                    TestFunction();
                    break;
                case 462: 
                    TestFunction();
                    break;
                case 463: 
                    TestFunction();
                    break;
                case 464: 
                    TestFunction();
                    break;
                case 465: 
                    TestFunction();
                    break;
                case 466: 
                    TestFunction();
                    break;
                case 467: 
                    TestFunction();
                    break;
                case 468: 
                    TestFunction();
                    break;
                case 469: 
                    TestFunction();
                    break;
                case 470: 
                    TestFunction();
                    break;
                case 471: 
                    TestFunction();
                    break;
                case 472: 
                    TestFunction();
                    break;
                case 473: 
                    TestFunction();
                    break;
                case 474: 
                    TestFunction();
                    break;
                case 475: 
                    TestFunction();
                    break;
                case 476: 
                    TestFunction();
                    break;
                case 477: 
                    TestFunction();
                    break;
                case 478: 
                    TestFunction();
                    break;
                case 479: 
                    TestFunction();
                    break;
                case 480: 
                    TestFunction();
                    break;
                case 481: 
                    TestFunction();
                    break;
                case 482: 
                    TestFunction();
                    break;
                case 483: 
                    TestFunction();
                    break;
                case 484: 
                    TestFunction();
                    break;
                case 485: 
                    TestFunction();
                    break;
                case 486: 
                    TestFunction();
                    break;
                case 487: 
                    TestFunction();
                    break;
                case 488: 
                    TestFunction();
                    break;
                case 489: 
                    TestFunction();
                    break;
                case 490: 
                    TestFunction();
                    break;
                case 491: 
                    TestFunction();
                    break;
                case 492: 
                    TestFunction();
                    break;
                case 493: 
                    TestFunction();
                    break;
                case 494: 
                    TestFunction();
                    break;
                case 495: 
                    TestFunction();
                    break;
                case 496: 
                    TestFunction();
                    break;
                case 497: 
                    TestFunction();
                    break;
                case 498: 
                    TestFunction();
                    break;
                case 499: 
                    TestFunction();
                    break;
                case 500: 
                    TestFunction();
                    break;
                case 501: 
                    TestFunction();
                    break;
                case 502: 
                    TestFunction();
                    break;
                case 503: 
                    TestFunction();
                    break;
                case 504: 
                    TestFunction();
                    break;
                case 505: 
                    TestFunction();
                    break;
                case 506: 
                    TestFunction();
                    break;
                case 507: 
                    TestFunction();
                    break;
                case 508: 
                    TestFunction();
                    break;
                case 509: 
                    TestFunction();
                    break;
                case 510: 
                    TestFunction();
                    break;
                case 511: 
                    TestFunction();
                    break;
                case 512: 
                    TestFunction();
                    break;
                case 513: 
                    TestFunction();
                    break;
                case 514: 
                    TestFunction();
                    break;
                case 515: 
                    TestFunction();
                    break;
                case 516: 
                    TestFunction();
                    break;
                case 517: 
                    TestFunction();
                    break;
                case 518: 
                    TestFunction();
                    break;
                case 519: 
                    TestFunction();
                    break;
                case 520: 
                    TestFunction();
                    break;
                case 521: 
                    TestFunction();
                    break;
                case 522: 
                    TestFunction();
                    break;
                case 523: 
                    TestFunction();
                    break;
                case 524: 
                    TestFunction();
                    break;
                case 525: 
                    TestFunction();
                    break;
                case 526: 
                    TestFunction();
                    break;
                case 527: 
                    TestFunction();
                    break;
                case 528: 
                    TestFunction();
                    break;
                case 529: 
                    TestFunction();
                    break;
                case 530: 
                    TestFunction();
                    break;
                case 531: 
                    TestFunction();
                    break;
                case 532: 
                    TestFunction();
                    break;
                case 533: 
                    TestFunction();
                    break;
                case 534: 
                    TestFunction();
                    break;
                case 535: 
                    TestFunction();
                    break;
                case 536: 
                    TestFunction();
                    break;
                case 537: 
                    TestFunction();
                    break;
                case 538: 
                    TestFunction();
                    break;
                case 539: 
                    TestFunction();
                    break;
                case 540: 
                    TestFunction();
                    break;
                case 541: 
                    TestFunction();
                    break;
                case 542: 
                    TestFunction();
                    break;
                case 543: 
                    TestFunction();
                    break;
                case 544: 
                    TestFunction();
                    break;
                case 545: 
                    TestFunction();
                    break;
                case 546: 
                    TestFunction();
                    break;
                case 547: 
                    TestFunction();
                    break;
                case 548: 
                    TestFunction();
                    break;
                case 549: 
                    TestFunction();
                    break;
                case 550: 
                    TestFunction();
                    break;
                case 551: 
                    TestFunction();
                    break;
                case 552: 
                    TestFunction();
                    break;
                case 553: 
                    TestFunction();
                    break;
                case 554: 
                    TestFunction();
                    break;
                case 555: 
                    TestFunction();
                    break;
                case 556: 
                    TestFunction();
                    break;
                case 557: 
                    TestFunction();
                    break;
                case 558: 
                    TestFunction();
                    break;
                case 559: 
                    TestFunction();
                    break;
                case 560: 
                    TestFunction();
                    break;
                case 561: 
                    TestFunction();
                    break;
                case 562: 
                    TestFunction();
                    break;
                case 563: 
                    TestFunction();
                    break;
                case 564: 
                    TestFunction();
                    break;
                case 565: 
                    TestFunction();
                    break;
                case 566: 
                    TestFunction();
                    break;
                case 567: 
                    TestFunction();
                    break;
                case 568: 
                    TestFunction();
                    break;
                case 569: 
                    TestFunction();
                    break;
                case 570: 
                    TestFunction();
                    break;
                case 571: 
                    TestFunction();
                    break;
                case 572: 
                    TestFunction();
                    break;
                case 573: 
                    TestFunction();
                    break;
                case 574: 
                    TestFunction();
                    break;
                case 575: 
                    TestFunction();
                    break;
                case 576: 
                    TestFunction();
                    break;
                case 577: 
                    TestFunction();
                    break;
                case 578: 
                    TestFunction();
                    break;
                case 579: 
                    TestFunction();
                    break;
                case 580: 
                    TestFunction();
                    break;
                case 581: 
                    TestFunction();
                    break;
                case 582: 
                    TestFunction();
                    break;
                case 583: 
                    TestFunction();
                    break;
                case 584: 
                    TestFunction();
                    break;
                case 585: 
                    TestFunction();
                    break;
                case 586: 
                    TestFunction();
                    break;
                case 587: 
                    TestFunction();
                    break;
                case 588: 
                    TestFunction();
                    break;
                case 589: 
                    TestFunction();
                    break;
                case 590: 
                    TestFunction();
                    break;
                case 591: 
                    TestFunction();
                    break;
                case 592: 
                    TestFunction();
                    break;
                case 593: 
                    TestFunction();
                    break;
                case 594: 
                    TestFunction();
                    break;
                case 595: 
                    TestFunction();
                    break;
                case 596: 
                    TestFunction();
                    break;
                case 597: 
                    TestFunction();
                    break;
                case 598: 
                    TestFunction();
                    break;
                case 599: 
                    TestFunction();
                    break;
                case 600: 
                    TestFunction();
                    break;
                case 601: 
                    TestFunction();
                    break;
                case 602: 
                    TestFunction();
                    break;
                case 603: 
                    TestFunction();
                    break;
                case 604: 
                    TestFunction();
                    break;
                case 605: 
                    TestFunction();
                    break;
                case 606: 
                    TestFunction();
                    break;
                case 607: 
                    TestFunction();
                    break;
                case 608: 
                    TestFunction();
                    break;
                case 609: 
                    TestFunction();
                    break;
                case 610: 
                    TestFunction();
                    break;
                case 611: 
                    TestFunction();
                    break;
                case 612: 
                    TestFunction();
                    break;
                case 613: 
                    TestFunction();
                    break;
                case 614: 
                    TestFunction();
                    break;
                case 615: 
                    TestFunction();
                    break;
                case 616: 
                    TestFunction();
                    break;
                case 617: 
                    TestFunction();
                    break;
                case 618: 
                    TestFunction();
                    break;
                case 619: 
                    TestFunction();
                    break;
                case 620: 
                    TestFunction();
                    break;
                case 621: 
                    TestFunction();
                    break;
                case 622: 
                    TestFunction();
                    break;
                case 623: 
                    TestFunction();
                    break;
                case 624: 
                    TestFunction();
                    break;
                case 625: 
                    TestFunction();
                    break;
                case 626: 
                    TestFunction();
                    break;
                case 627: 
                    TestFunction();
                    break;
                case 628: 
                    TestFunction();
                    break;
                case 629: 
                    TestFunction();
                    break;
                case 630: 
                    TestFunction();
                    break;
                case 631: 
                    TestFunction();
                    break;
                case 632: 
                    TestFunction();
                    break;
                case 633: 
                    TestFunction();
                    break;
                case 634: 
                    TestFunction();
                    break;
                case 635: 
                    TestFunction();
                    break;
                case 636: 
                    TestFunction();
                    break;
                case 637: 
                    TestFunction();
                    break;
                case 638: 
                    TestFunction();
                    break;
                case 639: 
                    TestFunction();
                    break;
                case 640: 
                    TestFunction();
                    break;
                case 641: 
                    TestFunction();
                    break;
                case 642: 
                    TestFunction();
                    break;
                case 643: 
                    TestFunction();
                    break;
                case 644: 
                    TestFunction();
                    break;
                case 645: 
                    TestFunction();
                    break;
                case 646: 
                    TestFunction();
                    break;
                case 647: 
                    TestFunction();
                    break;
                case 648: 
                    TestFunction();
                    break;
                case 649: 
                    TestFunction();
                    break;
                case 650: 
                    TestFunction();
                    break;
                case 651: 
                    TestFunction();
                    break;
                case 652: 
                    TestFunction();
                    break;
                case 653: 
                    TestFunction();
                    break;
                case 654: 
                    TestFunction();
                    break;
                case 655: 
                    TestFunction();
                    break;
                case 656: 
                    TestFunction();
                    break;
                case 657: 
                    TestFunction();
                    break;
                case 658: 
                    TestFunction();
                    break;
                case 659: 
                    TestFunction();
                    break;
                case 660: 
                    TestFunction();
                    break;
                case 661: 
                    TestFunction();
                    break;
                case 662: 
                    TestFunction();
                    break;
                case 663: 
                    TestFunction();
                    break;
                case 664: 
                    TestFunction();
                    break;
                case 665: 
                    TestFunction();
                    break;
                case 666: 
                    TestFunction();
                    break;
                case 667: 
                    TestFunction();
                    break;
                case 668: 
                    TestFunction();
                    break;
                case 669: 
                    TestFunction();
                    break;
                case 670: 
                    TestFunction();
                    break;
                case 671: 
                    TestFunction();
                    break;
                case 672: 
                    TestFunction();
                    break;
                case 673: 
                    TestFunction();
                    break;
                case 674: 
                    TestFunction();
                    break;
                case 675: 
                    TestFunction();
                    break;
                case 676: 
                    TestFunction();
                    break;
                case 677: 
                    TestFunction();
                    break;
                case 678: 
                    TestFunction();
                    break;
                case 679: 
                    TestFunction();
                    break;
                case 680: 
                    TestFunction();
                    break;
                case 681: 
                    TestFunction();
                    break;
                case 682: 
                    TestFunction();
                    break;
                case 683: 
                    TestFunction();
                    break;
                case 684: 
                    TestFunction();
                    break;
                case 685: 
                    TestFunction();
                    break;
                case 686: 
                    TestFunction();
                    break;
                case 687: 
                    TestFunction();
                    break;
                case 688: 
                    TestFunction();
                    break;
                case 689: 
                    TestFunction();
                    break;
                case 690: 
                    TestFunction();
                    break;
                case 691: 
                    TestFunction();
                    break;
                case 692: 
                    TestFunction();
                    break;
                case 693: 
                    TestFunction();
                    break;
                case 694: 
                    TestFunction();
                    break;
                case 695: 
                    TestFunction();
                    break;
                case 696: 
                    TestFunction();
                    break;
                case 697: 
                    TestFunction();
                    break;
                case 698: 
                    TestFunction();
                    break;
                case 699: 
                    TestFunction();
                    break;
                case 700: 
                    TestFunction();
                    break;
                case 701: 
                    TestFunction();
                    break;
                case 702: 
                    TestFunction();
                    break;
                case 703: 
                    TestFunction();
                    break;
                case 704: 
                    TestFunction();
                    break;
                case 705: 
                    TestFunction();
                    break;
                case 706: 
                    TestFunction();
                    break;
                case 707: 
                    TestFunction();
                    break;
                case 708: 
                    TestFunction();
                    break;
                case 709: 
                    TestFunction();
                    break;
                case 710: 
                    TestFunction();
                    break;
                case 711: 
                    TestFunction();
                    break;
                case 712: 
                    TestFunction();
                    break;
                case 713: 
                    TestFunction();
                    break;
                case 714: 
                    TestFunction();
                    break;
                case 715: 
                    TestFunction();
                    break;
                case 716: 
                    TestFunction();
                    break;
                case 717: 
                    TestFunction();
                    break;
                case 718: 
                    TestFunction();
                    break;
                case 719: 
                    TestFunction();
                    break;
                case 720: 
                    TestFunction();
                    break;
                case 721: 
                    TestFunction();
                    break;
                case 722: 
                    TestFunction();
                    break;
                case 723: 
                    TestFunction();
                    break;
                case 724: 
                    TestFunction();
                    break;
                case 725: 
                    TestFunction();
                    break;
                case 726: 
                    TestFunction();
                    break;
                case 727: 
                    TestFunction();
                    break;
                case 728: 
                    TestFunction();
                    break;
                case 729: 
                    TestFunction();
                    break;
                case 730: 
                    TestFunction();
                    break;
                case 731: 
                    TestFunction();
                    break;
                case 732: 
                    TestFunction();
                    break;
                case 733: 
                    TestFunction();
                    break;
                case 734: 
                    TestFunction();
                    break;
                case 735: 
                    TestFunction();
                    break;
                case 736: 
                    TestFunction();
                    break;
                case 737: 
                    TestFunction();
                    break;
                case 738: 
                    TestFunction();
                    break;
                case 739: 
                    TestFunction();
                    break;
                case 740: 
                    TestFunction();
                    break;
                case 741: 
                    TestFunction();
                    break;
                case 742: 
                    TestFunction();
                    break;
                case 743: 
                    TestFunction();
                    break;
                case 744: 
                    TestFunction();
                    break;
                case 745: 
                    TestFunction();
                    break;
                case 746: 
                    TestFunction();
                    break;
                case 747: 
                    TestFunction();
                    break;
                case 748: 
                    TestFunction();
                    break;
                case 749: 
                    TestFunction();
                    break;
                case 750: 
                    TestFunction();
                    break;
                case 751: 
                    TestFunction();
                    break;
                case 752: 
                    TestFunction();
                    break;
                case 753: 
                    TestFunction();
                    break;
                case 754: 
                    TestFunction();
                    break;
                case 755: 
                    TestFunction();
                    break;
                case 756: 
                    TestFunction();
                    break;
                case 757: 
                    TestFunction();
                    break;
                case 758: 
                    TestFunction();
                    break;
                case 759: 
                    TestFunction();
                    break;
                case 760: 
                    TestFunction();
                    break;
                case 761: 
                    TestFunction();
                    break;
                case 762: 
                    TestFunction();
                    break;
                case 763: 
                    TestFunction();
                    break;
                case 764: 
                    TestFunction();
                    break;
                case 765: 
                    TestFunction();
                    break;
                case 766: 
                    TestFunction();
                    break;
                case 767: 
                    TestFunction();
                    break;
                case 768: 
                    TestFunction();
                    break;
                case 769: 
                    TestFunction();
                    break;
                case 770: 
                    TestFunction();
                    break;
                case 771: 
                    TestFunction();
                    break;
                case 772: 
                    TestFunction();
                    break;
                case 773: 
                    TestFunction();
                    break;
                case 774: 
                    TestFunction();
                    break;
                case 775: 
                    TestFunction();
                    break;
                case 776: 
                    TestFunction();
                    break;
                case 777: 
                    TestFunction();
                    break;
                case 778: 
                    TestFunction();
                    break;
                case 779: 
                    TestFunction();
                    break;
                case 780: 
                    TestFunction();
                    break;
                case 781: 
                    TestFunction();
                    break;
                case 782: 
                    TestFunction();
                    break;
                case 783: 
                    TestFunction();
                    break;
                case 784: 
                    TestFunction();
                    break;
                case 785: 
                    TestFunction();
                    break;
                case 786: 
                    TestFunction();
                    break;
                case 787: 
                    TestFunction();
                    break;
                case 788: 
                    TestFunction();
                    break;
                case 789: 
                    TestFunction();
                    break;
                case 790: 
                    TestFunction();
                    break;
                case 791: 
                    TestFunction();
                    break;
                case 792: 
                    TestFunction();
                    break;
                case 793: 
                    TestFunction();
                    break;
                case 794: 
                    TestFunction();
                    break;
                case 795: 
                    TestFunction();
                    break;
                case 796: 
                    TestFunction();
                    break;
                case 797: 
                    TestFunction();
                    break;
                case 798: 
                    TestFunction();
                    break;
                case 799: 
                    TestFunction();
                    break;
                case 800: 
                    TestFunction();
                    break;
                case 801: 
                    TestFunction();
                    break;
                case 802: 
                    TestFunction();
                    break;
                case 803: 
                    TestFunction();
                    break;
                case 804: 
                    TestFunction();
                    break;
                case 805: 
                    TestFunction();
                    break;
                case 806: 
                    TestFunction();
                    break;
                case 807: 
                    TestFunction();
                    break;
                case 808: 
                    TestFunction();
                    break;
                case 809: 
                    TestFunction();
                    break;
                case 810: 
                    TestFunction();
                    break;
                case 811: 
                    TestFunction();
                    break;
                case 812: 
                    TestFunction();
                    break;
                case 813: 
                    TestFunction();
                    break;
                case 814: 
                    TestFunction();
                    break;
                case 815: 
                    TestFunction();
                    break;
                case 816: 
                    TestFunction();
                    break;
                case 817: 
                    TestFunction();
                    break;
                case 818: 
                    TestFunction();
                    break;
                case 819: 
                    TestFunction();
                    break;
                case 820: 
                    TestFunction();
                    break;
                case 821: 
                    TestFunction();
                    break;
                case 822: 
                    TestFunction();
                    break;
                case 823: 
                    TestFunction();
                    break;
                case 824: 
                    TestFunction();
                    break;
                case 825: 
                    TestFunction();
                    break;
                case 826: 
                    TestFunction();
                    break;
                case 827: 
                    TestFunction();
                    break;
                case 828: 
                    TestFunction();
                    break;
                case 829: 
                    TestFunction();
                    break;
                case 830: 
                    TestFunction();
                    break;
                case 831: 
                    TestFunction();
                    break;
                case 832: 
                    TestFunction();
                    break;
                case 833: 
                    TestFunction();
                    break;
                case 834: 
                    TestFunction();
                    break;
                case 835: 
                    TestFunction();
                    break;
                case 836: 
                    TestFunction();
                    break;
                case 837: 
                    TestFunction();
                    break;
                case 838: 
                    TestFunction();
                    break;
                case 839: 
                    TestFunction();
                    break;
                case 840: 
                    TestFunction();
                    break;
                case 841: 
                    TestFunction();
                    break;
                case 842: 
                    TestFunction();
                    break;
                case 843: 
                    TestFunction();
                    break;
                case 844: 
                    TestFunction();
                    break;
                case 845: 
                    TestFunction();
                    break;
                case 846: 
                    TestFunction();
                    break;
                case 847: 
                    TestFunction();
                    break;
                case 848: 
                    TestFunction();
                    break;
                case 849: 
                    TestFunction();
                    break;
                case 850: 
                    TestFunction();
                    break;
                case 851: 
                    TestFunction();
                    break;
                case 852: 
                    TestFunction();
                    break;
                case 853: 
                    TestFunction();
                    break;
                case 854: 
                    TestFunction();
                    break;
                case 855: 
                    TestFunction();
                    break;
                case 856: 
                    TestFunction();
                    break;
                case 857: 
                    TestFunction();
                    break;
                case 858: 
                    TestFunction();
                    break;
                case 859: 
                    TestFunction();
                    break;
                case 860: 
                    TestFunction();
                    break;
                case 861: 
                    TestFunction();
                    break;
                case 862: 
                    TestFunction();
                    break;
                case 863: 
                    TestFunction();
                    break;
                case 864: 
                    TestFunction();
                    break;
                case 865: 
                    TestFunction();
                    break;
                case 866: 
                    TestFunction();
                    break;
                case 867: 
                    TestFunction();
                    break;
                case 868: 
                    TestFunction();
                    break;
                case 869: 
                    TestFunction();
                    break;
                case 870: 
                    TestFunction();
                    break;
                case 871: 
                    TestFunction();
                    break;
                case 872: 
                    TestFunction();
                    break;
                case 873: 
                    TestFunction();
                    break;
                case 874: 
                    TestFunction();
                    break;
                case 875: 
                    TestFunction();
                    break;
                case 876: 
                    TestFunction();
                    break;
                case 877: 
                    TestFunction();
                    break;
                case 878: 
                    TestFunction();
                    break;
                case 879: 
                    TestFunction();
                    break;
                case 880: 
                    TestFunction();
                    break;
                case 881: 
                    TestFunction();
                    break;
                case 882: 
                    TestFunction();
                    break;
                case 883: 
                    TestFunction();
                    break;
                case 884: 
                    TestFunction();
                    break;
                case 885: 
                    TestFunction();
                    break;
                case 886: 
                    TestFunction();
                    break;
                case 887: 
                    TestFunction();
                    break;
                case 888: 
                    TestFunction();
                    break;
                case 889: 
                    TestFunction();
                    break;
                case 890: 
                    TestFunction();
                    break;
                case 891: 
                    TestFunction();
                    break;
                case 892: 
                    TestFunction();
                    break;
                case 893: 
                    TestFunction();
                    break;
                case 894: 
                    TestFunction();
                    break;
                case 895: 
                    TestFunction();
                    break;
                case 896: 
                    TestFunction();
                    break;
                case 897: 
                    TestFunction();
                    break;
                case 898: 
                    TestFunction();
                    break;
                case 899: 
                    TestFunction();
                    break;
                case 900: 
                    TestFunction();
                    break;
                case 901: 
                    TestFunction();
                    break;
                case 902: 
                    TestFunction();
                    break;
                case 903: 
                    TestFunction();
                    break;
                case 904: 
                    TestFunction();
                    break;
                case 905: 
                    TestFunction();
                    break;
                case 906: 
                    TestFunction();
                    break;
                case 907: 
                    TestFunction();
                    break;
                case 908: 
                    TestFunction();
                    break;
                case 909: 
                    TestFunction();
                    break;
                case 910: 
                    TestFunction();
                    break;
                case 911: 
                    TestFunction();
                    break;
                case 912: 
                    TestFunction();
                    break;
                case 913: 
                    TestFunction();
                    break;
                case 914: 
                    TestFunction();
                    break;
                case 915: 
                    TestFunction();
                    break;
                case 916: 
                    TestFunction();
                    break;
                case 917: 
                    TestFunction();
                    break;
                case 918: 
                    TestFunction();
                    break;
                case 919: 
                    TestFunction();
                    break;
                case 920: 
                    TestFunction();
                    break;
                case 921: 
                    TestFunction();
                    break;
                case 922: 
                    TestFunction();
                    break;
                case 923: 
                    TestFunction();
                    break;
                case 924: 
                    TestFunction();
                    break;
                case 925: 
                    TestFunction();
                    break;
                case 926: 
                    TestFunction();
                    break;
                case 927: 
                    TestFunction();
                    break;
                case 928: 
                    TestFunction();
                    break;
                case 929: 
                    TestFunction();
                    break;
                case 930: 
                    TestFunction();
                    break;
                case 931: 
                    TestFunction();
                    break;
                case 932: 
                    TestFunction();
                    break;
                case 933: 
                    TestFunction();
                    break;
                case 934: 
                    TestFunction();
                    break;
                case 935: 
                    TestFunction();
                    break;
                case 936: 
                    TestFunction();
                    break;
                case 937: 
                    TestFunction();
                    break;
                case 938: 
                    TestFunction();
                    break;
                case 939: 
                    TestFunction();
                    break;
                case 940: 
                    TestFunction();
                    break;
                case 941: 
                    TestFunction();
                    break;
                case 942: 
                    TestFunction();
                    break;
                case 943: 
                    TestFunction();
                    break;
                case 944: 
                    TestFunction();
                    break;
                case 945: 
                    TestFunction();
                    break;
                case 946: 
                    TestFunction();
                    break;
                case 947: 
                    TestFunction();
                    break;
                case 948: 
                    TestFunction();
                    break;
                case 949: 
                    TestFunction();
                    break;
                case 950: 
                    TestFunction();
                    break;
                case 951: 
                    TestFunction();
                    break;
                case 952: 
                    TestFunction();
                    break;
                case 953: 
                    TestFunction();
                    break;
                case 954: 
                    TestFunction();
                    break;
                case 955: 
                    TestFunction();
                    break;
                case 956: 
                    TestFunction();
                    break;
                case 957: 
                    TestFunction();
                    break;
                case 958: 
                    TestFunction();
                    break;
                case 959: 
                    TestFunction();
                    break;
                case 960: 
                    TestFunction();
                    break;
                case 961: 
                    TestFunction();
                    break;
                case 962: 
                    TestFunction();
                    break;
                case 963: 
                    TestFunction();
                    break;
                case 964: 
                    TestFunction();
                    break;
                case 965: 
                    TestFunction();
                    break;
                case 966: 
                    TestFunction();
                    break;
                case 967: 
                    TestFunction();
                    break;
                case 968: 
                    TestFunction();
                    break;
                case 969: 
                    TestFunction();
                    break;
                case 970: 
                    TestFunction();
                    break;
                case 971: 
                    TestFunction();
                    break;
                case 972: 
                    TestFunction();
                    break;
                case 973: 
                    TestFunction();
                    break;
                case 974: 
                    TestFunction();
                    break;
                case 975: 
                    TestFunction();
                    break;
                case 976: 
                    TestFunction();
                    break;
                case 977: 
                    TestFunction();
                    break;
                case 978: 
                    TestFunction();
                    break;
                case 979: 
                    TestFunction();
                    break;
                case 980: 
                    TestFunction();
                    break;
                case 981: 
                    TestFunction();
                    break;
                case 982: 
                    TestFunction();
                    break;
                case 983: 
                    TestFunction();
                    break;
                case 984: 
                    TestFunction();
                    break;
                case 985: 
                    TestFunction();
                    break;
                case 986: 
                    TestFunction();
                    break;
                case 987: 
                    TestFunction();
                    break;
                case 988: 
                    TestFunction();
                    break;
                case 989: 
                    TestFunction();
                    break;
                case 990: 
                    TestFunction();
                    break;
                case 991: 
                    TestFunction();
                    break;
                case 992: 
                    TestFunction();
                    break;
                case 993: 
                    TestFunction();
                    break;
                case 994: 
                    TestFunction();
                    break;
                case 995: 
                    TestFunction();
                    break;
                case 996: 
                    TestFunction();
                    break;
                case 997: 
                    TestFunction();
                    break;
                case 998: 
                    TestFunction();
                    break;
                case 999: 
                    TestFunction();
                    break;
                case 1000: 
                    TestFunction();
                    break;
                case 1001: 
                    TestFunction();
                    break;
                case 1002: 
                    TestFunction();
                    break;
                case 1003: 
                    TestFunction();
                    break;
                case 1004: 
                    TestFunction();
                    break;
                case 1005: 
                    TestFunction();
                    break;
                case 1006: 
                    TestFunction();
                    break;
                case 1007: 
                    TestFunction();
                    break;
                case 1008: 
                    TestFunction();
                    break;
                case 1009: 
                    TestFunction();
                    break;
                case 1010: 
                    TestFunction();
                    break;
                case 1011: 
                    TestFunction();
                    break;
                case 1012: 
                    TestFunction();
                    break;
                case 1013: 
                    TestFunction();
                    break;
                case 1014: 
                    TestFunction();
                    break;
                case 1015: 
                    TestFunction();
                    break;
                case 1016: 
                    TestFunction();
                    break;
                case 1017: 
                    TestFunction();
                    break;
                case 1018: 
                    TestFunction();
                    break;
                case 1019: 
                    TestFunction();
                    break;
                case 1020: 
                    TestFunction();
                    break;
                case 1021: 
                    TestFunction();
                    break;
                case 1022: 
                    TestFunction();
                    break;
                case 1023: 
                    TestFunction();
                    break;

            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Cons 6: " + stopWatch.Elapsed.TotalMilliseconds);
    }
}


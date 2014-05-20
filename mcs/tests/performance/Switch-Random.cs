using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class RandomSuite
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

    public static void Test1(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {65, 19, 7, 73};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (4)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
            case 65:
                TestFunction();
                break;
            case 19:
                TestFunction();
                break;
            case 7:
                TestFunction();
                break;
            case 73:
                TestFunction();
                break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #1: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test2(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] {65, 19, 7, 73, 71, 62, 51, 18};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (8)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 65:
                    TestFunction();
                    break;
                case 19:
                    TestFunction();
                    break;
                case 7:
                    TestFunction();
                    break;
                case 73:
                    TestFunction();
                    break;
                case 71:
                    TestFunction();
                    break;
                case 62:
                    TestFunction();
                    break;
                case 51:
                    TestFunction();
                    break;
                case 18:
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #2: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test3(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] { 617, 389, 231, 644, 868, 614, 491, 649,
                                  604, 713, 184, 183,  56, 362, 628, 804};
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = input[rand.Next (16)];
        }

        long length = numbers.Length;

        Stopwatch stopWatch = new Stopwatch();

        // Stopwatch is used here since it is more accurate than Datetime
        stopWatch.Start();

        for (int j = 0; j < length; j++) {
            switch (numbers [j]) {
                case 617: 
                    TestFunction();
                    break;
                case 389: 
                    TestFunction();
                    break;
                case 231: 
                    TestFunction();
                    break;
                case 644: 
                    TestFunction();
                    break;
                case 868: 
                    TestFunction();
                    break;
                case 614: 
                    TestFunction();
                    break;
                case 491: 
                    TestFunction();
                    break;
                case 649: 
                    TestFunction();
                    break;
                case 604: 
                    TestFunction();
                    break;
                case 713: 
                    TestFunction();
                    break;
                case 184: 
                    TestFunction();
                    break;
                case 183: 
                    TestFunction();
                    break;
                case 56: 
                    TestFunction();
                    break;
                case 362: 
                    TestFunction();
                    break;
                case 628: 
                    TestFunction();
                    break;
                case 804: 
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #3: " + stopWatch.Elapsed.TotalMilliseconds);
    }

    public static void Test4(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] { 750,641,668,674,679,909,610,333,
                                  16,200,548,825,731,203,367,461,
                                  422,462,845,296,578,780,661,66,
                                  303,732,644,327,144,612,692,826};
        
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
                case 750: 
                    TestFunction();
                    break;
                case 641: 
                    TestFunction();
                    break;
                case 668: 
                    TestFunction();
                    break;
                case 674: 
                    TestFunction();
                    break;
                case 679: 
                    TestFunction();
                    break;
                case 909: 
                    TestFunction();
                    break;
                case 610: 
                    TestFunction();
                    break;
                case 333: 
                    TestFunction();
                    break;
                case 16: 
                    TestFunction();
                    break;
                case 200: 
                    TestFunction();
                    break;
                case 548: 
                    TestFunction();
                    break;
                case 825: 
                    TestFunction();
                    break;
                case 731: 
                    TestFunction();
                    break;
                case 203: 
                    TestFunction();
                    break;
                case 367: 
                    TestFunction();
                    break;
                case 461: 
                    TestFunction();
                    break;
                case 422: 
                    TestFunction();
                    break;
                case 462: 
                    TestFunction();
                    break;
                case 845: 
                    TestFunction();
                    break;
                case 296: 
                    TestFunction();
                    break;
                case 578: 
                    TestFunction();
                    break;
                case 780: 
                    TestFunction();
                    break;
                case 661: 
                    TestFunction();
                    break;
                case 66: 
                    TestFunction();
                    break;
                case 303: 
                    TestFunction();
                    break;
                case 732: 
                    TestFunction();
                    break;
                case 644: 
                    TestFunction();
                    break;
                case 327: 
                    TestFunction();
                    break;
                case 144: 
                    TestFunction();
                    break;
                case 612: 
                    TestFunction();
                    break;
                case 692: 
                    TestFunction();
                    break;
                case 826: 
                    TestFunction();
                    break;

            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #4: " + stopWatch.Elapsed.TotalMilliseconds);   
    }

    public static void Test5(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] { 42405,52988,60083,17918,95711,87959,96731,53823,85735,59548,45274,30456,25690,94009,45596,39796,54391,98124,63362,75628,39020,96057,13625,96336,10369,74275,20137,65533,83517,37700,8239,36013,73765,29394,32514,93822,82599,17867,68984,62393,39127,84467,71408,26966,62113,56581,13349,98572,88865,80633,49307,61513,81218,45244,23438,46347,39362,63747,7549,21435,67822,31198,70305,48034,51308,9260,56690,96295,61495,51774,57197,36524,29140,969,36501,54552,24649,86658,34222,53788,60926,21565,76668,2884,88392,46726,54795,28521,5956,86166,54459,18851,10318,47548,94571,7929,14161,23373,75657,52853,99890,17053,37077,37090,23436,12783,32373,80248,8743,68886,21698,52703,29525,53760,60509,46257,54530,67421,59642,4582,54464,28168,90339,75328,97315,38346,26206,81591};
        
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
                case 42405: 
                    TestFunction();
                    break;
                case 52988: 
                    TestFunction();
                    break;
                case 60083: 
                    TestFunction();
                    break;
                case 17918: 
                    TestFunction();
                    break;
                case 95711: 
                    TestFunction();
                    break;
                case 87959: 
                    TestFunction();
                    break;
                case 96731: 
                    TestFunction();
                    break;
                case 53823: 
                    TestFunction();
                    break;
                case 85735: 
                    TestFunction();
                    break;
                case 59548: 
                    TestFunction();
                    break;
                case 45274: 
                    TestFunction();
                    break;
                case 30456: 
                    TestFunction();
                    break;
                case 25690: 
                    TestFunction();
                    break;
                case 94009: 
                    TestFunction();
                    break;
                case 45596: 
                    TestFunction();
                    break;
                case 39796: 
                    TestFunction();
                    break;
                case 54391: 
                    TestFunction();
                    break;
                case 98124: 
                    TestFunction();
                    break;
                case 63362: 
                    TestFunction();
                    break;
                case 75628: 
                    TestFunction();
                    break;
                case 39020: 
                    TestFunction();
                    break;
                case 96057: 
                    TestFunction();
                    break;
                case 13625: 
                    TestFunction();
                    break;
                case 96336: 
                    TestFunction();
                    break;
                case 10369: 
                    TestFunction();
                    break;
                case 74275: 
                    TestFunction();
                    break;
                case 20137: 
                    TestFunction();
                    break;
                case 65533: 
                    TestFunction();
                    break;
                case 83517: 
                    TestFunction();
                    break;
                case 37700: 
                    TestFunction();
                    break;
                case 8239: 
                    TestFunction();
                    break;
                case 36013: 
                    TestFunction();
                    break;
                case 73765: 
                    TestFunction();
                    break;
                case 29394: 
                    TestFunction();
                    break;
                case 32514: 
                    TestFunction();
                    break;
                case 93822: 
                    TestFunction();
                    break;
                case 82599: 
                    TestFunction();
                    break;
                case 17867: 
                    TestFunction();
                    break;
                case 68984: 
                    TestFunction();
                    break;
                case 62393: 
                    TestFunction();
                    break;
                case 39127: 
                    TestFunction();
                    break;
                case 84467: 
                    TestFunction();
                    break;
                case 71408: 
                    TestFunction();
                    break;
                case 26966: 
                    TestFunction();
                    break;
                case 62113: 
                    TestFunction();
                    break;
                case 56581: 
                    TestFunction();
                    break;
                case 13349: 
                    TestFunction();
                    break;
                case 98572: 
                    TestFunction();
                    break;
                case 88865: 
                    TestFunction();
                    break;
                case 80633: 
                    TestFunction();
                    break;
                case 49307: 
                    TestFunction();
                    break;
                case 61513: 
                    TestFunction();
                    break;
                case 81218: 
                    TestFunction();
                    break;
                case 45244: 
                    TestFunction();
                    break;
                case 23438: 
                    TestFunction();
                    break;
                case 46347: 
                    TestFunction();
                    break;
                case 39362: 
                    TestFunction();
                    break;
                case 63747: 
                    TestFunction();
                    break;
                case 7549: 
                    TestFunction();
                    break;
                case 21435: 
                    TestFunction();
                    break;
                case 67822: 
                    TestFunction();
                    break;
                case 31198: 
                    TestFunction();
                    break;
                case 70305: 
                    TestFunction();
                    break;
                case 48034: 
                    TestFunction();
                    break;
                case 51308: 
                    TestFunction();
                    break;
                case 9260: 
                    TestFunction();
                    break;
                case 56690: 
                    TestFunction();
                    break;
                case 96295: 
                    TestFunction();
                    break;
                case 61495: 
                    TestFunction();
                    break;
                case 51774: 
                    TestFunction();
                    break;
                case 57197: 
                    TestFunction();
                    break;
                case 36524: 
                    TestFunction();
                    break;
                case 29140: 
                    TestFunction();
                    break;
                case 969: 
                    TestFunction();
                    break;
                case 36501: 
                    TestFunction();
                    break;
                case 54552: 
                    TestFunction();
                    break;
                case 24649: 
                    TestFunction();
                    break;
                case 86658: 
                    TestFunction();
                    break;
                case 34222: 
                    TestFunction();
                    break;
                case 53788: 
                    TestFunction();
                    break;
                case 60926: 
                    TestFunction();
                    break;
                case 21565: 
                    TestFunction();
                    break;
                case 76668: 
                    TestFunction();
                    break;
                case 2884: 
                    TestFunction();
                    break;
                case 88392: 
                    TestFunction();
                    break;
                case 46726: 
                    TestFunction();
                    break;
                case 54795: 
                    TestFunction();
                    break;
                case 28521: 
                    TestFunction();
                    break;
                case 5956: 
                    TestFunction();
                    break;
                case 86166: 
                    TestFunction();
                    break;
                case 54459: 
                    TestFunction();
                    break;
                case 18851: 
                    TestFunction();
                    break;
                case 10318: 
                    TestFunction();
                    break;
                case 47548: 
                    TestFunction();
                    break;
                case 94571: 
                    TestFunction();
                    break;
                case 7929: 
                    TestFunction();
                    break;
                case 14161: 
                    TestFunction();
                    break;
                case 23373: 
                    TestFunction();
                    break;
                case 75657: 
                    TestFunction();
                    break;
                case 52853: 
                    TestFunction();
                    break;
                case 99890: 
                    TestFunction();
                    break;
                case 17053: 
                    TestFunction();
                    break;
                case 37077: 
                    TestFunction();
                    break;
                case 37090: 
                    TestFunction();
                    break;
                case 23436: 
                    TestFunction();
                    break;
                case 12783: 
                    TestFunction();
                    break;
                case 32373: 
                    TestFunction();
                    break;
                case 80248: 
                    TestFunction();
                    break;
                case 8743: 
                    TestFunction();
                    break;
                case 68886: 
                    TestFunction();
                    break;
                case 21698: 
                    TestFunction();
                    break;
                case 52703: 
                    TestFunction();
                    break;
                case 29525: 
                    TestFunction();
                    break;
                case 53760: 
                    TestFunction();
                    break;
                case 60509: 
                    TestFunction();
                    break;
                case 46257: 
                    TestFunction();
                    break;
                case 54530: 
                    TestFunction();
                    break;
                case 67421: 
                    TestFunction();
                    break;
                case 59642: 
                    TestFunction();
                    break;
                case 4582: 
                    TestFunction();
                    break;
                case 54464: 
                    TestFunction();
                    break;
                case 28168: 
                    TestFunction();
                    break;
                case 90339: 
                    TestFunction();
                    break;
                case 75328: 
                    TestFunction();
                    break;
                case 97315: 
                    TestFunction();
                    break;
                case 38346: 
                    TestFunction();
                    break;
                case 26206: 
                    TestFunction();
                    break;
                case 81591: 
                    TestFunction();
                    break;
            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #5: " + stopWatch.Elapsed.TotalMilliseconds);   
    }

        public static void Test6(int number)
    {
        Random rand = new Random ();
        int[] input = new int[] { 59591,34555,9670,4679,4265,20355,78256,28029,61369,33850,54166,14454,86802,96728,45821,69586,56332,71066,13378,86223,86409,76286,8640,49048,12831,91294,42700,75703,53114,89770,81410,10259,83565,8364,10586,31843,79661,80511,85667,76175,18061,37106,77709,61084,53939,39190,92130,93900,9868,61052,77815,70838,68580,59538,14303,83304,25914,60621,91848,12971,77654,2552,74914,71598,52440,43907,30888,78438,86141,13977,89925,75820,85399,37202,68161,49303,98577,47555,95108,73640,99164,48799,65834,92062,11955,10572,41678,24027,94060,27281,5929,19039,88662,72695,98520,15508,62191,6111,8644,10031,8301,13691,7759,95891,71127,1994,85438,31377,91376,65000,84727,78358,65512,18208,13806,28855,36718,82852,59642,41868,2229,6861,84378,58859,8048,70885,87158,12703,38682,52652,87111,92466,38911,85077,65338,85473,41040,69943,20935,9961,25133,10301,32650,29059,42554,27570,53526,70454,58889,69665,78790,79339,46468,66775,7802,1440,29312,48900,87843,241,14836,72735,92695,38724,77888,92261,39446,80435,52869,28333,87814,66774,61917,49681,16734,91928,74211,55319,16304,80477,17358,16703,53814,69016,73861,7772,45998,72135,77274,63898,56160,92140,82100,20693,95124,52397,17605,93926,51170,50292,88124,73091,17585,30556,81850,12015,17421,96786,50041,15874,27228,73993,32595,7365,82883,98132,18921,23678,64862,70116,46263,67310,3161,88971,72172,95674,84674,41224,54556,64336,74322,80285,4148,66012,92353,44267,99118,23257,87165,61846,90350,49211,22094,61399,36669,82167,59544,74734,37809,96992,33476,93927,29064,81054,4029,20813,69929,28613,58383,86176,27341,76197,42229,85704,41552,46943,69844,66583,15012,38616,99013,95663,36512,3016,79765,97051,45216,41761,52301,90005,36130,9939,3414,57564,30860,80395,51221,23094,61983,71540,74337,70504,64874,989,34504,14153,6982,36390,19847,89726,12322,92961,59722,99193,97978,37812,57414,26047,1288,6977,75597,28168,76312,68378,50045,17401,72783,84664,54843,61156,95721,46750,4600,43471,64278,28508,30789,35522,68511,65612,90069,8825,21913,62574,77682,43168,50217,4221,59585,93047,22980,25173,21806,55005,95943,46169,94192,96495,50943,17103,41369,22317,81546,58690,94004,65572,88361,16250,34914,69470,7023,21891,57536,35675,16907,66771,6254,13737,90695,6877,67184,68561,25079,61795,38176,70548,24943,49594,47528,18109,34316,34293,84579,51408,24242,67751,27279,63223,68569,12110,54807,33966,69306,90115,86024,1089,67636,86130,38097,29172,39915,80454,5800,44066,49919,72807,97237,19750,20514,23456,40628,38766,68721,16805,35153,72729,37312,6128,11433,49155,39491,43030,45167,78585,52069,33217,99255,34964,75771,37086,2911,38813,11496,18356,78194,53861,28493,40512,1489,51434,70514,7528,42708,45113,71481,16040,65244,52501,54961,13294,63776,61508,74696,88941,89680,96884,35287,27214,91997,16702,73552,62273,43979,83427,20545,1814,27270,50365,38611,81292,44236,96799,4639,59998,78641,31963,321,54,7103,36028,67972,46753,80002,62476,73310,41402,64116,22554,28676,81309,18574,1278,48515,84787,77882,8240,63549,59281,24567,69667,88770,14879,13890,73668,69058,66977,56869,14698,10300,57717,96562,35232,20111,55968,48729,26798,82270,81502,10117,79142,37697,4715,21689,57301,62718,42957,48284,19852,82116,70401,68413,75486,37436,47257,53092,32863,6334,93418,6332,84533,49418,12254,70958,84746,83341,81166,92546,36057,51083,25969,82046,49164,45424,31969,84054,93190,56588,10950,26100,18692,37017,32582,39898,89303,55522,59745,82675,8711,95637,93935,75936,88084,3784,94609,88279,92461,50730,72554,79377,61791,55738,83794,31032,44432,86367,91876,30061,5466,63202,59902,76274,95383,67318,87640,47515,16836,72355,81655,29224,23595,98491,83835,40419,57148,50032,93962,45379,50815,43689,91593,42460,84034,31573,64309,62954,53222,1549,95466,2936,63646,29684,77208,45508,35735,17660,80552,20766,16144,47093,71443,20105,69074,43330,55781,63300,71903,43375,73884,94399,92405,46496,79246,61777,71609,17441,92240,63810,3008,24685,94293,15286,76889,78719,65577,93911,21282,38326,4684,39487,69480,73195,29235,3721,72246,71488,73385,40703,75791,1008,91051,9847,27665,1067,10531,17149,50437,15431,73899,18293,25419,16741,17757,91458,52799,56156,43215,90355,77752,61870,42017,33576,38690,34396,24919,19209,17261,75524,89530,120,44056,51537,88019,1999,33634,84446,87621,75822,68188,48427,43473,5850,64427,86391,14068,52738,55438,37776,50921,16090,28272,83029,62950,13920,58991,57475,71156,93268,76148,91321,99888,74913,25901,73778,74236,73882,28722,15757,57823,68353,68534,67393,22167,29324,18397,36167,69148,52298,20328,72180,63770,79484,24602,73440,71848,61026,88586,74099,43008,76159,13289,94352,99673,76866,48539,68559,79949,90649,12154,40185,24016,39680,79952,82568,60878,60862,33626,95523,22824,88326,18858,72940,3967,27550,20404,50310,52460,1930,13209,85296,54622,72748,81664,55063,74181,67719,45301,80785,49837,56217,78499,40144,80143,48164,24090,99531,42034,25885,10969,164,54960,78576,20184,87832,94431,21412,95706,49315,28135,18249,27489,88719,98944,54888,69393,66932,98288,27504,73373,93159,15560,52840,45685,66606,9827,78713,92797,55803,3460,20872,8276,26575,90960,13045,30336,76046,52564,93832,60632,52769,72013,95986,52650,31588,28728,89779,41199,25254,78770,57157,1243,14529,52511,17809,84603,2119,32890,53578,78005,15717,28615,39903,45854,7263,9972,913,97758,85899,24552,93346,14368,4456,66872,20604,21146,19574,190,14097,37878,20047,37514,67542,77032,46302,19628,93747,74063,73150,28441,28216,43156,98985,15827,44914,24153,32110,50131,45387,21615,27814,92021,55299,701,85423,42789,96787,47657,31906,96663,65029,1928,18792,15699,57957,78202,61072,62870,99551,87634,16225,26849,24607,57458,96335,50190,15382,88629,21957,96451,89036,69442,54803,92482,10063,28025,82215,66841,91608,3513,22841,46089,42157,76487,63411,26287,24364,83286,57869,66711,63081,69239,50580,57752,5390,964,67414,97841,4366,35233,27407,8158,25699,35455,7627,95586,47125,26310,5635,29931,95987,94231,71261,96038,64793,70135,84692,48120,94046,70047,25825,32096,30759,55245,33369,19796,18861,97050,87092,9099,60611,84373,62474,56375,76105,14682,20390,6701,68859,67824,79162,98054,77650,27938,70724,68849,54542,92959,35254,16272,19293,3795,34318,9407,95311,77398};
        
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
                case 59591: 
                    TestFunction();
                    break;
                case 34555: 
                    TestFunction();
                    break;
                case 9670: 
                    TestFunction();
                    break;
                case 4679: 
                    TestFunction();
                    break;
                case 4265: 
                    TestFunction();
                    break;
                case 20355: 
                    TestFunction();
                    break;
                case 78256: 
                    TestFunction();
                    break;
                case 28029: 
                    TestFunction();
                    break;
                case 61369: 
                    TestFunction();
                    break;
                case 33850: 
                    TestFunction();
                    break;
                case 54166: 
                    TestFunction();
                    break;
                case 14454: 
                    TestFunction();
                    break;
                case 86802: 
                    TestFunction();
                    break;
                case 96728: 
                    TestFunction();
                    break;
                case 45821: 
                    TestFunction();
                    break;
                case 69586: 
                    TestFunction();
                    break;
                case 56332: 
                    TestFunction();
                    break;
                case 71066: 
                    TestFunction();
                    break;
                case 13378: 
                    TestFunction();
                    break;
                case 86223: 
                    TestFunction();
                    break;
                case 86409: 
                    TestFunction();
                    break;
                case 76286: 
                    TestFunction();
                    break;
                case 8640: 
                    TestFunction();
                    break;
                case 49048: 
                    TestFunction();
                    break;
                case 12831: 
                    TestFunction();
                    break;
                case 91294: 
                    TestFunction();
                    break;
                case 42700: 
                    TestFunction();
                    break;
                case 75703: 
                    TestFunction();
                    break;
                case 53114: 
                    TestFunction();
                    break;
                case 89770: 
                    TestFunction();
                    break;
                case 81410: 
                    TestFunction();
                    break;
                case 10259: 
                    TestFunction();
                    break;
                case 83565: 
                    TestFunction();
                    break;
                case 8364: 
                    TestFunction();
                    break;
                case 10586: 
                    TestFunction();
                    break;
                case 31843: 
                    TestFunction();
                    break;
                case 79661: 
                    TestFunction();
                    break;
                case 80511: 
                    TestFunction();
                    break;
                case 85667: 
                    TestFunction();
                    break;
                case 76175: 
                    TestFunction();
                    break;
                case 18061: 
                    TestFunction();
                    break;
                case 37106: 
                    TestFunction();
                    break;
                case 77709: 
                    TestFunction();
                    break;
                case 61084: 
                    TestFunction();
                    break;
                case 53939: 
                    TestFunction();
                    break;
                case 39190: 
                    TestFunction();
                    break;
                case 92130: 
                    TestFunction();
                    break;
                case 93900: 
                    TestFunction();
                    break;
                case 9868: 
                    TestFunction();
                    break;
                case 61052: 
                    TestFunction();
                    break;
                case 77815: 
                    TestFunction();
                    break;
                case 70838: 
                    TestFunction();
                    break;
                case 68580: 
                    TestFunction();
                    break;
                case 59538: 
                    TestFunction();
                    break;
                case 14303: 
                    TestFunction();
                    break;
                case 83304: 
                    TestFunction();
                    break;
                case 25914: 
                    TestFunction();
                    break;
                case 60621: 
                    TestFunction();
                    break;
                case 91848: 
                    TestFunction();
                    break;
                case 12971: 
                    TestFunction();
                    break;
                case 77654: 
                    TestFunction();
                    break;
                case 2552: 
                    TestFunction();
                    break;
                case 74914: 
                    TestFunction();
                    break;
                case 71598: 
                    TestFunction();
                    break;
                case 52440: 
                    TestFunction();
                    break;
                case 43907: 
                    TestFunction();
                    break;
                case 30888: 
                    TestFunction();
                    break;
                case 78438: 
                    TestFunction();
                    break;
                case 86141: 
                    TestFunction();
                    break;
                case 13977: 
                    TestFunction();
                    break;
                case 89925: 
                    TestFunction();
                    break;
                case 75820: 
                    TestFunction();
                    break;
                case 85399: 
                    TestFunction();
                    break;
                case 37202: 
                    TestFunction();
                    break;
                case 68161: 
                    TestFunction();
                    break;
                case 49303: 
                    TestFunction();
                    break;
                case 98577: 
                    TestFunction();
                    break;
                case 47555: 
                    TestFunction();
                    break;
                case 95108: 
                    TestFunction();
                    break;
                case 73640: 
                    TestFunction();
                    break;
                case 99164: 
                    TestFunction();
                    break;
                case 48799: 
                    TestFunction();
                    break;
                case 65834: 
                    TestFunction();
                    break;
                case 92062: 
                    TestFunction();
                    break;
                case 11955: 
                    TestFunction();
                    break;
                case 10572: 
                    TestFunction();
                    break;
                case 41678: 
                    TestFunction();
                    break;
                case 24027: 
                    TestFunction();
                    break;
                case 94060: 
                    TestFunction();
                    break;
                case 27281: 
                    TestFunction();
                    break;
                case 5929: 
                    TestFunction();
                    break;
                case 19039: 
                    TestFunction();
                    break;
                case 88662: 
                    TestFunction();
                    break;
                case 72695: 
                    TestFunction();
                    break;
                case 98520: 
                    TestFunction();
                    break;
                case 15508: 
                    TestFunction();
                    break;
                case 62191: 
                    TestFunction();
                    break;
                case 6111: 
                    TestFunction();
                    break;
                case 8644: 
                    TestFunction();
                    break;
                case 10031: 
                    TestFunction();
                    break;
                case 8301: 
                    TestFunction();
                    break;
                case 13691: 
                    TestFunction();
                    break;
                case 7759: 
                    TestFunction();
                    break;
                case 95891: 
                    TestFunction();
                    break;
                case 71127: 
                    TestFunction();
                    break;
                case 1994: 
                    TestFunction();
                    break;
                case 85438: 
                    TestFunction();
                    break;
                case 31377: 
                    TestFunction();
                    break;
                case 91376: 
                    TestFunction();
                    break;
                case 65000: 
                    TestFunction();
                    break;
                case 84727: 
                    TestFunction();
                    break;
                case 78358: 
                    TestFunction();
                    break;
                case 65512: 
                    TestFunction();
                    break;
                case 18208: 
                    TestFunction();
                    break;
                case 13806: 
                    TestFunction();
                    break;
                case 28855: 
                    TestFunction();
                    break;
                case 36718: 
                    TestFunction();
                    break;
                case 82852: 
                    TestFunction();
                    break;
                case 59642: 
                    TestFunction();
                    break;
                case 41868: 
                    TestFunction();
                    break;
                case 2229: 
                    TestFunction();
                    break;
                case 6861: 
                    TestFunction();
                    break;
                case 84378: 
                    TestFunction();
                    break;
                case 58859: 
                    TestFunction();
                    break;
                case 8048: 
                    TestFunction();
                    break;
                case 70885: 
                    TestFunction();
                    break;
                case 87158: 
                    TestFunction();
                    break;
                case 12703: 
                    TestFunction();
                    break;
                case 38682: 
                    TestFunction();
                    break;
                case 52652: 
                    TestFunction();
                    break;
                case 87111: 
                    TestFunction();
                    break;
                case 92466: 
                    TestFunction();
                    break;
                case 38911: 
                    TestFunction();
                    break;
                case 85077: 
                    TestFunction();
                    break;
                case 65338: 
                    TestFunction();
                    break;
                case 85473: 
                    TestFunction();
                    break;
                case 41040: 
                    TestFunction();
                    break;
                case 69943: 
                    TestFunction();
                    break;
                case 20935: 
                    TestFunction();
                    break;
                case 9961: 
                    TestFunction();
                    break;
                case 25133: 
                    TestFunction();
                    break;
                case 10301: 
                    TestFunction();
                    break;
                case 32650: 
                    TestFunction();
                    break;
                case 29059: 
                    TestFunction();
                    break;
                case 42554: 
                    TestFunction();
                    break;
                case 27570: 
                    TestFunction();
                    break;
                case 53526: 
                    TestFunction();
                    break;
                case 70454: 
                    TestFunction();
                    break;
                case 58889: 
                    TestFunction();
                    break;
                case 69665: 
                    TestFunction();
                    break;
                case 78790: 
                    TestFunction();
                    break;
                case 79339: 
                    TestFunction();
                    break;
                case 46468: 
                    TestFunction();
                    break;
                case 66775: 
                    TestFunction();
                    break;
                case 7802: 
                    TestFunction();
                    break;
                case 1440: 
                    TestFunction();
                    break;
                case 29312: 
                    TestFunction();
                    break;
                case 48900: 
                    TestFunction();
                    break;
                case 87843: 
                    TestFunction();
                    break;
                case 241: 
                    TestFunction();
                    break;
                case 14836: 
                    TestFunction();
                    break;
                case 72735: 
                    TestFunction();
                    break;
                case 92695: 
                    TestFunction();
                    break;
                case 38724: 
                    TestFunction();
                    break;
                case 77888: 
                    TestFunction();
                    break;
                case 92261: 
                    TestFunction();
                    break;
                case 39446: 
                    TestFunction();
                    break;
                case 80435: 
                    TestFunction();
                    break;
                case 52869: 
                    TestFunction();
                    break;
                case 28333: 
                    TestFunction();
                    break;
                case 87814: 
                    TestFunction();
                    break;
                case 66774: 
                    TestFunction();
                    break;
                case 61917: 
                    TestFunction();
                    break;
                case 49681: 
                    TestFunction();
                    break;
                case 16734: 
                    TestFunction();
                    break;
                case 91928: 
                    TestFunction();
                    break;
                case 74211: 
                    TestFunction();
                    break;
                case 55319: 
                    TestFunction();
                    break;
                case 16304: 
                    TestFunction();
                    break;
                case 80477: 
                    TestFunction();
                    break;
                case 17358: 
                    TestFunction();
                    break;
                case 16703: 
                    TestFunction();
                    break;
                case 53814: 
                    TestFunction();
                    break;
                case 69016: 
                    TestFunction();
                    break;
                case 73861: 
                    TestFunction();
                    break;
                case 7772: 
                    TestFunction();
                    break;
                case 45998: 
                    TestFunction();
                    break;
                case 72135: 
                    TestFunction();
                    break;
                case 77274: 
                    TestFunction();
                    break;
                case 63898: 
                    TestFunction();
                    break;
                case 56160: 
                    TestFunction();
                    break;
                case 92140: 
                    TestFunction();
                    break;
                case 82100: 
                    TestFunction();
                    break;
                case 20693: 
                    TestFunction();
                    break;
                case 95124: 
                    TestFunction();
                    break;
                case 52397: 
                    TestFunction();
                    break;
                case 17605: 
                    TestFunction();
                    break;
                case 93926: 
                    TestFunction();
                    break;
                case 51170: 
                    TestFunction();
                    break;
                case 50292: 
                    TestFunction();
                    break;
                case 88124: 
                    TestFunction();
                    break;
                case 73091: 
                    TestFunction();
                    break;
                case 17585: 
                    TestFunction();
                    break;
                case 30556: 
                    TestFunction();
                    break;
                case 81850: 
                    TestFunction();
                    break;
                case 12015: 
                    TestFunction();
                    break;
                case 17421: 
                    TestFunction();
                    break;
                case 96786: 
                    TestFunction();
                    break;
                case 50041: 
                    TestFunction();
                    break;
                case 15874: 
                    TestFunction();
                    break;
                case 27228: 
                    TestFunction();
                    break;
                case 73993: 
                    TestFunction();
                    break;
                case 32595: 
                    TestFunction();
                    break;
                case 7365: 
                    TestFunction();
                    break;
                case 82883: 
                    TestFunction();
                    break;
                case 98132: 
                    TestFunction();
                    break;
                case 18921: 
                    TestFunction();
                    break;
                case 23678: 
                    TestFunction();
                    break;
                case 64862: 
                    TestFunction();
                    break;
                case 70116: 
                    TestFunction();
                    break;
                case 46263: 
                    TestFunction();
                    break;
                case 67310: 
                    TestFunction();
                    break;
                case 3161: 
                    TestFunction();
                    break;
                case 88971: 
                    TestFunction();
                    break;
                case 72172: 
                    TestFunction();
                    break;
                case 95674: 
                    TestFunction();
                    break;
                case 84674: 
                    TestFunction();
                    break;
                case 41224: 
                    TestFunction();
                    break;
                case 54556: 
                    TestFunction();
                    break;
                case 64336: 
                    TestFunction();
                    break;
                case 74322: 
                    TestFunction();
                    break;
                case 80285: 
                    TestFunction();
                    break;
                case 4148: 
                    TestFunction();
                    break;
                case 66012: 
                    TestFunction();
                    break;
                case 92353: 
                    TestFunction();
                    break;
                case 44267: 
                    TestFunction();
                    break;
                case 99118: 
                    TestFunction();
                    break;
                case 23257: 
                    TestFunction();
                    break;
                case 87165: 
                    TestFunction();
                    break;
                case 61846: 
                    TestFunction();
                    break;
                case 90350: 
                    TestFunction();
                    break;
                case 49211: 
                    TestFunction();
                    break;
                case 22094: 
                    TestFunction();
                    break;
                case 61399: 
                    TestFunction();
                    break;
                case 36669: 
                    TestFunction();
                    break;
                case 82167: 
                    TestFunction();
                    break;
                case 59544: 
                    TestFunction();
                    break;
                case 74734: 
                    TestFunction();
                    break;
                case 37809: 
                    TestFunction();
                    break;
                case 96992: 
                    TestFunction();
                    break;
                case 33476: 
                    TestFunction();
                    break;
                case 93927: 
                    TestFunction();
                    break;
                case 29064: 
                    TestFunction();
                    break;
                case 81054: 
                    TestFunction();
                    break;
                case 4029: 
                    TestFunction();
                    break;
                case 20813: 
                    TestFunction();
                    break;
                case 69929: 
                    TestFunction();
                    break;
                case 28613: 
                    TestFunction();
                    break;
                case 58383: 
                    TestFunction();
                    break;
                case 86176: 
                    TestFunction();
                    break;
                case 27341: 
                    TestFunction();
                    break;
                case 76197: 
                    TestFunction();
                    break;
                case 42229: 
                    TestFunction();
                    break;
                case 85704: 
                    TestFunction();
                    break;
                case 41552: 
                    TestFunction();
                    break;
                case 46943: 
                    TestFunction();
                    break;
                case 69844: 
                    TestFunction();
                    break;
                case 66583: 
                    TestFunction();
                    break;
                case 15012: 
                    TestFunction();
                    break;
                case 38616: 
                    TestFunction();
                    break;
                case 99013: 
                    TestFunction();
                    break;
                case 95663: 
                    TestFunction();
                    break;
                case 36512: 
                    TestFunction();
                    break;
                case 3016: 
                    TestFunction();
                    break;
                case 79765: 
                    TestFunction();
                    break;
                case 97051: 
                    TestFunction();
                    break;
                case 45216: 
                    TestFunction();
                    break;
                case 41761: 
                    TestFunction();
                    break;
                case 52301: 
                    TestFunction();
                    break;
                case 90005: 
                    TestFunction();
                    break;
                case 36130: 
                    TestFunction();
                    break;
                case 9939: 
                    TestFunction();
                    break;
                case 3414: 
                    TestFunction();
                    break;
                case 57564: 
                    TestFunction();
                    break;
                case 30860: 
                    TestFunction();
                    break;
                case 80395: 
                    TestFunction();
                    break;
                case 51221: 
                    TestFunction();
                    break;
                case 23094: 
                    TestFunction();
                    break;
                case 61983: 
                    TestFunction();
                    break;
                case 71540: 
                    TestFunction();
                    break;
                case 74337: 
                    TestFunction();
                    break;
                case 70504: 
                    TestFunction();
                    break;
                case 64874: 
                    TestFunction();
                    break;
                case 989: 
                    TestFunction();
                    break;
                case 34504: 
                    TestFunction();
                    break;
                case 14153: 
                    TestFunction();
                    break;
                case 6982: 
                    TestFunction();
                    break;
                case 36390: 
                    TestFunction();
                    break;
                case 19847: 
                    TestFunction();
                    break;
                case 89726: 
                    TestFunction();
                    break;
                case 12322: 
                    TestFunction();
                    break;
                case 92961: 
                    TestFunction();
                    break;
                case 59722: 
                    TestFunction();
                    break;
                case 99193: 
                    TestFunction();
                    break;
                case 97978: 
                    TestFunction();
                    break;
                case 37812: 
                    TestFunction();
                    break;
                case 57414: 
                    TestFunction();
                    break;
                case 26047: 
                    TestFunction();
                    break;
                case 1288: 
                    TestFunction();
                    break;
                case 6977: 
                    TestFunction();
                    break;
                case 75597: 
                    TestFunction();
                    break;
                case 28168: 
                    TestFunction();
                    break;
                case 76312: 
                    TestFunction();
                    break;
                case 68378: 
                    TestFunction();
                    break;
                case 50045: 
                    TestFunction();
                    break;
                case 17401: 
                    TestFunction();
                    break;
                case 72783: 
                    TestFunction();
                    break;
                case 84664: 
                    TestFunction();
                    break;
                case 54843: 
                    TestFunction();
                    break;
                case 61156: 
                    TestFunction();
                    break;
                case 95721: 
                    TestFunction();
                    break;
                case 46750: 
                    TestFunction();
                    break;
                case 4600: 
                    TestFunction();
                    break;
                case 43471: 
                    TestFunction();
                    break;
                case 64278: 
                    TestFunction();
                    break;
                case 28508: 
                    TestFunction();
                    break;
                case 30789: 
                    TestFunction();
                    break;
                case 35522: 
                    TestFunction();
                    break;
                case 68511: 
                    TestFunction();
                    break;
                case 65612: 
                    TestFunction();
                    break;
                case 90069: 
                    TestFunction();
                    break;
                case 8825: 
                    TestFunction();
                    break;
                case 21913: 
                    TestFunction();
                    break;
                case 62574: 
                    TestFunction();
                    break;
                case 77682: 
                    TestFunction();
                    break;
                case 43168: 
                    TestFunction();
                    break;
                case 50217: 
                    TestFunction();
                    break;
                case 4221: 
                    TestFunction();
                    break;
                case 59585: 
                    TestFunction();
                    break;
                case 93047: 
                    TestFunction();
                    break;
                case 22980: 
                    TestFunction();
                    break;
                case 25173: 
                    TestFunction();
                    break;
                case 21806: 
                    TestFunction();
                    break;
                case 55005: 
                    TestFunction();
                    break;
                case 95943: 
                    TestFunction();
                    break;
                case 46169: 
                    TestFunction();
                    break;
                case 94192: 
                    TestFunction();
                    break;
                case 96495: 
                    TestFunction();
                    break;
                case 50943: 
                    TestFunction();
                    break;
                case 17103: 
                    TestFunction();
                    break;
                case 41369: 
                    TestFunction();
                    break;
                case 22317: 
                    TestFunction();
                    break;
                case 81546: 
                    TestFunction();
                    break;
                case 58690: 
                    TestFunction();
                    break;
                case 94004: 
                    TestFunction();
                    break;
                case 65572: 
                    TestFunction();
                    break;
                case 88361: 
                    TestFunction();
                    break;
                case 16250: 
                    TestFunction();
                    break;
                case 34914: 
                    TestFunction();
                    break;
                case 69470: 
                    TestFunction();
                    break;
                case 7023: 
                    TestFunction();
                    break;
                case 21891: 
                    TestFunction();
                    break;
                case 57536: 
                    TestFunction();
                    break;
                case 35675: 
                    TestFunction();
                    break;
                case 16907: 
                    TestFunction();
                    break;
                case 66771: 
                    TestFunction();
                    break;
                case 6254: 
                    TestFunction();
                    break;
                case 13737: 
                    TestFunction();
                    break;
                case 90695: 
                    TestFunction();
                    break;
                case 6877: 
                    TestFunction();
                    break;
                case 67184: 
                    TestFunction();
                    break;
                case 68561: 
                    TestFunction();
                    break;
                case 25079: 
                    TestFunction();
                    break;
                case 61795: 
                    TestFunction();
                    break;
                case 38176: 
                    TestFunction();
                    break;
                case 70548: 
                    TestFunction();
                    break;
                case 24943: 
                    TestFunction();
                    break;
                case 49594: 
                    TestFunction();
                    break;
                case 47528: 
                    TestFunction();
                    break;
                case 18109: 
                    TestFunction();
                    break;
                case 34316: 
                    TestFunction();
                    break;
                case 34293: 
                    TestFunction();
                    break;
                case 84579: 
                    TestFunction();
                    break;
                case 51408: 
                    TestFunction();
                    break;
                case 24242: 
                    TestFunction();
                    break;
                case 67751: 
                    TestFunction();
                    break;
                case 27279: 
                    TestFunction();
                    break;
                case 63223: 
                    TestFunction();
                    break;
                case 68569: 
                    TestFunction();
                    break;
                case 12110: 
                    TestFunction();
                    break;
                case 54807: 
                    TestFunction();
                    break;
                case 33966: 
                    TestFunction();
                    break;
                case 69306: 
                    TestFunction();
                    break;
                case 90115: 
                    TestFunction();
                    break;
                case 86024: 
                    TestFunction();
                    break;
                case 1089: 
                    TestFunction();
                    break;
                case 67636: 
                    TestFunction();
                    break;
                case 86130: 
                    TestFunction();
                    break;
                case 38097: 
                    TestFunction();
                    break;
                case 29172: 
                    TestFunction();
                    break;
                case 39915: 
                    TestFunction();
                    break;
                case 80454: 
                    TestFunction();
                    break;
                case 5800: 
                    TestFunction();
                    break;
                case 44066: 
                    TestFunction();
                    break;
                case 49919: 
                    TestFunction();
                    break;
                case 72807: 
                    TestFunction();
                    break;
                case 97237: 
                    TestFunction();
                    break;
                case 19750: 
                    TestFunction();
                    break;
                case 20514: 
                    TestFunction();
                    break;
                case 23456: 
                    TestFunction();
                    break;
                case 40628: 
                    TestFunction();
                    break;
                case 38766: 
                    TestFunction();
                    break;
                case 68721: 
                    TestFunction();
                    break;
                case 16805: 
                    TestFunction();
                    break;
                case 35153: 
                    TestFunction();
                    break;
                case 72729: 
                    TestFunction();
                    break;
                case 37312: 
                    TestFunction();
                    break;
                case 6128: 
                    TestFunction();
                    break;
                case 11433: 
                    TestFunction();
                    break;
                case 49155: 
                    TestFunction();
                    break;
                case 39491: 
                    TestFunction();
                    break;
                case 43030: 
                    TestFunction();
                    break;
                case 45167: 
                    TestFunction();
                    break;
                case 78585: 
                    TestFunction();
                    break;
                case 52069: 
                    TestFunction();
                    break;
                case 33217: 
                    TestFunction();
                    break;
                case 99255: 
                    TestFunction();
                    break;
                case 34964: 
                    TestFunction();
                    break;
                case 75771: 
                    TestFunction();
                    break;
                case 37086: 
                    TestFunction();
                    break;
                case 2911: 
                    TestFunction();
                    break;
                case 38813: 
                    TestFunction();
                    break;
                case 11496: 
                    TestFunction();
                    break;
                case 18356: 
                    TestFunction();
                    break;
                case 78194: 
                    TestFunction();
                    break;
                case 53861: 
                    TestFunction();
                    break;
                case 28493: 
                    TestFunction();
                    break;
                case 40512: 
                    TestFunction();
                    break;
                case 1489: 
                    TestFunction();
                    break;
                case 51434: 
                    TestFunction();
                    break;
                case 70514: 
                    TestFunction();
                    break;
                case 7528: 
                    TestFunction();
                    break;
                case 42708: 
                    TestFunction();
                    break;
                case 45113: 
                    TestFunction();
                    break;
                case 71481: 
                    TestFunction();
                    break;
                case 16040: 
                    TestFunction();
                    break;
                case 65244: 
                    TestFunction();
                    break;
                case 52501: 
                    TestFunction();
                    break;
                case 54961: 
                    TestFunction();
                    break;
                case 13294: 
                    TestFunction();
                    break;
                case 63776: 
                    TestFunction();
                    break;
                case 61508: 
                    TestFunction();
                    break;
                case 74696: 
                    TestFunction();
                    break;
                case 88941: 
                    TestFunction();
                    break;
                case 89680: 
                    TestFunction();
                    break;
                case 96884: 
                    TestFunction();
                    break;
                case 35287: 
                    TestFunction();
                    break;
                case 27214: 
                    TestFunction();
                    break;
                case 91997: 
                    TestFunction();
                    break;
                case 16702: 
                    TestFunction();
                    break;
                case 73552: 
                    TestFunction();
                    break;
                case 62273: 
                    TestFunction();
                    break;
                case 43979: 
                    TestFunction();
                    break;
                case 83427: 
                    TestFunction();
                    break;
                case 20545: 
                    TestFunction();
                    break;
                case 1814: 
                    TestFunction();
                    break;
                case 27270: 
                    TestFunction();
                    break;
                case 50365: 
                    TestFunction();
                    break;
                case 38611: 
                    TestFunction();
                    break;
                case 81292: 
                    TestFunction();
                    break;
                case 44236: 
                    TestFunction();
                    break;
                case 96799: 
                    TestFunction();
                    break;
                case 4639: 
                    TestFunction();
                    break;
                case 59998: 
                    TestFunction();
                    break;
                case 78641: 
                    TestFunction();
                    break;
                case 31963: 
                    TestFunction();
                    break;
                case 321: 
                    TestFunction();
                    break;
                case 54: 
                    TestFunction();
                    break;
                case 7103: 
                    TestFunction();
                    break;
                case 36028: 
                    TestFunction();
                    break;
                case 67972: 
                    TestFunction();
                    break;
                case 46753: 
                    TestFunction();
                    break;
                case 80002: 
                    TestFunction();
                    break;
                case 62476: 
                    TestFunction();
                    break;
                case 73310: 
                    TestFunction();
                    break;
                case 41402: 
                    TestFunction();
                    break;
                case 64116: 
                    TestFunction();
                    break;
                case 22554: 
                    TestFunction();
                    break;
                case 28676: 
                    TestFunction();
                    break;
                case 81309: 
                    TestFunction();
                    break;
                case 18574: 
                    TestFunction();
                    break;
                case 1278: 
                    TestFunction();
                    break;
                case 48515: 
                    TestFunction();
                    break;
                case 84787: 
                    TestFunction();
                    break;
                case 77882: 
                    TestFunction();
                    break;
                case 8240: 
                    TestFunction();
                    break;
                case 63549: 
                    TestFunction();
                    break;
                case 59281: 
                    TestFunction();
                    break;
                case 24567: 
                    TestFunction();
                    break;
                case 69667: 
                    TestFunction();
                    break;
                case 88770: 
                    TestFunction();
                    break;
                case 14879: 
                    TestFunction();
                    break;
                case 13890: 
                    TestFunction();
                    break;
                case 73668: 
                    TestFunction();
                    break;
                case 69058: 
                    TestFunction();
                    break;
                case 66977: 
                    TestFunction();
                    break;
                case 56869: 
                    TestFunction();
                    break;
                case 14698: 
                    TestFunction();
                    break;
                case 10300: 
                    TestFunction();
                    break;
                case 57717: 
                    TestFunction();
                    break;
                case 96562: 
                    TestFunction();
                    break;
                case 35232: 
                    TestFunction();
                    break;
                case 20111: 
                    TestFunction();
                    break;
                case 55968: 
                    TestFunction();
                    break;
                case 48729: 
                    TestFunction();
                    break;
                case 26798: 
                    TestFunction();
                    break;
                case 82270: 
                    TestFunction();
                    break;
                case 81502: 
                    TestFunction();
                    break;
                case 10117: 
                    TestFunction();
                    break;
                case 79142: 
                    TestFunction();
                    break;
                case 37697: 
                    TestFunction();
                    break;
                case 4715: 
                    TestFunction();
                    break;
                case 21689: 
                    TestFunction();
                    break;
                case 57301: 
                    TestFunction();
                    break;
                case 62718: 
                    TestFunction();
                    break;
                case 42957: 
                    TestFunction();
                    break;
                case 48284: 
                    TestFunction();
                    break;
                case 19852: 
                    TestFunction();
                    break;
                case 82116: 
                    TestFunction();
                    break;
                case 70401: 
                    TestFunction();
                    break;
                case 68413: 
                    TestFunction();
                    break;
                case 75486: 
                    TestFunction();
                    break;
                case 37436: 
                    TestFunction();
                    break;
                case 47257: 
                    TestFunction();
                    break;
                case 53092: 
                    TestFunction();
                    break;
                case 32863: 
                    TestFunction();
                    break;
                case 6334: 
                    TestFunction();
                    break;
                case 93418: 
                    TestFunction();
                    break;
                case 6332: 
                    TestFunction();
                    break;
                case 84533: 
                    TestFunction();
                    break;
                case 49418: 
                    TestFunction();
                    break;
                case 12254: 
                    TestFunction();
                    break;
                case 70958: 
                    TestFunction();
                    break;
                case 84746: 
                    TestFunction();
                    break;
                case 83341: 
                    TestFunction();
                    break;
                case 81166: 
                    TestFunction();
                    break;
                case 92546: 
                    TestFunction();
                    break;
                case 36057: 
                    TestFunction();
                    break;
                case 51083: 
                    TestFunction();
                    break;
                case 25969: 
                    TestFunction();
                    break;
                case 82046: 
                    TestFunction();
                    break;
                case 49164: 
                    TestFunction();
                    break;
                case 45424: 
                    TestFunction();
                    break;
                case 31969: 
                    TestFunction();
                    break;
                case 84054: 
                    TestFunction();
                    break;
                case 93190: 
                    TestFunction();
                    break;
                case 56588: 
                    TestFunction();
                    break;
                case 10950: 
                    TestFunction();
                    break;
                case 26100: 
                    TestFunction();
                    break;
                case 18692: 
                    TestFunction();
                    break;
                case 37017: 
                    TestFunction();
                    break;
                case 32582: 
                    TestFunction();
                    break;
                case 39898: 
                    TestFunction();
                    break;
                case 89303: 
                    TestFunction();
                    break;
                case 55522: 
                    TestFunction();
                    break;
                case 59745: 
                    TestFunction();
                    break;
                case 82675: 
                    TestFunction();
                    break;
                case 8711: 
                    TestFunction();
                    break;
                case 95637: 
                    TestFunction();
                    break;
                case 93935: 
                    TestFunction();
                    break;
                case 75936: 
                    TestFunction();
                    break;
                case 88084: 
                    TestFunction();
                    break;
                case 3784: 
                    TestFunction();
                    break;
                case 94609: 
                    TestFunction();
                    break;
                case 88279: 
                    TestFunction();
                    break;
                case 92461: 
                    TestFunction();
                    break;
                case 50730: 
                    TestFunction();
                    break;
                case 72554: 
                    TestFunction();
                    break;
                case 79377: 
                    TestFunction();
                    break;
                case 61791: 
                    TestFunction();
                    break;
                case 55738: 
                    TestFunction();
                    break;
                case 83794: 
                    TestFunction();
                    break;
                case 31032: 
                    TestFunction();
                    break;
                case 44432: 
                    TestFunction();
                    break;
                case 86367: 
                    TestFunction();
                    break;
                case 91876: 
                    TestFunction();
                    break;
                case 30061: 
                    TestFunction();
                    break;
                case 5466: 
                    TestFunction();
                    break;
                case 63202: 
                    TestFunction();
                    break;
                case 59902: 
                    TestFunction();
                    break;
                case 76274: 
                    TestFunction();
                    break;
                case 95383: 
                    TestFunction();
                    break;
                case 67318: 
                    TestFunction();
                    break;
                case 87640: 
                    TestFunction();
                    break;
                case 47515: 
                    TestFunction();
                    break;
                case 16836: 
                    TestFunction();
                    break;
                case 72355: 
                    TestFunction();
                    break;
                case 81655: 
                    TestFunction();
                    break;
                case 29224: 
                    TestFunction();
                    break;
                case 23595: 
                    TestFunction();
                    break;
                case 98491: 
                    TestFunction();
                    break;
                case 83835: 
                    TestFunction();
                    break;
                case 40419: 
                    TestFunction();
                    break;
                case 57148: 
                    TestFunction();
                    break;
                case 50032: 
                    TestFunction();
                    break;
                case 93962: 
                    TestFunction();
                    break;
                case 45379: 
                    TestFunction();
                    break;
                case 50815: 
                    TestFunction();
                    break;
                case 43689: 
                    TestFunction();
                    break;
                case 91593: 
                    TestFunction();
                    break;
                case 42460: 
                    TestFunction();
                    break;
                case 84034: 
                    TestFunction();
                    break;
                case 31573: 
                    TestFunction();
                    break;
                case 64309: 
                    TestFunction();
                    break;
                case 62954: 
                    TestFunction();
                    break;
                case 53222: 
                    TestFunction();
                    break;
                case 1549: 
                    TestFunction();
                    break;
                case 95466: 
                    TestFunction();
                    break;
                case 2936: 
                    TestFunction();
                    break;
                case 63646: 
                    TestFunction();
                    break;
                case 29684: 
                    TestFunction();
                    break;
                case 77208: 
                    TestFunction();
                    break;
                case 45508: 
                    TestFunction();
                    break;
                case 35735: 
                    TestFunction();
                    break;
                case 17660: 
                    TestFunction();
                    break;
                case 80552: 
                    TestFunction();
                    break;
                case 20766: 
                    TestFunction();
                    break;
                case 16144: 
                    TestFunction();
                    break;
                case 47093: 
                    TestFunction();
                    break;
                case 71443: 
                    TestFunction();
                    break;
                case 20105: 
                    TestFunction();
                    break;
                case 69074: 
                    TestFunction();
                    break;
                case 43330: 
                    TestFunction();
                    break;
                case 55781: 
                    TestFunction();
                    break;
                case 63300: 
                    TestFunction();
                    break;
                case 71903: 
                    TestFunction();
                    break;
                case 43375: 
                    TestFunction();
                    break;
                case 73884: 
                    TestFunction();
                    break;
                case 94399: 
                    TestFunction();
                    break;
                case 92405: 
                    TestFunction();
                    break;
                case 46496: 
                    TestFunction();
                    break;
                case 79246: 
                    TestFunction();
                    break;
                case 61777: 
                    TestFunction();
                    break;
                case 71609: 
                    TestFunction();
                    break;
                case 17441: 
                    TestFunction();
                    break;
                case 92240: 
                    TestFunction();
                    break;
                case 63810: 
                    TestFunction();
                    break;
                case 3008: 
                    TestFunction();
                    break;
                case 24685: 
                    TestFunction();
                    break;
                case 94293: 
                    TestFunction();
                    break;
                case 15286: 
                    TestFunction();
                    break;
                case 76889: 
                    TestFunction();
                    break;
                case 78719: 
                    TestFunction();
                    break;
                case 65577: 
                    TestFunction();
                    break;
                case 93911: 
                    TestFunction();
                    break;
                case 21282: 
                    TestFunction();
                    break;
                case 38326: 
                    TestFunction();
                    break;
                case 4684: 
                    TestFunction();
                    break;
                case 39487: 
                    TestFunction();
                    break;
                case 69480: 
                    TestFunction();
                    break;
                case 73195: 
                    TestFunction();
                    break;
                case 29235: 
                    TestFunction();
                    break;
                case 3721: 
                    TestFunction();
                    break;
                case 72246: 
                    TestFunction();
                    break;
                case 71488: 
                    TestFunction();
                    break;
                case 73385: 
                    TestFunction();
                    break;
                case 40703: 
                    TestFunction();
                    break;
                case 75791: 
                    TestFunction();
                    break;
                case 1008: 
                    TestFunction();
                    break;
                case 91051: 
                    TestFunction();
                    break;
                case 9847: 
                    TestFunction();
                    break;
                case 27665: 
                    TestFunction();
                    break;
                case 1067: 
                    TestFunction();
                    break;
                case 10531: 
                    TestFunction();
                    break;
                case 17149: 
                    TestFunction();
                    break;
                case 50437: 
                    TestFunction();
                    break;
                case 15431: 
                    TestFunction();
                    break;
                case 73899: 
                    TestFunction();
                    break;
                case 18293: 
                    TestFunction();
                    break;
                case 25419: 
                    TestFunction();
                    break;
                case 16741: 
                    TestFunction();
                    break;
                case 17757: 
                    TestFunction();
                    break;
                case 91458: 
                    TestFunction();
                    break;
                case 52799: 
                    TestFunction();
                    break;
                case 56156: 
                    TestFunction();
                    break;
                case 43215: 
                    TestFunction();
                    break;
                case 90355: 
                    TestFunction();
                    break;
                case 77752: 
                    TestFunction();
                    break;
                case 61870: 
                    TestFunction();
                    break;
                case 42017: 
                    TestFunction();
                    break;
                case 33576: 
                    TestFunction();
                    break;
                case 38690: 
                    TestFunction();
                    break;
                case 34396: 
                    TestFunction();
                    break;
                case 24919: 
                    TestFunction();
                    break;
                case 19209: 
                    TestFunction();
                    break;
                case 17261: 
                    TestFunction();
                    break;
                case 75524: 
                    TestFunction();
                    break;
                case 89530: 
                    TestFunction();
                    break;
                case 120: 
                    TestFunction();
                    break;
                case 44056: 
                    TestFunction();
                    break;
                case 51537: 
                    TestFunction();
                    break;
                case 88019: 
                    TestFunction();
                    break;
                case 1999: 
                    TestFunction();
                    break;
                case 33634: 
                    TestFunction();
                    break;
                case 84446: 
                    TestFunction();
                    break;
                case 87621: 
                    TestFunction();
                    break;
                case 75822: 
                    TestFunction();
                    break;
                case 68188: 
                    TestFunction();
                    break;
                case 48427: 
                    TestFunction();
                    break;
                case 43473: 
                    TestFunction();
                    break;
                case 5850: 
                    TestFunction();
                    break;
                case 64427: 
                    TestFunction();
                    break;
                case 86391: 
                    TestFunction();
                    break;
                case 14068: 
                    TestFunction();
                    break;
                case 52738: 
                    TestFunction();
                    break;
                case 55438: 
                    TestFunction();
                    break;
                case 37776: 
                    TestFunction();
                    break;
                case 50921: 
                    TestFunction();
                    break;
                case 16090: 
                    TestFunction();
                    break;
                case 28272: 
                    TestFunction();
                    break;
                case 83029: 
                    TestFunction();
                    break;
                case 62950: 
                    TestFunction();
                    break;
                case 13920: 
                    TestFunction();
                    break;
                case 58991: 
                    TestFunction();
                    break;
                case 57475: 
                    TestFunction();
                    break;
                case 71156: 
                    TestFunction();
                    break;
                case 93268: 
                    TestFunction();
                    break;
                case 76148: 
                    TestFunction();
                    break;
                case 91321: 
                    TestFunction();
                    break;
                case 99888: 
                    TestFunction();
                    break;
                case 74913: 
                    TestFunction();
                    break;
                case 25901: 
                    TestFunction();
                    break;
                case 73778: 
                    TestFunction();
                    break;
                case 74236: 
                    TestFunction();
                    break;
                case 73882: 
                    TestFunction();
                    break;
                case 28722: 
                    TestFunction();
                    break;
                case 15757: 
                    TestFunction();
                    break;
                case 57823: 
                    TestFunction();
                    break;
                case 68353: 
                    TestFunction();
                    break;
                case 68534: 
                    TestFunction();
                    break;
                case 67393: 
                    TestFunction();
                    break;
                case 22167: 
                    TestFunction();
                    break;
                case 29324: 
                    TestFunction();
                    break;
                case 18397: 
                    TestFunction();
                    break;
                case 36167: 
                    TestFunction();
                    break;
                case 69148: 
                    TestFunction();
                    break;
                case 52298: 
                    TestFunction();
                    break;
                case 20328: 
                    TestFunction();
                    break;
                case 72180: 
                    TestFunction();
                    break;
                case 63770: 
                    TestFunction();
                    break;
                case 79484: 
                    TestFunction();
                    break;
                case 24602: 
                    TestFunction();
                    break;
                case 73440: 
                    TestFunction();
                    break;
                case 71848: 
                    TestFunction();
                    break;
                case 61026: 
                    TestFunction();
                    break;
                case 88586: 
                    TestFunction();
                    break;
                case 74099: 
                    TestFunction();
                    break;
                case 43008: 
                    TestFunction();
                    break;
                case 76159: 
                    TestFunction();
                    break;
                case 13289: 
                    TestFunction();
                    break;
                case 94352: 
                    TestFunction();
                    break;
                case 99673: 
                    TestFunction();
                    break;
                case 76866: 
                    TestFunction();
                    break;
                case 48539: 
                    TestFunction();
                    break;
                case 68559: 
                    TestFunction();
                    break;
                case 79949: 
                    TestFunction();
                    break;
                case 90649: 
                    TestFunction();
                    break;
                case 12154: 
                    TestFunction();
                    break;
                case 40185: 
                    TestFunction();
                    break;
                case 24016: 
                    TestFunction();
                    break;
                case 39680: 
                    TestFunction();
                    break;
                case 79952: 
                    TestFunction();
                    break;
                case 82568: 
                    TestFunction();
                    break;
                case 60878: 
                    TestFunction();
                    break;
                case 60862: 
                    TestFunction();
                    break;
                case 33626: 
                    TestFunction();
                    break;
                case 95523: 
                    TestFunction();
                    break;
                case 22824: 
                    TestFunction();
                    break;
                case 88326: 
                    TestFunction();
                    break;
                case 18858: 
                    TestFunction();
                    break;
                case 72940: 
                    TestFunction();
                    break;
                case 3967: 
                    TestFunction();
                    break;
                case 27550: 
                    TestFunction();
                    break;
                case 20404: 
                    TestFunction();
                    break;
                case 50310: 
                    TestFunction();
                    break;
                case 52460: 
                    TestFunction();
                    break;
                case 1930: 
                    TestFunction();
                    break;
                case 13209: 
                    TestFunction();
                    break;
                case 85296: 
                    TestFunction();
                    break;
                case 54622: 
                    TestFunction();
                    break;
                case 72748: 
                    TestFunction();
                    break;
                case 81664: 
                    TestFunction();
                    break;
                case 55063: 
                    TestFunction();
                    break;
                case 74181: 
                    TestFunction();
                    break;
                case 67719: 
                    TestFunction();
                    break;
                case 45301: 
                    TestFunction();
                    break;
                case 80785: 
                    TestFunction();
                    break;
                case 49837: 
                    TestFunction();
                    break;
                case 56217: 
                    TestFunction();
                    break;
                case 78499: 
                    TestFunction();
                    break;
                case 40144: 
                    TestFunction();
                    break;
                case 80143: 
                    TestFunction();
                    break;
                case 48164: 
                    TestFunction();
                    break;
                case 24090: 
                    TestFunction();
                    break;
                case 99531: 
                    TestFunction();
                    break;
                case 42034: 
                    TestFunction();
                    break;
                case 25885: 
                    TestFunction();
                    break;
                case 10969: 
                    TestFunction();
                    break;
                case 164: 
                    TestFunction();
                    break;
                case 54960: 
                    TestFunction();
                    break;
                case 78576: 
                    TestFunction();
                    break;
                case 20184: 
                    TestFunction();
                    break;
                case 87832: 
                    TestFunction();
                    break;
                case 94431: 
                    TestFunction();
                    break;
                case 21412: 
                    TestFunction();
                    break;
                case 95706: 
                    TestFunction();
                    break;
                case 49315: 
                    TestFunction();
                    break;
                case 28135: 
                    TestFunction();
                    break;
                case 18249: 
                    TestFunction();
                    break;
                case 27489: 
                    TestFunction();
                    break;
                case 88719: 
                    TestFunction();
                    break;
                case 98944: 
                    TestFunction();
                    break;
                case 54888: 
                    TestFunction();
                    break;
                case 69393: 
                    TestFunction();
                    break;
                case 66932: 
                    TestFunction();
                    break;
                case 98288: 
                    TestFunction();
                    break;
                case 27504: 
                    TestFunction();
                    break;
                case 73373: 
                    TestFunction();
                    break;
                case 93159: 
                    TestFunction();
                    break;
                case 15560: 
                    TestFunction();
                    break;
                case 52840: 
                    TestFunction();
                    break;
                case 45685: 
                    TestFunction();
                    break;
                case 66606: 
                    TestFunction();
                    break;
                case 9827: 
                    TestFunction();
                    break;
                case 78713: 
                    TestFunction();
                    break;
                case 92797: 
                    TestFunction();
                    break;
                case 55803: 
                    TestFunction();
                    break;
                case 3460: 
                    TestFunction();
                    break;
                case 20872: 
                    TestFunction();
                    break;
                case 8276: 
                    TestFunction();
                    break;
                case 26575: 
                    TestFunction();
                    break;
                case 90960: 
                    TestFunction();
                    break;
                case 13045: 
                    TestFunction();
                    break;
                case 30336: 
                    TestFunction();
                    break;
                case 76046: 
                    TestFunction();
                    break;
                case 52564: 
                    TestFunction();
                    break;
                case 93832: 
                    TestFunction();
                    break;
                case 60632: 
                    TestFunction();
                    break;
                case 52769: 
                    TestFunction();
                    break;
                case 72013: 
                    TestFunction();
                    break;
                case 95986: 
                    TestFunction();
                    break;
                case 52650: 
                    TestFunction();
                    break;
                case 31588: 
                    TestFunction();
                    break;
                case 28728: 
                    TestFunction();
                    break;
                case 89779: 
                    TestFunction();
                    break;
                case 41199: 
                    TestFunction();
                    break;
                case 25254: 
                    TestFunction();
                    break;
                case 78770: 
                    TestFunction();
                    break;
                case 57157: 
                    TestFunction();
                    break;
                case 1243: 
                    TestFunction();
                    break;
                case 14529: 
                    TestFunction();
                    break;
                case 52511: 
                    TestFunction();
                    break;
                case 17809: 
                    TestFunction();
                    break;
                case 84603: 
                    TestFunction();
                    break;
                case 2119: 
                    TestFunction();
                    break;
                case 32890: 
                    TestFunction();
                    break;
                case 53578: 
                    TestFunction();
                    break;
                case 78005: 
                    TestFunction();
                    break;
                case 15717: 
                    TestFunction();
                    break;
                case 28615: 
                    TestFunction();
                    break;
                case 39903: 
                    TestFunction();
                    break;
                case 45854: 
                    TestFunction();
                    break;
                case 7263: 
                    TestFunction();
                    break;
                case 9972: 
                    TestFunction();
                    break;
                case 913: 
                    TestFunction();
                    break;
                case 97758: 
                    TestFunction();
                    break;
                case 85899: 
                    TestFunction();
                    break;
                case 24552: 
                    TestFunction();
                    break;
                case 93346: 
                    TestFunction();
                    break;
                case 14368: 
                    TestFunction();
                    break;
                case 4456: 
                    TestFunction();
                    break;
                case 66872: 
                    TestFunction();
                    break;
                case 20604: 
                    TestFunction();
                    break;
                case 21146: 
                    TestFunction();
                    break;
                case 19574: 
                    TestFunction();
                    break;
                case 190: 
                    TestFunction();
                    break;
                case 14097: 
                    TestFunction();
                    break;
                case 37878: 
                    TestFunction();
                    break;
                case 20047: 
                    TestFunction();
                    break;
                case 37514: 
                    TestFunction();
                    break;
                case 67542: 
                    TestFunction();
                    break;
                case 77032: 
                    TestFunction();
                    break;
                case 46302: 
                    TestFunction();
                    break;
                case 19628: 
                    TestFunction();
                    break;
                case 93747: 
                    TestFunction();
                    break;
                case 74063: 
                    TestFunction();
                    break;
                case 73150: 
                    TestFunction();
                    break;
                case 28441: 
                    TestFunction();
                    break;
                case 28216: 
                    TestFunction();
                    break;
                case 43156: 
                    TestFunction();
                    break;
                case 98985: 
                    TestFunction();
                    break;
                case 15827: 
                    TestFunction();
                    break;
                case 44914: 
                    TestFunction();
                    break;
                case 24153: 
                    TestFunction();
                    break;
                case 32110: 
                    TestFunction();
                    break;
                case 50131: 
                    TestFunction();
                    break;
                case 45387: 
                    TestFunction();
                    break;
                case 21615: 
                    TestFunction();
                    break;
                case 27814: 
                    TestFunction();
                    break;
                case 92021: 
                    TestFunction();
                    break;
                case 55299: 
                    TestFunction();
                    break;
                case 701: 
                    TestFunction();
                    break;
                case 85423: 
                    TestFunction();
                    break;
                case 42789: 
                    TestFunction();
                    break;
                case 96787: 
                    TestFunction();
                    break;
                case 47657: 
                    TestFunction();
                    break;
                case 31906: 
                    TestFunction();
                    break;
                case 96663: 
                    TestFunction();
                    break;
                case 65029: 
                    TestFunction();
                    break;
                case 1928: 
                    TestFunction();
                    break;
                case 18792: 
                    TestFunction();
                    break;
                case 15699: 
                    TestFunction();
                    break;
                case 57957: 
                    TestFunction();
                    break;
                case 78202: 
                    TestFunction();
                    break;
                case 61072: 
                    TestFunction();
                    break;
                case 62870: 
                    TestFunction();
                    break;
                case 99551: 
                    TestFunction();
                    break;
                case 87634: 
                    TestFunction();
                    break;
                case 16225: 
                    TestFunction();
                    break;
                case 26849: 
                    TestFunction();
                    break;
                case 24607: 
                    TestFunction();
                    break;
                case 57458: 
                    TestFunction();
                    break;
                case 96335: 
                    TestFunction();
                    break;
                case 50190: 
                    TestFunction();
                    break;
                case 15382: 
                    TestFunction();
                    break;
                case 88629: 
                    TestFunction();
                    break;
                case 21957: 
                    TestFunction();
                    break;
                case 96451: 
                    TestFunction();
                    break;
                case 89036: 
                    TestFunction();
                    break;
                case 69442: 
                    TestFunction();
                    break;
                case 54803: 
                    TestFunction();
                    break;
                case 92482: 
                    TestFunction();
                    break;
                case 10063: 
                    TestFunction();
                    break;
                case 28025: 
                    TestFunction();
                    break;
                case 82215: 
                    TestFunction();
                    break;
                case 66841: 
                    TestFunction();
                    break;
                case 91608: 
                    TestFunction();
                    break;
                case 3513: 
                    TestFunction();
                    break;
                case 22841: 
                    TestFunction();
                    break;
                case 46089: 
                    TestFunction();
                    break;
                case 42157: 
                    TestFunction();
                    break;
                case 76487: 
                    TestFunction();
                    break;
                case 63411: 
                    TestFunction();
                    break;
                case 26287: 
                    TestFunction();
                    break;
                case 24364: 
                    TestFunction();
                    break;
                case 83286: 
                    TestFunction();
                    break;
                case 57869: 
                    TestFunction();
                    break;
                case 66711: 
                    TestFunction();
                    break;
                case 63081: 
                    TestFunction();
                    break;
                case 69239: 
                    TestFunction();
                    break;
                case 50580: 
                    TestFunction();
                    break;
                case 57752: 
                    TestFunction();
                    break;
                case 5390: 
                    TestFunction();
                    break;
                case 964: 
                    TestFunction();
                    break;
                case 67414: 
                    TestFunction();
                    break;
                case 97841: 
                    TestFunction();
                    break;
                case 4366: 
                    TestFunction();
                    break;
                case 35233: 
                    TestFunction();
                    break;
                case 27407: 
                    TestFunction();
                    break;
                case 8158: 
                    TestFunction();
                    break;
                case 25699: 
                    TestFunction();
                    break;
                case 35455: 
                    TestFunction();
                    break;
                case 7627: 
                    TestFunction();
                    break;
                case 95586: 
                    TestFunction();
                    break;
                case 47125: 
                    TestFunction();
                    break;
                case 26310: 
                    TestFunction();
                    break;
                case 5635: 
                    TestFunction();
                    break;
                case 29931: 
                    TestFunction();
                    break;
                case 95987: 
                    TestFunction();
                    break;
                case 94231: 
                    TestFunction();
                    break;
                case 71261: 
                    TestFunction();
                    break;
                case 96038: 
                    TestFunction();
                    break;
                case 64793: 
                    TestFunction();
                    break;
                case 70135: 
                    TestFunction();
                    break;
                case 84692: 
                    TestFunction();
                    break;
                case 48120: 
                    TestFunction();
                    break;
                case 94046: 
                    TestFunction();
                    break;
                case 70047: 
                    TestFunction();
                    break;
                case 25825: 
                    TestFunction();
                    break;
                case 32096: 
                    TestFunction();
                    break;
                case 30759: 
                    TestFunction();
                    break;
                case 55245: 
                    TestFunction();
                    break;
                case 33369: 
                    TestFunction();
                    break;
                case 19796: 
                    TestFunction();
                    break;
                case 18861: 
                    TestFunction();
                    break;
                case 97050: 
                    TestFunction();
                    break;
                case 87092: 
                    TestFunction();
                    break;
                case 9099: 
                    TestFunction();
                    break;
                case 60611: 
                    TestFunction();
                    break;
                case 84373: 
                    TestFunction();
                    break;
                case 62474: 
                    TestFunction();
                    break;
                case 56375: 
                    TestFunction();
                    break;
                case 76105: 
                    TestFunction();
                    break;
                case 14682: 
                    TestFunction();
                    break;
                case 20390: 
                    TestFunction();
                    break;
                case 6701: 
                    TestFunction();
                    break;
                case 68859: 
                    TestFunction();
                    break;
                case 67824: 
                    TestFunction();
                    break;
                case 79162: 
                    TestFunction();
                    break;
                case 98054: 
                    TestFunction();
                    break;
                case 77650: 
                    TestFunction();
                    break;
                case 27938: 
                    TestFunction();
                    break;
                case 70724: 
                    TestFunction();
                    break;
                case 68849: 
                    TestFunction();
                    break;
                case 54542: 
                    TestFunction();
                    break;
                case 92959: 
                    TestFunction();
                    break;
                case 35254: 
                    TestFunction();
                    break;
                case 16272: 
                    TestFunction();
                    break;
                case 19293: 
                    TestFunction();
                    break;
                case 3795: 
                    TestFunction();
                    break;
                case 34318: 
                    TestFunction();
                    break;
                case 9407: 
                    TestFunction();
                    break;
                case 95311: 
                    TestFunction();
                    break;
                case 77398: 
                    TestFunction();
                    break;

            }
        }

        stopWatch.Stop ();

        Console.WriteLine ("Rand #6: " + stopWatch.Elapsed.TotalMilliseconds);   
    }
}
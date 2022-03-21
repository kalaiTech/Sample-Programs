using System;

namespace exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            addtwonumber myobj = new addtwonumber();
            celsiusandfrehranhait celsius = new celsiusandfrehranhait();
            ElementaryOperationsTask elementary = new ElementaryOperationsTask();
            IsResultTheSameTask isResult = new IsResultTheSameTask();
            ModuloOperationsTask moduloOperations = new ModuloOperationsTask();
            TheCubeOfTask theCube = new TheCubeOfTask();
            SwapTwoNumbersTask swapTwo = new SwapTwoNumbersTask();
            Console.WriteLine(addtwonumber.AddAndMultiply(3, 6, 35));
            Console.WriteLine(addtwonumber.AddAndMultiply(-12, 5, 17));
            Console.WriteLine(addtwonumber.AddAndMultiply(-40, 50, 60));
            Console.WriteLine(addtwonumber.AddAndMultiply(1.7, 9.9, 0.01));
            Console.WriteLine(celsiusandfrehranhait.CtoF(0));     // T = 32F
            Console.WriteLine(celsiusandfrehranhait.CtoF(-300));  // Temperature below absolute zero!
            Console.WriteLine(celsiusandfrehranhait.CtoF(28.5));
            Console.WriteLine(ElementaryOperationsTask.ElementaryOperations(36, 15));   // a + b = 51, a - b = 21, a * b = 540, a / b = 2.4
            Console.WriteLine(ElementaryOperationsTask.ElementaryOperations(-375, 25));
            Console.WriteLine(IsResultTheSameTask.IsResultTheSame(3 * 3, 18 / 2));           // True
            Console.WriteLine(IsResultTheSameTask.IsResultTheSame(3 + 7, 12 - 8));           // False
            Console.WriteLine(IsResultTheSameTask.IsResultTheSame(3 * 7 * 8, 256 / 2 / 3));
            Console.WriteLine(ModuloOperationsTask.ModuloOperations(542, 28, 7));    // 3
            Console.WriteLine(ModuloOperationsTask.ModuloOperations(33, 10, 2));     // 1
            Console.WriteLine(ModuloOperationsTask.ModuloOperations(2634, 892, 55));
            Console.WriteLine(TheCubeOfTask.TheCubeOf(15));    // 3375
            Console.WriteLine(TheCubeOfTask.TheCubeOf(0.25));  // 0.015625
            Console.WriteLine(TheCubeOfTask.TheCubeOf(-12));   // -1728
            Console.WriteLine(TheCubeOfTask.TheCubeOf(-0.1));
            Console.WriteLine(SwapTwoNumbersTask.SwapTwoNumbers(23, 15));      // Before: a = 23, b = 15; After: a = 15, b = 23
            Console.WriteLine(SwapTwoNumbersTask.SwapTwoNumbers(-123, 999));   // Before: a = -123, b = 999; After: a = 999, b = -123
            Console.WriteLine(SwapTwoNumbersTask.SwapTwoNumbers(0, 333));// 25// T = 83.3F
            AbsoluteValueTask a = new AbsoluteValueTask();
            Console.WriteLine(a.AbsoluteValue(-690543));  // 690543
            Console.WriteLine(a.AbsoluteValue(2744));     // 2744
            Console.WriteLine(a.AbsoluteValue(0));        // 0           
            Console.WriteLine(a.AbsoluteValue(-23));
            DivisibleBy2Or3Task b = new DivisibleBy2Or3Task();
            Console.WriteLine(b.DivisibleBy2Or3(2, 18));   // 36
            Console.WriteLine(b.DivisibleBy2Or3(7, 0));    // 7
            Console.WriteLine(b.DivisibleBy2Or3(33, 9));   // 297
            Console.WriteLine(b.DivisibleBy2Or3(-72, 54)); // -3888
            Console.WriteLine(b.DivisibleBy2Or3(24, -80)); // -1920
            Console.WriteLine(b.DivisibleBy2Or3(444, 0));
            IfGreaterThanThirdOneTask c = new IfGreaterThanThirdOneTask();
            Console.WriteLine(c.IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));      // False
            Console.WriteLine(c.IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));     // True
            Console.WriteLine(c.IfGreaterThanThirdOne(new int[] { -15, -25, 100 })); // True
            Console.WriteLine(c.IfGreaterThanThirdOne(new int[] { 11, 15, 166 })); // 0// 23
            uppercase d = new uppercase();
            Console.WriteLine(d.IfConsistsOfUppercaseLetters("drY")); // False 
            Console.WriteLine(d.IfConsistsOfUppercaseLetters("LOL")); // True
            Console.WriteLine(d.IfConsistsOfUppercaseLetters("N0t")); // False
            Console.WriteLine(d.IfConsistsOfUppercaseLetters("$1r")); // False
            IfNumberIsEvenTask e = new IfNumberIsEvenTask();
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(8));          // True
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(54749));      // False
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(-43234670));  // True
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(0));          // True
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(-950541901)); // False
            Console.WriteLine(IfNumberIsEvenTask.IfNumberIsEven(2140872324)); // True
            IfSortedAscendingTask f = new IfSortedAscendingTask();
            Console.WriteLine(IfSortedAscendingTask.IfSortedAscending(new int[] { 3, 6, 9 })); // True
            Console.WriteLine(IfSortedAscendingTask.IfSortedAscending(new int[] { 34, 17, 90 })); // False
            Console.WriteLine(IfSortedAscendingTask.IfSortedAscending(new int[] { -50, -24, -1 })); // True
            IfHasNeighbourTask g = new IfHasNeighbourTask();
            Console.WriteLine(IfHasNeighbourTask.IfHasNeighbour("DCA")); // True
            Console.WriteLine(IfHasNeighbourTask.IfHasNeighbour("PRT")); // False
            PositiveNegativeOrZeroTask h = new PositiveNegativeOrZeroTask();
            Console.WriteLine(PositiveNegativeOrZeroTask.PositiveNegativeOrZero(3.14)); // Positive
            Console.WriteLine(PositiveNegativeOrZeroTask.PositiveNegativeOrZero(0.0)); // Zero
            Console.WriteLine(PositiveNegativeOrZeroTask.PositiveNegativeOrZero(-200.003)); // Negative
            IfYearIsLeapTask i = new IfYearIsLeapTask();
            Console.WriteLine(IfYearIsLeapTask.IfYearIsLeap(2020)); // True
            Console.WriteLine(IfYearIsLeapTask.IfYearIsLeap(1719)); // False
            Console.WriteLine(IfYearIsLeapTask.IfYearIsLeap(2000)); // True
            Console.WriteLine(IfYearIsLeapTask.IfYearIsLeap(1412)); // True
            Console.WriteLine(IfYearIsLeapTask.IfYearIsLeap(1582)); // False
            IfNumberContains3Task j = new IfNumberContains3Task();
            Console.WriteLine(IfNumberContains3Task.IfNumberContains3(5384562)); // true
            Console.WriteLine(IfNumberContains3Task.IfNumberContains3(0));       // false
            Console.WriteLine(IfNumberContains3Task.IfNumberContains3(390462));  // true
            MultiplicationTableTask k = new MultiplicationTableTask();
            MultiplicationTableTask.MultiplicationTable();
            FractionsSumTask l = new FractionsSumTask();
            Console.WriteLine(FractionsSumTask.FractionsSum(2));  // 1.25
            Console.WriteLine(FractionsSumTask.FractionsSum(7));  // 1.5117970521542
            Console.WriteLine(FractionsSumTask.FractionsSum(10)); // 1.54976773116654
            //SortArrayAscendingTask m = new SortArrayAscendingTask();
            //int[] sortedArr = SortArrayAscendingTask.SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });
            
            //foreach (var s in sortedArr)
            //{
            //    Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
            //}
            TheBiggestNumberTask n = new TheBiggestNumberTask();
            Console.WriteLine(TheBiggestNumberTask.TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));                   // 9
            Console.WriteLine(TheBiggestNumberTask.TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));       // -7
            Console.WriteLine(TheBiggestNumberTask.TheBiggestNumber(new int[] { 1009, 998, 1090, 3000, 2934, 4888 }));  // 4888
            Two7sNextToEachOtherTask o = new Two7sNextToEachOtherTask();
            Console.WriteLine(Two7sNextToEachOtherTask.Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));           // 1
            Console.WriteLine(Two7sNextToEachOtherTask.Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));           // 0      
            Console.WriteLine(Two7sNextToEachOtherTask.Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));  // 3
            ThreeIncreasingAdjacentTask p = new ThreeIncreasingAdjacentTask();
            Console.WriteLine(ThreeIncreasingAdjacentTask.ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));                // True
            Console.WriteLine(ThreeIncreasingAdjacentTask.ThreeIncreasingAdjacent(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 }));       // True
            Console.WriteLine(ThreeIncreasingAdjacentTask.ThreeIncreasingAdjacent(new int[] { 15, 17, 14, 11, 18, 19, 16, 16 }));     // False
            ReturnEvenNumbersTask q = new ReturnEvenNumbersTask();
            Console.WriteLine(ReturnEvenNumbersTask.ReturnEvenNumbers());
            //SieveOfEratosthenesTask r = new SieveOfEratosthenesTask();
            //var arrayOfPrimes = SieveOfEratosthenesTask.SieveOfEratosthenes(100);
            //for (int i = 0; i < arrayOfPrimes.Length; i++)
            //{
            //    if (arrayOfPrimes[i] != false)
            //    {
            //        Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 
            //    }
            //}
            DrawHourglassTask s = new DrawHourglassTask();
            DrawHourglassTask.DrawHourglass();
            DrawParallelogramTask t = new DrawParallelogramTask();
            DrawParallelogramTask.DrawParallelogram();
            DrawChristmasTreeTask u = new DrawChristmasTreeTask();
            DrawChristmasTreeTask.DrawChristmasTree();
            FullSequenceOfLettersTask v = new FullSequenceOfLettersTask();
            Console.WriteLine(FullSequenceOfLettersTask.FullSequenceOfLetters("bg")); // bcdefg
            Console.WriteLine(FullSequenceOfLettersTask.FullSequenceOfLetters("xy")); // xy            
            Console.WriteLine(FullSequenceOfLettersTask.FullSequenceOfLetters("az")); // abcdefghijklmnopqrstuvwxyz
            LongestStrictlyIncreasingSequenceTask w = new LongestStrictlyIncreasingSequenceTask();
            Console.WriteLine(LongestStrictlyIncreasingSequenceTask.LongestStrictlyIncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 })); // 4
            Console.WriteLine(LongestStrictlyIncreasingSequenceTask.LongestStrictlyIncreasingSequence(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 })); // 1
            Console.WriteLine(LongestStrictlyIncreasingSequenceTask.LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 })); // 6
            Console.WriteLine(LongestStrictlyIncreasingSequenceTask.LongestStrictlyIncreasingSequence(new int[] { 1, 1, 1, 1, 1, })); // 0
            BitsToNumberTask x = new BitsToNumberTask();
            Console.WriteLine(BitsToNumberTask.BitsToNumber("0"));                   // 0
            Console.WriteLine(BitsToNumberTask.BitsToNumber("00001011000001"));      // 705
            Console.WriteLine(BitsToNumberTask.BitsToNumber("10001110001010100"));   // 72288
            DigitsSumTask y = new DigitsSumTask();
            Console.WriteLine(DigitsSumTask.DigitsSum(5));                   // 5
            Console.WriteLine(DigitsSumTask.DigitsSum(1029584739)); // 48
            Console.WriteLine(DigitsSumTask.DigitsSum(99999999));    // 72
            SumAndAverageTask z = new SumAndAverageTask();
            Console.WriteLine(SumAndAverageTask.SumAndAverage(20, 21)); // Sum: 41 Average: 20,5
            Console.WriteLine(SumAndAverageTask.SumAndAverage(55, 55)); // Sum: 55 Average: 55
            Console.WriteLine(SumAndAverageTask.SumAndAverage(0, 100)); // Sum: 5050 Average: 50
            SumDoubleOnlyTask sum = new SumDoubleOnlyTask();
            Console.WriteLine(SumDoubleOnlyTask.SumDoubleOnly(new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true })); // 24.89
            DrawTriangleTask task = new DrawTriangleTask();
            DrawTriangleTask.DrawTriangle();
            ToThePowerOfTask pow = new ToThePowerOfTask();
            Console.WriteLine(ToThePowerOfTask.ToThePowerOf(10, 0)); // 1
            Console.WriteLine(ToThePowerOfTask.ToThePowerOf(5, -2)); // 0.04
            Console.WriteLine(ToThePowerOfTask.ToThePowerOf(8, -8)); // 5.96046447753906E-08
            Console.WriteLine(ToThePowerOfTask.ToThePowerOf(0, 5));  // 0
            LettersBalanceTask letters = new LettersBalanceTask();


            Console.WriteLine(LettersBalanceTask.LettersBalance("kfdfdk"));           // True
            Console.WriteLine(LettersBalanceTask.LettersBalance("reyjer"));           // False
            Console.WriteLine(LettersBalanceTask.LettersBalance("wkxzcsazsckawx"));   // True
            Console.WriteLine(LettersBalanceTask.LettersBalance("pkmqsdedeskgqm"));   // False
            ReplaceWordsTask replaceWord = new ReplaceWordsTask();
            Console.WriteLine(ReplaceWordsTask.ReplaceWords("dog_octopus", '_'));     // octopus_dog
            Console.WriteLine(ReplaceWordsTask.ReplaceWords("a.b", '.'));                     // b.a
            Console.WriteLine(ReplaceWordsTask.ReplaceWords("good very", ' '));         // very good
            DigitalRootTask root = new DigitalRootTask();
            Console.WriteLine(DigitalRootTask.DigitalRoot(5));          // 5
            Console.WriteLine(DigitalRootTask.DigitalRoot(1029584739)); // 3
            Console.WriteLine(DigitalRootTask.DigitalRoot(99999999));   // 9
            CheckBracketsSequenceTask checkBrackets = new CheckBracketsSequenceTask();
            Console.WriteLine(CheckBracketsSequenceTask.CheckBracketsSequence("((()()()))"));           // True
            Console.WriteLine(CheckBracketsSequenceTask.CheckBracketsSequence(")"));                    // False
            Console.WriteLine(CheckBracketsSequenceTask.CheckBracketsSequence(")(())("));               // True
            Console.WriteLine(CheckBracketsSequenceTask.CheckBracketsSequence("()())()"));              // False
            Console.WriteLine(CheckBracketsSequenceTask.CheckBracketsSequence("((()(((()())))())())")); // True
            AddSeparatorTask ad = new AddSeparatorTask();
            Console.WriteLine(AddSeparatorTask.AddSeparator("computer", "_"));  // c_o_m_p_u_t_e_r
            Console.WriteLine(AddSeparatorTask.AddSeparator("$*(#", " "));       // $ * ( #
            Console.WriteLine(AddSeparatorTask.AddSeparator("AC", "B"));        // ABC
            Console.WriteLine(AddSeparatorTask.AddSeparator("octopus", "X"));   // oXcXtXoXpXuXs
            IsPalindromeTask palindromeTask = new IsPalindromeTask();
            Console.WriteLine(IsPalindromeTask.IsPalindrome("madam"));                          // True
            Console.WriteLine(IsPalindromeTask.IsPalindrome("123454321"));                    // True
            Console.WriteLine(IsPalindromeTask.IsPalindrome("apple"));                             // False
            Console.WriteLine(IsPalindromeTask.IsPalindrome("Never Odd Or Even"));       // True
            Console.WriteLine(IsPalindromeTask.IsPalindrome("Curabitur vel est diam"));   // False
            Console.WriteLine(IsPalindromeTask.IsPalindrome("x"));

            //LengthOfAStringTask length = new LengthOfAStringTask();
            //Console.WriteLine(LengthOfAStringTask.LengthOfAString("Lorem ipsum dolor sit amet")); //26
            //Console.WriteLine(LengthOfAStringTask.LengthOfAString(string.Empty));                 //0
            //Console.WriteLine(LengthOfAStringTask.LengthOfAString("conse12ctetur "));


            StringInReverseOrderTask reverse = new StringInReverseOrderTask();
            Console.WriteLine(StringInReverseOrderTask.StringInReverseOrder("Vivamus commodo quam at purus ")); //  surup ta mauq odommoc sumaviV
            Console.WriteLine(StringInReverseOrderTask.StringInReverseOrder("34 ( 9  9@*"));                    // *@9  9 ( 43
            Console.WriteLine(StringInReverseOrderTask.StringInReverseOrder("malesuada"));                      // adauselam
            MakeUppercaseTask upper = new MakeUppercaseTask();
            Console.WriteLine(MakeUppercaseTask.MakeUppercase("very short sentence."));   // VeRy ShOrT SeNtEnCe.
            Console.WriteLine(MakeUppercaseTask.MakeUppercase("motorcycle"));             // MoToRcYcLe
            Console.WriteLine(MakeUppercaseTask.MakeUppercase("Events And Delegates"));   // EvEnTs AnD DeLeGaTeS
            MixTwoStringsTask str = new MixTwoStringsTask();
            Console.WriteLine(MixTwoStringsTask.MixTwoStrings("DoG", "ElEpHaNt"));           // DEolGEpHaNt
            Console.WriteLine(MixTwoStringsTask.MixTwoStrings("The tallest", "XXXXXXXXXX")); // TXhXeX XtXaXlXlXeXsXt
            NumberOfWordsTask words = new NumberOfWordsTask();
            Console.WriteLine(NumberOfWordsTask.NumberOfWords("Mauris consectetur urna sit amet risus ultricies rutrum.")); // 8
            Console.WriteLine(NumberOfWordsTask.NumberOfWords("Quisque M"));                                                // 2
            Console.WriteLine(NumberOfWordsTask.NumberOfWords("Xor"));
            RevertWordsOrderTask revertWords = new RevertWordsOrderTask();

            Console.WriteLine(RevertWordsOrderTask.RevertWordsOrder("Proin in odio viverra, accumsan purus vel, placerat elit!")); // elit placerat vel, purus accumsan viverra, odio in Proin!
            Console.WriteLine(RevertWordsOrderTask.RevertWordsOrder("Cras iaculis tortor justo."));
            HowManyOccurrencesTask how = new HowManyOccurrencesTask();
            Console.WriteLine(HowManyOccurrencesTask.HowManyOccurrences("He is a good boy, he would never do that!", "he"));           // 1
            Console.WriteLine(HowManyOccurrencesTask.HowManyOccurrences("104 593 00-930 720193", "93"));                               // 3
            Console.WriteLine(HowManyOccurrencesTask.HowManyOccurrences("xyz", "a"));
            SortCharactersDescendingTask sort = new SortCharactersDescendingTask();
            Console.WriteLine(SortCharactersDescendingTask.SortCharactersDescending("Aliquam pulvinar aliquam libero, in fringilla erat.")); // vuuutrrrrqqponnnmmlllllliiiiiiigfeebaaaaaaA.,            
            Console.WriteLine(SortCharactersDescendingTask.SortCharactersDescending("Thi2 12  5@mpl3 Str!nG~"));
            CompressString com = new CompressString();
            Console.WriteLine(CompressString.CompressStrin("aaaabbcccccdaa"));    //a4b2c5d1a2
            Console.WriteLine(CompressString.CompressStrin("948kro"));            //914181k1r1o1
            Console.WriteLine(CompressString.CompressStrin("$999j*#jjjfYyyy"));   //$193j1*1#1j3f1Y1y3
            DigitsMultiplicationTask hh = new DigitsMultiplicationTask();
            Console.WriteLine(DigitsMultiplicationTask.DigitsMultiplication(1234));       // 24
            Console.WriteLine(DigitsMultiplicationTask.DigitsMultiplication(94632));      // 1296
            Console.WriteLine(DigitsMultiplicationTask.DigitsMultiplication(222222222));  // 512
            FactorialTask fact = new FactorialTask();
            Console.WriteLine(FactorialTask.Factorial(5));  // 120
            Console.WriteLine(FactorialTask.Factorial(1));  // 1
            Console.WriteLine(FactorialTask.Factorial(14)); // 87178291200
            Console.WriteLine(FactorialTask.Factorial(0));  // 1
            Console.WriteLine(FactorialTask.Factorial(20)); // 2432902008176640000
            NumbersMultiplicationTask multiple = new NumbersMultiplicationTask();
            Console.WriteLine(NumbersMultiplicationTask.NumbersMultiplication(1, 5));     // 120
            Console.WriteLine(NumbersMultiplicationTask.NumbersMultiplication(-27, -22)); // 213127200
            Console.WriteLine(NumbersMultiplicationTask.NumbersMultiplication(44, 44));   // 44  
            ToThePowerOfRecursionTask power = new ToThePowerOfRecursionTask();
            Console.WriteLine(ToThePowerOfRecursionTask.ToThePowerOfRecursion(10, 0)); // 1
            Console.WriteLine(ToThePowerOfRecursionTask.ToThePowerOfRecursion(3, 7));  // 2187
            Console.WriteLine(ToThePowerOfRecursionTask.ToThePowerOfRecursion(2, 10)); // 1024
            var str1 = "A";
            var str2 = "34 ( 9  9@*";
            var str3 = "eMpIrE";
            var str4 = string.Empty;
            StringInReverseOrderRecursionTask rev = new StringInReverseOrderRecursionTask();
            Console.WriteLine(StringInReverseOrderRecursionTask.StringInReverseOrderRecursion(str1)); // A
            Console.WriteLine(StringInReverseOrderRecursionTask.StringInReverseOrderRecursion(str2)); // *@9  9 ( 43
            Console.WriteLine(StringInReverseOrderRecursionTask.StringInReverseOrderRecursion(str3)); // ErIpMe
            Console.WriteLine(StringInReverseOrderRecursionTask.StringInReverseOrderRecursion(str4)); //
            IsPalindromeRecursionTask recursion = new IsPalindromeRecursionTask();
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("aa"));        // True
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("dad"));       // True
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("apple"));     // False
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("deleveled")); // True
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion(""));          // False
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("hannah"));    // True
            Console.WriteLine(IsPalindromeRecursionTask.IsPalindromeRecursion("X"));         // True
            MinimumElementTask mini = new MinimumElementTask();
            Console.WriteLine(MinimumElementTask.MinimumElement(new int[] { 7, 2, 9, 5, 4 }, 5));                  // 2
            Console.WriteLine(MinimumElementTask.MinimumElement(new int[] { -45, -6, 39, 96, -20, 0, -100 }, 7));  // -100
            Console.WriteLine(MinimumElementTask.MinimumElement(new int[] { 830, 905, 999, 831, 920, 900 }, 6));   // 830
            NegativeOrPositiveTask pos = new NegativeOrPositiveTask();
            Console.WriteLine(NegativeOrPositiveTask.NegativeOrPositive(72946));       // 270.085171751431
            Console.WriteLine(NegativeOrPositiveTask.NegativeOrPositive(-4.726));      // 22.335076
            Console.WriteLine(NegativeOrPositiveTask.NegativeOrPositive(0));             // 0
            Console.WriteLine(NegativeOrPositiveTask.NegativeOrPositive(3.334));       // 1.82592442340859
            Console.WriteLine(NegativeOrPositiveTask.NegativeOrPositive(-59));         // 3481
            ReplaceXWithYTask replace = new ReplaceXWithYTask();
            Console.WriteLine(ReplaceXWithYTask.ReplaceXWithY("yyy"));                                   // xxx
            Console.WriteLine(ReplaceXWithYTask.ReplaceXWithY("strawberry youghurt"));                   // strawberrx xoughurt
            Console.WriteLine(ReplaceXWithYTask.ReplaceXWithY("tym ryhosx oifg 6 t6 ypeg ergh"));        // txm rxhosx oifg 6 t6 xpeg ergh
            Console.WriteLine(ReplaceXWithYTask.ReplaceXWithY(""));
            ToLowerOrToUpperTask to = new ToLowerOrToUpperTask();
            Console.WriteLine(ToLowerOrToUpperTask.ToLowerOrToUpper("aaa BBB ccc DDD"));                             // AAA bbb CCC ddd
            Console.WriteLine(ToLowerOrToUpperTask.ToLowerOrToUpper("Etiam mollis lectus ac facilisis venenatis"));  // ETIAM mollis LECTUS ac FACILISIS venenatis
            Console.WriteLine(ToLowerOrToUpperTask.ToLowerOrToUpper("th1s 15 5amp13 53nt3nc3"));
            IfStartsWithLowerCaseTask low = new IfStartsWithLowerCaseTask();
            Console.WriteLine(IfStartsWithLowerCaseTask.IfStartsWithLowerCase("tthis iis ffake ssentence."));       // this is fake sentence.
            Console.WriteLine(IfStartsWithLowerCaseTask.IfStartsWithLowerCase("Praesent vitae convallis purus."));  // Praesent itae onvallis urus.
            Console.WriteLine(IfStartsWithLowerCaseTask.IfStartsWithLowerCase("1 2 3 7 8 9 a b c x y z"));          // 1 2 3 7 8 9

            NegativePositiveTask ne = new NegativePositiveTask();
            Console.WriteLine(NegativePositiveTask.NegativeOrPositive(72946));       // 270.085171751431
            Console.WriteLine(NegativePositiveTask.NegativeOrPositive(-4.726));      // 22.335076
            Console.WriteLine(NegativePositiveTask.NegativeOrPositive(0));             // 0
            Console.WriteLine(NegativePositiveTask.NegativeOrPositive(3.334));       // 1.82592442340859
            Console.WriteLine(NegativePositiveTask.NegativeOrPositive(-59));         // 3481
            AlmostOnlyLettersTask al = new AlmostOnlyLettersTask();
            Console.WriteLine(AlmostOnlyLettersTask.AlmostOnlyLetters("Very hot."));      // True
            Console.WriteLine(AlmostOnlyLettersTask.AlmostOnlyLetters("full of hope"));   // False
            Console.WriteLine(AlmostOnlyLettersTask.AlmostOnlyLetters(""));               // False
            Console.WriteLine(AlmostOnlyLettersTask.AlmostOnlyLetters("short."));         // True
            CheckPhoneNumberTask gg = new CheckPhoneNumberTask();
            Console.WriteLine(CheckPhoneNumberTask.CheckPhoneNumber("+48 592-045-990"));    // True
            Console.WriteLine(CheckPhoneNumberTask.CheckPhoneNumber("+999 543-000-305"));   // False
            Console.WriteLine(CheckPhoneNumberTask.CheckPhoneNumber("00 204-145-722"));     // False
            Console.WriteLine(CheckPhoneNumberTask.CheckPhoneNumber("+47 420-053-934"));    // True
            DecimalDigitInformationTask info = new DecimalDigitInformationTask();
            Console.WriteLine(DecimalDigitInformationTask.DecimalDigitInformation("The 7 is the digit!"));    // Digit 7 at position 4
            Console.WriteLine(DecimalDigitInformationTask.DecimalDigitInformation("Hamster and lion"));       // No digit found!
            Console.WriteLine(DecimalDigitInformationTask.DecimalDigitInformation("1st"));
            EveryWordInTheStringTask jj = new EveryWordInTheStringTask();
            Console.WriteLine(EveryWordInTheStringTask.EveryWordInTheString("I Love You"));                    // True
            Console.WriteLine(EveryWordInTheStringTask.EveryWordInTheString("Greater Than 9"));                // False
            Console.WriteLine(EveryWordInTheStringTask.EveryWordInTheString("Pig And Horse!!!"));              // True
            Console.WriteLine(EveryWordInTheStringTask.EveryWordInTheString("Make   Some      Whitespaces?")); // True
            Console.WriteLine(EveryWordInTheStringTask.EveryWordInTheString("As Fit As a Fiddle."));
            ReplaceGoodWithBadTask tak = new ReplaceGoodWithBadTask();
            Console.WriteLine(ReplaceGoodWithBadTask.ReplaceGoodWithBad("Very GoOd"));         // Very bad
            Console.WriteLine(ReplaceGoodWithBadTask.ReplaceGoodWithBad("GooDgOOdGOODgood"));  // badbadbadbad
            Console.WriteLine(ReplaceGoodWithBadTask.ReplaceGoodWithBad("Not so g00d"));   
            // Not so g00d// False// Digit 1 at position 0







        }





    }
    
}

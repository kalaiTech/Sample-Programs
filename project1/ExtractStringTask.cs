using System;

namespace project1
{
    class ExtractStringTask
    {
        class AlmostOnlyLettersTask
        {
            public static void Main()
            {
                List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };

                var SelectedNumbers = Numbers.Where(x => x > 30).Where(x => x < 100);

                foreach (var s in SelectedNumbers)
                {
                    Console.Write($"{s} "); // 54 82 95
                }
            }
        }
    }
}

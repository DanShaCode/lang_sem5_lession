// string s1 = "Bob";
// string s2 = "Mary";
// string s3 = s1 + " - " + s2;

// string s4 = string.Concat(s2, " - ", s1);
// Console.WriteLine(s3);
// Console.WriteLine(s4);

// int num = 12345;
// string sNum = Convert.ToString(num);

// int s3Len = sNum.Length;
// Console.WriteLine(sNum.Length);

// Console.WriteLine(s2[0]);

// string[] names = {"Bob", "Anna", "Artem", "Dida"};
// int[] age = {22, 25, 2, 60};

// string s10 = string.Join(" ", names);
// Console.WriteLine(s10);

// string s11 = string.Join("----", age);
// Console.WriteLine(s11);

// string s = "1, 2, 3, 4, 5, 6, 7.";

// string[] nums = s.Split(new char [] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

// foreach (var num in nums)
// {
//     Console.WriteLine($"Значение: {num}");
// }

// int[] n = nums.Select(Int32.Parse).ToArray();
// foreach (var i in n)
// {
//     Console.Write($"{i} ");
// }

// int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
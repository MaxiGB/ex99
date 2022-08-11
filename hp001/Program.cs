Console.WriteLine(Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).Max());

Console.WriteLine((int.Parse(Console.ReadLine()) & 1) == 0? "Yes": "No");

foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))

Console.WriteLine(i << 1);


string[] lines = File.ReadAllLines("./Input/input.txt");
Console.WriteLine(lines.Length);

int[] array = new int[lines.Length];
int currentIndex = 0;

foreach (string line in lines)
{
    if (!string.IsNullOrEmpty(line))
    {
        int value = int.Parse(line);
        array[currentIndex] += value;
    }
    else
    {
        currentIndex++;
    }
}
int maxIndex = 0;
int maxValue = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue)
    { maxValue = array[i]; 
    maxIndex = i; }
}
Console.WriteLine("Index with highest value: " + maxIndex + " And Max Calorie =" + maxValue);

Dictionary<int, int> dict = array.Select((value, index) => new { index, value })
                                     .ToDictionary(x => x.index, x => x.value);

var top3 = dict.OrderByDescending(x => x.Value).Take(3);
Console.WriteLine("Top 3 values");
foreach (var item in top3)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
int total = 0;
foreach (var item in top3)
{
    total += item.Value;
}
Console.WriteLine($"Top3Total -> {total}");
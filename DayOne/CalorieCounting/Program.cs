string[] lines = File.ReadAllLines("./Input/input.txt");

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
    { maxValue = array[i]; maxIndex = i; }
}
Console.WriteLine("Index with highest value: " + maxIndex);
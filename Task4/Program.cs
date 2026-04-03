//Task 1

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int count = 0;
foreach (int i in numbers)
{
    count = count + i;
}
Console.WriteLine($"Sum={count}");



//Task 2


int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

Array.Sort(temps);

int min = temps[0];
int max = temps[temps.Length - 1];

Console.WriteLine($"Min = {min}, Max = {max}");


int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

int minLoop = temps[0];
int maxLoop = temps[0];

foreach (int t in temps)
{
    minLoop = Math.Min(minLoop, t);
    maxLoop = Math.Max(maxLoop, t);
}

Console.WriteLine($"Min = {minLoop}, Max = {maxLoop}");


//Task 3

string[] words = { "apple", "banana", "cherry", "date" }
;
for (int i = 0; i < words.Length / 2; i++)
{
    int j = words.Length - i - 1;
    (words[i], words[j]) = (words[j], words[i]);
}
Console.WriteLine($"Expected output:{string.Join(" ", words)}");

string[] words = { "apple", "banana", "cherry", "date" };
Array.Reverse(words);
Console.WriteLine($"Expected output:{string.Join(" ", words)}");

//Task 4

int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
int even = 0;
int odd = 0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0)
    {
        even++;
    }
    if (data[i] % 2 != 0)
    {
        odd++;
    }
}
Console.WriteLine($"Even = {even}, Odd = {odd}");


//Task 5

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
int[] a = new int[raw.Length];
int count = 0;

for (int i = 0; i < raw.Length; i++)
{
    if (Array.IndexOf(a, raw[i], 0, count) == -1)
    {
        a[count] = raw[i];
        count++;
    }
}
int[] unique = new int[count];
for (int i = 0; i < count; i++)
{
    unique[i] = a[i];
}

Console.WriteLine(string.Join(" ", unique));

//Task 6

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    int[] result = new int[n];

    k = k % n;

    for (int i = 0; i < n; i++)
    {
        result[i] = arr[(i + k) % n];
    }

    return result;
}

int[] rotated = RotateLeft(arr, k);
Console.WriteLine(string.Join(" ", rotated));
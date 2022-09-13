string[] array =
{
    "A",
    "bbBb",
    "C",
    "DdDd",
    "Eeee",
    "FffffF"
};
Console.WriteLine("array [" + string.Join(",", array) + "]");
Random Rand = new Random();
int size =  Rand.Next(0,4);
string[] ArrayResalt = new string[size];
for (int i = 0; i <size; i++)
    { int j = Rand.Next(0, array.Length);
        ArrayResalt[i] = array[j];
    }

Console.WriteLine("new array [" + string.Join(",", ArrayResalt) + "]");

int[] Nubers = new int[10]  {11, 18, 25, 47, 53, 76, 84, 89, 92, 97 };
int count = 0;
foreach (int number in Nubers)
{
   
    if (number % 2 == 0)
    {
         count= count + 1;
    }

}
Console.WriteLine(count);

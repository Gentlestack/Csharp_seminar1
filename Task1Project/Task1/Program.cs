int[] Nubers = new int[10]  {7, 18, 20, 47, 58, 76, 83, 90, 95, 99 };
int count = 0;
foreach (int number in Nubers)
{
   
    if ((number <  90) && (number > 20))
    {
         count= count + 1;
    }
 
}
Console.WriteLine(count);
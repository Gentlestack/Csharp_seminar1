using System.Globalization;

double[] Numbers = new double[5]  {  7.24 , 18.35, 20.47 , 47.12, 58.78 };
double min = Numbers[0]; 
double max = Numbers[0];

foreach (double number in Numbers)
{
   
    if (number<min)
    {
         min=number;
    }
    if(number>max)
    {
        max=number;
    }
}

Console.WriteLine(max-min);
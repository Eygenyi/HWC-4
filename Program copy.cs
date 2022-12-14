
Console.WriteLine("Input number:");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree:");
int dee = Convert.ToInt32(Console.ReadLine());
int temp=1;
int i=0;
while (i<dee)
{
    temp=temp*numb;
    i++;
}
Console.WriteLine("Number "+numb+" in "+dee+" degree="+temp);
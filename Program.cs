Console.WriteLine("Input number:");
int numb = Convert.ToInt32(Console.ReadLine());
int temp=0;
while (0<numb || 0>numb)
{
    temp=temp+numb%10;
    numb=numb/10;
}
Console.WriteLine("Summ numbers is: " + Math.Abs(temp));
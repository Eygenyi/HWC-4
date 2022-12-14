int [] Array()
{ 
    Console.WriteLine("Input massive Length:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n==0)
    Console.WriteLine("No massive");
    
    int [] arr = new int [n];
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.WriteLine("Input massive element "+(i)+":");
        int test = Convert.ToInt32(Console.ReadLine());
        arr[i] = Convert.ToInt32(test);
    }
 return arr;

}
void ShowArray (int[] arr)
{
    Console.Write("Your massive is: ");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(" "+arr[i]);
    }
}

ShowArray(Array());

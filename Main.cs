public class HelloWorld
{
//Bubble Sort
    public static void Main(string[] args)
    {
        int[] arr={10,14,24,12,6};
        int temp;
        for(int i=0;i<=arr.Length-2;i++)
        {
            for(int j=0;j<=arr.Length-2;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    temp=arr[j+1];
                    arr[j+1]=arr[j];
                    arr[j]=temp;
                }
            }
        }
        Console.WriteLine("Sorted:");
        foreach(int p in arr )
        {
             Console.Write(p + " ");
        }
          
    }
}

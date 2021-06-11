using System;

class GFG
{

    static int mostFrequent(int[] arr, int n)
    {

      
        Array.Sort(arr);


        int max_count = 1, res = arr[0];
        int curr_count = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
                curr_count++;
            else
            {
                if (curr_count > max_count)
                {
                    max_count = curr_count;
                    res = arr[i - 1];
                }
                curr_count = 1;
            }
        }

      
        if (curr_count > max_count)
        {
            max_count = curr_count;
            res = arr[n - 1];
        }

        return res;
    }


    public static void Main()
    {

        Console.WriteLine("please input arr length");
        int n= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input array");
        String arr1 = Console.ReadLine();
        String[] arr2 = arr1.Split(" ");
        int[] arr = new int[arr2.Length];
        for(int i = 0; i < arr2.Length; i++)
        {
            arr[i]=Convert.ToInt32(arr2[i]);
        }






        Console.WriteLine(mostFrequent(arr, n));

    }
}
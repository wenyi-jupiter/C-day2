using System;

namespace Exercise3
{
    class Program
    {

        public int solution(int A,int B)

        {
            int count = 0;
            for(int i = A; i <= B; i++)
            {
                if (Math.Sqrt(i) % 2 == 0 || Math.Sqrt(i) % 2==1)
                {
                    count = count + 1;
                    
                }
            }
            return count;
            
        }

        public int A()
        {
            int a = 1;
            a = a + 1;
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input B");
            int B = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            //p.solution(A, B);
            
            Console.WriteLine(p.solution(A, B));
            

        }
    }
}


namespace Latihan
{
    public class Task1
    {
        public  void Latihan_Task_1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i% 5 == 0) 
                {
                    Console.WriteLine("foobar");
                }
                else if (i % 5 ==0)
                {
                    Console.WriteLine("bar");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("foo");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}

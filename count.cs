using System;

namespace countTest
{
    class count
    {
        static void Main(string[] args) {
             int sum = 0;
             for (int i = 0; i < 100000000; i++) {
                  sum += i;
             }
             Console.WriteLine(sum);
        }
    }
}

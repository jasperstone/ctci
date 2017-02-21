using System;
using Chapter01;
using ctci.Contracts;

namespace ctci
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuestion[] questions = {
                                        new Q01_1()
                                    };

            foreach(var q in questions)
            {
                Console.WriteLine(string.Format("{0}{1}", Environment.NewLine, Environment.NewLine));
                Console.WriteLine(string.Format("// Executing: {0}", q.GetType().ToString()));
                Console.WriteLine("---------------------------------------------------------");
                q.Run();

                Console.WriteLine(string.Format("{0}{1}", Environment.NewLine, Environment.NewLine));
                Console.WriteLine("Press [Enter] to Quit");
                Console.ReadLine();
            }
        }
    }
}

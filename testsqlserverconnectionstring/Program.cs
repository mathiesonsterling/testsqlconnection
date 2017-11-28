using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsqlserverconnectionstring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("No argument for connection string provided!");
                return;
            }

            var sqlda = new SqlDataAccess(args[0], Console.WriteLine);

            var res = sqlda.Connect().Result;

            Console.WriteLine(res ? "Connected to database" : "Could not connect to db");
        }
    }
}

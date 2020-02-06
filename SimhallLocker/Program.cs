using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimhallLocker
{
    class Program
    {
        static void Main(string[] args)
        {
            LockerRoomTest(args);
            Console.ReadKey();
        }
        public static void LockerRoomTest(String[] args)
        {
            LockerRoom<String> stringLockers = new LockerRoom<String>();
            stringLockers.Add(1, new Locker<String>("junk"));
            stringLockers.Add(3, new Locker<String>("towel"));
            stringLockers.Add(4, new Locker<String>("goggles"));
            stringLockers.Add(190, new Locker<String>("snorkle"));
            Locker<String> locker = stringLockers.Find(3);
            Console.WriteLine(locker.GetContents());
            // Vi borde fått ut "towel" i terminalen
            if (stringLockers.HasThing("goggles"))
            {
                Console.WriteLine("We found goggles in a locker!");
                // borde komma ut
            }
            if (stringLockers.HasThing("sandwich"))
            {
                Console.WriteLine("We found a sandwich, ugh!");
                // borde INTE komma ut
            }
            ListOfObjects<string> list = new ListOfObjects<string>();
            list.AddObject("Forty-two");
        }
    }
}

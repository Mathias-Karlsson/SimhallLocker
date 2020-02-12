using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimhallLocker
{
    public class LockerRoom<T>
    {
        private List<Locker<T>> locks = new List<Locker<T>>();

        public void Add(int number, Locker<T> locker)
        {
            locks.Add(locker);
        }

        public Locker<T> Find(int number)
        {
            return locks;
        }
    }
}

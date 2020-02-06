using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimhallLocker
{
    public class Locker<BathingSuit>
    {
        private BathingSuit contents;

        public Locker(BathingSuit contents)
        {
            this.contents = contents;
        }

        public BathingSuit GetContents()
        {
            return contents;
        }
    }
}

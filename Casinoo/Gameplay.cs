using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casinoo
{
    internal class Gameplay
    {
        public static int Match(int n1, int n2, int n3)
        {

            if (n1 == n2 && n2 == n3) return 3;
            else if (n1 == n2 || n2 == n3 || n1 == n3) return 2;

            return 0;
        }

        public static void Count(int count)
        {

        }
    }
}

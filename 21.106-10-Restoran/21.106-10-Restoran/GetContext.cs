using _21._106_10_Restoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._106_10_Restoran
{
    internal class GetContext
    {
        private static Entities s_Entities;
        public static Entities GetCnt()
        {
            if (s_Entities == null)
            {
                s_Entities = new Entities();
            }
            return s_Entities;
        }
    }
}

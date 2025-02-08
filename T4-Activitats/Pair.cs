using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Activitats
{
    public class Pair<T1,T2>
    {
        public T1 Ta1 { get; set; }
        public T2 Ta2 { get; set; }

        public Pair(T1 ta1,T2 ta2)
        {
            Ta1 = ta1;
            Ta2 = ta2;
        }
        public override string ToString()
        {
            return $"{Ta1} {Ta2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Rainbow
{
    internal class MyIntsCreator
    {
        static Random rand = new Random();
        List<MyInt> objects = new List<MyInt>();
        List<int> ints = new List<int>();

        public List<MyInt> CreateMyInts(int min, int max)
        {
            ints = Enumerable.Range(min,max-min).OrderBy(i => rand.Next()).ToList();
            for (int k = 0; k < ints.Count; k++)
            {
                objects.Add(new MyInt(ints[k]));
            }
            return objects;
        }
    }
}

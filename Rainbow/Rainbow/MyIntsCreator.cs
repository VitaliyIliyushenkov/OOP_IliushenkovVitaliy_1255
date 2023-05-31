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
        List<ISortable> objects = new List<ISortable>();
        List<int> ints = new List<int>();

        public List<ISortable> CreateMyInts(int min, int max)
        {
            objects.Clear();
            ints = Enumerable.Range(min,max-min+1).OrderBy(i => rand.Next()).ToList();
            for (int k = 0; k < ints.Count; k++)
            {
                MyInt myint = new MyInt
                {
                    VALUE = ints[k]
                };

                objects.Add(myint);
            }
            return objects;
        }
    }
}

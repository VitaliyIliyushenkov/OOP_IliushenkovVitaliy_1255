using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbow
{
    internal abstract class Sorter
    {
        public List<ISortable> OBJECTS = new List<ISortable>();
        public int WIDTH
        {
            get { return Form1.WIDTH_SCREEN / OBJECTS.Count(); }
            set {; }
        }
        public virtual void Sort_and_Draw(Graphics gr) { }
    }
}

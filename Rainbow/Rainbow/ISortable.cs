using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rainbow
{
    internal interface ISortable : IComparable
    {
        Color GetColor(ISortable min, ISortable max);
    }
}

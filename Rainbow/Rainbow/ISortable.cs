using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rainbow
{
    internal interface ISortable
    {
        Color GetColor(int min, int max);
    }
}

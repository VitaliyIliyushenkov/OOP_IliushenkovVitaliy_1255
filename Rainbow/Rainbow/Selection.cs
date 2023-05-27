using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Selection:Sorter
    {
        public override void Sort_and_Draw(Graphics gr)
        {
            //Выборка
            for (int i = 0; i < OBJECTS.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < OBJECTS.Count; j++)
                {
                    if (OBJECTS[min].CompareTo(OBJECTS[j]) < 0)
                        min = j;
                }
                (OBJECTS[i], OBJECTS[min]) = (OBJECTS[min], OBJECTS[i]);
                System.Threading.Thread.Sleep(1);
                gr.FillRectangle(new SolidBrush(OBJECTS[i].GetColor(OBJECTS.Min(), OBJECTS.Max())), i * WIDTH, 10, WIDTH, 100);
                gr.FillRectangle(new SolidBrush(OBJECTS[min].GetColor(OBJECTS.Min(), OBJECTS.Max())), (min) * WIDTH, 10, WIDTH, 100);
            }
        }
    }
}

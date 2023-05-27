using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Insert:Sorter
    {
        public override void Sort_and_Draw(Graphics gr)
        {
            //Вставка
            for (int i = 0; i < OBJECTS.Count; i++)
            {
                ISortable temp = OBJECTS[i];
                int j = i - 1;
                while (j >= 0 && OBJECTS[j].CompareTo(temp) < 0)
                {
                    OBJECTS[j + 1] = OBJECTS[j];
                    gr.FillRectangle(new SolidBrush(OBJECTS[j + 1].GetColor(OBJECTS.Min(), OBJECTS.Max())), (j + 1) * WIDTH, 10, WIDTH, 100);
                    j--;
                }
                OBJECTS[j + 1] = temp;

                System.Threading.Thread.Sleep(1);
                gr.FillRectangle(new SolidBrush(OBJECTS[j + 1].GetColor(OBJECTS.Min(), OBJECTS.Max())), (j + 1) * WIDTH, 10, WIDTH, 100);
            }
        }

    }
}

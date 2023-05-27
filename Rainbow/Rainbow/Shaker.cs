using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Shaker : Sorter
    {
        public override void Sort_and_Draw(Graphics gr)
        {
            //Шейкер
            bool F = true;
            int start_index = 0;
            int end_index = OBJECTS.Count - 1;
            while (F)
            {
                F = false;
                for (int i = start_index; i < end_index; i++)
                {
                    if (OBJECTS[i].CompareTo(OBJECTS[i + 1]) < 0)
                    {
                        (OBJECTS[i + 1], OBJECTS[i]) = (OBJECTS[i], OBJECTS[i + 1]);
                        System.Threading.Thread.Sleep(1);
                        gr.FillRectangle(new SolidBrush(OBJECTS[i].GetColor(OBJECTS.Min(), OBJECTS.Max())), i * WIDTH, 10, WIDTH, 100);
                        gr.FillRectangle(new SolidBrush(OBJECTS[i + 1].GetColor(OBJECTS.Min(), OBJECTS.Max())), (i + 1) * WIDTH, 10, WIDTH, 100);
                        F = true;
                    }
                }
                if (F == false)
                {
                    break;
                }
                F = false;
                end_index--;

                for (int i = end_index - 1; i > start_index - 1; i--)
                {
                    if (OBJECTS[i].CompareTo(OBJECTS[i + 1]) < 0)
                    {
                        (OBJECTS[i + 1], OBJECTS[i]) = (OBJECTS[i], OBJECTS[i + 1]);
                        System.Threading.Thread.Sleep(1);
                        gr.FillRectangle(new SolidBrush(OBJECTS[i].GetColor(OBJECTS.Min(), OBJECTS.Max())), i * WIDTH, 10, WIDTH, 100);
                        gr.FillRectangle(new SolidBrush(OBJECTS[i + 1].GetColor(OBJECTS.Min(), OBJECTS.Max())), (i + 1) * WIDTH, 10, WIDTH, 100);
                        F = true;
                    }
                }
                start_index++;
            }
        }

    }
}

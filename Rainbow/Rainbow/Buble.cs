using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rainbow
{
    internal class Buble : Sorter
    {
        public override void Sort_and_Draw(Graphics gr)
        { 

            //Пузырек
            for (int i = 0; i < OBJECTS.Count - 1; i++)
            {
                for (int j = 0; j < OBJECTS.Count - i - 1; j++)
                {
                    if (OBJECTS[j].CompareTo(OBJECTS[j + 1]) < 0)
                    {
                        (OBJECTS[j + 1], OBJECTS[j]) = (OBJECTS[j], OBJECTS[j + 1]);
                        System.Threading.Thread.Sleep(1);
                        gr.FillRectangle(new SolidBrush(OBJECTS[j].GetColor(OBJECTS.Min(), OBJECTS.Max())), j * WIDTH, 10, WIDTH, 100);
                        gr.FillRectangle(new SolidBrush(OBJECTS[j + 1].GetColor(OBJECTS.Min(), OBJECTS.Max())), (j + 1) * WIDTH, 10, WIDTH, 100);
                    }
                }
            }
        }
    }
}

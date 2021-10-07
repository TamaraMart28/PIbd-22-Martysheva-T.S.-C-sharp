using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCruiser
{
    public class Docking<T> where T : class, ITransport
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        // изменить размеры мест
        private readonly int _placeSizeWidth = 322;
        private readonly int _placeSizeHeight = 66;

        public Docking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Docking<T> p, T ship)
        {
            // Прописать логику для сложения
            return true;
        }

        public static T operator -(Docking<T> p, int index)
        {
            // Прописать логику для вычитания
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Brush brushOlive = new SolidBrush(Color.Olive);
            Brush brushBrown = new SolidBrush(Color.Brown);
            Pen pen = new Pen(Color.Brown, 4);
            // свой рисунок
            /*for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                //g.FillRectangle(brush, (i+1) * _placeSizeWidth + 4, 0, 10, (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 15);
                g.DrawLine(pen, (i + 1) * _placeSizeWidth, 0, 10, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
                for (int j = 0; j < pictureHeight / _placeSizeHeight; j++)
                {
                    int indentLeft = 0;
                    if (i == 1) indentLeft = 14;
                    g.FillRectangle(brush, i * _placeSizeWidth + 2 + indentLeft, j * _placeSizeHeight + 5, _placeSizeWidth, _placeSizeHeight);
                    
                }
            }
            g.FillRectangle(brush, 0, (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 10, pictureWidth, 10);*/

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight-1; ++j)
                {
                    g.FillRectangle(brushOlive, i * _placeSizeWidth + 4, j * _placeSizeHeight + 4, _placeSizeWidth/2 - 4, _placeSizeHeight - 8);
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight - 1) * _placeSizeHeight);
            }
            g.FillRectangle(brushBrown, 0, (pictureHeight / _placeSizeHeight - 1) * _placeSizeHeight, pictureWidth, 10);
        }
    }
}

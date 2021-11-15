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
        private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 322;
        private readonly int _placeSizeHeight = 66;

        public Docking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * (height-1);
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        
        public static int operator +(Docking<T> p, T ship)
        {
            if (p._places.Count < p._maxCount)
            {
                p._places.Add(ship);
                return 1;
            }
            return -1;
        }

        public static T operator -(Docking<T> p, int index)
        {
            if (index >= p._places.Count) return null;
            else
            {
                if (p._places[index] == null) return null;
                else
                {
                    T temp = p._places[index];
                    p._places.RemoveAt(index);
                    return temp;
                }
            }
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0;  i < _places.Count;  ++i)
            {
                _places[i].SetPosition(i % (pictureWidth/_placeSizeWidth) * _placeSizeWidth + 6, 
                    i / (pictureWidth / _placeSizeWidth) * _placeSizeHeight + 8, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Brush brushOlive = new SolidBrush(Color.Olive);
            Brush brushBrown = new SolidBrush(Color.Brown);
            Pen pen = new Pen(Color.Brown, 4);
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

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
    }
}

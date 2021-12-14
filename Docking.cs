using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsCruiser
{
    public class Docking<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _placeSizeWidth = 322;
        private readonly int _placeSizeHeight = 66;
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];


        public Docking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * (height-1);
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }
        
        public static int operator +(Docking<T> p, T ship)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new DockingOverflowException();
            }
            if (p._places.Contains(ship))
            {
                throw new DockingAlreadyHaveException();
            }

            p._places.Add(ship);
            return 1;
        }

        public static T operator -(Docking<T> p, int index)
        {
            if (index >= p._places.Count || index < 0) 
            {
                throw new DockingNotFoundException(index);
            }
            if (p._places[index] == null) return null;
            else
            {
                T temp = p._places[index];
                p._places.RemoveAt(index);
                return temp;
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

        public void Sort() => _places.Sort((IComparer<T>)new ShipComparer());

        public void Dispose() {}

        public bool MoveNext()
        {
            if (_currentIndex < _places.Count - 1)
            {
                _currentIndex++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}

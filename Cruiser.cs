using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCruiser
{
    class Cruiser
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private readonly int cruiserWidth = 145;
        private readonly int cruiserHeight = 50;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        //мои свойства
        public bool Helipad { private set; get; }
        public bool Radar { private set; get; }
        public bool Gun { private set; get; }

        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool helipad, bool radar, bool gun)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Helipad = helipad;
            Radar = radar;
            Gun = gun;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveCruiser(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - cruiserWidth )
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - cruiserHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawCruiser(Graphics g)
        {
            Brush brushMain = new SolidBrush(MainColor);
            Brush brushDop = new SolidBrush(DopColor);
            Pen penDop = new Pen(DopColor);
            Pen penMain = new Pen(Color.White);
            PointF deckPoint1 = new PointF(_startPosX + 5.0F, _startPosY);
            PointF deckPoint2 = new PointF(_startPosX + 105.0F, _startPosY);
            PointF deckPoint3 = new PointF(_startPosX + 145.0F, _startPosY + 25.0F);
            PointF deckPoint4 = new PointF(_startPosX + 105.0F, _startPosY + 50.0F);
            PointF deckPoint5 = new PointF(_startPosX + 5.0F, _startPosY + 50.0F);
            PointF[] deckPoints =
                     {
                 deckPoint1,
                 deckPoint2,
                 deckPoint3,
                 deckPoint4,
                 deckPoint5
             };
            g.FillPolygon(brushMain, deckPoints);
            g.DrawEllipse(penMain, _startPosX + 90, _startPosY + 15, 20, 20);
            g.DrawRectangle(penMain, _startPosX + 60, _startPosY + 15, 18, 20);
            g.DrawRectangle(penMain, _startPosX + 42, _startPosY + 20, 18, 10);
            g.FillRectangle(brushMain, _startPosX , _startPosY + 10, 5, 10);
            g.FillRectangle(brushMain, _startPosX, _startPosY + 25, 5, 10);
            g.DrawRectangle(penMain, _startPosX, _startPosY + 10, 5, 10);
            g.DrawRectangle(penMain, _startPosX, _startPosY + 25, 5, 10);

            if (Helipad)
            {
                g.FillRectangle(brushDop, _startPosX + 10, _startPosY + 5, 35, 40);
                g.DrawRectangle(penMain, _startPosX + 11, _startPosY + 25, 14, 15);
                g.DrawRectangle(penMain, _startPosX + 28, _startPosY + 25, 14, 15);
                g.DrawRectangle(penMain, _startPosX +11 , _startPosY + 8, 14, 15);
                g.DrawRectangle(penMain, _startPosX + 28, _startPosY + 8, 14, 15);
            }

            if (Radar)
            {
                g.FillRectangle(brushDop, _startPosX + 70, _startPosY + 15, 10, 10);
                PointF radarPoint1 = new PointF(_startPosX + 70.0F, _startPosY + 20.0F);
                PointF radarPoint2 = new PointF(_startPosX + 65.0F, _startPosY + 20.0F);
                PointF radarPoint3 = new PointF(_startPosX + 75.0F, _startPosY + 25.0F);
                PointF radarPoint4 = new PointF(_startPosX + 75.0F, _startPosY + 30.0F);
                g.DrawLine(penMain, radarPoint1, radarPoint2);
                g.DrawLine(penMain, radarPoint3, radarPoint4);
            }

            if (Gun)
            {
                g.FillEllipse(brushDop, _startPosX + 115, _startPosY + 20, 10, 10);
                PointF gunPoint1 = new PointF(_startPosX + 125.0F, _startPosY + 25.0F);
                PointF gunPoint2 = new PointF(_startPosX + 135.0F, _startPosY + 20.0F);
                PointF gunPoint3 = new PointF(_startPosX + 135.0F, _startPosY + 30.0F);
                Pen pen = new Pen(DopColor);
                g.DrawLine(pen, gunPoint1, gunPoint2);
                g.DrawLine(pen, gunPoint1, gunPoint3);
            }
        }
    }
}

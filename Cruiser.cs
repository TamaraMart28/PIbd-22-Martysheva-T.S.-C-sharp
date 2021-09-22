using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCruiser
{
    public class Cruiser : Ship
    {
        /*private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private readonly int cruiserWidth = 85;
        private readonly int cruiserHeight = 20;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }*/
        public Color DopColor { private set; get; }
        //мои свойства
        public bool Helipad { private set; get; }
        public bool Radar { private set; get; }
        public bool Gun { private set; get; }

        public Cruiser(int maxSpeed, float weight, Color mainColor, Color dopColor, 
            bool helipad, bool radar, bool gun) 
            : base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Helipad = helipad;
            Radar = radar;
            Gun = gun;
        }

        /*public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool helipad, bool radar, bool gun)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Helipad = helipad;
            Radar = radar;
            Gun = gun;
        }*/

        /*public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x + 100;
            _startPosY = y + 100;
            _pictureWidth = width;
            _pictureHeight = height;
        }*/

        /*public void MoveCruiser(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - cruiserWidth - 5
                        )
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 53)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 20)
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
        }*/

        public override void DrawCruiser(Graphics g)
        {
            // отрисовка основной части
            base.DrawCruiser(g);
            Brush brushDop = new SolidBrush(DopColor);
            Pen penDop = new Pen(DopColor);
            Pen penMain = new Pen(Color.White);
            /*Brush brushMain = new SolidBrush(MainColor);
            PointF deckPoint1 = new PointF(_startPosX - 50.0F, _startPosY - 25.0F);
            PointF deckPoint2 = new PointF(_startPosX + 50.0F, _startPosY - 25.0F);
            PointF deckPoint3 = new PointF(_startPosX + 90.0F, _startPosY);
            PointF deckPoint4 = new PointF(_startPosX + 50.0F, _startPosY + 25.0F);
            PointF deckPoint5 = new PointF(_startPosX - 50.0F, _startPosY + 25.0F);
            PointF[] deckPoints =
                     {
                 deckPoint1,
                 deckPoint2,
                 deckPoint3,
                 deckPoint4,
                 deckPoint5
             };
            g.FillPolygon(brushMain, deckPoints);
            g.DrawEllipse(penMain, _startPosX + 40, _startPosY - 10, 20, 20);
            g.DrawRectangle(penMain, _startPosX + 10, _startPosY - 10, 18, 20);
            g.DrawRectangle(penMain, _startPosX - 8, _startPosY - 5, 18, 10);
            g.FillRectangle(brushMain, _startPosX - 55, _startPosY - 7, 5, 10);
            g.FillRectangle(brushMain, _startPosX - 55, _startPosY + 5, 5, 10);
            g.DrawRectangle(penMain, _startPosX - 55, _startPosY - 7, 5, 10);
            g.DrawRectangle(penMain, _startPosX - 55, _startPosY + 5, 5, 10);*/

            if (Helipad)
            {
                g.FillRectangle(brushDop, _startPosX - 45, _startPosY - 20, 35, 40);
                g.DrawRectangle(penMain, _startPosX - 44, _startPosY - 19, 14, 15);
                g.DrawRectangle(penMain, _startPosX - 26, _startPosY - 19, 14, 15);
                g.DrawRectangle(penMain, _startPosX - 44, _startPosY + 2, 14, 15);
                g.DrawRectangle(penMain, _startPosX - 26, _startPosY + 2, 14, 15);
            }

            if (Radar)
            {
                g.FillRectangle(brushDop, _startPosX + 20, _startPosY - 10, 10, 10);
                PointF radarPoint1 = new PointF(_startPosX + 20.0F, _startPosY - 5.0F);
                PointF radarPoint2 = new PointF(_startPosX + 16.0F, _startPosY - 5.0F);
                PointF radarPoint3 = new PointF(_startPosX + 24.0F, _startPosY - 1.0F);
                PointF radarPoint4 = new PointF(_startPosX + 24.0F, _startPosY + 3.0F);
                g.DrawLine(penMain, radarPoint1, radarPoint2);
                g.DrawLine(penMain, radarPoint3, radarPoint4);
            }

            if (Gun)
            {
                g.FillEllipse(brushDop, _startPosX + 65, _startPosY - 5, 10, 10);
                PointF gunPoint1 = new PointF(_startPosX + 75.0F, _startPosY);
                PointF gunPoint2 = new PointF(_startPosX + 80.0F, _startPosY + 5.0F);
                PointF gunPoint3 = new PointF(_startPosX + 80.0F, _startPosY - 5.0F);
                Pen pen = new Pen(DopColor);
                g.DrawLine(pen, gunPoint1, gunPoint2);
                g.DrawLine(pen, gunPoint1, gunPoint3);
            }
        }
    }
}

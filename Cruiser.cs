using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCruiser
{
    public class Cruiser : Ship, IEquatable<Cruiser>
    {
        public Color DopColor { private set; get; }
        //мои свойства
        public bool Helipad { private set; get; }
        public bool Radar { private set; get; }
        public bool Gun { private set; get; }

        public Cruiser(int maxSpeed, float weight, Color mainColor, Color dopColor, 
            bool helipad, bool radar, bool gun) 
            : base(maxSpeed, weight, mainColor, 145, 50)
        {
            DopColor = dopColor;
            Helipad = helipad;
            Radar = radar;
            Gun = gun;
        }

        public Cruiser(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Helipad = Convert.ToBoolean(strs[4]);
                Radar = Convert.ToBoolean(strs[5]);
                Gun = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            // отрисовка основной части
            base.DrawTransport(g);
            Brush brushDop = new SolidBrush(DopColor);
            Pen penDop = new Pen(DopColor);
            Pen penMain = new Pen(Color.White);

            if (Helipad)
            {
                g.FillRectangle(brushDop, _startPosX + 10, _startPosY + 5, 35, 40);
                g.DrawRectangle(penMain, _startPosX + 11, _startPosY + 25, 14, 15);
                g.DrawRectangle(penMain, _startPosX + 28, _startPosY + 25, 14, 15);
                g.DrawRectangle(penMain, _startPosX + 11, _startPosY + 8, 14, 15);
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

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Helipad}{separator}{Radar}{separator}{Gun}";
        }

        public bool Equals(Cruiser other)
        {
            // Реализовать метод сравнения для дочернего класса
            if (!Equals((Ship)other))
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Helipad != other.Helipad)
            {
                return false;
            }
            if (Radar != other.Radar)
            {
                return false;
            }
            if (Gun != other.Gun)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Cruiser cruiserObj))
            {
                return false;
            }
            else
            {
                return Equals(cruiserObj);
            }
        }
    }
}

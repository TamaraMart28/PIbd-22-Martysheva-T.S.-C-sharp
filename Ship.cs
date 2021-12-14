﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCruiser
{
    public class Ship : Vehicle, IEquatable<Ship>
    {
        protected readonly int cruiserWidth = 145;
        protected readonly int cruiserHeight = 50;
        protected readonly char separator = ';';

        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Ship(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        protected Ship(int maxSpeed, float weight, Color mainColor, int cruiserWidth, int cruiserHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.cruiserWidth = cruiserWidth;
            this.cruiserHeight = cruiserHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - cruiserWidth)
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

        public override void DrawTransport(Graphics g)
        {
            Brush brushMain = new SolidBrush(MainColor);
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
            g.FillRectangle(brushMain, _startPosX, _startPosY + 10, 5, 10);
            g.FillRectangle(brushMain, _startPosX, _startPosY + 25, 5, 10);
            g.DrawRectangle(penMain, _startPosX, _startPosY + 10, 5, 10);
            g.DrawRectangle(penMain, _startPosX, _startPosY + 25, 5, 10);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            if (!(obj is Ship shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
    }
}

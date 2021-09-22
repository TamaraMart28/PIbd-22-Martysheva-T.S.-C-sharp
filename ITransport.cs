﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsCruiser
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveCruiser(Direction direction);
        void DrawCruiser(Graphics g);
    }
}

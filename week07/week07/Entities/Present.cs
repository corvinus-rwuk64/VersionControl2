﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week07.Abstractions;

namespace week07.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }
        public Present(Color ribbonColor, Color boxColor)
        {
            RibbonColor = new SolidBrush(ribbonColor);
            BoxColor = new SolidBrush(boxColor);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 20, 0, Width / 5, Height);
            g.FillRectangle(RibbonColor, 0, 20, Width, Height / 5);
        }
    }
}
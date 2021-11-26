﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week07.Abstractions;

namespace week07.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color RibbonColor { get; set; }
        public Color BoxColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(RibbonColor, BoxColor);
        }
    }
}
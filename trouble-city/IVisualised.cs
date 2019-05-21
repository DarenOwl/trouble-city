﻿using System.Windows.Controls;

namespace trouble_city
{
    interface IVisualised
    {
        Image Img { get; }
        double Radius { get; }
        int Health { get; set; }
        Vector Position { get;}

        void Act();
        void Destroy();
    }
}

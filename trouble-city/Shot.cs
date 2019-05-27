﻿using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace trouble_city
{
    class Shot: IVisualised
    {
        public Image Img { get; }
        public int Radius { get; }
        public int Health
        {
            get { return health; }
            set
            {
                if (value <= 0) Destroy();
                else health = value;
            }
        }
        public Vector Position { get { return new Vector(Canvas.GetLeft(Img), Canvas.GetTop(Img)); } }

        Vector direction;
        int health;

        public Shot(Vector blasterDirection)
        {
            Img = new Image();
            Img.Source = new BitmapImage(new Uri("pack://application:,,,/Images/shot.png"));
            Img.Width = 20;
            Radius = 20;
            health = 20;
            direction = blasterDirection;
        }

        public void Act()
        {
            Canvas.SetTop(Img, Position.Y + direction.Y*10);
            Canvas.SetLeft(Img, Position.X + direction.X*10);
        }

        public void Destroy() => Game.Destroy(this);
    }
}

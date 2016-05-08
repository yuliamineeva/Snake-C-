﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 1, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 1, mapHeight - 1, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
     //   HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
    //    HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
  //      VerticalLine leftLine = new VerticalLine(0, 1, 24, '+');
  //      VerticalLine rightLine = new VerticalLine(78, 1, 24, '+');


        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}

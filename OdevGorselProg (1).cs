using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;

namespace Mover
{
    class Mover
    {
        static Random sayi = new Random();
        Vector2 pos;


        Vector2 hiz;
        int foröWidth, formHeight;

        public Mover(int width, int height)
        {
            foröWidth = width;
            formHeight = height;
            pos = new Vector2(sayi.Next(width), sayi.Next(height));


            hiz = new Vector2(3, 2);
        }
        public void Update()
        {
            if( pos.X > foröWidth - 140)
            {
                hiz.X = hiz.X * -1;
            }
            if(pos.Y > formHeight - 40  )
            {
                hiz.Y = hiz.Y * -1;

            }
            if (pos.Y < 0 || pos.Y > formHeight -140 )
            {
                hiz.Y = hiz.Y * -1;
            }
            if(pos.X < 0  )
            {
                pos.X = 1700;
                pos.Y =+ pos.Y;
            }
            pos = Vector2.Add(pos, hiz);
        }
        public void Display(Graphics e)
        {
            e.FillEllipse(Brushes.PaleGreen, pos.X, pos.Y, 100, 100);
           
            
                     /*   Random sayi = new Random();
                        int randomSayi = sayi.Next(100);
                        switch (randomSayi)
                        {
                            case 1:
                                e.FillEllipse(Brushes.Black, pos.X, pos.Y, 100, 100);
                                break;
                            case 2:
                                e.FillEllipse(Brushes.DarkGray, pos.X, pos.Y, 100, 100);
                                break;
                            case 3:
                                e.FillEllipse(Brushes.Yellow, pos.X, pos.Y, 100, 100);
                                break;
                            case 4:
                                e.FillEllipse(Brushes.Red, pos.X, pos.Y, 100, 100);
                                break;
                            case 5:
                                e.FillEllipse(Brushes.Blue, pos.X, pos.Y, 100, 100);
                                break;
                            case 6:
                                e.FillEllipse(Brushes.Honeydew, pos.X, pos.Y, 100, 100);
                                break;
                            case 7:
                                e.FillEllipse(Brushes.Gainsboro, pos.X, pos.Y, 100, 100);
                                break;
                            case 8:
                                e.FillEllipse(Brushes.Firebrick, pos.X, pos.Y, 100, 100);
                                break;
                            case 9:
                                e.FillEllipse(Brushes.AliceBlue, pos.X, pos.Y, 100, 100);
                                break;
                            case 10:
                                e.FillEllipse(Brushes.Magenta, pos.X, pos.Y, 100, 100);
                                break;


                        }*/
        }
    }
}


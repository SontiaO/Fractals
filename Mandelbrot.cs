using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractals
{
    //public enum 
    class Mandelbrot
    {
        public readonly Bitmap bmp;
        private int max_iter_count;
        private int color_scheme_choice;
        

        public Mandelbrot(Size size, double  x0, double y0, double width, double height, int max_iter, int color_choice)
        {
            color_scheme_choice = color_choice;
            GetMaxIter(max_iter);
            bmp = new Bitmap(size.Width, size.Height);
            double x=x0; double y = y0;
            double stepX = width/(double)size.Width;
            double stepY = height / (double)size.Height;

            for (int i=0; i<size.Height; i++)
            {
                for (int j=0; j<size.Width; j++)
                {
                    bmp.SetPixel(j, i, GetPixelColor(GetIterationsCount(x, y)));
                    x = x + stepX;   
                }
                x = x0;
                y = y + stepY;
            }
        }

        private void GetMaxIter(int i)
        {
            max_iter_count = i;
        }

        private Color GetPixelColor(int iter)
        {
            Color pixColor;
            double koeff = 1 - (double)iter / (double)max_iter_count;
            int component = (int)(255 * koeff);
            switch (color_scheme_choice)
            {
                case 0:
                    {
                        long rgb = (int)(0xFFFFFF * koeff) + 0xFF000000;
                        pixColor= Color.FromArgb((int)rgb);
                        break;
                    }
                case 1:
                    {
                        pixColor = Color.FromArgb(component,component,component);
                        break;
                    }
                case 2:
                    {
                        pixColor = Color.FromArgb(component, 0, 0);
                        break;
                    }
                case 3:
                    {
                        pixColor = Color.FromArgb(0, component, 0);
                        break;
                    }
                case 4:
                    {
                        pixColor = Color.FromArgb(0, 0, component);
                        break;
                    }
                case 5:
                    {
                        pixColor = Color.FromArgb(component, 0, component);
                        break;
                    }
                default:
                    {
                        pixColor=Color.Empty;
                        break;
                    }

            }
            return pixColor;
        }

        private int GetIterationsCount (double x0, double y0)
        {
            int iter=0;
            double x = x0;
            double y = y0;
            while ((x*x+y*y<4)&&(iter<max_iter_count))
            {
                double prevX=x; double prevY = y;
                x = prevX * prevX - prevY * prevY + x0;
                y = 2 * prevX * prevY + y0;
                iter++;
            }
            return iter;
        }

    }
}

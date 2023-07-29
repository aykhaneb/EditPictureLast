using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditPictureTask
{
    internal class PictureManager
    {
        internal Bitmap ColorFormatting(Bitmap image, int red, int green, int blue)
        {
            int r, g, b;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    r = pixelColor.R + red;
                    r = r % 255;
                    g = pixelColor.G + green;
                    g = g % 255;
                    b = pixelColor.B + blue;
                    b = b % 255;

                    Color newColor = Color.FromArgb(r, g, b);

                    image.SetPixel(i, j, newColor);
                }
            }

            return image;
        }

        internal void SaveFile(Bitmap image)
        {
            Console.Write("Enter the file name:");
            string newPicture = Console.ReadLine() + ".jpeg";

            image.Save(newPicture);

            Console.WriteLine("Image saved");
        }
    }
}

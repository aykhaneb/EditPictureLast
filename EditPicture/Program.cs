using System;
using System.Drawing;

namespace EditPictureTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EditManager EditManager = new EditManager();

            string apply = "";

            while (apply != "end")
            {
                Console.Write("Enter Image location:");
                string imageLocation = Console.ReadLine();

                Bitmap image = new Bitmap(imageLocation);

                Console.WriteLine($"1.Random Filter\n2.Custom Filter");

            start:

                apply = Console.ReadLine();

                if (apply.Equals("1"))
                {
                    var random = new Random();
                    int r = random.Next(0, 255);
                    int g = random.Next(0, 255);
                    int b = random.Next(0, 255);

                    Bitmap newRandomPicture = EditManager.ColorFormatting(image, r, g, b);
                    EditManager.SaveFile(newRandomPicture);
                    image.Dispose();
                }

                else if (apply.Equals("2"))
                {
                    Console.Write("Red:");
                    int red = int.Parse(Console.ReadLine());
                    Console.Write("Green:");
                    int green = int.Parse(Console.ReadLine());
                    Console.Write("Blue:");
                    int blue = int.Parse(Console.ReadLine());

                    Bitmap newPicture = EditManager.ColorFormatting(image, red, green, blue);

                    EditManager.SaveFile(newPicture);

                    image.Dispose();
                }

                else
                {

                    goto start;
                }
            }
        }
    }
}
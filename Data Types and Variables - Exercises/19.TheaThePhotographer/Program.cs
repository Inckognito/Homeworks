using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            double secondsPerPicture = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double time = picturesTaken * secondsPerPicture;
            double goodPictures = Math.Ceiling(percent * picturesTaken / 100);
            double goodPicturesUploadTime = goodPictures * uploadTime;
            double totalTime = time + goodPicturesUploadTime;

            TimeSpan span = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{span:d\\:hh\\:mm\\:ss}");
        }
    }
}

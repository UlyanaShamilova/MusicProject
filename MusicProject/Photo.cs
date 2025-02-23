using System;
using System.IO;
using System.Windows.Forms;

namespace MusicProject
{
    internal class Photo
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }

        public Photo(string fileRow)
        {
            var parts = fileRow.Split(',');

            if (parts.Length != 2)
                throw new ArgumentException("Invalid file row");

            ImagePath = Path.Combine(Application.StartupPath, "Assets", "Photos", parts[0]);
            Title = parts[1];
        }
    }
}
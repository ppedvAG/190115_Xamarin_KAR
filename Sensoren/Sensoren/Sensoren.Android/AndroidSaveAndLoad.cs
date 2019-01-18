using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(Sensoren.Droid.AndroidSaveAndLoad))]
namespace Sensoren.Droid
{
    class AndroidSaveAndLoad : ISaveAndLoad
    {
        public string LoadText(string filename)
        {
            var fullpath = Path.Combine(Android.OS.Environment.DirectoryDownloads, filename);
            return File.ReadAllText(fullpath);
        }

        public void SaveText(string filename, string content)
        {
            var fullpath = Path.Combine(Android.OS.Environment.DirectoryDownloads, filename);
            File.WriteAllText(fullpath, content);
        }
    }
}
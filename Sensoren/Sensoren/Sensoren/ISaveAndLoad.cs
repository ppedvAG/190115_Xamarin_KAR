using System;
using System.Collections.Generic;
using System.Text;

namespace Sensoren
{
    public interface ISaveAndLoad
    {
        void SaveText(string filename, string content);
        string LoadText(string filename);
    }
}

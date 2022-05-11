using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Objects
{
    public class Session
    {
        private const string FILENAME = "session.xml";

        private static string _applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private static string _applicationPath = Path.Combine(_applicationDataPath, "SuperNotepad");
        /// <summary>
        /// Chemin d'accès et nom du fichier représenant la session.
        /// </summary>
        public string FileName { get; } = Path.Combine(_applicationDataPath, FILENAME);

        public int ActiveIndex { get; set; } = 0;

        public List<TextFile> TextFiles { get; set; }

        public Session()
        {
            TextFiles = new List<TextFile>();
        }
    }
}

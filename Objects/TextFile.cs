using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad.Objects
{
    public class TextFile
    {
        
        /// chemin d'accès et nom du fichier.
      
        public string FileName { get; set; }

        /// chemin d'accès et nom du fichier backup.

        public string BackUpFileName { get; set; }

        /// nom et extension du fichier. Le nom du fichier n'inclut pas le chemin d'accès

        public string SafeFileName { get; set; }

        /// nom et extension du fichier backup. Le nom du fichier n'inclut pas le chemin d'accès

        public string SafeBackUpFileName { get; set; }

        /// contenu du fichier.

        public string Contents { get; set; } = string.Empty;

        /// <summary>
        /// Constructeur de la classe textFile.
        /// </summary>
        public TextFile()
        {

        }

        /// <summary>
        /// Constructeur de la classe textFile.
        /// </summary>
        /// <param name="fileName"></param>

        public TextFile(string fileName)
        {
            FileName = fileName;
            SafeFileName = Path.GetFileName(fileName);
        }

    }
}

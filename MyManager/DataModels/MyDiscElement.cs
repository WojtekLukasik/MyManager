using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyManager.DataModels
{
    public abstract class MyDiscElement
    {
        // Pola klasy MyDiscElement wraz z getterami
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime creationDate { get; set; }
        public string extension { get; set; }

        // Konstruktor klasy abstrakcyjnej MyDiscElement
        public MyDiscElement(string path)
        {
            this.Path = path;
            this.Name = path.Substring(path.LastIndexOf(@"\") + 1);
            creationDate = File.GetCreationTime(path);
        }

        //public virtual string GetDescription()
        //{
        //    return this.Name + this.creationDate;
        //}


        // Metoda zwracająca ścieżkę pliku, te ify są dlatego że miałem problem ze slashami w zależności 
        // od długości ścieżki ale teraz wszystko pięknie śmiga
        public virtual string GetPath() 
        {                               
            int pathLen = Path.Length;
            int nameLen = Name.Length;
            string getPath =  Path.Substring(0, pathLen - nameLen);
            if(getPath.Length > 4)
            {
                return getPath.Substring(0, getPath.Length - 1);
            }
            else
            {
                return getPath;
            }
        }

        // Metoda, która zwraca rozszerzenie dla pliku lub <DIR> dla folderów

        public string GetExtension()
        {
            string ext = Path.Split('.').Last();

            if(ext.Length <= 4)
            {
                return ext;
            }
            else
            {
                return "<DIR>";
            }
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyManager.DataModels
{
    public class MyDirectory: MyDiscElement
    {
        public MyDirectory(string path) : base(path)
        {

        }

        public string GetName()
        {
            return Name;
        }

        // Metoda zwracająca zawartość danego folderu
        public List<MyDiscElement> GetDirectoryContent(string path)
        {
            List<MyDiscElement> subElements = new List<MyDiscElement>(); // Tworzenie nowej listy o klasie MyDiscElement

            IEnumerable<string> directories = Directory.GetDirectories(path); // Tworzenie kolekcji plików i podfolderów za pomocą interfejsu 
            IEnumerable<string> files = Directory.GetFiles(path);             // IEnumerable, dzięki któremu będzie można użyć foreach

            foreach(string directory in directories)
            {
                subElements.Add(new MyDirectory(directory));
            }

            foreach(string file in files)
            {
                subElements.Add(new MyFile(file));
            }

            return subElements;
        }

    }
}

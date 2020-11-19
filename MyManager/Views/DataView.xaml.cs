using MyManager.DataModels;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace MyManager.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        MyDiscElement myDiscElement;

        // Konstruktor widoku dla elementu z dysku
        public DataView(MyDiscElement myDiscElement)
        {
            this.myDiscElement = myDiscElement;
            InitializeComponent();
            dataName.Content = myDiscElement.Name;
            dataCreationDate.Content = myDiscElement.creationDate.ToLongDateString();
        }


        // Metoda do kopiowania folderów działająca rekurencyjnie dla każdego z podfolderów

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            if (copySubDirs)
            {
                foreach(DirectoryInfo subDir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subDir.Name);
                    DirectoryCopy(subDir.FullName, tempPath, copySubDirs);
                }
            }
        }

        public delegate void DataViewDeleteEventHandler(MyDiscElement myDiscElement);
        public event DataViewDeleteEventHandler DataViewDeleted;

        public delegate void DataViewOpenEventHandler(MyDiscElement myDiscElement);
        public event DataViewOpenEventHandler DataViewOpened;


        // Usuwanie
        private void DeleteObject(object sender, RoutedEventArgs e)
        {
            DataViewDeleted.Invoke(myDiscElement);
        }

        // Otwieranie
        private void DataOpenButton_Click(object sender, RoutedEventArgs e)
        {
            DataViewOpened.Invoke(myDiscElement);
        }


        // Kopiowanie
        private void DataCopy_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("fileToCopy: " + myDiscElement.Path + "\n" + "newLocation: " + MainWindow.rightStack.currentPath + "\\" + myDiscElement.Name);

            if(myDiscElement is MyFile)
            {
                if (myDiscElement.GetPath().Equals(MainWindow.leftStack.currentPath) == true) // Kopiowanie z lewego do prawego
                {
                    File.Copy(myDiscElement.Path, MainWindow.rightStack.currentPath + "\\" + myDiscElement.Name);
                    MainWindow.rightStack.LoadPath(MainWindow.rightStack.currentPath);
                }
                else // Kopiowanie z prawego do lewego
                {
                    File.Copy(myDiscElement.Path, MainWindow.leftStack.currentPath + "\\" + myDiscElement.Name);
                    MainWindow.leftStack.LoadPath(MainWindow.leftStack.currentPath);
                }
            }
            else
            {
                if(myDiscElement.GetPath().Equals(MainWindow.leftStack.currentPath) == true)
                {
                    DirectoryCopy(myDiscElement.Path, MainWindow.rightStack.currentPath + "\\" + myDiscElement.Name, true);
                    MainWindow.rightStack.LoadPath(MainWindow.rightStack.currentPath);
                }
                else
                {
                    DirectoryCopy(myDiscElement.Path, MainWindow.leftStack.currentPath + "\\" + myDiscElement.Name, true);
                    MainWindow.leftStack.LoadPath(MainWindow.leftStack.currentPath);
                }
                
            }

        }
    }
}

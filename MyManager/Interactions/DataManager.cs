using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyManager.Interactions;
using MyManager.DataModels;
using MyManager.Views;
using System.IO;

namespace MyManager.Interactions
{
    public class DataManager
    {
        public void CreateNewDirectory(string currentPath, string newDirectoryName)
        {
            FilesPanel filesPanel = new FilesPanel(currentPath);
            if (!newDirectoryName.Equals(string.Empty))
            {
                Directory.CreateDirectory(currentPath + newDirectoryName); 
            }
            else MessageBox.Show("Podaj Nazwę folderu.");
        }
       
    }
}

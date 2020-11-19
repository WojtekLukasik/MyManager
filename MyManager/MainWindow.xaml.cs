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

namespace MyManager
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataManager dataManager = new DataManager();

        public static FilesPanel leftStack;
        public static FilesPanel rightStack;
        
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                //FilesPanel leftStack = new FilesPanel(@"C:\\");
                //FilesPanel rightStack = new FilesPanel(@"D:\\");
                leftStack = new FilesPanel(@"C:\");
                rightStack = new FilesPanel(@"D:\");

                leftGrid.Children.Add(leftStack);
                rightGrid.Children.Add(rightStack);
          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        
    }
}

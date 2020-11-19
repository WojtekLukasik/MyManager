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
using System.IO;
using System.Diagnostics;


namespace MyManager.Views
{
    /// <summary>
    /// Logika interakcji dla klasy FilesPanel.xaml
    /// </summary>
    public partial class FilesPanel : UserControl
    {
        DataManager dataManager;
        
        public string currentPath;

        // Konstruktor widoku plików
        public FilesPanel(string path)
        {
            this.dataManager = new DataManager();
            InitializeComponent();
            currentPath = path;
            LoadPath(path);
            LoadDrives();
            currentPathLabel.Content = currentPath;
    
        }

        // Metoda odświeżająca widok z argumentem przyjmującym ścieżkę do katalogu
        public void LoadPath(string path)
        {
            filesStack.Children.Clear();

            MyDirectory myDirectory = new MyDirectory(path);

            List<MyDiscElement> myDiscElements = new List<MyDiscElement>();
            myDiscElements = myDirectory.GetDirectoryContent(path);

            foreach (MyDiscElement myDiscElement in myDiscElements)
            {
                DataView dataView = new DataView(myDiscElement);
                dataView.dataType.Content = myDiscElement.GetExtension();                
                dataView.DataViewDeleted += DeleteObject;
                dataView.DataViewOpened += DataOpen;
                filesStack.Children.Add(dataView);
            }
            currentPathLabel.Content = currentPath;
        }

        // Ładowanie głównych dysków do ComboBoxa
        public void LoadDrives()
        {
            foreach(var drive in DriveInfo.GetDrives())
            {
                drivesList.Items.Add(drive);
            }
        }

        // Metoda odświeżająca widok z argumentem przyjmującym liste elementów
        public void LoadList(List<MyDiscElement> myDiscElements)
        {
            filesStack.Children.Clear();
            foreach (MyDiscElement myDiscElement in myDiscElements)
            {
                DataView dataView = new DataView(myDiscElement);
                dataView.dataType.Content = myDiscElement.GetExtension();
                dataView.DataViewDeleted += DeleteObject;
                dataView.DataViewOpened += DataOpen;
                filesStack.Children.Add(dataView);
            }
            currentPathLabel.Content = currentPath;
        }

        // Usuwanie
        private void DeleteObject(MyDiscElement myDiscElement)
        {
            if(myDiscElement is MyFile)
            {
                File.Delete(myDiscElement.Path);
                LoadPath(currentPath);
            }
            else
            {
                Directory.Delete(myDiscElement.Path, true);
                LoadPath(currentPath);
            }
        }

        // Otwieranie
        private void DataOpen(MyDiscElement myDiscElement)
        {
            if(myDiscElement is MyDirectory)
            {
                currentPath = currentPath + "\\" + myDiscElement.Name;
                LoadPath(currentPath);
            }
            else if(myDiscElement.GetExtension() == "txt")
            {     
                string text = File.ReadAllText(myDiscElement.Path);
                textReader.Visibility = Visibility.Visible;
                textReader.Text = text;
            }
            else if (myDiscElement.GetExtension() == "jpg" || myDiscElement.GetExtension() == "png" )
            {
                ImageSource imageSource = new BitmapImage(new Uri(myDiscElement.Path));
                imageReader.Source = imageSource;
                imageReader.Stretch = Stretch.Fill;
                imageReader.Visibility = Visibility.Visible;

            }
            else
            {
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = myDiscElement.Path;
                myProcess.Start();

            }
        }

        // Tworzenie nowego folderu
        private void CreateNewDirectoryButton_Click(object sender, RoutedEventArgs e)
        {

            if (!newDirectoryName.Text.Equals(""))
            {
                Directory.CreateDirectory(currentPath + "\\" +newDirectoryName.Text);
            }
            else MessageBox.Show("Podaj Nazwę folderu.");

            LoadPath(currentPath);
            newDirectoryName.Text = "";
        }

        // Cofanie folderu
        private void BackDirectory_Click(object sender, RoutedEventArgs e)
        {
            currentPath = currentPath.Substring(0, currentPath.LastIndexOf("\\"));
            LoadPath(currentPath);
        }

        // Sortowanie

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            MyDirectory myDirectory = new MyDirectory(currentPath);
            List<MyDiscElement> myDiscElements = new List<MyDiscElement>();
            myDiscElements = myDirectory.GetDirectoryContent(currentPath);
            

            if (dateSortCheckBox.IsChecked == true && nameSortCheckBox.IsChecked == false)
            {
                myDiscElements = myDiscElements.OrderBy(File => File.creationDate).ToList<MyDiscElement>();
                LoadList(myDiscElements);
            }
            else if (dateSortCheckBox.IsChecked == false && nameSortCheckBox.IsChecked == true)
            {
                myDiscElements = myDiscElements.OrderBy(File => File.Name).ToList<MyDiscElement>();
                LoadList(myDiscElements);

            }
            
        }

        // Zamykanie przeglądarki plików tekstowych/graficznych
        private void CloseReader_Click(object sender, RoutedEventArgs e)
        {
            textReader.Visibility = Visibility.Hidden;
            imageReader.Visibility = Visibility.Hidden;
        }

        // Wyszukiwanie po nazwie
        private void SearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyDirectory myDirectory = new MyDirectory(currentPath);
            List<MyDiscElement> myDiscElements = new List<MyDiscElement>();
            myDiscElements = myDirectory.GetDirectoryContent(currentPath);
            if (!searchName.Text.Equals(""))
            {
                myDiscElements = myDiscElements.Where(File => File.Name.Contains(searchName.Text)).ToList<MyDiscElement>();
            }
            LoadList(myDiscElements);
        }

        // Zmiana dysków
        private void DrivesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentPath = drivesList.SelectedItem.ToString();
            LoadPath(currentPath);
           
        }
       
    }
}


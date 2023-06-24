using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

using WPFTestDesign.Models;
using Ohio.InOut;

namespace WPFTestDesign;


public partial class MainWindow : Window
{
    private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
    private BindingList<TodoModel> _todoData;
    private FileIOServises _fileIOServises;
    
    public MainWindow()
    {
        InitializeComponent();                 
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }

    }

    private void NotesButton_Click(object sender, RoutedEventArgs e)
    {
               
        if (NotesBox.Visibility == Visibility.Hidden)
        {
            NotesBox.Visibility = Visibility.Visible;
        }
        else
        {
            NotesBox.Visibility = Visibility.Visible;
        }
        if (SettingsBox.Visibility == Visibility.Visible)
        {
            SettingsBox.Visibility = Visibility.Hidden;
        }

    }
    private void SettingsButton_Click(Object sender, RoutedEventArgs e)
    {
        if (SettingsBox.Visibility == Visibility.Hidden)
        {
            SettingsBox.Visibility = Visibility.Visible;
        }
        else
        {
            SettingsBox.Visibility = Visibility.Visible;
        }

        if (NotesBox.Visibility == Visibility.Visible)
        {
            NotesBox.Visibility = Visibility.Hidden;
        }

    }
    
   
    private void ExitButton_Click(object sender, RoutedEventArgs e)
    {
        Main.Close();
    }

    private void Main_Loaded(object sender, RoutedEventArgs e)
    {
        _fileIOServises = new FileIOServises(PATH);
      
        try
        {
            _todoData = _fileIOServises.LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Close();
        }

        Notesdg.ItemsSource = _todoData;

        _todoData.ListChanged += _todoData_ListChanged;

    }

    private void _todoData_ListChanged(object sender, ListChangedEventArgs e)
    {
        if (e.ListChangedType==ListChangedType.ItemAdded|| e.ListChangedType == ListChangedType.ItemDeleted|| e.ListChangedType == ListChangedType.ItemChanged)
        {
            try
            {
                _fileIOServises.SaveData(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        
    }
}


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
using System;
using System.Diagnostics;

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
    private void WhiteThemesButton_Click (object sender, RoutedEventArgs e)
    {        
        ButtonsBox.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FEE6DF");
        NameBox.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FEE6DF");
        MainBox.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#E3E3E3");
        DateColumnBox.Foreground = new SolidColorBrush(Colors.Black);
        TaskColumnBox.Foreground = new SolidColorBrush(Colors.Black);

        SettingsButton.Background= (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        SettingsButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        NotesButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        NotesButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        WhiteButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        WhiteButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        DarkButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        DarkButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        GitButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");
        GitButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#E6643D");

    }
    private void DarkThemesButton_Click(object sender, RoutedEventArgs e)
    {
        ButtonsBox.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#2a2a2a");
        NameBox.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#2a2a2a");
        MainBox.Background = new SolidColorBrush(Colors.Transparent);
        DateColumnBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#e5e5e5"); 
        TaskColumnBox.Foreground = (SolidColorBrush)new BrushConverter().ConvertFrom("#e5e5e5");

        SettingsButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        SettingsButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        NotesButton.Background= (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        NotesButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        WhiteButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        WhiteButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        DarkButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        DarkButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        GitButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
        GitButton.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#606060");
    }
    private void GitHubButton_Click(object sender, RoutedEventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/Vimer5410/Ohio/tree/main") { UseShellExecute = true });
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
/*
 * SetPrimaryColor(Colors.Red);
 *  private static void SetPrimaryColor(Color color)
    {
        PaletteHelper paletteHelper = new PaletteHelper();
        var theme=paletteHelper.GetTheme();
        theme.SetPrimaryColor(color);
        paletteHelper.SetTheme(theme);
    }
 <materialDesign:BundledTheme BaseTheme="Inherit" PrimaryColor="Yellow" SecondaryColor="Red"
                                             ColorAdjustment = "{materialDesign:ColorAdjustment}" />
var uri = new Uri(@"WhiteThemes.xaml", UriKind.Relative);
ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
Application.Current.Resources.Clear();
Application.Current.Resources.MergedDictionaries.Add(resourceDictionary)
*/

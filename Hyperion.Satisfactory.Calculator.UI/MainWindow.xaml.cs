using System.Windows;
using Microsoft.Win32;

namespace Hyperion.Satisfactory.Calculator.UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void LoadSaveButton_OnClick(object sender, RoutedEventArgs e)
    {
        // Open a file dialog to select an existing save file
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Save Files (*.json)|*.json|All Files (*.*)|*.*",
            Title = "Select a Save File"
        };

        if (openFileDialog.ShowDialog() == true)
        {
            string filePath = openFileDialog.FileName;
            MessageBox.Show($"Loaded save file: {filePath}", "Load Save");
            // Add logic to load the save file
        }
    }

    private void NewSaveButton_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Starting a new save!", "New Save");
        // Add logic to initialize a new save
    }
}
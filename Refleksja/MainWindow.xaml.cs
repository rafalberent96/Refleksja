
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;
using System.Linq;
using System;
using Interface;
using System.ComponentModel;

namespace Refleksja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new FolderBrowserDialog();
            var result = fileDialog.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.OK) return;

            var assemblyList = new List<Assembly>();
            foreach (var file in Directory.GetFiles(fileDialog.SelectedPath))
            {
                if(file.EndsWith(".dll") || file.EndsWith(".exe"))
                {
                    assemblyList.Add(Assembly.LoadFrom(file));                    
                }
            }
            AddAssembliesToListBox(assemblyList);
        }

        private void AddAssembliesToListBox(List<Assembly> assemblyList)
        {
            var types = new List<Type>();
            foreach(var assembly in assemblyList)
            {
                foreach(var module in assembly.Modules)
                {
                    foreach (var type in module.GetTypes())
                    {
                        if (typeof(IMath).IsAssignableFrom(type))
                        {
                            types.Add(type);
                        }
                    }
                }
            }
            this.AssemblyListBox.ItemsSource = types;
        }



        private void AssemblyListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
           var selectedType = this.AssemblyListBox.SelectedItem as Type;
           var descriptionAttribute = selectedType.GetCustomAttribute<DescriptionAttribute>(true);
            if (null != descriptionAttribute)
            {
                this.DescriptionTextBox.Text = descriptionAttribute.Description;                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.XInPut.Text == null || this.YInPut.Text == null || this.AssemblyListBox.SelectedItem == null) return;
            var x = this.XInPut.Text;
            var y = this.YInPut.Text;
            var type = this.AssemblyListBox.SelectedItem as Type;

            if (Double.TryParse(x, out double xParsed) && Double.TryParse(y, out double yParsed))
            {
                if (!typeof(IMath).IsAssignableFrom(type)) return;
                if (Activator.CreateInstance(type) is IMath math)
                {
                    this.OutputLable.Content = "=" + math.Result(xParsed, yParsed);
                }
            }


        }
    }
}

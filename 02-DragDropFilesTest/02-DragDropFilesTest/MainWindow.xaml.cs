using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace _02_DragDropFilesTest
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

        private List<string> newlist = new List<string>();
        private void ImagePanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {      
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);   
             

                foreach (var file in files)
                {
                    if (!newlist.Contains(file))
                    {
                        newlist.Add(file);
                        string result = Path.GetFileName(file);
                        listbox.Items.Add(file);
                    }
                    else
                        MessageBox.Show("Already exist");
                }
                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                //HandleFileOpen(files[0]);
                asd.Content = listbox.Items.Count;

                
            }
        }

    }
}

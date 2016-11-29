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

namespace ITC110Assignment9
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

        private void buttonWrite_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPath.Text != null)
            {
                try
                {
                    WriteFile note = new WriteFile(textBoxPath.Text);
                    note.AddText(textBoxOne.Text);
                    note.CloseFile();
                    MessageBox.Show("Your text was saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReadFile doc = new ReadFile(textBoxPath.Text);
                textBoxOne.Text = doc.GetFile();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxOne.Clear();
            textBoxPath.Clear();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

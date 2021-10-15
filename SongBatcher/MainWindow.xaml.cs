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
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using FFmpeg.NET;

namespace SongBatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog filePath = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void FileDialogButton_Click(object sender, RoutedEventArgs e)
        {
            
            filePath.Multiselect = true;
            filePath.Filter = "Video Files (*.mp4)|*.mp4";
            filePath.ShowDialog();
           

        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }

        public void ContentButton_Click(object sender, RoutedEventArgs e)
        {
            string[] fNames = filePath.FileNames;
            string[] fNamesOnly = new string[fNames.Length];
            InputFile[] md = new InputFile[fNames.Length];
            OutputFile[] mdo = new OutputFile[fNames.Length];
            for (int i = 0; i < fNames.Length; i++)
            {
                Debug.WriteLine(fNames[i]);
                fNamesOnly[i] = fNames[i].Split("\\").Last();
                fNamesOnly[i] = fNamesOnly[i].Replace(".mp4", ".mp3");
                Debug.WriteLine(fNamesOnly[i]);
                md[i] = new InputFile(fNames[i]);
            }
            string directory = System.IO.Path.GetDirectoryName(fNames[0]);
            Debug.WriteLine("Directory: " + directory);
            string directoryOutput = directory + "\\mp3\\";
            System.IO.Directory.CreateDirectory(directoryOutput);

            for (int i = 0; i < fNames.Length; i++)
            {
                mdo[i] = new OutputFile(directoryOutput + fNamesOnly[i]);
                Debug.WriteLine(directoryOutput + fNamesOnly[i]);
            }

            Engine engine = new Engine("ffmpeg.exe");

            int len = fNames.Length;
            for (int i = 0; i < fNames.Length; i++)
            {
                Debug.WriteLine(i);

                ProgressBarText.Text = directoryOutput + fNamesOnly[i];
                Debug.WriteLine("Converting..." + fNames[i]);
                engine.ConvertAsync(md[i], mdo[i]);
                ProgressConsole.AppendText("\nConverted to " + directoryOutput + fNamesOnly[i] + "...");
                if (fNames.Length == 1)
                {
                    ProgressBarConvert.Value = 100;
                }
                else ProgressBarConvert.Value = ((float)i / ((float)len - 1)) * 100;
            }
        }
    }
}

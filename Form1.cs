using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ParallelFileSearching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConcurrentBag<string> bcResult;
        CancellationTokenSource Cancelsource;
        static string filePathtoSearch = @"C:\";
        static string fileNametoSearch = string.Empty;
        ParallelOptions paralleloption = new ParallelOptions();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            fileNametoSearch = TextBoxfileNametoSearch.Text;

            if (string.IsNullOrEmpty(fileNametoSearch))
                return;

            filePathtoSearch = textBoxFilePathtosearch.Text;
            bcResult = new ConcurrentBag<string>();
            if (Cancelsource != null)
                Cancelsource.Cancel();
            Cancelsource = new CancellationTokenSource();
            Stopwatch sw = Stopwatch.StartNew();

            paralleloption.CancellationToken = Cancelsource.Token;

            DirectoryInfo dir = new DirectoryInfo(filePathtoSearch);
            getDirsFiles(dir).ContinueWith(v =>
              {
                  sw.Stop();
                  try
                  {
                      if (!Cancelsource.IsCancellationRequested)
                      {
                          if (v.IsFaulted)
                              listBoxException.DataSource = (from a in v.Exception.Flatten().InnerExceptions select a).ToList();

                          listBoxShow.DataSource = bcResult.ToList<string>();
                          groupBox1.Text = string.Format("Search Result ({0}) time {1}", bcResult.Count().ToString(), sw.Elapsed);
                      }
                  }
                  catch (Exception ed)
                  {
                      MessageBox.Show(ed.Message);
                  }
              }, CancellationToken.None, TaskContinuationOptions.NotOnCanceled, TaskScheduler.FromCurrentSynchronizationContext());
        }




        public Task getDirsFiles(DirectoryInfo directory)
        {
            var t = Task.Factory.StartNew(() =>{
                //create an array of files using FileInfo object
                FileInfo[] files;
                //get all files for the current directory                
                files = directory.GetFiles("*.*");

                Parallel.ForEach(files, paralleloption, (file, loopState) => {
                         if (file.Name.Contains(fileNametoSearch)){
                             // join perform at this location
                             bcResult.Add(file.FullName + " " + file.Length.ToString() +
                             " " + file.Extension + " " + file.LastWriteTime.ToString());
                         }
                     });
                DirectoryInfo[] dirs = directory.GetDirectories("*.*");
                foreach (var dir in dirs){
                    if (Cancelsource.IsCancellationRequested)
                        break;
                    //Recursive call (Fork perform at this position)
                    getDirsFiles(dir);
                }
            },Cancelsource.Token,TaskCreationOptions.AttachedToParent,TaskScheduler.Default);
            return t;
        }

        private void TextBoxfileNametoSearch_TextChanged(object sender, EventArgs e)
        {//
            if (TextBoxfileNametoSearch.Text.Length > 2)
                button1_Click(null, null);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Caselle_Autorun_Views
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new Form1());

      var processes = Process.GetProcesses();
      var process = processes.FirstOrDefault(x => x.MainWindowTitle.StartsWith("Caselle Clarity® 1.0.0.0") || x.MainWindowTitle.StartsWith("Caselle Connect® 1.0.0.0"));

      if (process == null)
      {
        
      }
      else
      {
        var fileName = process.MainModule.FileName;

        fileName = fileName.Substring(0, fileName.LastIndexOf('\\'));

        fileName += "\\AutoRunViews.txt";

        Process.Start(@"C:\Program Files (x86)\Notepad++\notepad++.exe", fileName);
      }
    }
  }
}

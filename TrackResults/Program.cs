
/* 
 * Sami Alzoubi 
 * CPSC 23000
 * March 17th, 2024
 * Track Results
 */
using System;
using System.Windows.Forms;
using TrackResults.View;

namespace TrackResults
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

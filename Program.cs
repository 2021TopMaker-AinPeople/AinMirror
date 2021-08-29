using System;
using Tizen.NUI;

namespace AinMirror
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// test
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MainApp Instance = new MainApp();
            Instance.Run(args);
        }
    }
}

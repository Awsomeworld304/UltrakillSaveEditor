using System.Runtime.InteropServices;
namespace UltrakillSaveEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        static void Main()
        {
            // Config starting vars here.
            if(Globals.System.DEV_MODE) AllocConsole();
            //Start the application.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}
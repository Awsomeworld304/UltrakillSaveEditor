using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltrakillSaveEditor
{
    public class FileUtils
    {
        public static int readByte(String path, int position = 0x00)
        {
            var result = 0;
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                stream.Position = position;
                result = stream.ReadByte();
                Console.WriteLine();
            }
            return result;
        }

        public static void writeByte(String path, int position = 0x00, byte theByte = 0x00)
        {
            checkSaveDirectory(path);
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                stream.Position = position;
                stream.WriteByte(theByte);
                if (Globals.System.DEV_MODE)
                    Console.WriteLine("Wrote: " + theByte + " at position: " + position + " of: " + path);
            }
        }

        //! Used for parser, nowhere else.
        public static bool checkSaveDirectory()
        {
            var path = Globals.Save.SAVE_PATH + "Slot3\\generalprogress.bepis";
            if (!System.IO.Directory.Exists(Globals.Save.SAVE_PATH))
            {
                MessageBox.Show("Save file not found!\n" + Globals.Save.SAVE_PATH, "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                return false;

            }
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("Save directory not found!\n" + path, "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            return true;
        }

        public static void checkSaveDirectory(String savePath)
        {
            if (!System.IO.Directory.Exists(savePath))
            {
                MessageBox.Show("Save directory not found!\n" + savePath, "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
        }

        public static void checkSaveDirectory(Label statLabel)
        {
            if (!System.IO.Directory.Exists(Globals.Save.SAVE_PATH))
            {
                Globals.System.noSaveWarning = true;
                statLabel.Text = "Status: ERROR -> Save directory not found!";
                MessageBox.Show("Save directory not found!\n" + Globals.Save.SAVE_PATH, "File Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            Globals.System.noSaveWarning = false;
        }

        public static void copyDirectory(string sourceDir, string destinationDir, bool recursive, bool overwrite)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                try
                {
                    file.CopyTo(targetFilePath, overwrite);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nThis happens when you copy without overwriting.");
                }
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    copyDirectory(subDir.FullName, newDestinationDir, true, overwrite);
                }
            }

            Console.WriteLine("Copied " + Path.GetDirectoryName(sourceDir) + " to " + Path.GetDirectoryName(destinationDir));
        }
    }
}

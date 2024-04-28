using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Numerics;
using System.Runtime.InteropServices;
using System.IO;

namespace UltrakillSaveEditor
{
    public class BepisParser
    {
        enum SaveFile
        {
            GeneralProgress,
            CybergrindProgress
        }

        byte fileHeader = 0x39;
        byte version = 0x29;

        String savePath(SaveFile saveFile)
        {
            String path = "";
            switch (saveFile)
            {
                case SaveFile.GeneralProgress:
                    path = Globals.Save.TEMP_SAVE_LOCATION + Globals.Save.activeSlot + "\\generalprogress.bepis";
                    return path;
                case SaveFile.CybergrindProgress:
                    path = Globals.Save.TEMP_SAVE_LOCATION + "cybergrindprogress.bepis";
                    return path;
                default:
                    throw new Exception("Invalid save file type.");
            }
        }

        public static void checkSlots(ComboBox list)
        {
            for (int i=0; i>=Globals.Save.loadedSlots.Length; i++)
            {
                list.Items[i] = null;
                Console.WriteLine("Checking slot: " + (i + 1));

                switch (i) 
                {
                    case 0:
                        if (Directory.Exists(Globals.Save.TEMP_SAVE_LOCATION + "Slot1\\"))
                        {
                            Globals.Save.loadedSlots[0] = true;
                            Console.WriteLine("Found Slot 1");
                        }
                        else { Globals.Save.loadedSlots[i] = false; }
                        break;
                    case 1:
                        if (Directory.Exists(Globals.Save.TEMP_SAVE_LOCATION + "Slot2\\"))
                        {
                            Globals.Save.loadedSlots[1] = true;
                            Console.WriteLine("Found Slot 2");
                        }
                        else { Globals.Save.loadedSlots[i] = false; }
                        break;
                    case 2:
                        if (Directory.Exists(Globals.Save.TEMP_SAVE_LOCATION + "Slot3\\"))
                        {
                            Globals.Save.loadedSlots[2] = true;
                            Console.WriteLine("Found Slot 3");
                        }
                        else { Globals.Save.loadedSlots[i] = false; }
                        break;
                    case 3:
                        if (Directory.Exists(Globals.Save.TEMP_SAVE_LOCATION + "Slot4\\"))
                        {
                            Globals.Save.loadedSlots[3] = true;
                            Console.WriteLine("Found Slot 4");
                        }
                        else { Globals.Save.loadedSlots[i] = false; }
                        break;
                    case 4:
                        if (Directory.Exists(Globals.Save.TEMP_SAVE_LOCATION + "Slot5\\"))
                        {
                            Globals.Save.loadedSlots[4] = true;
                            Console.WriteLine("Found Slot 5");
                        }
                        else { Globals.Save.loadedSlots[i] = false; }
                        break;
                    default:
                        throw new Exception("Invalid save slot.");
                }

                if (Globals.Save.loadedSlots[i])
                {
                    switch(i)
                    {
                        case 0:
                            list.Items[i] = ("Slot 1");
                            break;
                        case 1:
                            list.Items[i] = ("Slot 2");
                            break;
                        case 2:
                            list.Items[i] = ("Slot 3");
                            break;
                        case 3:
                            list.Items[i] = ("Slot 4");
                            break;
                        case 4:
                            list.Items[i] = ("Slot 5");
                            break;
                    }
                }
            }
        }

        public void readSave()
        {
            Console.Clear();
            Console.WriteLine("Copying files from " + Globals.Save.activeSlot + "...");
            // Phase 0 Preface.
            var path = Globals.Save.TEMP_SAVE_LOCATION + Globals.Save.activeSlot + "\\generalprogress.bepis";

            // Phase 1 Check if the file exists. (No file, quit operation.)
            if (!FileUtils.checkSaveDirectory()) { return; }

            // Phase 2 Copy to temp location.
            FileUtils.copyDirectory(Globals.Save.SAVE_PATH, Globals.Save.TEMP_SAVE_LOCATION, true, Globals.Save.overwriteCopy);

            // Phase 3 Read the file.
            Console.WriteLine("Reading save from " + Globals.Save.activeSlot + "...");
            Globals.GeneralData data = new Globals.GeneralData();

            BinaryReader br;

            try 
            {
                br = new BinaryReader(new FileStream(path, FileMode.Open));

                br.BaseStream.Seek(0x271, SeekOrigin.Begin); //Money offset
                data.money = br.ReadInt32();

                br.BaseStream.Seek(0x275, SeekOrigin.Begin); //IntroSeen offset
                data.introSeen = br.ReadBoolean();

                //br.BaseStream.Seek(0x276, SeekOrigin.Begin); //TutorialBeat offset
                data.tutorialBeat = br.ReadBoolean();

                //br.BaseStream.Seek(0x277, SeekOrigin.Begin); //ClashModeUnlocked offset
                data.clashModeUnlocked = br.ReadBoolean();

                data.rev0 = br.ReadBoolean();
                br.BaseStream.Seek(0x27C, SeekOrigin.Begin);
                data.rev1 = br.ReadBoolean();
                br.BaseStream.Seek(0x280, SeekOrigin.Begin);
                data.rev2 = br.ReadBoolean();
                //br.BaseStream.Seek(0x288, SeekOrigin.Begin);
                //data.rev3 = br.ReadBoolean();

                br.BaseStream.Seek(0x28C, SeekOrigin.Begin);
                data.sho0 = br.ReadBoolean();
                br.BaseStream.Seek(0x290, SeekOrigin.Begin);
                data.sho1 = br.ReadBoolean();
                //br.BaseStream.Seek(0x294, SeekOrigin.Begin);
                //data.sho2 = br.ReadBoolean();
                //br.BaseStream.Seek(0x298, SeekOrigin.Begin);
                //data.sho3 = br.ReadBoolean();

                br.BaseStream.Seek(0x29C, SeekOrigin.Begin);
                data.nai0 = br.ReadBoolean();
                br.BaseStream.Seek(0x2A0, SeekOrigin.Begin);
                data.nai1 = br.ReadBoolean();
                //br.BaseStream.Seek(0x2A4, SeekOrigin.Begin);
                //data.nai2 = br.ReadBoolean();
                //br.BaseStream.Seek(0x2A8, SeekOrigin.Begin);
                //data.nai3 = br.ReadBoolean();
                br.BaseStream.Seek(0x2AC, SeekOrigin.Begin);
                data.naiAlt = br.ReadBoolean();

                br.BaseStream.Seek(0x2D0, SeekOrigin.Begin);
                data.rai0 = br.ReadBoolean();
                br.BaseStream.Seek(0x2B4, SeekOrigin.Begin);
                data.rai1 = br.ReadBoolean();
                br.BaseStream.Seek(0x2B8, SeekOrigin.Begin);
                data.rai2 = br.ReadBoolean();
                //br.BaseStream.Seek(0x2BC, SeekOrigin.Begin);
                //data.rai3 = br.ReadBoolean();

                br.BaseStream.Seek(0x2C0, SeekOrigin.Begin);
                data.rock0 = br.ReadBoolean();
                br.BaseStream.Seek(0x2C4, SeekOrigin.Begin);
                data.rock1 = br.ReadBoolean();
                //br.BaseStream.Seek(0x2C8, SeekOrigin.Begin);
                //data.rock2 = br.ReadBoolean();
                //br.BaseStream.Seek(0x2CC, SeekOrigin.Begin);
                //data.rock3 = br.ReadBoolean();

                /*
                br.BaseStream.Seek(0x32E, SeekOrigin.Begin);
                data.revCustomizationUnlocked = br.ReadBoolean();
                br.BaseStream.Seek(0x32F, SeekOrigin.Begin);
                data.shoCustomizationUnlocked = br.ReadBoolean();
                br.BaseStream.Seek(0x330, SeekOrigin.Begin);
                data.naiCustomizationUnlocked = br.ReadBoolean();
                br.BaseStream.Seek(0x331, SeekOrigin.Begin);
                data.raiCustomizationUnlocked = br.ReadBoolean();
                br.BaseStream.Seek(0x332, SeekOrigin.Begin);
                data.rockCustomizationUnlocked = br.ReadBoolean();
                */

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Error loading save: " + e.Message);
                return;
            }
            Console.WriteLine("Save loaded!");

            // Phase 4 Parse & Display the data.
            Console.WriteLine("Money: " + data.money);
            Console.WriteLine("Intro Seen: " + data.introSeen);
            Console.WriteLine("Tutorial Beat: " + data.tutorialBeat);
            Console.WriteLine("Clash Mode Unlocked: " + data.clashModeUnlocked);
            Console.WriteLine("Rev0: " + data.rev0);
            Console.WriteLine("Rev1: " + data.rev1);
            Console.WriteLine("Rev2: " + data.rev2);
            //Console.WriteLine("Rev3: " + data.rev3);
            Console.WriteLine("RevAlt: " + data.revAlt);
            Console.WriteLine("Sho0: " + data.sho0);
            Console.WriteLine("Sho1: " + data.sho1);
            //Console.WriteLine("Sho2: " + data.sho2);
            //Console.WriteLine("Sho3: " + data.sho3);
            Console.WriteLine("Nai0: " + data.nai0);
            Console.WriteLine("Nai1: " + data.nai1);
            //Console.WriteLine("Nai2: " + data.nai2);
            //Console.WriteLine("Nai3: " + data.nai3);
            Console.WriteLine("NaiAlt: " + data.naiAlt);
            Console.WriteLine("Rai0: " + data.rai0);
            Console.WriteLine("Rai1: " + data.rai1);
            Console.WriteLine("Rai2: " + data.rai2);
            //Console.WriteLine("Rai3: " + data.rai3);
            Console.WriteLine("Rock0: " + data.rock0);
            Console.WriteLine("Rock1: " + data.rock1);
            //Console.WriteLine("Rock2: " + data.rock2);
            //Console.WriteLine("Rock3: " + data.rock3);
            //Console.WriteLine("Rev Customization Unlocked: " + data.revCustomizationUnlocked);
            //Console.WriteLine("Sho Customization Unlocked: " + data.shoCustomizationUnlocked);
            //Console.WriteLine("Nai Customization Unlocked: " + data.naiCustomizationUnlocked);
            //Console.WriteLine("Rai Customization Unlocked: " + data.raiCustomizationUnlocked);
            //Console.WriteLine("Rock Customization Unlocked: " + data.rockCustomizationUnlocked);

            // Phase 5 Close the file.
            br.Close();
        }

        public void resetSave()
        {

        }

        void writeSave(byte[] save)
        {
            byte[] result = save;
            using (var ms = new MemoryStream())
            {   // Expandable
                var bw = new BinaryWriter(ms);

                UInt32 len = 0x1337;
                bw.Write(len);
                // ...

                result = ms.GetBuffer();   // Get the underlying byte array you've created.
            }
        }
    }

    //saddness
    public class BepisGetter
    {
    }
}

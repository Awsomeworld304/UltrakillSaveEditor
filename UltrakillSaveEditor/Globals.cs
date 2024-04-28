using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UltrakillSaveEditor
{
    public static class Globals
    {
        public static class System
        {
            public static readonly String devStr = " - DEV";
            public static readonly bool DEV_MODE = true;
            public static readonly String VERSION = "0.1";

            public static bool noSaveWarning = true;
        }

        public static class Save
        {
            // Specified by the user. Default is the Steam C: save location.
            public static String SAVE_PATH = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\ULTRAKILL\\Saves\\";
            //Should be in the same directory as the executable. .\EditingSave\...
            public static String TEMP_SAVE_LOCATION = ".\\TempSave\\";
            // Five save slots.
            public static bool[] loadedSlots = [false, false, false, false, false];
            public static String activeSlot = "";

            // If the user wants to overwrite the temp save file.
            public static bool overwriteCopy = true;
        }

        public class GeneralData
        {
            enum DataList
            {
                Points,
                IntroSeen,
                TutorialBeat,
                ClashModeUnlocked,
                PeircerRevolver,
                SharpshooterRevolver,
                MarksmanRevolver,
                AlternateRevolver,
                CoreEjectorShotgun,
                PumpChargeShotgun,
                AttractorNailgun,
                OverheatNailgun,
                AlternateNailgun,
                ElectricRailgun,
                ScrewdriverRailgun,
                MaliciousRailgun,
                FreezeFrameRocketlauncher,
                SRSCannonRocketlauncher,
                FeedbackerArm,
                KnuckleblasterArm,
                WhiplashArm
            }

            public readonly String dataHeader = "";

            // Global game stuff
            public int money = 0; // At 0x271 thru 0x274 Called money internally, but Points in game.
            public bool introSeen = false;  // 0x275
            public bool tutorialBeat = false; // 0x276
            public bool clashModeUnlocked = false; // 0x277

            // Guns
            public bool rev0 = true; // 278
            public bool rev1 = false; // 27C
            public bool rev2 = false; // 280
            public bool rev3 = false; // 284 (UNUSED - SCRAPPED)
            public bool revAlt = false; // 288 (Shows an 0x08??)

            public bool sho0 = false; // 28C
            public bool sho1 = false; // 290
            public bool sho2 = false; // 294 (UNUSED - FOR RED VARIENT)
            public bool sho3 = false; // 298 (UNUSED - SCRAPPED)

            public bool nai0 = false; // 29C
            public bool nai1 = false; // 2A0
            public bool nai2 = false; // 2A4 (UNUSED - FOR RED VARIENT)  
            public bool nai3 = false; // 2A8 (UNUSED - SCRAPPED)
            public bool naiAlt = false; // 2AC

            public bool rai0 = false; // 2B0
            public bool rai1 = false; // 2B4
            public bool rai2 = false; // 2B8
            public bool rai3 = false; // 2BC (UNUSED - SCRAPPED)

            public bool rock0 = false; // 2C0
            public bool rock1 = false; // 2C4
            public bool rock2 = false; // 2C8 (UNUSED - FOR RED VARIENT)
            public bool rock3 = false; // 2CC (UNUSED - SCRAPPED)

            // SCRAPPED WEAPON
            public bool beam0 = false; // 2D0
            public bool beam1 = false; // 2D4
            public bool beam2 = false; // 2D8
            public bool beam3 = false; // 2DC

            // These are really weird in memory. They behave differently than anything else. Yet to be figured out.
            public int[] arm1 = { 0,0,0,0 }; // 2E0 2E3
            public int[] arm2 = { 0,0,0,0 }; // 2E4 2E7
            public int[] arm3 = { 0,0,0,0 }; // 2E8 2EB

            // 1(2FD, 2FE, 2FF, 300) 2(302, 303, 304, 305) 3(306, 307, 308, 30D) 4(30E, 30F, 310, 311) 5(312, 313, 314, 315)
            public int[,] secretMissions = { // (0 - Not unlocked) (1 - Unlocked) (2 - Completed)
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}
            };
            // 1() 2() 3() 4()
            public int[,] limboSwitches = { // (0 - Not Pressed) (1 - Pressed)
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0} 
            };
            public int[] shotgunSwitches = { 0 }; // starts: 32F

            //! Used but not figured out yet.
            public int[] newEnemiesFound = { 0 }; // (TBA)
            public int[] unlockablesFound = { 0 }; // (TBA)

            // Customization Flags
            public bool revCustomizationUnlocked = false;  // 32E
            public bool shoCustomizationUnlocked = false;  // 32F
            public bool naiCustomizationUnlocked = false;  // 330
            public bool raiCustomizationUnlocked = false;  // 331
            public bool rockCustomizationUnlocked = false; // 332
        }
    }
}

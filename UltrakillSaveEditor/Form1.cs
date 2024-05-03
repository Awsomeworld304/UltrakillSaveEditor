namespace UltrakillSaveEditor
{
    public partial class Main : Form
    {
        BepisParser bp;
        public Main()
        {
            InitializeComponent();

            if (Globals.System.DEV_MODE)
            {
                this.Text = "Ultrakill Save Editor" + Globals.System.devStr;
            }
            else
            {
                this.Text = "Ultrakill Save Editor";
            }

            Version.Text = "Version: " + Globals.System.VERSION;
            bp = new BepisParser();


            FileUtils.checkSaveDirectory(StatusLabel);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            bp.readSave();

            generalMoney.Text = bp.data.money.ToString();

            dataSelector.SelectedIndex = 0;

            generalToggles.SetItemCheckState(0, bp.data.introSeen ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(1, bp.data.tutorialBeat ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(2, bp.data.clashModeUnlocked ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(3, bp.data.rev0 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(4, bp.data.rev1 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(5, bp.data.rev2 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(6, bp.data.revAlt ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(7, bp.data.sho0 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(8, bp.data.sho1 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(9, bp.data.nai0 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(10, bp.data.nai1 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(11, bp.data.naiAlt ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(12, bp.data.rai0 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(13, bp.data.rai1 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(14, bp.data.rai2 ? CheckState.Checked : CheckState.Unchecked);
            generalToggles.SetItemCheckState(15, bp.data.rock0 ? CheckState.Checked : CheckState.Unchecked);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            moneyLabel.Visible = false;
            generalMoney.Visible = false;
            generalToggles.Visible = false;
        }

        private void SaveModified_Click(object sender, EventArgs e)
        {
            bp.data.money = int.Parse(generalMoney.Text);

            bp.writeSave();
        }

        private void slotSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            BepisParser.checkSlots(slotSelect);
            Console.WriteLine("Selected slot: " + (slotSelect.SelectedIndex + 1));
            switch (slotSelect.SelectedIndex)
            {
                case 0:
                    Globals.Save.activeSlot = "Slot1";
                    break;
                case 1:
                    Globals.Save.activeSlot = "Slot2";
                    break;
                case 2:
                    Globals.Save.activeSlot = "Slot3";
                    break;
                case 3:
                    Globals.Save.activeSlot = "Slot4";
                    break;
                case 4:
                    Globals.Save.activeSlot = "Slot5";
                    break;
            }
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            BepisParser.checkSlots(slotSelect);
        }

        private void overWriteTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (overWriteTemp.Checked)
            {
                Globals.Save.overwriteCopy = true;
            }
            else
            {
                Globals.Save.overwriteCopy = false;
            }
        }

        private void dataSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataSelector.SelectedIndex == 0)
            {
                moneyLabel.Visible = true;
                generalMoney.Visible = true;
                generalToggles.Visible = true;
            }
            else
            {
                moneyLabel.Visible = false;
                generalMoney.Visible = false;
                generalToggles.Visible = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bp.resetSave();
        }

        private void generalMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void generalToggles_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (generalToggles.SelectedIndex)
            {
                case 0:
                    bp.data.introSeen = !bp.data.introSeen;
                    break;
                case 1:
                    bp.data.tutorialBeat = !bp.data.tutorialBeat;
                    break;
                case 2:
                    bp.data.clashModeUnlocked = !bp.data.clashModeUnlocked;
                    break;
                case 3:
                    bp.data.rev0 = !bp.data.rev0;
                    break;
                case 4:
                    bp.data.rev1 = !bp.data.rev1;
                    break;
                case 5:
                    bp.data.rev2 = !bp.data.rev2;
                    break;
                case 6:
                    bp.data.revAlt = !bp.data.revAlt;
                    break;
                case 7:
                    bp.data.sho0 = !bp.data.sho0;
                    break;
                case 8:
                    bp.data.sho1 = !bp.data.sho1;
                    break;
                case 9:
                    bp.data.nai0 = !bp.data.nai0;
                    break;
                case 10:
                    bp.data.nai1 = !bp.data.nai1;
                    break;
                case 11:
                    bp.data.naiAlt = !bp.data.naiAlt;
                    break;
                case 12:
                    bp.data.rai0 = !bp.data.rai0;
                    break;
                case 13:
                    bp.data.rai1 = !bp.data.rai1;
                    break;
                case 14:
                    bp.data.rai2 = !bp.data.rai2;
                    break;
                case 15:
                    bp.data.rock0 = !bp.data.rock0;
                    break;
                case 16:
                    bp.data.rock1 = !bp.data.rock1;
                    break;
            }
        }
    }
}

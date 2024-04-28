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

            dataSelector.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            moneyLabel.Visible = false;
            generalMoney.Visible = false;
            generalToggles.Visible = false;
        }

        private void SaveModified_Click(object sender, EventArgs e)
        {
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

        }
    }
}

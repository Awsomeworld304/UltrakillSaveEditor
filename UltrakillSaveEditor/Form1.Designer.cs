namespace UltrakillSaveEditor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Version = new Label();
            loadButton = new Button();
            SaveModified = new Button();
            resetButton = new Button();
            loadPanel = new Panel();
            overWriteTemp = new CheckBox();
            slotSelect = new ComboBox();
            slotLabel = new Label();
            title = new Label();
            editPanel = new Panel();
            flags_label = new Label();
            moneyLabel = new Label();
            generalMoney = new TextBox();
            generalToggles = new CheckedListBox();
            dataSelector = new ComboBox();
            StatusLabel = new Label();
            loadPanel.SuspendLayout();
            editPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new Font("VCR OSD Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Version.ForeColor = Color.White;
            Version.Location = new Point(12, 9);
            Version.Name = "Version";
            Version.Size = new Size(130, 22);
            Version.TabIndex = 0;
            Version.Text = "Version: 0";
            // 
            // loadButton
            // 
            loadButton.AccessibleDescription = "Loads the save.";
            loadButton.AccessibleName = "Load Save Button.";
            loadButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadButton.Location = new Point(96, 447);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(84, 36);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load Save";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // SaveModified
            // 
            SaveModified.AccessibleDescription = "Saves the new save.";
            SaveModified.AccessibleName = "Save button.";
            SaveModified.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveModified.Location = new Point(372, 447);
            SaveModified.Name = "SaveModified";
            SaveModified.Size = new Size(90, 36);
            SaveModified.TabIndex = 2;
            SaveModified.Text = "Save";
            SaveModified.UseVisualStyleBackColor = true;
            SaveModified.Click += SaveModified_Click;
            // 
            // resetButton
            // 
            resetButton.AccessibleDescription = "Resets the modified save.";
            resetButton.AccessibleName = "Reset button.";
            resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resetButton.Location = new Point(539, 606);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(128, 44);
            resetButton.TabIndex = 3;
            resetButton.Text = "Reset Save";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // loadPanel
            // 
            loadPanel.BackColor = Color.FromArgb(32, 0, 0);
            loadPanel.BorderStyle = BorderStyle.FixedSingle;
            loadPanel.Controls.Add(overWriteTemp);
            loadPanel.Controls.Add(slotSelect);
            loadPanel.Controls.Add(slotLabel);
            loadPanel.Controls.Add(loadButton);
            loadPanel.Location = new Point(34, 77);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(288, 502);
            loadPanel.TabIndex = 5;
            // 
            // overWriteTemp
            // 
            overWriteTemp.AutoSize = true;
            overWriteTemp.Checked = true;
            overWriteTemp.CheckState = CheckState.Checked;
            overWriteTemp.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overWriteTemp.ForeColor = Color.White;
            overWriteTemp.Location = new Point(3, 51);
            overWriteTemp.Name = "overWriteTemp";
            overWriteTemp.Size = new Size(255, 21);
            overWriteTemp.TabIndex = 5;
            overWriteTemp.Text = "Overwrite temporary data.";
            overWriteTemp.UseVisualStyleBackColor = true;
            overWriteTemp.CheckedChanged += overWriteTemp_CheckedChanged;
            // 
            // slotSelect
            // 
            slotSelect.BackColor = Color.FromArgb(32, 0, 0);
            slotSelect.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slotSelect.ForeColor = Color.White;
            slotSelect.FormattingEnabled = true;
            slotSelect.Items.AddRange(new object[] { "Slot1", "Slot2", "Slot3", "Slot4", "Slot5" });
            slotSelect.Location = new Point(3, 20);
            slotSelect.MaxDropDownItems = 5;
            slotSelect.Name = "slotSelect";
            slotSelect.Size = new Size(260, 25);
            slotSelect.TabIndex = 4;
            slotSelect.SelectedIndexChanged += slotSelect_SelectedIndexChanged;
            // 
            // slotLabel
            // 
            slotLabel.AutoSize = true;
            slotLabel.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slotLabel.ForeColor = Color.White;
            slotLabel.Location = new Point(3, 0);
            slotLabel.Name = "slotLabel";
            slotLabel.Size = new Size(134, 17);
            slotLabel.TabIndex = 3;
            slotLabel.Text = "Selected Slot:";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("BroshKill", 47.9999924F);
            title.ForeColor = Color.Red;
            title.Location = new Point(346, 9);
            title.Name = "title";
            title.Size = new Size(533, 64);
            title.TabIndex = 6;
            title.Text = "ULTRAKILL SAVE EDITOR";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editPanel
            // 
            editPanel.BackColor = Color.FromArgb(32, 0, 0);
            editPanel.BorderStyle = BorderStyle.FixedSingle;
            editPanel.Controls.Add(flags_label);
            editPanel.Controls.Add(moneyLabel);
            editPanel.Controls.Add(generalMoney);
            editPanel.Controls.Add(generalToggles);
            editPanel.Controls.Add(dataSelector);
            editPanel.Controls.Add(SaveModified);
            editPanel.Location = new Point(328, 77);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(855, 502);
            editPanel.TabIndex = 6;
            editPanel.Paint += editPanel_Paint;
            // 
            // flags_label
            // 
            flags_label.AutoSize = true;
            flags_label.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flags_label.ForeColor = Color.White;
            flags_label.Location = new Point(-1, 103);
            flags_label.Name = "flags_label";
            flags_label.Size = new Size(62, 17);
            flags_label.TabIndex = 7;
            flags_label.Text = "Flags:";
            flags_label.Click += label1_Click;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyLabel.ForeColor = Color.White;
            moneyLabel.Location = new Point(-1, 42);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(72, 17);
            moneyLabel.TabIndex = 6;
            moneyLabel.Text = "Points:";
            moneyLabel.Click += moneyLabel_Click;
            // 
            // generalMoney
            // 
            generalMoney.BackColor = Color.FromArgb(32, 0, 0);
            generalMoney.ForeColor = Color.White;
            generalMoney.Location = new Point(3, 62);
            generalMoney.MaxLength = 10;
            generalMoney.Name = "generalMoney";
            generalMoney.Size = new Size(269, 23);
            generalMoney.TabIndex = 5;
            generalMoney.TextChanged += generalMoney_TextChanged;
            // 
            // generalToggles
            // 
            generalToggles.BackColor = Color.FromArgb(32, 0, 0);
            generalToggles.Font = new Font("VCR OSD Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generalToggles.ForeColor = Color.White;
            generalToggles.FormattingEnabled = true;
            generalToggles.Items.AddRange(new object[] { "Intro Seen", "Tutorial Completed", "Clash Mode Unlocked", "Piercer Revolver Unlocked", "Sharp Shooter Revolver Unlocked", "Marksman Revolver Unlocked", "Alternate Revolver Unlocked", "Core Eject Shotgun Unlocked", "Pump Charge Shotgun Unlocked", "Attractor Nailgun Unlocked", "Overheat Nailgun Unlocked", "Alternate Nailgun Unlocked", "Electric Railcannon Unlocked", "Screwdriver Railcannon Unlocked", "Malicious Railcannon Unlocked", "Freeze Frame Rocket Launcher Unlocked", "S.R.S. Cannon Rocket Launcher Unlocked" });
            generalToggles.Location = new Point(1, 123);
            generalToggles.Name = "generalToggles";
            generalToggles.Size = new Size(853, 257);
            generalToggles.TabIndex = 4;
            generalToggles.SelectedIndexChanged += generalToggles_SelectedIndexChanged;
            // 
            // dataSelector
            // 
            dataSelector.BackColor = Color.FromArgb(32, 0, 0);
            dataSelector.Font = new Font("VCR OSD Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataSelector.ForeColor = Color.White;
            dataSelector.FormattingEnabled = true;
            dataSelector.Items.AddRange(new object[] { "GeneralProgress", "CybergrindProgress" });
            dataSelector.Location = new Point(1, 2);
            dataSelector.Name = "dataSelector";
            dataSelector.Size = new Size(271, 25);
            dataSelector.TabIndex = 3;
            dataSelector.SelectedIndexChanged += dataSelector_SelectedIndexChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("VCR OSD Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = SystemColors.Window;
            StatusLabel.Location = new Point(12, 650);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(166, 22);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status: Ready";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1264, 681);
            Controls.Add(StatusLabel);
            Controls.Add(editPanel);
            Controls.Add(title);
            Controls.Add(loadPanel);
            Controls.Add(resetButton);
            Controls.Add(Version);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Ultrakill Save Editor";
            Load += Main_Load;
            loadPanel.ResumeLayout(false);
            loadPanel.PerformLayout();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label slotLabel;
        private Label label2;
        private Label Version;
        private Button loadButton;
        private Button SaveModified;
        private Button resetButton;
        private Panel loadPanel;
        private Label title;
        private Panel editPanel;
        private ComboBox slotSelect;
        private CheckBox overWriteTemp;
        private ComboBox dataSelector;
        public Label StatusLabel;
        private CheckedListBox generalToggles;
        private TextBox generalMoney;
        private Label moneyLabel;
        private Label flags_label;
    }
}

namespace AirBomber
{
    partial class FormEntityConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxConfig = new System.Windows.Forms.GroupBox();
            this.ImprovedLabel = new System.Windows.Forms.Label();
            this.SimpleLabel = new System.Windows.Forms.Label();
            this.GroupBoxColors = new System.Windows.Forms.GroupBox();
            this.PanelBlack = new System.Windows.Forms.Panel();
            this.PanelWhite = new System.Windows.Forms.Panel();
            this.PanelPurple = new System.Windows.Forms.Panel();
            this.PanelGrey = new System.Windows.Forms.Panel();
            this.PanelYellow = new System.Windows.Forms.Panel();
            this.PanelBlue = new System.Windows.Forms.Panel();
            this.PanelGreen = new System.Windows.Forms.Panel();
            this.PanelRed = new System.Windows.Forms.Panel();
            this.BombsCheckBox = new System.Windows.Forms.CheckBox();
            this.FuelTanksCheckBox = new System.Windows.Forms.CheckBox();
            this.NumericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.PictureBoxEntity = new System.Windows.Forms.PictureBox();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.AdditionColorLabel = new System.Windows.Forms.Label();
            this.AddEntity = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.GroupBoxConfig.SuspendLayout();
            this.GroupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEntity)).BeginInit();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxConfig
            // 
            this.GroupBoxConfig.Controls.Add(this.ImprovedLabel);
            this.GroupBoxConfig.Controls.Add(this.SimpleLabel);
            this.GroupBoxConfig.Controls.Add(this.GroupBoxColors);
            this.GroupBoxConfig.Controls.Add(this.BombsCheckBox);
            this.GroupBoxConfig.Controls.Add(this.FuelTanksCheckBox);
            this.GroupBoxConfig.Controls.Add(this.NumericUpDownWeight);
            this.GroupBoxConfig.Controls.Add(this.NumericUpDownSpeed);
            this.GroupBoxConfig.Controls.Add(this.LabelWeight);
            this.GroupBoxConfig.Controls.Add(this.LabelSpeed);
            this.GroupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxConfig.Name = "GroupBoxConfig";
            this.GroupBoxConfig.Size = new System.Drawing.Size(463, 233);
            this.GroupBoxConfig.TabIndex = 0;
            this.GroupBoxConfig.TabStop = false;
            this.GroupBoxConfig.Text = "Параметры";
            // 
            // ImprovedLabel
            // 
            this.ImprovedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImprovedLabel.Location = new System.Drawing.Point(340, 156);
            this.ImprovedLabel.Name = "ImprovedLabel";
            this.ImprovedLabel.Size = new System.Drawing.Size(104, 40);
            this.ImprovedLabel.TabIndex = 8;
            this.ImprovedLabel.Text = "Продвинутый";
            this.ImprovedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImprovedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // SimpleLabel
            // 
            this.SimpleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleLabel.Location = new System.Drawing.Point(230, 156);
            this.SimpleLabel.Name = "SimpleLabel";
            this.SimpleLabel.Size = new System.Drawing.Size(104, 40);
            this.SimpleLabel.TabIndex = 7;
            this.SimpleLabel.Text = "Простой";
            this.SimpleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // GroupBoxColors
            // 
            this.GroupBoxColors.Controls.Add(this.PanelBlack);
            this.GroupBoxColors.Controls.Add(this.PanelWhite);
            this.GroupBoxColors.Controls.Add(this.PanelPurple);
            this.GroupBoxColors.Controls.Add(this.PanelGrey);
            this.GroupBoxColors.Controls.Add(this.PanelYellow);
            this.GroupBoxColors.Controls.Add(this.PanelBlue);
            this.GroupBoxColors.Controls.Add(this.PanelGreen);
            this.GroupBoxColors.Controls.Add(this.PanelRed);
            this.GroupBoxColors.Location = new System.Drawing.Point(224, 22);
            this.GroupBoxColors.Name = "GroupBoxColors";
            this.GroupBoxColors.Size = new System.Drawing.Size(231, 131);
            this.GroupBoxColors.TabIndex = 6;
            this.GroupBoxColors.TabStop = false;
            this.GroupBoxColors.Text = "Цвета";
            // 
            // PanelBlack
            // 
            this.PanelBlack.BackColor = System.Drawing.Color.Black;
            this.PanelBlack.Location = new System.Drawing.Point(116, 71);
            this.PanelBlack.Name = "PanelBlack";
            this.PanelBlack.Size = new System.Drawing.Size(49, 43);
            this.PanelBlack.TabIndex = 8;
            // 
            // PanelWhite
            // 
            this.PanelWhite.BackColor = System.Drawing.Color.White;
            this.PanelWhite.Location = new System.Drawing.Point(61, 71);
            this.PanelWhite.Name = "PanelWhite";
            this.PanelWhite.Size = new System.Drawing.Size(49, 43);
            this.PanelWhite.TabIndex = 8;
            // 
            // PanelPurple
            // 
            this.PanelPurple.BackColor = System.Drawing.Color.Purple;
            this.PanelPurple.Location = new System.Drawing.Point(171, 22);
            this.PanelPurple.Name = "PanelPurple";
            this.PanelPurple.Size = new System.Drawing.Size(49, 43);
            this.PanelPurple.TabIndex = 8;
            // 
            // PanelGrey
            // 
            this.PanelGrey.BackColor = System.Drawing.Color.Gray;
            this.PanelGrey.Location = new System.Drawing.Point(171, 71);
            this.PanelGrey.Name = "PanelGrey";
            this.PanelGrey.Size = new System.Drawing.Size(49, 43);
            this.PanelGrey.TabIndex = 8;
            // 
            // PanelYellow
            // 
            this.PanelYellow.BackColor = System.Drawing.Color.Yellow;
            this.PanelYellow.Location = new System.Drawing.Point(6, 22);
            this.PanelYellow.Name = "PanelYellow";
            this.PanelYellow.Size = new System.Drawing.Size(49, 43);
            this.PanelYellow.TabIndex = 8;
            // 
            // PanelBlue
            // 
            this.PanelBlue.BackColor = System.Drawing.Color.Blue;
            this.PanelBlue.Location = new System.Drawing.Point(116, 22);
            this.PanelBlue.Name = "PanelBlue";
            this.PanelBlue.Size = new System.Drawing.Size(49, 43);
            this.PanelBlue.TabIndex = 8;
            // 
            // PanelGreen
            // 
            this.PanelGreen.BackColor = System.Drawing.Color.Lime;
            this.PanelGreen.Location = new System.Drawing.Point(61, 22);
            this.PanelGreen.Name = "PanelGreen";
            this.PanelGreen.Size = new System.Drawing.Size(49, 43);
            this.PanelGreen.TabIndex = 8;
            // 
            // PanelRed
            // 
            this.PanelRed.BackColor = System.Drawing.Color.Red;
            this.PanelRed.Location = new System.Drawing.Point(6, 71);
            this.PanelRed.Name = "PanelRed";
            this.PanelRed.Size = new System.Drawing.Size(49, 43);
            this.PanelRed.TabIndex = 7;
            // 
            // BombsCheckBox
            // 
            this.BombsCheckBox.AutoSize = true;
            this.BombsCheckBox.Location = new System.Drawing.Point(6, 126);
            this.BombsCheckBox.Name = "BombsCheckBox";
            this.BombsCheckBox.Size = new System.Drawing.Size(108, 19);
            this.BombsCheckBox.TabIndex = 5;
            this.BombsCheckBox.Text = "Наличие бомб";
            this.BombsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FuelTanksCheckBox
            // 
            this.FuelTanksCheckBox.AutoSize = true;
            this.FuelTanksCheckBox.Location = new System.Drawing.Point(6, 101);
            this.FuelTanksCheckBox.Name = "FuelTanksCheckBox";
            this.FuelTanksCheckBox.Size = new System.Drawing.Size(174, 19);
            this.FuelTanksCheckBox.TabIndex = 4;
            this.FuelTanksCheckBox.Text = "Наличие топливных баков";
            this.FuelTanksCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownWeight
            // 
            this.NumericUpDownWeight.Location = new System.Drawing.Point(84, 62);
            this.NumericUpDownWeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumericUpDownWeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownWeight.Name = "NumericUpDownWeight";
            this.NumericUpDownWeight.Size = new System.Drawing.Size(73, 23);
            this.NumericUpDownWeight.TabIndex = 3;
            this.NumericUpDownWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // NumericUpDownSpeed
            // 
            this.NumericUpDownSpeed.Location = new System.Drawing.Point(84, 30);
            this.NumericUpDownSpeed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownSpeed.Name = "NumericUpDownSpeed";
            this.NumericUpDownSpeed.Size = new System.Drawing.Size(73, 23);
            this.NumericUpDownSpeed.TabIndex = 2;
            this.NumericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Location = new System.Drawing.Point(6, 64);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(29, 15);
            this.LabelWeight.TabIndex = 1;
            this.LabelWeight.Text = "Вес:";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(6, 30);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(62, 15);
            this.LabelSpeed.TabIndex = 0;
            this.LabelSpeed.Text = "Скорость:";
            // 
            // PictureBoxEntity
            // 
            this.PictureBoxEntity.Location = new System.Drawing.Point(18, 54);
            this.PictureBoxEntity.Name = "PictureBoxEntity";
            this.PictureBoxEntity.Size = new System.Drawing.Size(246, 119);
            this.PictureBoxEntity.TabIndex = 1;
            this.PictureBoxEntity.TabStop = false;
            // 
            // DragPanel
            // 
            this.DragPanel.AllowDrop = true;
            this.DragPanel.Controls.Add(this.ColorLabel);
            this.DragPanel.Controls.Add(this.AdditionColorLabel);
            this.DragPanel.Controls.Add(this.PictureBoxEntity);
            this.DragPanel.Location = new System.Drawing.Point(481, 22);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(286, 186);
            this.DragPanel.TabIndex = 2;
            this.DragPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragPanel_DragDrop);
            this.DragPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragPanel_DragEnter);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AllowDrop = true;
            this.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorLabel.Location = new System.Drawing.Point(18, 7);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(122, 40);
            this.ColorLabel.TabIndex = 9;
            this.ColorLabel.Text = "Цвет";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.ColorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // AdditionColorLabel
            // 
            this.AdditionColorLabel.AllowDrop = true;
            this.AdditionColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionColorLabel.Location = new System.Drawing.Point(146, 7);
            this.AdditionColorLabel.Name = "AdditionColorLabel";
            this.AdditionColorLabel.Size = new System.Drawing.Size(118, 40);
            this.AdditionColorLabel.TabIndex = 8;
            this.AdditionColorLabel.Text = "Доп. цвет";
            this.AdditionColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdditionColorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.AdditionColorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragEnter);
            // 
            // AddEntity
            // 
            this.AddEntity.Location = new System.Drawing.Point(499, 214);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(122, 30);
            this.AddEntity.TabIndex = 10;
            this.AddEntity.Text = "Добавить";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(627, 214);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(118, 30);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormEntityConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 257);
            this.Controls.Add(this.AddEntity);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.GroupBoxConfig);
            this.Name = "FormEntityConfig";
            this.Text = "Создание объекта";
            this.GroupBoxConfig.ResumeLayout(false);
            this.GroupBoxConfig.PerformLayout();
            this.GroupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEntity)).EndInit();
            this.DragPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GroupBoxConfig;
        private NumericUpDown NumericUpDownWeight;
        private NumericUpDown NumericUpDownSpeed;
        private Label LabelWeight;
        private Label LabelSpeed;
        private CheckBox BombsCheckBox;
        private CheckBox FuelTanksCheckBox;
        private GroupBox GroupBoxColors;
        private Panel PanelBlack;
        private Panel PanelWhite;
        private Panel PanelPurple;
        private Panel PanelGrey;
        private Panel PanelYellow;
        private Panel PanelBlue;
        private Panel PanelGreen;
        private Panel PanelRed;
        private Label ImprovedLabel;
        private Label SimpleLabel;
        private PictureBox PictureBoxEntity;
        private Panel DragPanel;
        private Label ColorLabel;
        private Label AdditionColorLabel;
        private Button AddEntity;
        private Button Cancel;
    }
}
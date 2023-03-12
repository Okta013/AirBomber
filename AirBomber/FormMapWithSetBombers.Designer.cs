namespace AirBomber
{
    partial class FormMapWithSetBombers
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RemoveEntity = new System.Windows.Forms.Button();
            this.CheckMap = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.Button();
            this.AddEntity = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.MaskedTextBox);
            this.GroupBox.Controls.Add(this.RemoveEntity);
            this.GroupBox.Controls.Add(this.CheckMap);
            this.GroupBox.Controls.Add(this.CheckBox);
            this.GroupBox.Controls.Add(this.AddEntity);
            this.GroupBox.Controls.Add(this.ComboBox);
            this.GroupBox.Controls.Add(this.ButtonRight);
            this.GroupBox.Controls.Add(this.ButtonDown);
            this.GroupBox.Controls.Add(this.ButtonLeft);
            this.GroupBox.Controls.Add(this.ButtonUp);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupBox.Location = new System.Drawing.Point(754, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(197, 549);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Инструменты";
            // 
            // maskedTextBox1
            // 
            this.MaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskedTextBox.Location = new System.Drawing.Point(18, 180);
            this.MaskedTextBox.Mask = "00";
            this.MaskedTextBox.Name = "MaskedTextBox";
            this.MaskedTextBox.Size = new System.Drawing.Size(167, 23);
            this.MaskedTextBox.TabIndex = 12;
            //  
            // RemoveEntity
            // 
            this.RemoveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEntity.Location = new System.Drawing.Point(18, 250);
            this.RemoveEntity.Name = "RemoveEntity";
            this.RemoveEntity.Size = new System.Drawing.Size(167, 30);
            this.RemoveEntity.TabIndex = 11;
            this.RemoveEntity.Text = "Удалить сущность";
            this.RemoveEntity.UseVisualStyleBackColor = true;
            this.RemoveEntity.Click += RemoveEntity_Click;
            // 
            // CheckMap
            // 
            this.CheckMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckMap.Location = new System.Drawing.Point(18, 398);
            this.CheckMap.Name = "CheckMap";
            this.CheckMap.Size = new System.Drawing.Size(167, 30);
            this.CheckMap.TabIndex = 10;
            this.CheckMap.Text = "Посмотреть карту";
            this.CheckMap.UseVisualStyleBackColor = true;
            this.CheckMap.Click += CheckMap_Click;
            // 
            // CheckBox
            // 
            this.CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox.Location = new System.Drawing.Point(18, 319);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(167, 30);
            this.CheckBox.TabIndex = 9;
            this.CheckBox.Text = "Посмотреть хранилище";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.Click += CheckBox_Click;
            // 
            // AddEntity
            // 
            this.AddEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEntity.Location = new System.Drawing.Point(18, 108);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(167, 30);
            this.AddEntity.TabIndex = 8;
            this.AddEntity.Text = "Добавить сущность";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += AddEntity_Click;
            // 
            // ComboBox
            // 
            this.ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(18, 45);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Items.AddRange(new object[] { "Простая карта", "Улучшенная карта" });
            this.ComboBox.Size = new System.Drawing.Size(167, 23);
            this.ComboBox.TabIndex = 1;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRight.BackgroundImage = global::AirBomber.Properties.Resources.right;
            this.ButtonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRight.Location = new System.Drawing.Point(128, 507);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(30, 30);
            this.ButtonRight.TabIndex = 7;
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += ButtonMove_Click;
            // 
            // ButtonDown
            // 
            this.ButtonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDown.BackgroundImage = global::AirBomber.Properties.Resources.down;
            this.ButtonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDown.Location = new System.Drawing.Point(92, 507);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(30, 30);
            this.ButtonDown.TabIndex = 6;
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += ButtonMove_Click;
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLeft.BackgroundImage = global::AirBomber.Properties.Resources.left;
            this.ButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLeft.Location = new System.Drawing.Point(56, 507);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(30, 30);
            this.ButtonLeft.TabIndex = 5;
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += ButtonMove_Click;
            // 
            // ButtonUp
            // 
            this.ButtonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUp.BackgroundImage = global::AirBomber.Properties.Resources.up;
            this.ButtonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUp.Location = new System.Drawing.Point(92, 471);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(30, 30);
            this.ButtonUp.TabIndex = 4;
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += ButtonMove_Click;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(754, 549);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // FormMaoWithSetBombers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 549);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.GroupBox);
            this.Name = "FormMaoWithSetBombers";
            this.Text = "Form1";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private GroupBox GroupBox;
        private Button ButtonUp;
        private Button ButtonLeft;
        private Button ButtonDown;
        private Button ButtonRight;
        private ComboBox ComboBox;
        private MaskedTextBox MaskedTextBox;
        private Button RemoveEntity;
        private Button CheckMap;
        private Button CheckBox;
        private Button AddEntity;
        private PictureBox PictureBox;
    }
}
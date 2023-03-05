namespace AirBomber
{
    partial class FormAirBomber
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelSpeed = new ToolStripStatusLabel();
            toolStripStatusLabelWeight = new ToolStripStatusLabel();
            toolStripStatusLabelBodyColor = new ToolStripStatusLabel();
            pictureBoxAirBomber = new PictureBox();
            buttonCreate = new Button();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            buttonCreateModif = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirBomber).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSpeed, toolStripStatusLabelWeight, toolStripStatusLabelBodyColor });
            statusStrip1.Location = new Point(0, 439);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSpeed
            // 
            toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            toolStripStatusLabelSpeed.Size = new Size(62, 17);
            toolStripStatusLabelSpeed.Text = "Скорость:";
            // 
            // toolStripStatusLabelWeight
            // 
            toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            toolStripStatusLabelWeight.Size = new Size(29, 17);
            toolStripStatusLabelWeight.Text = "Вес:";
            // 
            // toolStripStatusLabelBodyColor
            // 
            toolStripStatusLabelBodyColor.Name = "toolStripStatusLabelBodyColor";
            toolStripStatusLabelBodyColor.Size = new Size(36, 17);
            toolStripStatusLabelBodyColor.Text = "Цвет:";
            // 
            // pictureBoxAirBomber
            // 
            pictureBoxAirBomber.Dock = DockStyle.Fill;
            pictureBoxAirBomber.Location = new Point(0, 0);
            pictureBoxAirBomber.Name = "pictureBoxAirBomber";
            pictureBoxAirBomber.Size = new Size(884, 439);
            pictureBoxAirBomber.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAirBomber.TabIndex = 1;
            pictureBoxAirBomber.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreate.Location = new Point(12, 404);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.up;
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Location = new Point(806, 368);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(30, 30);
            buttonUp.TabIndex = 3;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.left;
            buttonLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft.Location = new Point(770, 404);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(30, 30);
            buttonLeft.TabIndex = 4;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.down;
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Location = new Point(806, 404);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(30, 30);
            buttonDown.TabIndex = 5;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.right;
            buttonRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight.Location = new Point(842, 404);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(30, 30);
            buttonRight.TabIndex = 6;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // buttonCreateModif
            // 
            buttonCreateModif.Location = new Point(93, 404);
            buttonCreateModif.Name = "buttonCreateModif";
            buttonCreateModif.Size = new Size(100, 23);
            buttonCreateModif.TabIndex = 7;
            buttonCreateModif.Text = "Модификация";
            buttonCreateModif.UseVisualStyleBackColor = true;
            buttonCreateModif.Click += ButtonCreateModif_Click;
            // 
            // FormAirBomber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(buttonCreateModif);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(buttonUp);
            Controls.Add(buttonCreate);
            Controls.Add(pictureBoxAirBomber);
            Controls.Add(statusStrip1);
            Name = "FormAirBomber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бомбардировщик";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAirBomber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelSpeed;
        private ToolStripStatusLabel toolStripStatusLabelWeight;
        private ToolStripStatusLabel toolStripStatusLabelBodyColor;
        private PictureBox pictureBoxAirBomber;
        private Button buttonCreate;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
        private Button buttonCreateModif;
    }
}
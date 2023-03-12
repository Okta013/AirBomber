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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBodyColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxAirBomber = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreateModif = new System.Windows.Forms.Button();
            this.SelectCar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirBomber)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSpeed,
            this.toolStripStatusLabelWeight,
            this.toolStripStatusLabelBodyColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabelSpeed.Text = "Скорость:";
            // 
            // toolStripStatusLabelWeight
            // 
            this.toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            this.toolStripStatusLabelWeight.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelWeight.Text = "Вес:";
            // 
            // toolStripStatusLabelBodyColor
            // 
            this.toolStripStatusLabelBodyColor.Name = "toolStripStatusLabelBodyColor";
            this.toolStripStatusLabelBodyColor.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelBodyColor.Text = "Цвет:";
            // 
            // pictureBoxAirBomber
            // 
            this.pictureBoxAirBomber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAirBomber.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirBomber.Name = "pictureBoxAirBomber";
            this.pictureBoxAirBomber.Size = new System.Drawing.Size(884, 439);
            this.pictureBoxAirBomber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAirBomber.TabIndex = 1;
            this.pictureBoxAirBomber.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Location = new System.Drawing.Point(12, 404);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += ButtonCreate_Click;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::AirBomber.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(806, 368);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::AirBomber.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(770, 404);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::AirBomber.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(806, 404);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::AirBomber.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 404);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonCreateModif
            // 
            this.buttonCreateModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateModif.Location = new System.Drawing.Point(93, 404);
            this.buttonCreateModif.Name = "buttonCreateModif";
            this.buttonCreateModif.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateModif.TabIndex = 7;
            this.buttonCreateModif.Text = "Модификация";
            this.buttonCreateModif.UseVisualStyleBackColor = true;
            this.buttonCreateModif.Click += ButtonCreateModif_Click;
            // 
            // SelectCar
            // 
            this.SelectCar.Location = new System.Drawing.Point(670, 408);
            this.SelectCar.Name = "SelectCar";
            this.SelectCar.Size = new System.Drawing.Size(75, 23);
            this.SelectCar.TabIndex = 10;
            this.SelectCar.Text = "Выбрать";
            this.SelectCar.UseVisualStyleBackColor = true;
            this.SelectCar.Click += new System.EventHandler(this.SelectCar_Click);
            // 
            // FormAirBomber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.SelectCar);
            this.Controls.Add(this.buttonCreateModif);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxAirBomber);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormAirBomber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бомбардировщик";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirBomber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonCreate_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Button SelectCar;
    }
}
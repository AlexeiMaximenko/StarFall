namespace Star
    {
    partial class StarForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.amountStarMenuNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountStarMenuLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountStarMenuNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.amountStarMenuNumericUpDown);
            this.splitContainer.Panel1.Controls.Add(this.amountStarMenuLabel);
            this.splitContainer.Panel1.Controls.Add(this.stopButton);
            this.splitContainer.Panel1.Controls.Add(this.startButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer.Size = new System.Drawing.Size(839, 466);
            this.splitContainer.SplitterDistance = 157;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.Text = "splitContainer1";
            // 
            // amountStarMenuNumericUpDown
            // 
            this.amountStarMenuNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountStarMenuNumericUpDown.Location = new System.Drawing.Point(108, 22);
            this.amountStarMenuNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountStarMenuNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountStarMenuNumericUpDown.Name = "amountStarMenuNumericUpDown";
            this.amountStarMenuNumericUpDown.Size = new System.Drawing.Size(39, 23);
            this.amountStarMenuNumericUpDown.TabIndex = 3;
            this.amountStarMenuNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // amountStarMenuLabel
            // 
            this.amountStarMenuLabel.AutoSize = true;
            this.amountStarMenuLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountStarMenuLabel.Location = new System.Drawing.Point(6, 22);
            this.amountStarMenuLabel.Name = "amountStarMenuLabel";
            this.amountStarMenuLabel.Size = new System.Drawing.Size(96, 20);
            this.amountStarMenuLabel.TabIndex = 2;
            this.amountStarMenuLabel.Text = "Star amount";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(30, 111);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 36);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(30, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(676, 464);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // StarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 466);
            this.Controls.Add(this.splitContainer);
            this.Name = "StarForm";
            this.Text = "Star";
            this.Load += new System.EventHandler(this.starForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountStarMenuNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.NumericUpDown amountStarMenuNumericUpDown;
        private System.Windows.Forms.Label amountStarMenuLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer mainTimer;
        }
    }


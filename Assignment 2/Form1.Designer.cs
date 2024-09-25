namespace Assignment_2
{
    partial class Form1
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
            lblMakeandModel = new Label();
            lblYear = new Label();
            lbMakeandModel = new ListBox();
            grbColors = new GroupBox();
            rbRed = new RadioButton();
            rbBlack = new RadioButton();
            rbBlue = new RadioButton();
            rbGreen = new RadioButton();
            grbFeatures = new GroupBox();
            chkLane = new CheckBox();
            chkSyrius = new CheckBox();
            chkPowerWindows = new CheckBox();
            chkAC = new CheckBox();
            txtYear = new TextBox();
            lblSum = new Label();
            btnPurchase = new Button();
            grbColors.SuspendLayout();
            grbFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeandModel
            // 
            lblMakeandModel.AutoSize = true;
            lblMakeandModel.Location = new Point(46, 13);
            lblMakeandModel.Name = "lblMakeandModel";
            lblMakeandModel.Size = new Size(96, 15);
            lblMakeandModel.TabIndex = 0;
            lblMakeandModel.Text = "&Make and Model";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(271, 15);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // lbMakeandModel
            // 
            lbMakeandModel.FormattingEnabled = true;
            lbMakeandModel.ItemHeight = 15;
            lbMakeandModel.Items.AddRange(new object[] { "Chevy Silverado", "Ford F-150", "Toyota Yaris", "Honda Element" });
            lbMakeandModel.Location = new Point(45, 54);
            lbMakeandModel.Name = "lbMakeandModel";
            lbMakeandModel.Size = new Size(120, 94);
            lbMakeandModel.TabIndex = 1;
            // 
            // grbColors
            // 
            grbColors.Controls.Add(rbRed);
            grbColors.Controls.Add(rbBlack);
            grbColors.Controls.Add(rbBlue);
            grbColors.Controls.Add(rbGreen);
            grbColors.Location = new Point(441, 15);
            grbColors.Name = "grbColors";
            grbColors.Size = new Size(117, 133);
            grbColors.TabIndex = 4;
            grbColors.TabStop = false;
            grbColors.Text = "&Color";
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(0, 96);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(45, 19);
            rbRed.TabIndex = 3;
            rbRed.TabStop = true;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Location = new Point(0, 71);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(53, 19);
            rbBlack.TabIndex = 2;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            rbBlack.CheckedChanged += rbBlack_CheckedChanged;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Location = new Point(0, 46);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(48, 19);
            rbBlue.TabIndex = 1;
            rbBlue.TabStop = true;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            rbBlue.CheckedChanged += rbBlue_CheckedChanged;
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(0, 21);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(56, 19);
            rbGreen.TabIndex = 0;
            rbGreen.TabStop = true;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // grbFeatures
            // 
            grbFeatures.Controls.Add(chkLane);
            grbFeatures.Controls.Add(chkSyrius);
            grbFeatures.Controls.Add(chkPowerWindows);
            grbFeatures.Controls.Add(chkAC);
            grbFeatures.Location = new Point(599, 16);
            grbFeatures.Name = "grbFeatures";
            grbFeatures.Size = new Size(189, 132);
            grbFeatures.TabIndex = 5;
            grbFeatures.TabStop = false;
            grbFeatures.Text = "&Features";
            // 
            // chkLane
            // 
            chkLane.AutoSize = true;
            chkLane.Location = new Point(4, 97);
            chkLane.Name = "chkLane";
            chkLane.Size = new Size(84, 19);
            chkLane.TabIndex = 3;
            chkLane.Text = "Lane Assist";
            chkLane.UseVisualStyleBackColor = true;
            // 
            // chkSyrius
            // 
            chkSyrius.AutoSize = true;
            chkSyrius.Location = new Point(5, 70);
            chkSyrius.Name = "chkSyrius";
            chkSyrius.Size = new Size(90, 19);
            chkSyrius.TabIndex = 2;
            chkSyrius.Text = "Syrius Radio";
            chkSyrius.UseVisualStyleBackColor = true;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(6, 44);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(111, 19);
            chkPowerWindows.TabIndex = 1;
            chkPowerWindows.Text = "Power Windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(6, 20);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(42, 19);
            chkAC.TabIndex = 0;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(235, 54);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 3;
            // 
            // lblSum
            // 
            lblSum.BorderStyle = BorderStyle.FixedSingle;
            lblSum.Location = new Point(315, 247);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(434, 183);
            lblSum.TabIndex = 7;
            lblSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(78, 296);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 6;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPurchase);
            Controls.Add(lblSum);
            Controls.Add(txtYear);
            Controls.Add(grbFeatures);
            Controls.Add(grbColors);
            Controls.Add(lbMakeandModel);
            Controls.Add(lblYear);
            Controls.Add(lblMakeandModel);
            Name = "Form1";
            Text = "Form1";
            grbColors.ResumeLayout(false);
            grbColors.PerformLayout();
            grbFeatures.ResumeLayout(false);
            grbFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMakeandModel;
        private Label lblYear;
        private ListBox lbMakeandModel;
        private GroupBox grbColors;
        private GroupBox grbFeatures;
        private RadioButton rbBlack;
        private RadioButton rbBlue;
        private RadioButton rbGreen;
        private RadioButton rbRed;
        private TextBox txtYear;
        private Label lblSum;
        private Button btnPurchase;
        private CheckBox chkPowerWindows;
        private CheckBox chkAC;
        private CheckBox chkLane;
        private CheckBox chkSyrius;
    }
}

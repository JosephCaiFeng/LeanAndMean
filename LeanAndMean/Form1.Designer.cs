namespace LeanAndMean
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bmiOutputLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.weightTextbox = new System.Windows.Forms.TextBox();
            this.heightftTextbox = new System.Windows.Forms.TextBox();
            this.heightinTextbox = new System.Windows.Forms.TextBox();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.lossPerWeekComboBox = new System.Windows.Forms.ComboBox();
            this.activityLevelComboBox = new System.Windows.Forms.ComboBox();
            this.caloriesOutputLabel = new System.Windows.Forms.Label();
            this.BMIhelp = new System.Windows.Forms.ToolTip(this.components);
            this.helpBMI = new System.Windows.Forms.PictureBox();
            this.infoTDEE = new System.Windows.Forms.ToolTip(this.components);
            this.helpTDEE = new System.Windows.Forms.PictureBox();
            this.macroLabel = new System.Windows.Forms.Label();
            this.macroComboBox = new System.Windows.Forms.ComboBox();
            this.macroLabelOutputLabel = new System.Windows.Forms.Label();
            this.macroLabelOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpTDEE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight (lbs): ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ft.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "in.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleButton);
            this.groupBox1.Controls.Add(this.maleButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(71, 19);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 1;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(14, 19);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 0;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Desired Weight Loss / Week:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Activity Level:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "BMI Score:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Calories you should consume each day:";
            // 
            // bmiOutputLabel
            // 
            this.bmiOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmiOutputLabel.Location = new System.Drawing.Point(209, 366);
            this.bmiOutputLabel.Name = "bmiOutputLabel";
            this.bmiOutputLabel.Size = new System.Drawing.Size(103, 25);
            this.bmiOutputLabel.TabIndex = 10;
            this.bmiOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(41, 459);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 12;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(135, 459);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(226, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // weightTextbox
            // 
            this.weightTextbox.Location = new System.Drawing.Point(81, 6);
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(100, 20);
            this.weightTextbox.TabIndex = 15;
            // 
            // heightftTextbox
            // 
            this.heightftTextbox.Location = new System.Drawing.Point(81, 48);
            this.heightftTextbox.Name = "heightftTextbox";
            this.heightftTextbox.Size = new System.Drawing.Size(100, 20);
            this.heightftTextbox.TabIndex = 16;
            // 
            // heightinTextbox
            // 
            this.heightinTextbox.Location = new System.Drawing.Point(209, 52);
            this.heightinTextbox.Name = "heightinTextbox";
            this.heightinTextbox.Size = new System.Drawing.Size(100, 20);
            this.heightinTextbox.TabIndex = 17;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(81, 85);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(100, 20);
            this.ageTextbox.TabIndex = 18;
            // 
            // lossPerWeekComboBox
            // 
            this.lossPerWeekComboBox.FormattingEnabled = true;
            this.lossPerWeekComboBox.Items.AddRange(new object[] {
            "0.5 lbs",
            "1 lb",
            "2 lbs",
            "Maintain weight."});
            this.lossPerWeekComboBox.Location = new System.Drawing.Point(166, 197);
            this.lossPerWeekComboBox.Name = "lossPerWeekComboBox";
            this.lossPerWeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.lossPerWeekComboBox.TabIndex = 19;
            // 
            // activityLevelComboBox
            // 
            this.activityLevelComboBox.FormattingEnabled = true;
            this.activityLevelComboBox.Items.AddRange(new object[] {
            "Sedentary (Office Job)",
            "Light (1 - 2 days per week)",
            "Moderate (3 - 5 days per week)",
            "Heavy (6 - 7 days per week)",
            "Athlete (Twice a day)"});
            this.activityLevelComboBox.Location = new System.Drawing.Point(166, 224);
            this.activityLevelComboBox.Name = "activityLevelComboBox";
            this.activityLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.activityLevelComboBox.TabIndex = 20;
            // 
            // caloriesOutputLabel
            // 
            this.caloriesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesOutputLabel.Location = new System.Drawing.Point(209, 414);
            this.caloriesOutputLabel.Name = "caloriesOutputLabel";
            this.caloriesOutputLabel.Size = new System.Drawing.Size(103, 25);
            this.caloriesOutputLabel.TabIndex = 21;
            this.caloriesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIhelp
            // 
            this.BMIhelp.BackColor = System.Drawing.SystemColors.InfoText;
            // 
            // helpBMI
            // 
            this.helpBMI.Image = global::LeanAndMean.Properties.Resources.qOXqp;
            this.helpBMI.Location = new System.Drawing.Point(318, 374);
            this.helpBMI.Name = "helpBMI";
            this.helpBMI.Size = new System.Drawing.Size(13, 17);
            this.helpBMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpBMI.TabIndex = 23;
            this.helpBMI.TabStop = false;
            this.BMIhelp.SetToolTip(this.helpBMI, "The body mass index (BMI) or Quetelet index is a measure of body fat derived from" +
        " the mass (weight) and height of an individual.");
            // 
            // infoTDEE
            // 
            this.infoTDEE.IsBalloon = true;
            this.infoTDEE.ShowAlways = true;
            this.infoTDEE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // helpTDEE
            // 
            this.helpTDEE.Image = global::LeanAndMean.Properties.Resources.qOXqp;
            this.helpTDEE.Location = new System.Drawing.Point(318, 420);
            this.helpTDEE.Name = "helpTDEE";
            this.helpTDEE.Size = new System.Drawing.Size(13, 17);
            this.helpTDEE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helpTDEE.TabIndex = 24;
            this.helpTDEE.TabStop = false;
            this.infoTDEE.SetToolTip(this.helpTDEE, "TDEE, total daily energy expenditure, is the amount of energy in calories you bur" +
        "n per day. TDEE is best calculated by factoring in your BMR, or basal metabolic " +
        "rate, and your activity level. ");
            // 
            // macroLabel
            // 
            this.macroLabel.AutoSize = true;
            this.macroLabel.Location = new System.Drawing.Point(115, 261);
            this.macroLabel.Name = "macroLabel";
            this.macroLabel.Size = new System.Drawing.Size(45, 13);
            this.macroLabel.TabIndex = 25;
            this.macroLabel.Text = "Macros:";
            // 
            // macroComboBox
            // 
            this.macroComboBox.FormattingEnabled = true;
            this.macroComboBox.Items.AddRange(new object[] {
            "Maintain",
            "Bulk",
            "Cut"});
            this.macroComboBox.Location = new System.Drawing.Point(166, 258);
            this.macroComboBox.Name = "macroComboBox";
            this.macroComboBox.Size = new System.Drawing.Size(121, 21);
            this.macroComboBox.TabIndex = 26;
            // 
            // macroLabelOutputLabel
            // 
            this.macroLabelOutputLabel.AutoSize = true;
            this.macroLabelOutputLabel.Location = new System.Drawing.Point(21, 287);
            this.macroLabelOutputLabel.Name = "macroLabelOutputLabel";
            this.macroLabelOutputLabel.Size = new System.Drawing.Size(120, 13);
            this.macroLabelOutputLabel.TabIndex = 27;
            this.macroLabelOutputLabel.Text = "Recommended Macros:";
            this.macroLabelOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // macroLabelOutput
            // 
            this.macroLabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macroLabelOutput.Location = new System.Drawing.Point(24, 310);
            this.macroLabelOutput.Name = "macroLabelOutput";
            this.macroLabelOutput.Size = new System.Drawing.Size(288, 46);
            this.macroLabelOutput.TabIndex = 28;
            this.macroLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 503);
            this.Controls.Add(this.macroLabelOutput);
            this.Controls.Add(this.macroLabelOutputLabel);
            this.Controls.Add(this.macroComboBox);
            this.Controls.Add(this.macroLabel);
            this.Controls.Add(this.helpTDEE);
            this.Controls.Add(this.helpBMI);
            this.Controls.Add(this.caloriesOutputLabel);
            this.Controls.Add(this.activityLevelComboBox);
            this.Controls.Add(this.lossPerWeekComboBox);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.heightinTextbox);
            this.Controls.Add(this.heightftTextbox);
            this.Controls.Add(this.weightTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.bmiOutputLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpTDEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bmiOutputLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox weightTextbox;
        private System.Windows.Forms.TextBox heightftTextbox;
        private System.Windows.Forms.TextBox heightinTextbox;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.ComboBox lossPerWeekComboBox;
        private System.Windows.Forms.ComboBox activityLevelComboBox;
        private System.Windows.Forms.Label caloriesOutputLabel;
        private System.Windows.Forms.ToolTip BMIhelp;
        private System.Windows.Forms.ToolTip infoTDEE;
        private System.Windows.Forms.PictureBox helpBMI;
        private System.Windows.Forms.PictureBox helpTDEE;
        private System.Windows.Forms.Label macroLabel;
        private System.Windows.Forms.ComboBox macroComboBox;
        private System.Windows.Forms.Label macroLabelOutputLabel;
        private System.Windows.Forms.Label macroLabelOutput;
    }
}


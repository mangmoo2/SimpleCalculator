namespace SimpleCalculator
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
            label1 = new Label();
            TotalDisplay = new TextBox();
            CurrentDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            pictureBox1 = new PictureBox();
            listBoxHistory = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightPink;
            label1.Font = new Font("한컴 울주 반구대 암각화체", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 0;
            label1.Text = "나만의 계산기 ♥";
            label1.Click += label1_Click;
            // 
            // TotalDisplay
            // 
            TotalDisplay.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            TotalDisplay.Location = new Point(40, 78);
            TotalDisplay.Name = "TotalDisplay";
            TotalDisplay.Size = new Size(318, 33);
            TotalDisplay.TabIndex = 1;
            // 
            // CurrentDisplay
            // 
            CurrentDisplay.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CurrentDisplay.Location = new Point(41, 107);
            CurrentDisplay.Name = "CurrentDisplay";
            CurrentDisplay.Size = new Size(317, 33);
            CurrentDisplay.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(39, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 3;
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CE_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(120, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 4;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += C_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.DeepPink;
            button3.Location = new Point(282, 196);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 6;
            button3.Text = "÷";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Op_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(201, 196);
            button4.Name = "button4";
            button4.Size = new Size(75, 45);
            button4.TabIndex = 5;
            button4.Text = "del";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Del_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button5.ForeColor = Color.DeepPink;
            button5.Location = new Point(282, 247);
            button5.Name = "button5";
            button5.Size = new Size(75, 45);
            button5.TabIndex = 10;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Op_Click;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button6.ForeColor = Color.DeepPink;
            button6.Location = new Point(201, 247);
            button6.Name = "button6";
            button6.Size = new Size(75, 45);
            button6.TabIndex = 9;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Number_Click;
            // 
            // button7
            // 
            button7.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button7.ForeColor = Color.DeepPink;
            button7.Location = new Point(120, 247);
            button7.Name = "button7";
            button7.Size = new Size(75, 45);
            button7.TabIndex = 8;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Number_Click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button8.ForeColor = Color.DeepPink;
            button8.Location = new Point(39, 247);
            button8.Name = "button8";
            button8.Size = new Size(75, 45);
            button8.TabIndex = 7;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Number_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MistyRose;
            button9.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button9.ForeColor = Color.DeepPink;
            button9.Location = new Point(282, 349);
            button9.Name = "button9";
            button9.Size = new Size(75, 45);
            button9.TabIndex = 18;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Op_Click;
            // 
            // button10
            // 
            button10.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button10.ForeColor = Color.DeepPink;
            button10.Location = new Point(201, 349);
            button10.Name = "button10";
            button10.Size = new Size(75, 45);
            button10.TabIndex = 17;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Number_Click;
            // 
            // button11
            // 
            button11.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button11.ForeColor = Color.DeepPink;
            button11.Location = new Point(120, 349);
            button11.Name = "button11";
            button11.Size = new Size(75, 45);
            button11.TabIndex = 16;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Number_Click;
            // 
            // button12
            // 
            button12.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button12.ForeColor = Color.DeepPink;
            button12.Location = new Point(39, 349);
            button12.Name = "button12";
            button12.Size = new Size(75, 45);
            button12.TabIndex = 15;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Number_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MistyRose;
            button13.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button13.ForeColor = Color.DeepPink;
            button13.Location = new Point(283, 298);
            button13.Name = "button13";
            button13.Size = new Size(75, 45);
            button13.TabIndex = 14;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = false;
            button13.Click += Op_Click;
            // 
            // button14
            // 
            button14.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button14.ForeColor = Color.DeepPink;
            button14.Location = new Point(202, 298);
            button14.Name = "button14";
            button14.Size = new Size(75, 45);
            button14.TabIndex = 13;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Number_Click;
            // 
            // button15
            // 
            button15.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button15.ForeColor = Color.DeepPink;
            button15.Location = new Point(121, 298);
            button15.Name = "button15";
            button15.Size = new Size(75, 45);
            button15.TabIndex = 12;
            button15.Text = "5";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Number_Click;
            // 
            // button16
            // 
            button16.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button16.ForeColor = Color.DeepPink;
            button16.Location = new Point(40, 298);
            button16.Name = "button16";
            button16.Size = new Size(75, 45);
            button16.TabIndex = 11;
            button16.Text = "4";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Number_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.MistyRose;
            button17.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button17.ForeColor = Color.DeepPink;
            button17.Location = new Point(282, 400);
            button17.Name = "button17";
            button17.Size = new Size(75, 45);
            button17.TabIndex = 22;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += Result_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Moccasin;
            button18.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button18.ForeColor = Color.DeepPink;
            button18.Location = new Point(201, 400);
            button18.Name = "button18";
            button18.Size = new Size(75, 45);
            button18.TabIndex = 21;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = false;
            button18.Click += Dot_Click;
            // 
            // button19
            // 
            button19.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button19.ForeColor = Color.DeepPink;
            button19.Location = new Point(120, 400);
            button19.Name = "button19";
            button19.Size = new Size(75, 45);
            button19.TabIndex = 20;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Number_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Moccasin;
            button20.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            button20.ForeColor = Color.DeepPink;
            button20.Location = new Point(39, 400);
            button20.Name = "button20";
            button20.Size = new Size(75, 45);
            button20.TabIndex = 19;
            button20.Text = "+/-";
            button20.UseVisualStyleBackColor = false;
            button20.Click += Negate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightPink;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 166);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // listBoxHistory
            // 
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(418, 23);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(369, 424);
            listBoxHistory.TabIndex = 24;
            listBoxHistory.Click += listBoxHistory_DoubleClick;
            listBoxHistory.SelectedIndexChanged += listBoxHistory_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(820, 481);
            Controls.Add(listBoxHistory);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CurrentDisplay);
            Controls.Add(TotalDisplay);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TotalDisplay;
        private TextBox CurrentDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private PictureBox pictureBox1;
        private ListBox listBoxHistory;
    }
}

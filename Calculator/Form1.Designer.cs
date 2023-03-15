namespace Calculator
{
    partial class Calculator_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScreen = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.btnHistoryOut = new CustomControls.RJControls.RJButton();
            this.btnShowHistory = new CustomControls.RJControls.RJButton();
            this.btnTag = new CustomControls.RJControls.RJButton();
            this.btnCos = new CustomControls.RJControls.RJButton();
            this.btnSin = new CustomControls.RJControls.RJButton();
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.btnSubstraction = new CustomControls.RJControls.RJButton();
            this.btnMultiplication = new CustomControls.RJControls.RJButton();
            this.btnDivide = new CustomControls.RJControls.RJButton();
            this.btnEqual = new CustomControls.RJControls.RJButton();
            this.btnPoint = new CustomControls.RJControls.RJButton();
            this.btnZero = new CustomControls.RJControls.RJButton();
            this.btnThree = new CustomControls.RJControls.RJButton();
            this.btnTwo = new CustomControls.RJControls.RJButton();
            this.btnOne = new CustomControls.RJControls.RJButton();
            this.btnSix = new CustomControls.RJControls.RJButton();
            this.btnFive = new CustomControls.RJControls.RJButton();
            this.btnFour = new CustomControls.RJControls.RJButton();
            this.btnNine = new CustomControls.RJControls.RJButton();
            this.btnEight = new CustomControls.RJControls.RJButton();
            this.btnSeven = new CustomControls.RJControls.RJButton();
            this.btnSqrt = new CustomControls.RJControls.RJButton();
            this.btnBracketR = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btnDelete = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnScreen);
            this.panel1.Controls.Add(this.output);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 126);
            this.panel1.TabIndex = 21;
            // 
            // btnScreen
            // 
            this.btnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnScreen.Enabled = false;
            this.btnScreen.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnScreen.HideSelection = false;
            this.btnScreen.Location = new System.Drawing.Point(25, 8);
            this.btnScreen.Multiline = true;
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.ReadOnly = true;
            this.btnScreen.Size = new System.Drawing.Size(515, 53);
            this.btnScreen.TabIndex = 23;
            this.btnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Cursor = System.Windows.Forms.Cursors.Default;
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.output.Location = new System.Drawing.Point(65, 63);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(475, 56);
            this.output.TabIndex = 0;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(68, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 122);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(757, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 34);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "History";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.btnTag);
            this.groupBox1.Controls.Add(this.btnCos);
            this.groupBox1.Controls.Add(this.btnSin);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSubstraction);
            this.groupBox1.Controls.Add(this.btnMultiplication);
            this.groupBox1.Controls.Add(this.btnDivide);
            this.groupBox1.Controls.Add(this.btnEqual);
            this.groupBox1.Controls.Add(this.btnPoint);
            this.groupBox1.Controls.Add(this.btnZero);
            this.groupBox1.Controls.Add(this.btnThree);
            this.groupBox1.Controls.Add(this.btnTwo);
            this.groupBox1.Controls.Add(this.btnOne);
            this.groupBox1.Controls.Add(this.btnSix);
            this.groupBox1.Controls.Add(this.btnFive);
            this.groupBox1.Controls.Add(this.btnFour);
            this.groupBox1.Controls.Add(this.btnNine);
            this.groupBox1.Controls.Add(this.btnEight);
            this.groupBox1.Controls.Add(this.btnSeven);
            this.groupBox1.Controls.Add(this.btnSqrt);
            this.groupBox1.Controls.Add(this.btnBracketR);
            this.groupBox1.Controls.Add(this.rjButton2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(27, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 568);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // listHistory
            // 
            this.listHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.ForeColor = System.Drawing.Color.White;
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 31;
            this.listHistory.Location = new System.Drawing.Point(615, 93);
            this.listHistory.Name = "listHistory";
            this.listHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listHistory.Size = new System.Drawing.Size(394, 500);
            this.listHistory.TabIndex = 28;
            this.listHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btnHistoryOut
            // 
            this.btnHistoryOut.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHistoryOut.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHistoryOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHistoryOut.BorderRadius = 10;
            this.btnHistoryOut.BorderSize = 0;
            this.btnHistoryOut.FlatAppearance.BorderSize = 0;
            this.btnHistoryOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryOut.ForeColor = System.Drawing.Color.White;
            this.btnHistoryOut.Location = new System.Drawing.Point(820, 659);
            this.btnHistoryOut.Name = "btnHistoryOut";
            this.btnHistoryOut.Size = new System.Drawing.Size(189, 40);
            this.btnHistoryOut.TabIndex = 27;
            this.btnHistoryOut.Text = "Delete History";
            this.btnHistoryOut.TextColor = System.Drawing.Color.White;
            this.btnHistoryOut.UseVisualStyleBackColor = false;
            this.btnHistoryOut.Click += new System.EventHandler(this.btnHistoryOut_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnShowHistory.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.btnShowHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowHistory.BorderRadius = 10;
            this.btnShowHistory.BorderSize = 0;
            this.btnShowHistory.FlatAppearance.BorderSize = 0;
            this.btnShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistory.ForeColor = System.Drawing.Color.White;
            this.btnShowHistory.Location = new System.Drawing.Point(615, 659);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(187, 40);
            this.btnShowHistory.TabIndex = 26;
            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.TextColor = System.Drawing.Color.White;
            this.btnShowHistory.UseVisualStyleBackColor = false;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTag.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnTag.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTag.BorderRadius = 20;
            this.btnTag.BorderSize = 0;
            this.btnTag.FlatAppearance.BorderSize = 0;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTag.ForeColor = System.Drawing.Color.White;
            this.btnTag.Location = new System.Drawing.Point(6, 336);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(109, 100);
            this.btnTag.TabIndex = 46;
            this.btnTag.Text = "tag";
            this.btnTag.TextColor = System.Drawing.Color.White;
            this.btnTag.UseVisualStyleBackColor = false;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnCos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCos.BorderRadius = 20;
            this.btnCos.BorderSize = 0;
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(6, 230);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(109, 100);
            this.btnCos.TabIndex = 45;
            this.btnCos.Text = "cos";
            this.btnCos.TextColor = System.Drawing.Color.White;
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSin.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnSin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSin.BorderRadius = 20;
            this.btnSin.BorderSize = 0;
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.Location = new System.Drawing.Point(6, 126);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(109, 100);
            this.btnSin.TabIndex = 44;
            this.btnSin.Text = "sin";
            this.btnSin.TextColor = System.Drawing.Color.White;
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(453, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 100);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.Color.SlateGray;
            this.btnSubstraction.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnSubstraction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubstraction.BorderRadius = 20;
            this.btnSubstraction.BorderSize = 0;
            this.btnSubstraction.FlatAppearance.BorderSize = 0;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.ForeColor = System.Drawing.Color.White;
            this.btnSubstraction.Location = new System.Drawing.Point(453, 336);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(103, 100);
            this.btnSubstraction.TabIndex = 42;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.TextColor = System.Drawing.Color.White;
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.SlateGray;
            this.btnMultiplication.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnMultiplication.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMultiplication.BorderRadius = 20;
            this.btnMultiplication.BorderSize = 0;
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.ForeColor = System.Drawing.Color.White;
            this.btnMultiplication.Location = new System.Drawing.Point(453, 232);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(103, 100);
            this.btnMultiplication.TabIndex = 41;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.TextColor = System.Drawing.Color.White;
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.SlateGray;
            this.btnDivide.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btnDivide.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDivide.BorderRadius = 20;
            this.btnDivide.BorderSize = 0;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(453, 124);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(103, 100);
            this.btnDivide.TabIndex = 40;
            this.btnDivide.Text = "/";
            this.btnDivide.TextColor = System.Drawing.Color.White;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click_1);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEqual.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEqual.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.BorderRadius = 20;
            this.btnEqual.BorderSize = 0;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(227, 442);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(221, 100);
            this.btnEqual.TabIndex = 39;
            this.btnEqual.Text = "=";
            this.btnEqual.TextColor = System.Drawing.Color.White;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.DimGray;
            this.btnPoint.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnPoint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPoint.BorderRadius = 20;
            this.btnPoint.BorderSize = 0;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(6, 442);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(109, 100);
            this.btnPoint.TabIndex = 38;
            this.btnPoint.Text = ".";
            this.btnPoint.TextColor = System.Drawing.Color.White;
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.DimGray;
            this.btnZero.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnZero.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnZero.BorderRadius = 20;
            this.btnZero.BorderSize = 0;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(115, 442);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(109, 100);
            this.btnZero.TabIndex = 37;
            this.btnZero.Text = "0";
            this.btnZero.TextColor = System.Drawing.Color.White;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.DimGray;
            this.btnThree.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnThree.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThree.BorderRadius = 20;
            this.btnThree.BorderSize = 0;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(339, 336);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(109, 100);
            this.btnThree.TabIndex = 36;
            this.btnThree.Text = "3";
            this.btnThree.TextColor = System.Drawing.Color.White;
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.DimGray;
            this.btnTwo.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnTwo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTwo.BorderRadius = 20;
            this.btnTwo.BorderSize = 0;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(227, 336);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(109, 100);
            this.btnTwo.TabIndex = 35;
            this.btnTwo.Text = "2";
            this.btnTwo.TextColor = System.Drawing.Color.White;
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.DimGray;
            this.btnOne.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnOne.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOne.BorderRadius = 20;
            this.btnOne.BorderSize = 0;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(115, 336);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(109, 100);
            this.btnOne.TabIndex = 34;
            this.btnOne.Text = "1";
            this.btnOne.TextColor = System.Drawing.Color.White;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.DimGray;
            this.btnSix.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnSix.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSix.BorderRadius = 20;
            this.btnSix.BorderSize = 0;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(339, 232);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(109, 100);
            this.btnSix.TabIndex = 33;
            this.btnSix.Text = "6";
            this.btnSix.TextColor = System.Drawing.Color.White;
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click_1);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.DimGray;
            this.btnFive.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnFive.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFive.BorderRadius = 20;
            this.btnFive.BorderSize = 0;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(227, 232);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(109, 100);
            this.btnFive.TabIndex = 32;
            this.btnFive.Text = "5";
            this.btnFive.TextColor = System.Drawing.Color.White;
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.DimGray;
            this.btnFour.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnFour.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFour.BorderRadius = 20;
            this.btnFour.BorderSize = 0;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(115, 230);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(109, 100);
            this.btnFour.TabIndex = 31;
            this.btnFour.Text = "4";
            this.btnFour.TextColor = System.Drawing.Color.White;
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click_1);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.DimGray;
            this.btnNine.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnNine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNine.BorderRadius = 20;
            this.btnNine.BorderSize = 0;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.ForeColor = System.Drawing.Color.White;
            this.btnNine.Location = new System.Drawing.Point(339, 126);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(109, 100);
            this.btnNine.TabIndex = 30;
            this.btnNine.Text = "9";
            this.btnNine.TextColor = System.Drawing.Color.White;
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click_1);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.DimGray;
            this.btnEight.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnEight.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEight.BorderRadius = 20;
            this.btnEight.BorderSize = 0;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.ForeColor = System.Drawing.Color.White;
            this.btnEight.Location = new System.Drawing.Point(227, 126);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(109, 100);
            this.btnEight.TabIndex = 29;
            this.btnEight.Text = "8";
            this.btnEight.TextColor = System.Drawing.Color.White;
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click_1);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.DimGray;
            this.btnSeven.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnSeven.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSeven.BorderRadius = 20;
            this.btnSeven.BorderSize = 0;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(115, 124);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(109, 100);
            this.btnSeven.TabIndex = 28;
            this.btnSeven.Text = "7";
            this.btnSeven.TextColor = System.Drawing.Color.White;
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click_1);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSqrt.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnSqrt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSqrt.BorderRadius = 20;
            this.btnSqrt.BorderSize = 0;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(453, 20);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(103, 100);
            this.btnSqrt.TabIndex = 27;
            this.btnSqrt.Text = "√";
            this.btnSqrt.TextColor = System.Drawing.Color.White;
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnBracketR
            // 
            this.btnBracketR.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBracketR.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnBracketR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBracketR.BorderRadius = 20;
            this.btnBracketR.BorderSize = 0;
            this.btnBracketR.FlatAppearance.BorderSize = 0;
            this.btnBracketR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBracketR.ForeColor = System.Drawing.Color.White;
            this.btnBracketR.Location = new System.Drawing.Point(339, 20);
            this.btnBracketR.Name = "btnBracketR";
            this.btnBracketR.Size = new System.Drawing.Size(109, 100);
            this.btnBracketR.TabIndex = 26;
            this.btnBracketR.Text = ")";
            this.btnBracketR.TextColor = System.Drawing.Color.White;
            this.btnBracketR.UseVisualStyleBackColor = false;
            this.btnBracketR.Click += new System.EventHandler(this.btnBracketR_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.LightSlateGray;
            this.rjButton2.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(227, 18);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(109, 100);
            this.rjButton2.TabIndex = 25;
            this.rjButton2.Text = "(";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnBracketL_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(2, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(222, 100);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "C";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1036, 731);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.btnHistoryOut);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox output;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox btnScreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btnBracketR;
        private CustomControls.RJControls.RJButton btnSqrt;
        private CustomControls.RJControls.RJButton btnSeven;
        private CustomControls.RJControls.RJButton btnEight;
        private CustomControls.RJControls.RJButton btnNine;
        private CustomControls.RJControls.RJButton btnFour;
        private CustomControls.RJControls.RJButton btnFive;
        private CustomControls.RJControls.RJButton btnSix;
        private CustomControls.RJControls.RJButton btnOne;
        private CustomControls.RJControls.RJButton btnTwo;
        private CustomControls.RJControls.RJButton btnThree;
        private CustomControls.RJControls.RJButton btnZero;
        private CustomControls.RJControls.RJButton btnPoint;
        private CustomControls.RJControls.RJButton btnEqual;
        private CustomControls.RJControls.RJButton btnDivide;
        private CustomControls.RJControls.RJButton btnMultiplication;
        private CustomControls.RJControls.RJButton btnSubstraction;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnSin;
        private CustomControls.RJControls.RJButton btnCos;
        private CustomControls.RJControls.RJButton btnTag;
        private CustomControls.RJControls.RJButton btnShowHistory;
        private CustomControls.RJControls.RJButton btnHistoryOut;
        private System.Windows.Forms.ListBox listHistory;
    }
}


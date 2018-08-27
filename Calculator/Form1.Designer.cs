namespace Calculator
{
    partial class CalcForm
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
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.Modulo = new System.Windows.Forms.Button();
            this.Multiplication_Inverse = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Clr_Entry = new System.Windows.Forms.Button();
            this.Global_Clr = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Bullet_Oprtr = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.PlusMinus_Sign = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.Square_Root = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Screen_Output = new System.Windows.Forms.Label();
            this.Label_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(2, 84);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ReadOnly = true;
            this.TxtBox.Size = new System.Drawing.Size(435, 20);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.Text = "0";
            this.TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Modulo
            // 
            this.Modulo.Location = new System.Drawing.Point(2, 110);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(105, 41);
            this.Modulo.TabIndex = 2;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Operation_Perf);
            // 
            // Multiplication_Inverse
            // 
            this.Multiplication_Inverse.Location = new System.Drawing.Point(333, 110);
            this.Multiplication_Inverse.Name = "Multiplication_Inverse";
            this.Multiplication_Inverse.Size = new System.Drawing.Size(104, 41);
            this.Multiplication_Inverse.TabIndex = 3;
            this.Multiplication_Inverse.Text = "1/x";
            this.Multiplication_Inverse.UseVisualStyleBackColor = true;
            this.Multiplication_Inverse.Click += new System.EventHandler(this.Multiplication_Inverse_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(223, 110);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(104, 41);
            this.Square.TabIndex = 5;
            this.Square.Text = "x²";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Clr_Entry
            // 
            this.Clr_Entry.Location = new System.Drawing.Point(2, 153);
            this.Clr_Entry.Name = "Clr_Entry";
            this.Clr_Entry.Size = new System.Drawing.Size(105, 41);
            this.Clr_Entry.TabIndex = 6;
            this.Clr_Entry.Text = "CE";
            this.Clr_Entry.UseVisualStyleBackColor = true;
            this.Clr_Entry.Click += new System.EventHandler(this.Clr_Entry_Click);
            // 
            // Global_Clr
            // 
            this.Global_Clr.Location = new System.Drawing.Point(113, 153);
            this.Global_Clr.Name = "Global_Clr";
            this.Global_Clr.Size = new System.Drawing.Size(104, 41);
            this.Global_Clr.TabIndex = 7;
            this.Global_Clr.Text = "C";
            this.Global_Clr.UseVisualStyleBackColor = true;
            this.Global_Clr.Click += new System.EventHandler(this.Global_Clr_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(333, 153);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(104, 41);
            this.Division.TabIndex = 9;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Operation_Perf);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(333, 196);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(104, 41);
            this.Multiplication.TabIndex = 10;
            this.Multiplication.Text = "×";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Operation_Perf);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(333, 239);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(104, 41);
            this.Substraction.TabIndex = 11;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Operation_Perf);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(333, 282);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(104, 41);
            this.Addition.TabIndex = 12;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Operation_Perf);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(333, 324);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(104, 41);
            this.Equal.TabIndex = 13;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Bullet_Oprtr
            // 
            this.Bullet_Oprtr.Location = new System.Drawing.Point(223, 324);
            this.Bullet_Oprtr.Name = "Bullet_Oprtr";
            this.Bullet_Oprtr.Size = new System.Drawing.Size(104, 41);
            this.Bullet_Oprtr.TabIndex = 14;
            this.Bullet_Oprtr.Text = ".";
            this.Bullet_Oprtr.UseVisualStyleBackColor = true;
            this.Bullet_Oprtr.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(113, 324);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(104, 41);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Button_Click);
            // 
            // PlusMinus_Sign
            // 
            this.PlusMinus_Sign.Location = new System.Drawing.Point(2, 324);
            this.PlusMinus_Sign.Name = "PlusMinus_Sign";
            this.PlusMinus_Sign.Size = new System.Drawing.Size(105, 41);
            this.PlusMinus_Sign.TabIndex = 16;
            this.PlusMinus_Sign.Text = "±";
            this.PlusMinus_Sign.UseVisualStyleBackColor = true;
            this.PlusMinus_Sign.Click += new System.EventHandler(this.PlusMinus_Sign_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.Location = new System.Drawing.Point(2, 196);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(105, 41);
            this.btnSeven.TabIndex = 17;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(113, 196);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(104, 41);
            this.btnEight.TabIndex = 18;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(223, 196);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(104, 41);
            this.btnNine.TabIndex = 19;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(2, 239);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(105, 41);
            this.btnFour.TabIndex = 20;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(113, 239);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(104, 41);
            this.btnFive.TabIndex = 21;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(223, 239);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(104, 41);
            this.btnSix.TabIndex = 22;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(2, 282);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(105, 41);
            this.btnOne.TabIndex = 23;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(113, 282);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(104, 41);
            this.btnTwo.TabIndex = 24;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(223, 282);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(104, 41);
            this.btnThree.TabIndex = 25;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.Button_Click);
            // 
            // Square_Root
            // 
            this.Square_Root.Location = new System.Drawing.Point(113, 110);
            this.Square_Root.Name = "Square_Root";
            this.Square_Root.Size = new System.Drawing.Size(104, 41);
            this.Square_Root.TabIndex = 26;
            this.Square_Root.Text = "√";
            this.Square_Root.UseVisualStyleBackColor = true;
            this.Square_Root.Click += new System.EventHandler(this.Square_Root_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(223, 153);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(104, 41);
            this.Backspace.TabIndex = 28;
            this.Backspace.Text = "←";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Screen_Output
            // 
            this.Screen_Output.AutoSize = true;
            this.Screen_Output.Location = new System.Drawing.Point(391, 53);
            this.Screen_Output.Name = "Screen_Output";
            this.Screen_Output.Size = new System.Drawing.Size(0, 13);
            this.Screen_Output.TabIndex = 29;
            // 
            // Label_Show
            // 
            this.Label_Show.AutoSize = true;
            this.Label_Show.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label_Show.Location = new System.Drawing.Point(397, 53);
            this.Label_Show.Name = "Label_Show";
            this.Label_Show.Size = new System.Drawing.Size(0, 13);
            this.Label_Show.TabIndex = 30;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.Label_Show);
            this.Controls.Add(this.Screen_Output);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Square_Root);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.PlusMinus_Sign);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.Bullet_Oprtr);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Global_Clr);
            this.Controls.Add(this.Clr_Entry);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Multiplication_Inverse);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.TxtBox);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button Multiplication_Inverse;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Clr_Entry;
        private System.Windows.Forms.Button Global_Clr;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Bullet_Oprtr;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button PlusMinus_Sign;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button Square_Root;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Label Screen_Output;
        private System.Windows.Forms.Label Label_Show;
    }
}


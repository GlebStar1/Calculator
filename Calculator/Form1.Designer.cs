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
            this.Zero = new System.Windows.Forms.Button();
            this.PlusMinus_Sign = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
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
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(113, 324);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(104, 41);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Button_Click);
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
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Transparent;
            this.Seven.Location = new System.Drawing.Point(2, 196);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(105, 41);
            this.Seven.TabIndex = 17;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(113, 196);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(104, 41);
            this.Eight.TabIndex = 18;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(223, 196);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(104, 41);
            this.Nine.TabIndex = 19;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(2, 239);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(105, 41);
            this.Four.TabIndex = 20;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Button_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(113, 239);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(104, 41);
            this.Five.TabIndex = 21;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Button_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(223, 239);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(104, 41);
            this.Six.TabIndex = 22;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Button_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(2, 282);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(105, 41);
            this.One.TabIndex = 23;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Button_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(113, 282);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(104, 41);
            this.Two.TabIndex = 24;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Button_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(223, 282);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(104, 41);
            this.Three.TabIndex = 25;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Button_Click);
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
            // Calc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 367);
            this.Controls.Add(this.Label_Show);
            this.Controls.Add(this.Screen_Output);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Square_Root);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.PlusMinus_Sign);
            this.Controls.Add(this.Zero);
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
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button PlusMinus_Sign;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Square_Root;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Label Screen_Output;
        private System.Windows.Forms.Label Label_Show;
    }
}


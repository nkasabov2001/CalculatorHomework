namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.labelInput = new System.Windows.Forms.Label();
            this.inputOutputBox = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonMultiplyByMinusOne = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonFraction = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputOutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.BackColor = System.Drawing.Color.Gray;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.ForeColor = System.Drawing.Color.Cyan;
            this.labelInput.Location = new System.Drawing.Point(31, 88);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(180, 30);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "0";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputOutputBox
            // 
            this.inputOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputOutputBox.Location = new System.Drawing.Point(12, 12);
            this.inputOutputBox.Name = "inputOutputBox";
            this.inputOutputBox.Size = new System.Drawing.Size(218, 131);
            this.inputOutputBox.TabIndex = 6;
            this.inputOutputBox.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Gray;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.Cyan;
            this.labelResult.Location = new System.Drawing.Point(30, 31);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(180, 30);
            this.labelResult.TabIndex = 7;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonMultiplyByMinusOne
            // 
            this.buttonMultiplyByMinusOne.BackColor = System.Drawing.Color.DimGray;
            this.buttonMultiplyByMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplyByMinusOne.ForeColor = System.Drawing.Color.Cyan;
            this.buttonMultiplyByMinusOne.Location = new System.Drawing.Point(12, 428);
            this.buttonMultiplyByMinusOne.Name = "buttonMultiplyByMinusOne";
            this.buttonMultiplyByMinusOne.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiplyByMinusOne.TabIndex = 8;
            this.buttonMultiplyByMinusOne.Text = "+/-";
            this.buttonMultiplyByMinusOne.UseVisualStyleBackColor = false;
            this.buttonMultiplyByMinusOne.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.DimGray;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.ForeColor = System.Drawing.Color.Cyan;
            this.buttonZero.Location = new System.Drawing.Point(68, 428);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(50, 50);
            this.buttonZero.TabIndex = 9;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.DimGray;
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPoint.Location = new System.Drawing.Point(124, 428);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(50, 50);
            this.buttonPoint.TabIndex = 10;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.DimGray;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.ForeColor = System.Drawing.Color.Cyan;
            this.buttonEquals.Location = new System.Drawing.Point(180, 428);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 50);
            this.buttonEquals.TabIndex = 11;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.DimGray;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.ForeColor = System.Drawing.Color.Cyan;
            this.buttonNine.Location = new System.Drawing.Point(124, 261);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(50, 50);
            this.buttonNine.TabIndex = 12;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.DimGray;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.ForeColor = System.Drawing.Color.Cyan;
            this.buttonEight.Location = new System.Drawing.Point(68, 261);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(50, 50);
            this.buttonEight.TabIndex = 29;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.DimGray;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSeven.Location = new System.Drawing.Point(12, 261);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(50, 50);
            this.buttonSeven.TabIndex = 28;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.DimGray;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSix.Location = new System.Drawing.Point(124, 316);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(50, 50);
            this.buttonSix.TabIndex = 27;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.DimGray;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.ForeColor = System.Drawing.Color.Cyan;
            this.buttonFive.Location = new System.Drawing.Point(68, 316);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(50, 50);
            this.buttonFive.TabIndex = 26;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.DimGray;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.ForeColor = System.Drawing.Color.Cyan;
            this.buttonFour.Location = new System.Drawing.Point(12, 316);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(50, 50);
            this.buttonFour.TabIndex = 25;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackSpace.ForeColor = System.Drawing.Color.Cyan;
            this.buttonBackSpace.Location = new System.Drawing.Point(180, 149);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(50, 50);
            this.buttonBackSpace.TabIndex = 24;
            this.buttonBackSpace.Text = "⌫";
            this.buttonBackSpace.UseVisualStyleBackColor = false;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DimGray;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Cyan;
            this.buttonClear.Location = new System.Drawing.Point(124, 149);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.DimGray;
            this.buttonClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearEntry.ForeColor = System.Drawing.Color.Cyan;
            this.buttonClearEntry.Location = new System.Drawing.Point(68, 149);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(50, 50);
            this.buttonClearEntry.TabIndex = 22;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.DimGray;
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercent.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPercent.Location = new System.Drawing.Point(12, 149);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(50, 50);
            this.buttonPercent.TabIndex = 21;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonFraction
            // 
            this.buttonFraction.BackColor = System.Drawing.Color.DimGray;
            this.buttonFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFraction.ForeColor = System.Drawing.Color.Cyan;
            this.buttonFraction.Location = new System.Drawing.Point(12, 205);
            this.buttonFraction.Name = "buttonFraction";
            this.buttonFraction.Size = new System.Drawing.Size(50, 50);
            this.buttonFraction.TabIndex = 20;
            this.buttonFraction.Text = "1/x";
            this.buttonFraction.UseVisualStyleBackColor = false;
            this.buttonFraction.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.BackColor = System.Drawing.Color.DimGray;
            this.buttonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPower.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPower.Location = new System.Drawing.Point(68, 205);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(50, 50);
            this.buttonPower.TabIndex = 19;
            this.buttonPower.Text = "^2";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(124, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "√x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonDevide
            // 
            this.buttonDevide.BackColor = System.Drawing.Color.DimGray;
            this.buttonDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDevide.ForeColor = System.Drawing.Color.Cyan;
            this.buttonDevide.Location = new System.Drawing.Point(180, 205);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(50, 50);
            this.buttonDevide.TabIndex = 17;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = false;
            this.buttonDevide.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.DimGray;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.Cyan;
            this.buttonMultiply.Location = new System.Drawing.Point(180, 261);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.DimGray;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSubtract.Location = new System.Drawing.Point(180, 316);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 50);
            this.buttonSubtract.TabIndex = 15;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAdd.Location = new System.Drawing.Point(180, 372);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOprataion_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.DimGray;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.ForeColor = System.Drawing.Color.Cyan;
            this.buttonThree.Location = new System.Drawing.Point(124, 372);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(50, 50);
            this.buttonThree.TabIndex = 13;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.DimGray;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.ForeColor = System.Drawing.Color.Cyan;
            this.buttonTwo.Location = new System.Drawing.Point(68, 372);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(50, 50);
            this.buttonTwo.TabIndex = 30;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.DimGray;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.ForeColor = System.Drawing.Color.Cyan;
            this.buttonOne.Location = new System.Drawing.Point(12, 372);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(50, 50);
            this.buttonOne.TabIndex = 31;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(247, 489);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonFraction);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDevide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonMultiplyByMinusOne);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.inputOutputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.inputOutputBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.PictureBox inputOutputBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonMultiplyByMinusOne;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonFraction;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
    }
}


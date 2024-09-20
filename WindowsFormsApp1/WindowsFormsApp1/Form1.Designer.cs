namespace WindowsFormsApp1
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
            this.Count = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.UpperCase = new System.Windows.Forms.Button();
            this.LowerCase = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EvenOdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(270, 273);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(75, 23);
            this.Count.TabIndex = 0;
            this.Count.Text = "Count";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.GetName_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(270, 247);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(296, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // UpperCase
            // 
            this.UpperCase.Location = new System.Drawing.Point(382, 273);
            this.UpperCase.Name = "UpperCase";
            this.UpperCase.Size = new System.Drawing.Size(75, 23);
            this.UpperCase.TabIndex = 2;
            this.UpperCase.Text = "UpperCase";
            this.UpperCase.UseVisualStyleBackColor = true;
            this.UpperCase.Click += new System.EventHandler(this.button2_Click);
            // 
            // LowerCase
            // 
            this.LowerCase.Location = new System.Drawing.Point(491, 273);
            this.LowerCase.Name = "LowerCase";
            this.LowerCase.Size = new System.Drawing.Size(75, 23);
            this.LowerCase.TabIndex = 3;
            this.LowerCase.Text = "LowerCase";
            this.LowerCase.UseVisualStyleBackColor = true;
            this.LowerCase.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Greetings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(382, 313);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 5;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TextBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TextBox1";
            // 
            // EvenOdd
            // 
            this.EvenOdd.Location = new System.Drawing.Point(491, 313);
            this.EvenOdd.Name = "EvenOdd";
            this.EvenOdd.Size = new System.Drawing.Size(75, 23);
            this.EvenOdd.TabIndex = 9;
            this.EvenOdd.Text = "Even/Odd";
            this.EvenOdd.UseVisualStyleBackColor = true;
            this.EvenOdd.Click += new System.EventHandler(this.EvenOdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "By Entering String into the Textbox1 you can used Button like Count, UpperCase, L" +
    "owerCase and Greetings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(535, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "By Entering Hello World into the TextBox1 and Entering C# into the TextBox2 you c" +
    "an Used the Button Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(530, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "By Entering Numbers into TextBox1 you can determine if the number is even or odd " +
    "using the button Even/Odd";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EvenOdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LowerCase);
            this.Controls.Add(this.UpperCase);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Count);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button UpperCase;
        private System.Windows.Forms.Button LowerCase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EvenOdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


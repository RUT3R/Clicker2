namespace Clicker
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1upgradeAmmount = new System.Windows.Forms.Button();
            this.A1upgradeinterval = new System.Windows.Forms.Button();
            this.A1label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Napierdalaj ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUBY: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPGRADE\r\n(10)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Location = new System.Drawing.Point(148, 9);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            this.A1AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1upgradeAmmount
            // 
            this.A1upgradeAmmount.Location = new System.Drawing.Point(254, 10);
            this.A1upgradeAmmount.Name = "A1upgradeAmmount";
            this.A1upgradeAmmount.Size = new System.Drawing.Size(100, 23);
            this.A1upgradeAmmount.TabIndex = 5;
            this.A1upgradeAmmount.Text = "Ulepsz ilość";
            this.A1upgradeAmmount.UseVisualStyleBackColor = true;
            this.A1upgradeAmmount.Click += new System.EventHandler(this.A1upgradeAmmount_Click);
            // 
            // A1upgradeinterval
            // 
            this.A1upgradeinterval.Location = new System.Drawing.Point(254, 59);
            this.A1upgradeinterval.Name = "A1upgradeinterval";
            this.A1upgradeinterval.Size = new System.Drawing.Size(127, 27);
            this.A1upgradeinterval.TabIndex = 6;
            this.A1upgradeinterval.Text = "Ulepsz częstotliwość";
            this.A1upgradeinterval.UseVisualStyleBackColor = true;
            this.A1upgradeinterval.Click += new System.EventHandler(this.A1upgradeinterval_Click);
            // 
            // A1label
            // 
            this.A1label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1label.Location = new System.Drawing.Point(12, 9);
            this.A1label.Name = "A1label";
            this.A1label.Size = new System.Drawing.Size(130, 30);
            this.A1label.TabIndex = 7;
            this.A1label.Text = "AUTOUPGRADE";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(148, 62);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1label);
            this.Controls.Add(this.A1upgradeinterval);
            this.Controls.Add(this.A1upgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private TextBox A1AmmountTextBox;
        private Button A1upgradeAmmount;
        private Button A1upgradeinterval;
        private Label A1label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
    }
}
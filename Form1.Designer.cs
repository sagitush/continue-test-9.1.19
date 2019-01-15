using System;

namespace exam_chelek_c___etgar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random1Lbl = new System.Windows.Forms.Label();
            this.random2Lbl = new System.Windows.Forms.Label();
            this.random3Lbl = new System.Windows.Forms.Label();
            this.random4Lbl = new System.Windows.Forms.Label();
            this.random5Lbl = new System.Windows.Forms.Label();
            this.memory1TxtBx = new System.Windows.Forms.TextBox();
            this.memory2TxtBx = new System.Windows.Forms.TextBox();
            this.memory3TxtBx = new System.Windows.Forms.TextBox();
            this.memory4TxtBx = new System.Windows.Forms.TextBox();
            this.memory5TxtBx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resultsLstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // random1Lbl
            // 
            this.random1Lbl.AutoSize = true;
            this.random1Lbl.Location = new System.Drawing.Point(66, 79);
            this.random1Lbl.Name = "random1Lbl";
            this.random1Lbl.Size = new System.Drawing.Size(35, 13);
            this.random1Lbl.TabIndex = 1;
            this.random1Lbl.Text = "label1";
            // 
            // random2Lbl
            // 
            this.random2Lbl.AutoSize = true;
            this.random2Lbl.Location = new System.Drawing.Point(188, 79);
            this.random2Lbl.Name = "random2Lbl";
            this.random2Lbl.Size = new System.Drawing.Size(35, 13);
            this.random2Lbl.TabIndex = 2;
            this.random2Lbl.Text = "label2";
            this.random2Lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // random3Lbl
            // 
            this.random3Lbl.AutoSize = true;
            this.random3Lbl.Location = new System.Drawing.Point(319, 79);
            this.random3Lbl.Name = "random3Lbl";
            this.random3Lbl.Size = new System.Drawing.Size(35, 13);
            this.random3Lbl.TabIndex = 3;
            this.random3Lbl.Text = "label3";
            // 
            // random4Lbl
            // 
            this.random4Lbl.AutoSize = true;
            this.random4Lbl.Location = new System.Drawing.Point(429, 79);
            this.random4Lbl.Name = "random4Lbl";
            this.random4Lbl.Size = new System.Drawing.Size(35, 13);
            this.random4Lbl.TabIndex = 4;
            this.random4Lbl.Text = "label4";
            // 
            // random5Lbl
            // 
            this.random5Lbl.AutoSize = true;
            this.random5Lbl.Location = new System.Drawing.Point(544, 79);
            this.random5Lbl.Name = "random5Lbl";
            this.random5Lbl.Size = new System.Drawing.Size(35, 13);
            this.random5Lbl.TabIndex = 5;
            this.random5Lbl.Text = "label5";
            // 
            // memory1TxtBx
            // 
            this.memory1TxtBx.Location = new System.Drawing.Point(31, 133);
            this.memory1TxtBx.Name = "memory1TxtBx";
            this.memory1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.memory1TxtBx.TabIndex = 6;
            this.memory1TxtBx.TextChanged += new System.EventHandler(this.memory1TxtBx_Leave_1);
            this.memory1TxtBx.Leave += new System.EventHandler(this.memory1TxtBx_Leave_1);
            // 
            // memory2TxtBx
            // 
            this.memory2TxtBx.Location = new System.Drawing.Point(158, 133);
            this.memory2TxtBx.Name = "memory2TxtBx";
            this.memory2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.memory2TxtBx.TabIndex = 7;
            this.memory2TxtBx.TextChanged += new System.EventHandler(this.memory2TxtBx_Leave);
            // 
            // memory3TxtBx
            // 
            this.memory3TxtBx.Location = new System.Drawing.Point(281, 133);
            this.memory3TxtBx.Name = "memory3TxtBx";
            this.memory3TxtBx.Size = new System.Drawing.Size(100, 20);
            this.memory3TxtBx.TabIndex = 8;
            this.memory3TxtBx.TextChanged += new System.EventHandler(this.memory3TxtBx_Leave);
            // 
            // memory4TxtBx
            // 
            this.memory4TxtBx.Location = new System.Drawing.Point(400, 133);
            this.memory4TxtBx.Name = "memory4TxtBx";
            this.memory4TxtBx.Size = new System.Drawing.Size(100, 20);
            this.memory4TxtBx.TabIndex = 9;
            this.memory4TxtBx.TextChanged += new System.EventHandler(this.memory4TxtBx_Leave);
            // 
            // memory5TxtBx
            // 
            this.memory5TxtBx.Location = new System.Drawing.Point(516, 133);
            this.memory5TxtBx.Name = "memory5TxtBx";
            this.memory5TxtBx.Size = new System.Drawing.Size(100, 20);
            this.memory5TxtBx.TabIndex = 10;
            this.memory5TxtBx.TextChanged += new System.EventHandler(this.memory5TxtBx_Leave);
            this.memory5TxtBx.Leave += new System.EventHandler(this.memory5TxtBx_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(406, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(516, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // resultsLstBox
            // 
            this.resultsLstBox.FormattingEnabled = true;
            this.resultsLstBox.Location = new System.Drawing.Point(31, 304);
            this.resultsLstBox.Name = "resultsLstBox";
            this.resultsLstBox.Size = new System.Drawing.Size(409, 134);
            this.resultsLstBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(48, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "High Scores:";
            // 
            // headLbl
            // 
            this.headLbl.AutoSize = true;
            this.headLbl.Location = new System.Drawing.Point(57, 48);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(35, 13);
            this.headLbl.TabIndex = 15;
            this.headLbl.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsLstBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memory5TxtBx);
            this.Controls.Add(this.memory4TxtBx);
            this.Controls.Add(this.memory3TxtBx);
            this.Controls.Add(this.memory2TxtBx);
            this.Controls.Add(this.memory1TxtBx);
            this.Controls.Add(this.random5Lbl);
            this.Controls.Add(this.random4Lbl);
            this.Controls.Add(this.random3Lbl);
            this.Controls.Add(this.random2Lbl);
            this.Controls.Add(this.random1Lbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label random1Lbl;
        private System.Windows.Forms.Label random2Lbl;
        private System.Windows.Forms.Label random3Lbl;
        private System.Windows.Forms.Label random4Lbl;
        private System.Windows.Forms.Label random5Lbl;
        private System.Windows.Forms.TextBox memory1TxtBx;
        private System.Windows.Forms.TextBox memory2TxtBx;
        private System.Windows.Forms.TextBox memory3TxtBx;
        private System.Windows.Forms.TextBox memory4TxtBx;
        private System.Windows.Forms.TextBox memory5TxtBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox resultsLstBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headLbl;
    }
}


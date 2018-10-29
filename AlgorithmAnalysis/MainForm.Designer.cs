namespace AlgorithmAnalysis
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRadix = new System.Windows.Forms.Button();
            this.buttonCounting = new System.Windows.Forms.Button();
            this.buttonMedianQuickSort = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonShell = new System.Windows.Forms.Button();
            this.buttonOGQuickSort = new System.Windows.Forms.Button();
            this.buttonInsertion = new System.Windows.Forms.Button();
            this.buttonSink = new System.Windows.Forms.Button();
            this.textBoxFinished = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRadix);
            this.panel1.Controls.Add(this.buttonCounting);
            this.panel1.Controls.Add(this.buttonMedianQuickSort);
            this.panel1.Controls.Add(this.buttonMerge);
            this.panel1.Controls.Add(this.buttonSelection);
            this.panel1.Controls.Add(this.buttonShell);
            this.panel1.Controls.Add(this.buttonOGQuickSort);
            this.panel1.Controls.Add(this.buttonInsertion);
            this.panel1.Controls.Add(this.buttonSink);
            this.panel1.Location = new System.Drawing.Point(34, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 339);
            this.panel1.TabIndex = 1;
            // 
            // buttonRadix
            // 
            this.buttonRadix.Location = new System.Drawing.Point(112, 272);
            this.buttonRadix.Name = "buttonRadix";
            this.buttonRadix.Size = new System.Drawing.Size(113, 59);
            this.buttonRadix.TabIndex = 11;
            this.buttonRadix.Text = "Radix Sort";
            this.buttonRadix.UseVisualStyleBackColor = true;
            // 
            // buttonCounting
            // 
            this.buttonCounting.Location = new System.Drawing.Point(204, 207);
            this.buttonCounting.Name = "buttonCounting";
            this.buttonCounting.Size = new System.Drawing.Size(113, 59);
            this.buttonCounting.TabIndex = 10;
            this.buttonCounting.Text = "Counting Sort";
            this.buttonCounting.UseVisualStyleBackColor = true;
            // 
            // buttonMedianQuickSort
            // 
            this.buttonMedianQuickSort.Location = new System.Drawing.Point(204, 144);
            this.buttonMedianQuickSort.Name = "buttonMedianQuickSort";
            this.buttonMedianQuickSort.Size = new System.Drawing.Size(113, 59);
            this.buttonMedianQuickSort.TabIndex = 9;
            this.buttonMedianQuickSort.Text = "Quick Sort (Median of Three)";
            this.buttonMedianQuickSort.UseVisualStyleBackColor = true;
            this.buttonMedianQuickSort.Click += new System.EventHandler(this.buttonMedianQuickSort_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(204, 78);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(113, 59);
            this.buttonMerge.TabIndex = 8;
            this.buttonMerge.Text = "Merge Sort";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(204, 13);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(113, 59);
            this.buttonSelection.TabIndex = 7;
            this.buttonSelection.Text = "Selection Sort";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // buttonShell
            // 
            this.buttonShell.Location = new System.Drawing.Point(24, 207);
            this.buttonShell.Name = "buttonShell";
            this.buttonShell.Size = new System.Drawing.Size(113, 59);
            this.buttonShell.TabIndex = 6;
            this.buttonShell.Text = "Shell Sort";
            this.buttonShell.UseVisualStyleBackColor = true;
            // 
            // buttonOGQuickSort
            // 
            this.buttonOGQuickSort.Location = new System.Drawing.Point(24, 143);
            this.buttonOGQuickSort.Name = "buttonOGQuickSort";
            this.buttonOGQuickSort.Size = new System.Drawing.Size(113, 59);
            this.buttonOGQuickSort.TabIndex = 5;
            this.buttonOGQuickSort.Text = "Quick Sort (Original)";
            this.buttonOGQuickSort.UseVisualStyleBackColor = true;
            this.buttonOGQuickSort.Click += new System.EventHandler(this.buttonOGQuickSort_Click);
            // 
            // buttonInsertion
            // 
            this.buttonInsertion.Location = new System.Drawing.Point(24, 78);
            this.buttonInsertion.Name = "buttonInsertion";
            this.buttonInsertion.Size = new System.Drawing.Size(113, 59);
            this.buttonInsertion.TabIndex = 4;
            this.buttonInsertion.Text = "Insertion Sort";
            this.buttonInsertion.UseVisualStyleBackColor = true;
            // 
            // buttonSink
            // 
            this.buttonSink.Location = new System.Drawing.Point(24, 13);
            this.buttonSink.Name = "buttonSink";
            this.buttonSink.Size = new System.Drawing.Size(113, 59);
            this.buttonSink.TabIndex = 3;
            this.buttonSink.Text = "&Sinking Sort";
            this.buttonSink.UseVisualStyleBackColor = true;
            this.buttonSink.Click += new System.EventHandler(this.buttonSink_Click);
            // 
            // textBoxFinished
            // 
            this.textBoxFinished.Location = new System.Drawing.Point(106, 416);
            this.textBoxFinished.Name = "textBoxFinished";
            this.textBoxFinished.ReadOnly = true;
            this.textBoxFinished.Size = new System.Drawing.Size(177, 22);
            this.textBoxFinished.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFinished);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithm Analysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRadix;
        private System.Windows.Forms.Button buttonCounting;
        private System.Windows.Forms.Button buttonMedianQuickSort;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonShell;
        private System.Windows.Forms.Button buttonOGQuickSort;
        private System.Windows.Forms.Button buttonInsertion;
        private System.Windows.Forms.Button buttonSink;
        private System.Windows.Forms.TextBox textBoxFinished;
        private System.Windows.Forms.Label label1;
    }
}


﻿namespace PicAnalyzer
{
        partial class PicAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicAnalyzer));
            this.NextButton = new System.Windows.Forms.Button();
            this.PersonPresent = new System.Windows.Forms.CheckBox();
            this.Fixations = new System.Windows.Forms.GroupBox();
            this.InvalidFixation = new System.Windows.Forms.RadioButton();
            this.SurroundingFixation = new System.Windows.Forms.RadioButton();
            this.BodyFixation = new System.Windows.Forms.RadioButton();
            this.HeadFixation = new System.Windows.Forms.RadioButton();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportVideoFramesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Fixations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.AutoSize = true;
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(772, 612);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(126, 50);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next Image";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // PersonPresent
            // 
            this.PersonPresent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonPresent.AutoSize = true;
            this.PersonPresent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonPresent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonPresent.Location = new System.Drawing.Point(6, 19);
            this.PersonPresent.Name = "PersonPresent";
            this.PersonPresent.Size = new System.Drawing.Size(97, 17);
            this.PersonPresent.TabIndex = 4;
            this.PersonPresent.Text = "Person present";
            this.PersonPresent.UseVisualStyleBackColor = false;
            // 
            // Fixations
            // 
            this.Fixations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fixations.AutoSize = true;
            this.Fixations.Controls.Add(this.InvalidFixation);
            this.Fixations.Controls.Add(this.SurroundingFixation);
            this.Fixations.Controls.Add(this.BodyFixation);
            this.Fixations.Controls.Add(this.HeadFixation);
            this.Fixations.Location = new System.Drawing.Point(6, 42);
            this.Fixations.Name = "Fixations";
            this.Fixations.Size = new System.Drawing.Size(165, 124);
            this.Fixations.TabIndex = 11;
            this.Fixations.TabStop = false;
            this.Fixations.Text = "Fixations";
            // 
            // InvalidFixation
            // 
            this.InvalidFixation.AutoSize = true;
            this.InvalidFixation.Location = new System.Drawing.Point(6, 88);
            this.InvalidFixation.Name = "InvalidFixation";
            this.InvalidFixation.Size = new System.Drawing.Size(56, 17);
            this.InvalidFixation.TabIndex = 3;
            this.InvalidFixation.TabStop = true;
            this.InvalidFixation.Text = "Invalid";
            this.InvalidFixation.UseVisualStyleBackColor = true;
            // 
            // SurroundingFixation
            // 
            this.SurroundingFixation.AutoSize = true;
            this.SurroundingFixation.Location = new System.Drawing.Point(6, 65);
            this.SurroundingFixation.Name = "SurroundingFixation";
            this.SurroundingFixation.Size = new System.Drawing.Size(87, 17);
            this.SurroundingFixation.TabIndex = 2;
            this.SurroundingFixation.TabStop = true;
            this.SurroundingFixation.Text = "Surroundings";
            this.SurroundingFixation.UseVisualStyleBackColor = true;
            // 
            // BodyFixation
            // 
            this.BodyFixation.AutoSize = true;
            this.BodyFixation.Location = new System.Drawing.Point(6, 42);
            this.BodyFixation.Name = "BodyFixation";
            this.BodyFixation.Size = new System.Drawing.Size(49, 17);
            this.BodyFixation.TabIndex = 1;
            this.BodyFixation.TabStop = true;
            this.BodyFixation.Text = "Body";
            this.BodyFixation.UseVisualStyleBackColor = true;
            // 
            // HeadFixation
            // 
            this.HeadFixation.AutoSize = true;
            this.HeadFixation.Location = new System.Drawing.Point(6, 19);
            this.HeadFixation.Name = "HeadFixation";
            this.HeadFixation.Size = new System.Drawing.Size(51, 17);
            this.HeadFixation.TabIndex = 0;
            this.HeadFixation.TabStop = true;
            this.HeadFixation.Text = "Head";
            this.HeadFixation.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousButton.AutoSize = true;
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Location = new System.Drawing.Point(12, 612);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(126, 50);
            this.PreviousButton.TabIndex = 12;
            this.PreviousButton.Text = "Previous Image";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click_1);
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.Location = new System.Drawing.Point(12, 27);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(886, 577);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 13;
            this.imageBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubjectToolStripMenuItem,
            this.splitVideoToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveSessionToolStripMenuItem,
            this.loadSessionToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportToolStripMenuItem,
            this.exportVideoFramesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSubjectToolStripMenuItem
            // 
            this.openSubjectToolStripMenuItem.Name = "openSubjectToolStripMenuItem";
            this.openSubjectToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openSubjectToolStripMenuItem.Text = "Open subject folder";
            this.openSubjectToolStripMenuItem.Click += new System.EventHandler(this.openSubjectToolStripMenuItem_Click);
            // 
            // splitVideoToolStripMenuItem
            // 
            this.splitVideoToolStripMenuItem.Name = "splitVideoToolStripMenuItem";
            this.splitVideoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.splitVideoToolStripMenuItem.Text = "Open subject video";
            this.splitVideoToolStripMenuItem.Click += new System.EventHandler(this.splitVideoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // saveSessionToolStripMenuItem
            // 
            this.saveSessionToolStripMenuItem.Name = "saveSessionToolStripMenuItem";
            this.saveSessionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveSessionToolStripMenuItem.Text = "Save session";
            this.saveSessionToolStripMenuItem.Click += new System.EventHandler(this.saveSessionToolStripMenuItem_Click);
            // 
            // loadSessionToolStripMenuItem
            // 
            this.loadSessionToolStripMenuItem.Name = "loadSessionToolStripMenuItem";
            this.loadSessionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadSessionToolStripMenuItem.Text = "Load session";
            this.loadSessionToolStripMenuItem.Click += new System.EventHandler(this.loadSessionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportToolStripMenuItem.Text = "Export .csv";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportVideoFramesToolStripMenuItem
            // 
            this.exportVideoFramesToolStripMenuItem.Name = "exportVideoFramesToolStripMenuItem";
            this.exportVideoFramesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportVideoFramesToolStripMenuItem.Text = "Export images";
            this.exportVideoFramesToolStripMenuItem.Click += new System.EventHandler(this.exportVideoFramesToolStripMenuItem_Click);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentTextBox.Location = new System.Drawing.Point(6, 185);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(165, 103);
            this.CommentTextBox.TabIndex = 16;
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(3, 169);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(51, 13);
            this.CommentLabel.TabIndex = 17;
            this.CommentLabel.Text = "Comment";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CommentTextBox);
            this.groupBox1.Controls.Add(this.CommentLabel);
            this.groupBox1.Controls.Add(this.Fixations);
            this.groupBox1.Controls.Add(this.PersonPresent);
            this.groupBox1.Location = new System.Drawing.Point(904, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 299);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(904, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 299);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Entry";
            // 
            // PicAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1093, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PicAnalyzer";
            this.Text = "PicAnalyzer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Fixations.ResumeLayout(false);
            this.Fixations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
        
            private System.Windows.Forms.Button NextButton;
            private System.Windows.Forms.CheckBox PersonPresent;
            private System.Windows.Forms.GroupBox Fixations;
            private System.Windows.Forms.RadioButton SurroundingFixation;
            private System.Windows.Forms.RadioButton BodyFixation;
            private System.Windows.Forms.RadioButton HeadFixation;
            private System.Windows.Forms.RadioButton InvalidFixation;
            private System.Windows.Forms.Button PreviousButton;
            private System.Windows.Forms.PictureBox imageBox;
            private System.Windows.Forms.MenuStrip menuStrip;
            private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem openSubjectToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveSessionToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem loadSessionToolStripMenuItem;
            private System.Windows.Forms.TextBox CommentTextBox;
            private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportVideoFramesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
    }
    }


namespace DoFactory.GangOfFour
{
    partial class FormMain
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
            this.m_treeView = new System.Windows.Forms.TreeView();
            this.m_rtbDefinition = new System.Windows.Forms.RichTextBox();
            this.m_pbDiagram = new System.Windows.Forms.PictureBox();
            this.m_pbFrequencyLevel = new System.Windows.Forms.PictureBox();
            this.m_lFrequencyLevel = new System.Windows.Forms.Label();
            this.m_lFrequencyDescription = new System.Windows.Forms.Label();
            this.m_lPatternName = new System.Windows.Forms.Label();
            this.m_rtbCode = new System.Windows.Forms.RichTextBox();
            this.m_rtbParticipants = new System.Windows.Forms.RichTextBox();
            this.m_rbStructural = new System.Windows.Forms.RadioButton();
            this.m_rbRealworld = new System.Windows.Forms.RadioButton();
            this.m_rbOptimized = new System.Windows.Forms.RadioButton();
            this.m_panel = new System.Windows.Forms.Panel();
            this.m_bRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbFrequencyLevel)).BeginInit();
            this.m_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_treeView
            // 
            this.m_treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_treeView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_treeView.Location = new System.Drawing.Point(12, 80);
            this.m_treeView.Name = "m_treeView";
            this.m_treeView.Size = new System.Drawing.Size(284, 623);
            this.m_treeView.TabIndex = 0;
            this.m_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_treeView_AfterSelect);
            this.m_treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.m_treeView_NodeMouseDoubleClick);
            // 
            // m_rtbDefinition
            // 
            this.m_rtbDefinition.BackColor = System.Drawing.Color.White;
            this.m_rtbDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_rtbDefinition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rtbDefinition.Location = new System.Drawing.Point(302, 80);
            this.m_rtbDefinition.Name = "m_rtbDefinition";
            this.m_rtbDefinition.ReadOnly = true;
            this.m_rtbDefinition.Size = new System.Drawing.Size(540, 139);
            this.m_rtbDefinition.TabIndex = 1;
            this.m_rtbDefinition.Text = "";
            // 
            // m_pbDiagram
            // 
            this.m_pbDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_pbDiagram.BackColor = System.Drawing.Color.White;
            this.m_pbDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_pbDiagram.Location = new System.Drawing.Point(302, 225);
            this.m_pbDiagram.Name = "m_pbDiagram";
            this.m_pbDiagram.Size = new System.Drawing.Size(540, 726);
            this.m_pbDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.m_pbDiagram.TabIndex = 2;
            this.m_pbDiagram.TabStop = false;
            // 
            // m_pbFrequencyLevel
            // 
            this.m_pbFrequencyLevel.Location = new System.Drawing.Point(101, 33);
            this.m_pbFrequencyLevel.Name = "m_pbFrequencyLevel";
            this.m_pbFrequencyLevel.Size = new System.Drawing.Size(101, 20);
            this.m_pbFrequencyLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.m_pbFrequencyLevel.TabIndex = 3;
            this.m_pbFrequencyLevel.TabStop = false;
            // 
            // m_lFrequencyLevel
            // 
            this.m_lFrequencyLevel.AutoSize = true;
            this.m_lFrequencyLevel.Location = new System.Drawing.Point(3, 40);
            this.m_lFrequencyLevel.Name = "m_lFrequencyLevel";
            this.m_lFrequencyLevel.Size = new System.Drawing.Size(92, 13);
            this.m_lFrequencyLevel.TabIndex = 4;
            this.m_lFrequencyLevel.Text = "Frequency of use:";
            // 
            // m_lFrequencyDescription
            // 
            this.m_lFrequencyDescription.AutoSize = true;
            this.m_lFrequencyDescription.Location = new System.Drawing.Point(208, 40);
            this.m_lFrequencyDescription.Name = "m_lFrequencyDescription";
            this.m_lFrequencyDescription.Size = new System.Drawing.Size(64, 13);
            this.m_lFrequencyDescription.TabIndex = 5;
            this.m_lFrequencyDescription.Text = "Low to High";
            // 
            // m_lPatternName
            // 
            this.m_lPatternName.AutoSize = true;
            this.m_lPatternName.Font = new System.Drawing.Font("Arial Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lPatternName.Location = new System.Drawing.Point(12, 9);
            this.m_lPatternName.Name = "m_lPatternName";
            this.m_lPatternName.Size = new System.Drawing.Size(375, 68);
            this.m_lPatternName.TabIndex = 6;
            this.m_lPatternName.Text = "PatternName";
            // 
            // m_rtbCode
            // 
            this.m_rtbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_rtbCode.BackColor = System.Drawing.Color.White;
            this.m_rtbCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_rtbCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rtbCode.Location = new System.Drawing.Point(848, 80);
            this.m_rtbCode.Name = "m_rtbCode";
            this.m_rtbCode.ReadOnly = true;
            this.m_rtbCode.Size = new System.Drawing.Size(540, 139);
            this.m_rtbCode.TabIndex = 7;
            this.m_rtbCode.Text = "";
            // 
            // m_rtbParticipants
            // 
            this.m_rtbParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_rtbParticipants.BackColor = System.Drawing.Color.White;
            this.m_rtbParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_rtbParticipants.Location = new System.Drawing.Point(848, 225);
            this.m_rtbParticipants.Name = "m_rtbParticipants";
            this.m_rtbParticipants.ReadOnly = true;
            this.m_rtbParticipants.Size = new System.Drawing.Size(540, 726);
            this.m_rtbParticipants.TabIndex = 8;
            this.m_rtbParticipants.Text = "";
            // 
            // m_rbStructural
            // 
            this.m_rbStructural.AutoSize = true;
            this.m_rbStructural.Checked = true;
            this.m_rbStructural.Location = new System.Drawing.Point(6, 92);
            this.m_rbStructural.Name = "m_rbStructural";
            this.m_rbStructural.Size = new System.Drawing.Size(97, 17);
            this.m_rbStructural.TabIndex = 9;
            this.m_rbStructural.TabStop = true;
            this.m_rbStructural.Text = "Structural code";
            this.m_rbStructural.UseVisualStyleBackColor = true;
            this.m_rbStructural.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // m_rbRealworld
            // 
            this.m_rbRealworld.AutoSize = true;
            this.m_rbRealworld.Location = new System.Drawing.Point(6, 136);
            this.m_rbRealworld.Name = "m_rbRealworld";
            this.m_rbRealworld.Size = new System.Drawing.Size(102, 17);
            this.m_rbRealworld.TabIndex = 10;
            this.m_rbRealworld.Text = "Real-world code";
            this.m_rbRealworld.UseVisualStyleBackColor = true;
            this.m_rbRealworld.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // m_rbOptimized
            // 
            this.m_rbOptimized.AutoSize = true;
            this.m_rbOptimized.Location = new System.Drawing.Point(6, 180);
            this.m_rbOptimized.Name = "m_rbOptimized";
            this.m_rbOptimized.Size = new System.Drawing.Size(98, 17);
            this.m_rbOptimized.TabIndex = 11;
            this.m_rbOptimized.Text = "Optimized code";
            this.m_rbOptimized.UseVisualStyleBackColor = true;
            this.m_rbOptimized.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // m_panel
            // 
            this.m_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_panel.Controls.Add(this.m_bRun);
            this.m_panel.Controls.Add(this.m_pbFrequencyLevel);
            this.m_panel.Controls.Add(this.m_rbOptimized);
            this.m_panel.Controls.Add(this.m_lFrequencyLevel);
            this.m_panel.Controls.Add(this.m_rbRealworld);
            this.m_panel.Controls.Add(this.m_lFrequencyDescription);
            this.m_panel.Controls.Add(this.m_rbStructural);
            this.m_panel.Location = new System.Drawing.Point(12, 709);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(284, 242);
            this.m_panel.TabIndex = 12;
            // 
            // m_bRun
            // 
            this.m_bRun.Enabled = false;
            this.m_bRun.Location = new System.Drawing.Point(197, 180);
            this.m_bRun.Name = "m_bRun";
            this.m_bRun.Size = new System.Drawing.Size(75, 23);
            this.m_bRun.TabIndex = 12;
            this.m_bRun.Text = "Run";
            this.m_bRun.UseVisualStyleBackColor = true;
            this.m_bRun.Click += new System.EventHandler(this.m_bRun_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.m_bRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 963);
            this.Controls.Add(this.m_panel);
            this.Controls.Add(this.m_rtbParticipants);
            this.Controls.Add(this.m_rtbCode);
            this.Controls.Add(this.m_lPatternName);
            this.Controls.Add(this.m_pbDiagram);
            this.Controls.Add(this.m_rtbDefinition);
            this.Controls.Add(this.m_treeView);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoFactory";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbFrequencyLevel)).EndInit();
            this.m_panel.ResumeLayout(false);
            this.m_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeView;
        private System.Windows.Forms.RichTextBox m_rtbDefinition;
        private System.Windows.Forms.PictureBox m_pbDiagram;
        private System.Windows.Forms.PictureBox m_pbFrequencyLevel;
        private System.Windows.Forms.Label m_lFrequencyLevel;
        private System.Windows.Forms.Label m_lFrequencyDescription;
        private System.Windows.Forms.Label m_lPatternName;
        private System.Windows.Forms.RichTextBox m_rtbCode;
        private System.Windows.Forms.RichTextBox m_rtbParticipants;
        private System.Windows.Forms.RadioButton m_rbStructural;
        private System.Windows.Forms.RadioButton m_rbRealworld;
        private System.Windows.Forms.RadioButton m_rbOptimized;
        private System.Windows.Forms.Panel m_panel;
        private System.Windows.Forms.Button m_bRun;
    }
}


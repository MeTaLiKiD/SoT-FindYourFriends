namespace SoTFindYourFriends
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FindServerButton = new System.Windows.Forms.Button();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.DiscordLabel = new System.Windows.Forms.LinkLabel();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.SourceCodeLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.LinkLabel();
            this.GithubPicture = new System.Windows.Forms.PictureBox();
            this.LoadingPicture = new System.Windows.Forms.PictureBox();
            this.DiscordPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FindServerButton
            // 
            this.FindServerButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindServerButton.Location = new System.Drawing.Point(12, 13);
            this.FindServerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindServerButton.Name = "FindServerButton";
            this.FindServerButton.Size = new System.Drawing.Size(244, 46);
            this.FindServerButton.TabIndex = 0;
            this.FindServerButton.Text = "Trouver mon serveur";
            this.FindServerButton.UseVisualStyleBackColor = true;
            this.FindServerButton.Click += new System.EventHandler(this.FindServer);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(12, 64);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(244, 29);
            this.ServerTextBox.TabIndex = 2;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(262, 64);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(80, 29);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copier";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ReportLabel
            // 
            this.ReportLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ReportLabel.Location = new System.Drawing.Point(12, 96);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(244, 29);
            this.ReportLabel.TabIndex = 4;
            this.ReportLabel.Text = "Serveur non trouvé.";
            this.ReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportLabel.Visible = false;
            // 
            // DiscordLabel
            // 
            this.DiscordLabel.AutoSize = true;
            this.DiscordLabel.Location = new System.Drawing.Point(60, 184);
            this.DiscordLabel.Name = "DiscordLabel";
            this.DiscordLabel.Size = new System.Drawing.Size(201, 21);
            this.DiscordLabel.TabIndex = 5;
            this.DiscordLabel.TabStop = true;
            this.DiscordLabel.Text = "https://discord.gg/7pHP3xu";
            this.DiscordLabel.Click += new System.EventHandler(this.DiscordLabel_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(60, 163);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(151, 21);
            this.HelpLabel.TabIndex = 7;
            this.HelpLabel.Text = "Aide et informations";
            // 
            // SourceCodeLabel
            // 
            this.SourceCodeLabel.AutoSize = true;
            this.SourceCodeLabel.Location = new System.Drawing.Point(60, 211);
            this.SourceCodeLabel.Name = "SourceCodeLabel";
            this.SourceCodeLabel.Size = new System.Drawing.Size(96, 21);
            this.SourceCodeLabel.TabIndex = 10;
            this.SourceCodeLabel.Text = "Code source";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(60, 232);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(286, 21);
            this.GithubLabel.TabIndex = 8;
            this.GithubLabel.TabStop = true;
            this.GithubLabel.Text = "https://github.com/SoT-FindYourFriends";
            this.GithubLabel.Click += new System.EventHandler(this.GithubLabel_Click);
            // 
            // GithubPicture
            // 
            this.GithubPicture.Image = global::SoTFindYourFriends.Properties.Resources.Github;
            this.GithubPicture.Location = new System.Drawing.Point(12, 211);
            this.GithubPicture.Name = "GithubPicture";
            this.GithubPicture.Size = new System.Drawing.Size(42, 42);
            this.GithubPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GithubPicture.TabIndex = 9;
            this.GithubPicture.TabStop = false;
            // 
            // LoadingPicture
            // 
            this.LoadingPicture.Image = global::SoTFindYourFriends.Properties.Resources.Loader;
            this.LoadingPicture.Location = new System.Drawing.Point(262, 12);
            this.LoadingPicture.Name = "LoadingPicture";
            this.LoadingPicture.Size = new System.Drawing.Size(80, 80);
            this.LoadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPicture.TabIndex = 1;
            this.LoadingPicture.TabStop = false;
            this.LoadingPicture.Visible = false;
            // 
            // DiscordPicture
            // 
            this.DiscordPicture.Image = global::SoTFindYourFriends.Properties.Resources.Discord;
            this.DiscordPicture.Location = new System.Drawing.Point(12, 163);
            this.DiscordPicture.Name = "DiscordPicture";
            this.DiscordPicture.Size = new System.Drawing.Size(42, 42);
            this.DiscordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscordPicture.TabIndex = 6;
            this.DiscordPicture.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.FindServerButton);
            this.Controls.Add(this.LoadingPicture);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.DiscordPicture);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.DiscordLabel);
            this.Controls.Add(this.GithubPicture);
            this.Controls.Add(this.SourceCodeLabel);
            this.Controls.Add(this.GithubLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 300);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoT - Find Your Friends";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.GithubPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindServerButton;
        private System.Windows.Forms.PictureBox LoadingPicture;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.LinkLabel DiscordLabel;
        private System.Windows.Forms.PictureBox DiscordPicture;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label SourceCodeLabel;
        private System.Windows.Forms.PictureBox GithubPicture;
        private System.Windows.Forms.LinkLabel GithubLabel;
    }
}


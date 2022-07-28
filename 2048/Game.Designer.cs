namespace _2048
{
    partial class Game
    {
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gameTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.goToMenu = new System.Windows.Forms.Label();
            this.scoreTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoreNumber = new System.Windows.Forms.Label();
            this.gameOverTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gameOverRestartLbl = new System.Windows.Forms.Label();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.enterPlayerPanel = new System.Windows.Forms.Panel();
            this.acceptButtonLbl = new System.Windows.Forms.Label();
            this.enterPlayerLbl = new System.Windows.Forms.Label();
            this.enterPlayerNameTextbox = new System.Windows.Forms.TextBox();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gameNameLbl = new System.Windows.Forms.Label();
            this.scoreTableLayout.SuspendLayout();
            this.gameOverTableLayout.SuspendLayout();
            this.enterPlayerPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // gameTableLayout
            // 
            this.gameTableLayout.Location = new System.Drawing.Point(0, 0);
            this.gameTableLayout.Name = "gameTableLayout";
            this.gameTableLayout.Size = new System.Drawing.Size(200, 100);
            this.gameTableLayout.TabIndex = 0;
            // 
            // goToMenu
            // 
            this.goToMenu.AutoSize = true;
            this.goToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToMenu.Location = new System.Drawing.Point(12, 9);
            this.goToMenu.Name = "goToMenu";
            this.goToMenu.Size = new System.Drawing.Size(75, 58);
            this.goToMenu.TabIndex = 2;
            this.goToMenu.Text = "←";
            this.goToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goToMenu.Click += new System.EventHandler(this.GoToMenu_Click);
            // 
            // scoreTableLayout
            // 
            this.scoreTableLayout.AutoSize = true;
            this.scoreTableLayout.ColumnCount = 1;
            this.scoreTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scoreTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scoreTableLayout.Controls.Add(this.scoreLbl, 0, 0);
            this.scoreTableLayout.Controls.Add(this.scoreNumber, 0, 1);
            this.scoreTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreTableLayout.Location = new System.Drawing.Point(5, 5);
            this.scoreTableLayout.Name = "scoreTableLayout";
            this.scoreTableLayout.RowCount = 2;
            this.scoreTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scoreTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scoreTableLayout.Size = new System.Drawing.Size(126, 87);
            this.scoreTableLayout.TabIndex = 4;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(3, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(120, 43);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Wynik";
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreNumber
            // 
            this.scoreNumber.AutoSize = true;
            this.scoreNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNumber.Location = new System.Drawing.Point(3, 43);
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(120, 44);
            this.scoreNumber.TabIndex = 1;
            this.scoreNumber.Text = "Score";
            this.scoreNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverTableLayout
            // 
            this.gameOverTableLayout.AutoSize = true;
            this.gameOverTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gameOverTableLayout.ColumnCount = 1;
            this.gameOverTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOverTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOverTableLayout.Controls.Add(this.gameOverRestartLbl, 0, 1);
            this.gameOverTableLayout.Controls.Add(this.gameOverLbl, 0, 0);
            this.gameOverTableLayout.Location = new System.Drawing.Point(160, 260);
            this.gameOverTableLayout.Name = "gameOverTableLayout";
            this.gameOverTableLayout.RowCount = 2;
            this.gameOverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameOverTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gameOverTableLayout.Size = new System.Drawing.Size(126, 85);
            this.gameOverTableLayout.TabIndex = 5;
            // 
            // gameOverRestartLbl
            // 
            this.gameOverRestartLbl.AutoSize = true;
            this.gameOverRestartLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverRestartLbl.Location = new System.Drawing.Point(4, 43);
            this.gameOverRestartLbl.Name = "gameOverRestartLbl";
            this.gameOverRestartLbl.Size = new System.Drawing.Size(118, 41);
            this.gameOverRestartLbl.TabIndex = 7;
            this.gameOverRestartLbl.Text = "Restart";
            this.gameOverRestartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverRestartLbl.Click += new System.EventHandler(this.GameOverRestartLbl_Click);
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOverLbl.Location = new System.Drawing.Point(4, 1);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(118, 41);
            this.gameOverLbl.TabIndex = 6;
            this.gameOverLbl.Text = "Koniec Gry";
            this.gameOverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverLbl.Click += new System.EventHandler(this.GoToMenu_Click);
            // 
            // enterPlayerPanel
            // 
            this.enterPlayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enterPlayerPanel.Controls.Add(this.acceptButtonLbl);
            this.enterPlayerPanel.Controls.Add(this.enterPlayerLbl);
            this.enterPlayerPanel.Controls.Add(this.enterPlayerNameTextbox);
            this.enterPlayerPanel.Location = new System.Drawing.Point(55, 347);
            this.enterPlayerPanel.Name = "enterPlayerPanel";
            this.enterPlayerPanel.Size = new System.Drawing.Size(288, 192);
            this.enterPlayerPanel.TabIndex = 6;
            // 
            // acceptButtonLbl
            // 
            this.acceptButtonLbl.AutoSize = true;
            this.acceptButtonLbl.Location = new System.Drawing.Point(75, 128);
            this.acceptButtonLbl.Name = "acceptButtonLbl";
            this.acceptButtonLbl.Size = new System.Drawing.Size(78, 17);
            this.acceptButtonLbl.TabIndex = 2;
            this.acceptButtonLbl.Text = "Zaakceptuj";
            this.acceptButtonLbl.Click += new System.EventHandler(this.acceptButtonLbl_Click);
            // 
            // enterPlayerLbl
            // 
            this.enterPlayerLbl.AutoSize = true;
            this.enterPlayerLbl.Location = new System.Drawing.Point(49, 41);
            this.enterPlayerLbl.Name = "enterPlayerLbl";
            this.enterPlayerLbl.Size = new System.Drawing.Size(101, 17);
            this.enterPlayerLbl.TabIndex = 1;
            this.enterPlayerLbl.Text = "Nazwa gracza:";
            // 
            // enterPlayerNameTextbox
            // 
            this.enterPlayerNameTextbox.Location = new System.Drawing.Point(52, 76);
            this.enterPlayerNameTextbox.MaxLength = 12;
            this.enterPlayerNameTextbox.Name = "enterPlayerNameTextbox";
            this.enterPlayerNameTextbox.Size = new System.Drawing.Size(178, 22);
            this.enterPlayerNameTextbox.TabIndex = 0;
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scorePanel.Controls.Add(this.flowLayoutPanel1);
            this.scorePanel.Controls.Add(this.scoreTableLayout);
            this.scorePanel.Location = new System.Drawing.Point(22, 70);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Padding = new System.Windows.Forms.Padding(5);
            this.scorePanel.Size = new System.Drawing.Size(136, 97);
            this.scorePanel.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // gameNameLbl
            // 
            this.gameNameLbl.AutoSize = true;
            this.gameNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLbl.Location = new System.Drawing.Point(162, 15);
            this.gameNameLbl.Name = "gameNameLbl";
            this.gameNameLbl.Size = new System.Drawing.Size(118, 51);
            this.gameNameLbl.TabIndex = 8;
            this.gameNameLbl.Text = "2048";
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(438, 520);
            this.Controls.Add(this.gameNameLbl);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.enterPlayerPanel);
            this.Controls.Add(this.gameOverTableLayout);
            this.Controls.Add(this.goToMenu);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.scoreTableLayout.ResumeLayout(false);
            this.scoreTableLayout.PerformLayout();
            this.gameOverTableLayout.ResumeLayout(false);
            this.gameOverTableLayout.PerformLayout();
            this.enterPlayerPanel.ResumeLayout(false);
            this.enterPlayerPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel gameTableLayout;
        private System.Windows.Forms.Label goToMenu;
        private System.Windows.Forms.TableLayoutPanel scoreTableLayout;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoreNumber;
        private System.Windows.Forms.TableLayoutPanel gameOverTableLayout;
        private System.Windows.Forms.Label gameOverRestartLbl;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Panel enterPlayerPanel;
        private System.Windows.Forms.Label acceptButtonLbl;
        private System.Windows.Forms.Label enterPlayerLbl;
        private System.Windows.Forms.TextBox enterPlayerNameTextbox;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label gameNameLbl;
    }
}

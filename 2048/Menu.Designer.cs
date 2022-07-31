using System.Drawing;
namespace _2048
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.menuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonScores = new System.Windows.Forms.Button();
            this.leaderBoardPanel = new System.Windows.Forms.Panel();
            this.leaderBoardScoreListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backToMenuLbl = new System.Windows.Forms.Label();
            this.leaderBoardNameListBox = new System.Windows.Forms.ListBox();
            this.leaderBoardLbl = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.saveInformationLbl = new System.Windows.Forms.Label();
            this.cellsyNumeric = new System.Windows.Forms.NumericUpDown();
            this.cellsyLbl = new System.Windows.Forms.Label();
            this.cellsxNumeric = new System.Windows.Forms.NumericUpDown();
            this.cellsxLbl = new System.Windows.Forms.Label();
            this.themeLbl = new System.Windows.Forms.Label();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.backFromOptionsMenuLbl = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.menuTablePanel.SuspendLayout();
            this.leaderBoardPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellsyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsxNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameTitle.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(7, 0);
            this.lblGameTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(315, 73);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "2048";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.buttonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(3, 234);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOptions.Size = new System.Drawing.Size(323, 43);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Opcje";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // menuTablePanel
            // 
            this.menuTablePanel.ColumnCount = 1;
            this.menuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTablePanel.Controls.Add(this.buttonQuit, 0, 4);
            this.menuTablePanel.Controls.Add(this.buttonOptions, 0, 3);
            this.menuTablePanel.Controls.Add(this.buttonPlay, 0, 1);
            this.menuTablePanel.Controls.Add(this.buttonScores, 0, 2);
            this.menuTablePanel.Controls.Add(this.lblGameTitle, 0, 0);
            this.menuTablePanel.Location = new System.Drawing.Point(131, 49);
            this.menuTablePanel.Name = "menuTablePanel";
            this.menuTablePanel.RowCount = 5;
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuTablePanel.Size = new System.Drawing.Size(329, 366);
            this.menuTablePanel.TabIndex = 5;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(3, 307);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonQuit.Size = new System.Drawing.Size(323, 44);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Wyjście";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(3, 88);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPlay.Size = new System.Drawing.Size(323, 43);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Gra";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // buttonScores
            // 
            this.buttonScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.buttonScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonScores.FlatAppearance.BorderSize = 0;
            this.buttonScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScores.Location = new System.Drawing.Point(3, 161);
            this.buttonScores.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.buttonScores.Name = "buttonScores";
            this.buttonScores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonScores.Size = new System.Drawing.Size(323, 43);
            this.buttonScores.TabIndex = 6;
            this.buttonScores.Text = "Tabela Wyników";
            this.buttonScores.UseVisualStyleBackColor = false;
            this.buttonScores.Click += new System.EventHandler(this.ButtonScores_Click);
            // 
            // leaderBoardPanel
            // 
            this.leaderBoardPanel.Controls.Add(this.leaderBoardScoreListBox);
            this.leaderBoardPanel.Controls.Add(this.deleteButton);
            this.leaderBoardPanel.Controls.Add(this.backToMenuLbl);
            this.leaderBoardPanel.Controls.Add(this.leaderBoardNameListBox);
            this.leaderBoardPanel.Controls.Add(this.leaderBoardLbl);
            this.leaderBoardPanel.Location = new System.Drawing.Point(12, 12);
            this.leaderBoardPanel.Name = "leaderBoardPanel";
            this.leaderBoardPanel.Size = new System.Drawing.Size(568, 471);
            this.leaderBoardPanel.TabIndex = 6;
            this.leaderBoardPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaderBoardPanel_MouseDown);
            // 
            // leaderBoardScoreListBox
            // 
            this.leaderBoardScoreListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaderBoardScoreListBox.FormattingEnabled = true;
            this.leaderBoardScoreListBox.ItemHeight = 29;
            this.leaderBoardScoreListBox.Location = new System.Drawing.Point(280, 82);
            this.leaderBoardScoreListBox.Name = "leaderBoardScoreListBox";
            this.leaderBoardScoreListBox.Size = new System.Drawing.Size(236, 319);
            this.leaderBoardScoreListBox.TabIndex = 4;
            this.leaderBoardScoreListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaderBoardScoreListBox_MouseDown);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(225, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 41);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backToMenuLbl
            // 
            this.backToMenuLbl.AutoSize = true;
            this.backToMenuLbl.Font = new System.Drawing.Font("Century", 30F);
            this.backToMenuLbl.Location = new System.Drawing.Point(0, -12);
            this.backToMenuLbl.Name = "backToMenuLbl";
            this.backToMenuLbl.Size = new System.Drawing.Size(75, 60);
            this.backToMenuLbl.TabIndex = 2;
            this.backToMenuLbl.Text = "←";
            this.backToMenuLbl.Click += new System.EventHandler(this.BackToMenuLbl_Click);
            // 
            // leaderBoardNameListBox
            // 
            this.leaderBoardNameListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaderBoardNameListBox.FormattingEnabled = true;
            this.leaderBoardNameListBox.ItemHeight = 29;
            this.leaderBoardNameListBox.Location = new System.Drawing.Point(22, 82);
            this.leaderBoardNameListBox.Name = "leaderBoardNameListBox";
            this.leaderBoardNameListBox.Size = new System.Drawing.Size(259, 319);
            this.leaderBoardNameListBox.TabIndex = 1;
            this.leaderBoardNameListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaderBoardNameListBox_MouseDown);
            // 
            // leaderBoardLbl
            // 
            this.leaderBoardLbl.AutoSize = true;
            this.leaderBoardLbl.Location = new System.Drawing.Point(188, 37);
            this.leaderBoardLbl.Name = "leaderBoardLbl";
            this.leaderBoardLbl.Size = new System.Drawing.Size(207, 29);
            this.leaderBoardLbl.TabIndex = 0;
            this.leaderBoardLbl.Text = "Tabela Wyników";
            this.leaderBoardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.saveInformationLbl);
            this.optionsPanel.Controls.Add(this.cellsyNumeric);
            this.optionsPanel.Controls.Add(this.cellsyLbl);
            this.optionsPanel.Controls.Add(this.cellsxNumeric);
            this.optionsPanel.Controls.Add(this.cellsxLbl);
            this.optionsPanel.Controls.Add(this.themeLbl);
            this.optionsPanel.Controls.Add(this.themeComboBox);
            this.optionsPanel.Controls.Add(this.backFromOptionsMenuLbl);
            this.optionsPanel.Controls.Add(this.optionsLabel);
            this.optionsPanel.Location = new System.Drawing.Point(2, 12);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(591, 471);
            this.optionsPanel.TabIndex = 7;
            // 
            // saveInformationLbl
            // 
            this.saveInformationLbl.AutoSize = true;
            this.saveInformationLbl.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInformationLbl.Location = new System.Drawing.Point(8, 442);
            this.saveInformationLbl.Name = "saveInformationLbl";
            this.saveInformationLbl.Size = new System.Drawing.Size(358, 17);
            this.saveInformationLbl.TabIndex = 8;
            this.saveInformationLbl.Text = "(Uwaga, wynik gry zapisuje sie tylko dla planszy 4x4)";
            // 
            // cellsyNumeric
            // 
            this.cellsyNumeric.Location = new System.Drawing.Point(20, 210);
            this.cellsyNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cellsyNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cellsyNumeric.Name = "cellsyNumeric";
            this.cellsyNumeric.Size = new System.Drawing.Size(60, 38);
            this.cellsyNumeric.TabIndex = 7;
            this.cellsyNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cellsyLbl
            // 
            this.cellsyLbl.AutoSize = true;
            this.cellsyLbl.Location = new System.Drawing.Point(15, 179);
            this.cellsyLbl.Name = "cellsyLbl";
            this.cellsyLbl.Size = new System.Drawing.Size(227, 29);
            this.cellsyLbl.TabIndex = 6;
            this.cellsyLbl.Text = "Wysokość planszy:";
            // 
            // cellsxNumeric
            // 
            this.cellsxNumeric.Location = new System.Drawing.Point(20, 138);
            this.cellsxNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cellsxNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cellsxNumeric.Name = "cellsxNumeric";
            this.cellsxNumeric.Size = new System.Drawing.Size(60, 38);
            this.cellsxNumeric.TabIndex = 5;
            this.cellsxNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cellsxLbl
            // 
            this.cellsxLbl.AutoSize = true;
            this.cellsxLbl.Location = new System.Drawing.Point(15, 106);
            this.cellsxLbl.Name = "cellsxLbl";
            this.cellsxLbl.Size = new System.Drawing.Size(229, 29);
            this.cellsxLbl.TabIndex = 4;
            this.cellsxLbl.Text = "Szerokość planszy:";
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = true;
            this.themeLbl.Location = new System.Drawing.Point(380, 106);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(67, 29);
            this.themeLbl.TabIndex = 3;
            this.themeLbl.Text = "Styl:";
            // 
            // themeComboBox
            // 
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Items.AddRange(new object[] {
            "Klasyczny",
            "Ciemny"});
            this.themeComboBox.Location = new System.Drawing.Point(385, 137);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(164, 37);
            this.themeComboBox.TabIndex = 2;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // backFromOptionsMenuLbl
            // 
            this.backFromOptionsMenuLbl.AutoSize = true;
            this.backFromOptionsMenuLbl.Font = new System.Drawing.Font("Century", 30F);
            this.backFromOptionsMenuLbl.Location = new System.Drawing.Point(3, -9);
            this.backFromOptionsMenuLbl.Name = "backFromOptionsMenuLbl";
            this.backFromOptionsMenuLbl.Size = new System.Drawing.Size(75, 60);
            this.backFromOptionsMenuLbl.TabIndex = 1;
            this.backFromOptionsMenuLbl.Text = "←";
            this.backFromOptionsMenuLbl.Click += new System.EventHandler(this.BackFromOptionsMenuLbl_Click);
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(257, 31);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(77, 29);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Opcje";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(592, 495);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.leaderBoardPanel);
            this.Controls.Add(this.menuTablePanel);
            this.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Shown += new System.EventHandler(this.Menu_Load);
            this.menuTablePanel.ResumeLayout(false);
            this.menuTablePanel.PerformLayout();
            this.leaderBoardPanel.ResumeLayout(false);
            this.leaderBoardPanel.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellsyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsxNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.TableLayoutPanel menuTablePanel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonScores;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Panel leaderBoardPanel;
        private System.Windows.Forms.ListBox leaderBoardNameListBox;
        private System.Windows.Forms.Label leaderBoardLbl;
        private System.Windows.Forms.Label backToMenuLbl;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox leaderBoardScoreListBox;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label backFromOptionsMenuLbl;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.Label themeLbl;
        private System.Windows.Forms.NumericUpDown cellsxNumeric;
        private System.Windows.Forms.Label cellsxLbl;
        private System.Windows.Forms.NumericUpDown cellsyNumeric;
        private System.Windows.Forms.Label cellsyLbl;
        private System.Windows.Forms.Label saveInformationLbl;
    }
}


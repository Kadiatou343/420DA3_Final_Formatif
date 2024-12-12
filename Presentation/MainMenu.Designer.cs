namespace _420DA3_Final_Formatif.Presentation
{
    partial class MainMenu
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
            topBarPanel = new Panel();
            bottomBarPanel = new Panel();
            mainTableLayout = new TableLayoutPanel();
            centerPanel = new Panel();
            countryListtBox = new ListBox();
            searchTextBox = new TextBox();
            updateButton = new Button();
            button1 = new Button();
            seeDetailsButton = new Button();
            createButton = new Button();
            cancelButton = new Button();
            bottomBarPanel.SuspendLayout();
            mainTableLayout.SuspendLayout();
            centerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBarPanel
            // 
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(460, 50);
            topBarPanel.TabIndex = 0;
            // 
            // bottomBarPanel
            // 
            bottomBarPanel.Controls.Add(cancelButton);
            bottomBarPanel.Dock = DockStyle.Bottom;
            bottomBarPanel.Location = new Point(0, 381);
            bottomBarPanel.Name = "bottomBarPanel";
            bottomBarPanel.Size = new Size(460, 50);
            bottomBarPanel.TabIndex = 1;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.Controls.Add(centerPanel, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 50);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(460, 331);
            mainTableLayout.TabIndex = 2;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(countryListtBox);
            centerPanel.Controls.Add(searchTextBox);
            centerPanel.Controls.Add(updateButton);
            centerPanel.Controls.Add(button1);
            centerPanel.Controls.Add(seeDetailsButton);
            centerPanel.Controls.Add(createButton);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(68, 3);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(324, 325);
            centerPanel.TabIndex = 0;
            // 
            // countryListtBox
            // 
            countryListtBox.Dock = DockStyle.Fill;
            countryListtBox.FormattingEnabled = true;
            countryListtBox.ItemHeight = 25;
            countryListtBox.Location = new Point(0, 65);
            countryListtBox.Name = "countryListtBox";
            countryListtBox.Size = new Size(324, 158);
            countryListtBox.TabIndex = 5;
            countryListtBox.SelectedIndexChanged += countryListtBox_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Top;
            searchTextBox.Location = new Point(0, 34);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Recharcher un pays";
            searchTextBox.Size = new Size(324, 31);
            searchTextBox.TabIndex = 4;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // updateButton
            // 
            updateButton.Dock = DockStyle.Bottom;
            updateButton.Location = new Point(0, 223);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(324, 34);
            updateButton.TabIndex = 3;
            updateButton.Text = "Modifier";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 257);
            button1.Name = "button1";
            button1.Size = new Size(324, 34);
            button1.TabIndex = 2;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // seeDetailsButton
            // 
            seeDetailsButton.Dock = DockStyle.Bottom;
            seeDetailsButton.Location = new Point(0, 291);
            seeDetailsButton.Name = "seeDetailsButton";
            seeDetailsButton.Size = new Size(324, 34);
            seeDetailsButton.TabIndex = 1;
            seeDetailsButton.Text = "Voir Details";
            seeDetailsButton.UseVisualStyleBackColor = true;
            seeDetailsButton.Click += seeDetailsButton_Click;
            // 
            // createButton
            // 
            createButton.Dock = DockStyle.Top;
            createButton.Location = new Point(0, 0);
            createButton.Name = "createButton";
            createButton.Size = new Size(324, 34);
            createButton.TabIndex = 0;
            createButton.Text = "Créer un pays";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(336, 6);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 431);
            Controls.Add(mainTableLayout);
            Controls.Add(bottomBarPanel);
            Controls.Add(topBarPanel);
            Name = "MainMenu";
            Text = "MainMenu";
            bottomBarPanel.ResumeLayout(false);
            mainTableLayout.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarPanel;
        private Panel bottomBarPanel;
        private TableLayoutPanel mainTableLayout;
        private Panel centerPanel;
        private Button createButton;
        private ListBox countryListtBox;
        private TextBox searchTextBox;
        private Button updateButton;
        private Button button1;
        private Button seeDetailsButton;
        private Button cancelButton;
    }
}
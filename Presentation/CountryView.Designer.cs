namespace _420DA3_Final_Formatif.Presentation
{
    partial class CountryView
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
            viewModeLabel = new Label();
            bottomBarPanel = new Panel();
            actionButton = new Button();
            cancelButton = new Button();
            mainTableLayout = new TableLayoutPanel();
            centerPanel = new Panel();
            label1 = new Label();
            langageListbox = new ListBox();
            fullNameTextBox = new TextBox();
            shortNameTextBox = new TextBox();
            idNumUpDown = new NumericUpDown();
            fullNameLabel = new Label();
            shortNameLabel = new Label();
            idLabel = new Label();
            topBarPanel.SuspendLayout();
            bottomBarPanel.SuspendLayout();
            mainTableLayout.SuspendLayout();
            centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // topBarPanel
            // 
            topBarPanel.Controls.Add(viewModeLabel);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(800, 50);
            topBarPanel.TabIndex = 1;
            // 
            // viewModeLabel
            // 
            viewModeLabel.AutoSize = true;
            viewModeLabel.Location = new Point(12, 9);
            viewModeLabel.Name = "viewModeLabel";
            viewModeLabel.Size = new Size(64, 25);
            viewModeLabel.TabIndex = 0;
            viewModeLabel.Text = "Mode ";
            // 
            // bottomBarPanel
            // 
            bottomBarPanel.Controls.Add(actionButton);
            bottomBarPanel.Controls.Add(cancelButton);
            bottomBarPanel.Dock = DockStyle.Bottom;
            bottomBarPanel.Location = new Point(0, 487);
            bottomBarPanel.Name = "bottomBarPanel";
            bottomBarPanel.Size = new Size(800, 50);
            bottomBarPanel.TabIndex = 2;
            // 
            // actionButton
            // 
            actionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            actionButton.Location = new Point(530, 6);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(112, 34);
            actionButton.TabIndex = 1;
            actionButton.Text = "Action";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(676, 6);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 659F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.Controls.Add(centerPanel, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 50);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(800, 437);
            mainTableLayout.TabIndex = 3;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(label1);
            centerPanel.Controls.Add(langageListbox);
            centerPanel.Controls.Add(fullNameTextBox);
            centerPanel.Controls.Add(shortNameTextBox);
            centerPanel.Controls.Add(idNumUpDown);
            centerPanel.Controls.Add(fullNameLabel);
            centerPanel.Controls.Add(shortNameLabel);
            centerPanel.Controls.Add(idLabel);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(73, 3);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(653, 431);
            centerPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 206);
            label1.Name = "label1";
            label1.Size = new Size(252, 38);
            label1.TabIndex = 7;
            label1.Text = "Liste des langues parlées";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // langageListbox
            // 
            langageListbox.FormattingEnabled = true;
            langageListbox.ItemHeight = 25;
            langageListbox.Location = new Point(142, 258);
            langageListbox.Name = "langageListbox";
            langageListbox.SelectionMode = SelectionMode.MultiSimple;
            langageListbox.Size = new Size(329, 154);
            langageListbox.TabIndex = 6;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(261, 129);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(389, 31);
            fullNameTextBox.TabIndex = 5;
            // 
            // shortNameTextBox
            // 
            shortNameTextBox.Location = new Point(261, 81);
            shortNameTextBox.Name = "shortNameTextBox";
            shortNameTextBox.Size = new Size(389, 31);
            shortNameTextBox.TabIndex = 4;
            // 
            // idNumUpDown
            // 
            idNumUpDown.Location = new Point(261, 30);
            idNumUpDown.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            idNumUpDown.Name = "idNumUpDown";
            idNumUpDown.Size = new Size(389, 31);
            idNumUpDown.TabIndex = 3;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(3, 122);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(252, 38);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name";
            fullNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shortNameLabel
            // 
            shortNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shortNameLabel.Location = new Point(3, 74);
            shortNameLabel.Name = "shortNameLabel";
            shortNameLabel.Size = new Size(252, 38);
            shortNameLabel.TabIndex = 1;
            shortNameLabel.Text = "Short Name";
            shortNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(3, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(252, 38);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            idLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CountryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(mainTableLayout);
            Controls.Add(bottomBarPanel);
            Controls.Add(topBarPanel);
            Name = "CountryView";
            Text = "CountryView";
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            bottomBarPanel.ResumeLayout(false);
            mainTableLayout.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idNumUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarPanel;
        private Panel bottomBarPanel;
        private TableLayoutPanel mainTableLayout;
        private Panel centerPanel;
        private Label idLabel;
        private Label fullNameLabel;
        private Label shortNameLabel;
        private ListBox langageListbox;
        private TextBox fullNameTextBox;
        private TextBox shortNameTextBox;
        private NumericUpDown idNumUpDown;
        private Label viewModeLabel;
        private Button actionButton;
        private Button cancelButton;
        private Label label1;
    }
}
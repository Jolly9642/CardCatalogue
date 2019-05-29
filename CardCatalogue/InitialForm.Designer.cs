namespace CardCatalogue
{
    partial class InitialForm
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
            this.nameOfCollection = new System.Windows.Forms.TextBox();
            this.collectionNameButton = new System.Windows.Forms.Button();
            this.collectionNameLabel = new System.Windows.Forms.Label();
            this.collectionListBox = new System.Windows.Forms.ListBox();
            this.collectionSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameOfCollection
            // 
            this.nameOfCollection.Location = new System.Drawing.Point(106, 190);
            this.nameOfCollection.Name = "nameOfCollection";
            this.nameOfCollection.Size = new System.Drawing.Size(202, 20);
            this.nameOfCollection.TabIndex = 0;
            // 
            // collectionNameButton
            // 
            this.collectionNameButton.Location = new System.Drawing.Point(102, 230);
            this.collectionNameButton.Name = "collectionNameButton";
            this.collectionNameButton.Size = new System.Drawing.Size(100, 23);
            this.collectionNameButton.TabIndex = 1;
            this.collectionNameButton.Text = "Submit";
            this.collectionNameButton.UseVisualStyleBackColor = true;
            this.collectionNameButton.Click += new System.EventHandler(this.collectionNameButton_Click);
            // 
            // collectionNameLabel
            // 
            this.collectionNameLabel.AutoSize = true;
            this.collectionNameLabel.Location = new System.Drawing.Point(106, 142);
            this.collectionNameLabel.Name = "collectionNameLabel";
            this.collectionNameLabel.Size = new System.Drawing.Size(96, 13);
            this.collectionNameLabel.TabIndex = 3;
            this.collectionNameLabel.Text = "Name of Collection";
            // 
            // collectionListBox
            // 
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.Location = new System.Drawing.Point(339, 115);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(120, 290);
            this.collectionListBox.TabIndex = 4;
            // 
            // collectionSelectionButton
            // 
            this.collectionSelectionButton.Location = new System.Drawing.Point(339, 412);
            this.collectionSelectionButton.Name = "collectionSelectionButton";
            this.collectionSelectionButton.Size = new System.Drawing.Size(120, 23);
            this.collectionSelectionButton.TabIndex = 5;
            this.collectionSelectionButton.Text = "Select Collection";
            this.collectionSelectionButton.UseVisualStyleBackColor = true;
            this.collectionSelectionButton.Click += new System.EventHandler(this.collectionSelectionButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.collectionSelectionButton);
            this.Controls.Add(this.collectionListBox);
            this.Controls.Add(this.collectionNameLabel);
            this.Controls.Add(this.collectionNameButton);
            this.Controls.Add(this.nameOfCollection);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameOfCollection;
        private System.Windows.Forms.Button collectionNameButton;
        private System.Windows.Forms.Label collectionNameLabel;
        private System.Windows.Forms.ListBox collectionListBox;
        private System.Windows.Forms.Button collectionSelectionButton;
    }
}
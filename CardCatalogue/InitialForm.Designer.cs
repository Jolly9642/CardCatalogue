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
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.removeCardButton = new System.Windows.Forms.Button();
            this.editCardButton = new System.Windows.Forms.Button();
            this.collectionLabel = new System.Windows.Forms.Label();
            this.newCollLabel = new System.Windows.Forms.Label();
            this.CardsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfCollection
            // 
            this.nameOfCollection.Location = new System.Drawing.Point(29, 190);
            this.nameOfCollection.Name = "nameOfCollection";
            this.nameOfCollection.Size = new System.Drawing.Size(202, 20);
            this.nameOfCollection.TabIndex = 0;
            // 
            // collectionNameButton
            // 
            this.collectionNameButton.Location = new System.Drawing.Point(29, 255);
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
            this.collectionNameLabel.Location = new System.Drawing.Point(33, 174);
            this.collectionNameLabel.Name = "collectionNameLabel";
            this.collectionNameLabel.Size = new System.Drawing.Size(96, 13);
            this.collectionNameLabel.TabIndex = 3;
            this.collectionNameLabel.Text = "Name of Collection";
            // 
            // collectionListBox
            // 
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.Location = new System.Drawing.Point(339, 39);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(120, 290);
            this.collectionListBox.TabIndex = 4;
            this.collectionListBox.SelectedIndexChanged += new System.EventHandler(this.collectionListBox_SelectedIndexChanged);
            // 
            // collectionSelectionButton
            // 
            this.collectionSelectionButton.Location = new System.Drawing.Point(339, 400);
            this.collectionSelectionButton.Name = "collectionSelectionButton";
            this.collectionSelectionButton.Size = new System.Drawing.Size(120, 23);
            this.collectionSelectionButton.TabIndex = 5;
            this.collectionSelectionButton.Text = "Select Collection";
            this.collectionSelectionButton.UseVisualStyleBackColor = true;
            this.collectionSelectionButton.Click += new System.EventHandler(this.collectionSelectionButton_Click);
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.Location = new System.Drawing.Point(565, 104);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(256, 290);
            this.cardListBox.TabIndex = 6;
            this.cardListBox.SelectedIndexChanged += new System.EventHandler(this.cardListBox_SelectedIndexChanged);
            // 
            // removeCardButton
            // 
            this.removeCardButton.Location = new System.Drawing.Point(565, 400);
            this.removeCardButton.Name = "removeCardButton";
            this.removeCardButton.Size = new System.Drawing.Size(89, 23);
            this.removeCardButton.TabIndex = 7;
            this.removeCardButton.Text = "Remove Card";
            this.removeCardButton.UseVisualStyleBackColor = true;
            this.removeCardButton.Click += new System.EventHandler(this.removeCardButton_Click);
            // 
            // editCardButton
            // 
            this.editCardButton.Location = new System.Drawing.Point(708, 400);
            this.editCardButton.Name = "editCardButton";
            this.editCardButton.Size = new System.Drawing.Size(75, 23);
            this.editCardButton.TabIndex = 8;
            this.editCardButton.Text = "Edit Card";
            this.editCardButton.UseVisualStyleBackColor = true;
            this.editCardButton.Click += new System.EventHandler(this.editCardButton_Click);
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Location = new System.Drawing.Point(336, 332);
            this.collectionLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(98, 65);
            this.collectionLabel.TabIndex = 11;
            this.collectionLabel.Text = "Select a Collection to see the cards in that collection and hit the button to add" +
    " cards.";
            // 
            // newCollLabel
            // 
            this.newCollLabel.AutoSize = true;
            this.newCollLabel.Location = new System.Drawing.Point(29, 227);
            this.newCollLabel.Name = "newCollLabel";
            this.newCollLabel.Size = new System.Drawing.Size(165, 13);
            this.newCollLabel.TabIndex = 12;
            this.newCollLabel.Text = "This is to create a new collection.";
            // 
            // CardsLabel
            // 
            this.CardsLabel.AutoSize = true;
            this.CardsLabel.Location = new System.Drawing.Point(565, 85);
            this.CardsLabel.Name = "CardsLabel";
            this.CardsLabel.Size = new System.Drawing.Size(34, 13);
            this.CardsLabel.TabIndex = 13;
            this.CardsLabel.Text = "Cards";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.CardsLabel);
            this.Controls.Add(this.newCollLabel);
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.editCardButton);
            this.Controls.Add(this.removeCardButton);
            this.Controls.Add(this.cardListBox);
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
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button removeCardButton;
        private System.Windows.Forms.Button editCardButton;
        private System.Windows.Forms.Label collectionLabel;
        private System.Windows.Forms.Label newCollLabel;
        private System.Windows.Forms.Label CardsLabel;
    }
}
namespace CardCatalogue
{
    partial class AddCardForm
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
            this.cardNameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.inDeckRadio = new System.Windows.Forms.RadioButton();
            this.collectionLabel = new System.Windows.Forms.Label();
            this.submitCardButton = new System.Windows.Forms.Button();
            this.backToCollectionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardNameInput
            // 
            this.cardNameInput.Location = new System.Drawing.Point(13, 55);
            this.cardNameInput.Name = "cardNameInput";
            this.cardNameInput.Size = new System.Drawing.Size(100, 20);
            this.cardNameInput.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Card Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 82);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(289, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Card Price (Would like to create a way to update this online)";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(13, 99);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 3;
            // 
            // inDeckRadio
            // 
            this.inDeckRadio.AutoSize = true;
            this.inDeckRadio.Location = new System.Drawing.Point(13, 151);
            this.inDeckRadio.Name = "inDeckRadio";
            this.inDeckRadio.Size = new System.Drawing.Size(172, 17);
            this.inDeckRadio.TabIndex = 4;
            this.inDeckRadio.TabStop = true;
            this.inDeckRadio.Text = "Check here if card is in a deck.";
            this.inDeckRadio.UseVisualStyleBackColor = true;
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Location = new System.Drawing.Point(13, 287);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(101, 13);
            this.collectionLabel.TabIndex = 5;
            this.collectionLabel.Text = "This is for Collection";
            // 
            // submitCardButton
            // 
            this.submitCardButton.Location = new System.Drawing.Point(16, 216);
            this.submitCardButton.Name = "submitCardButton";
            this.submitCardButton.Size = new System.Drawing.Size(150, 23);
            this.submitCardButton.TabIndex = 6;
            this.submitCardButton.Text = "Submit card to collection";
            this.submitCardButton.UseVisualStyleBackColor = true;
            this.submitCardButton.Click += new System.EventHandler(this.submitCardButton_Click);
            // 
            // backToCollectionsButton
            // 
            this.backToCollectionsButton.Location = new System.Drawing.Point(13, 368);
            this.backToCollectionsButton.Name = "backToCollectionsButton";
            this.backToCollectionsButton.Size = new System.Drawing.Size(127, 23);
            this.backToCollectionsButton.TabIndex = 7;
            this.backToCollectionsButton.Text = "Back to Collections";
            this.backToCollectionsButton.UseVisualStyleBackColor = true;
            this.backToCollectionsButton.Click += new System.EventHandler(this.backToCollectionsButton_Click);
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 406);
            this.Controls.Add(this.backToCollectionsButton);
            this.Controls.Add(this.submitCardButton);
            this.Controls.Add(this.collectionLabel);
            this.Controls.Add(this.inDeckRadio);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cardNameInput);
            this.Name = "AddCardForm";
            this.Text = "AddCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.RadioButton inDeckRadio;
        private System.Windows.Forms.Label collectionLabel;
        private System.Windows.Forms.Button submitCardButton;
        private System.Windows.Forms.Button backToCollectionsButton;
    }
}
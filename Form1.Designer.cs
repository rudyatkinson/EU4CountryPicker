
namespace EU4RandomCountryPicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regionBox = new System.Windows.Forms.GroupBox();
            this.RegionsListBox = new System.Windows.Forms.CheckedListBox();
            this.RandomCountryButton = new System.Windows.Forms.Button();
            this.PickedCountry = new System.Windows.Forms.Label();
            this.regionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // regionBox
            // 
            this.regionBox.Controls.Add(this.RegionsListBox);
            this.regionBox.Location = new System.Drawing.Point(12, 12);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(199, 214);
            this.regionBox.TabIndex = 0;
            this.regionBox.TabStop = false;
            this.regionBox.Text = "Regions";
            // 
            // RegionsListBox
            // 
            this.RegionsListBox.FormattingEnabled = true;
            this.RegionsListBox.Location = new System.Drawing.Point(7, 23);
            this.RegionsListBox.Name = "RegionsListBox";
            this.RegionsListBox.Size = new System.Drawing.Size(186, 184);
            this.RegionsListBox.TabIndex = 0;
            // 
            // RandomCountryButton
            // 
            this.RandomCountryButton.Location = new System.Drawing.Point(234, 35);
            this.RandomCountryButton.Name = "RandomCountryButton";
            this.RandomCountryButton.Size = new System.Drawing.Size(195, 23);
            this.RandomCountryButton.TabIndex = 1;
            this.RandomCountryButton.Text = "Pick my destiny";
            this.RandomCountryButton.UseVisualStyleBackColor = true;
            this.RandomCountryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickedCountry
            // 
            this.PickedCountry.AutoSize = true;
            this.PickedCountry.Location = new System.Drawing.Point(234, 93);
            this.PickedCountry.Name = "PickedCountry";
            this.PickedCountry.Size = new System.Drawing.Size(0, 15);
            this.PickedCountry.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 238);
            this.Controls.Add(this.PickedCountry);
            this.Controls.Add(this.RandomCountryButton);
            this.Controls.Add(this.regionBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 277);
            this.MinimumSize = new System.Drawing.Size(467, 277);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EU4CountryPicker";
            this.regionBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox regionBox;
        private System.Windows.Forms.CheckedListBox RegionsListBox;
        private System.Windows.Forms.Button RandomCountryButton;
        private System.Windows.Forms.Label PickedCountry;
    }
}


namespace MarsRoverPhotoApp
{
    partial class MarsRoverPhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarsRoverPhotoForm));
            this.photoButton = new System.Windows.Forms.Button();
            this.camBox = new System.Windows.Forms.ComboBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoButton
            // 
            this.photoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.photoButton.Location = new System.Drawing.Point(208, 817);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(1092, 23);
            this.photoButton.TabIndex = 3;
            this.photoButton.TabStop = false;
            this.photoButton.Text = "Get Photo";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // camBox
            // 
            this.camBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.camBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.camBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.camBox.FormattingEnabled = true;
            this.camBox.Items.AddRange(new object[] {
            "Front Hazard Avoidance Camera",
            "Rear Hazard Avoidance Camera",
            "Mast Camera",
            "Mars Hand Lens Imager",
            "Mars Descent Imager",
            "Navigation Camera"});
            this.camBox.Location = new System.Drawing.Point(208, 788);
            this.camBox.Name = "camBox";
            this.camBox.Size = new System.Drawing.Size(1092, 23);
            this.camBox.TabIndex = 2;
            this.camBox.TabStop = false;
            this.camBox.SelectedIndexChanged += new System.EventHandler(this.camBox_SelectedIndexChanged);
            // 
            // dateText
            // 
            this.dateText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dateText.Location = new System.Drawing.Point(208, 761);
            this.dateText.Name = "dateText";
            this.dateText.PlaceholderText = "Desired Earth Date..";
            this.dateText.Size = new System.Drawing.Size(190, 16);
            this.dateText.TabIndex = 1;
            this.dateText.TabStop = false;
            this.dateText.TextChanged += new System.EventHandler(this.dateText_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(404, 762);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(900, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Tip: Please ensure entered Earth date is after the landing of Curiosity (2012/08/" +
    "05), and not a future date. Also, some dates may not contain any photos if none " +
    "were taken.";
            // 
            // photoBox
            // 
            this.photoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoBox.Location = new System.Drawing.Point(0, 0);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(1508, 853);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 5;
            this.photoBox.TabStop = false;
            this.photoBox.WaitOnLoad = true;
            this.photoBox.Click += new System.EventHandler(this.photoBox_Click);
            // 
            // MarsRoverPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1508, 852);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.camBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.photoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1524, 891);
            this.Name = "MarsRoverPhotoForm";
            this.Text = "NASA Mars Rover Photo App";
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button photoButton;
        private ComboBox camBox;
        private TextBox dateText;
        private Label dateLabel;
        public PictureBox photoBox;
    }
}
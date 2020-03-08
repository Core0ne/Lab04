namespace Lab04
{
    partial class Form1
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
            this.inputMessageLabel = new System.Windows.Forms.Label();
            this.initialMessageTextBox = new System.Windows.Forms.TextBox();
            this.encodedMessageLabel = new System.Windows.Forms.Label();
            this.encodeMessageButton = new System.Windows.Forms.Button();
            this.encodedMessageTextBox = new System.Windows.Forms.TextBox();
            this.decodeMessageButton = new System.Windows.Forms.Button();
            this.decodedMessageLabel = new System.Windows.Forms.Label();
            this.decodedMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputMessageLabel
            // 
            this.inputMessageLabel.AutoSize = true;
            this.inputMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputMessageLabel.Location = new System.Drawing.Point(47, 63);
            this.inputMessageLabel.Name = "inputMessageLabel";
            this.inputMessageLabel.Size = new System.Drawing.Size(186, 20);
            this.inputMessageLabel.TabIndex = 0;
            this.inputMessageLabel.Text = "Введите сообщение:";
            // 
            // initialMessageTextBox
            // 
            this.initialMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.initialMessageTextBox.Location = new System.Drawing.Point(330, 57);
            this.initialMessageTextBox.Name = "initialMessageTextBox";
            this.initialMessageTextBox.Size = new System.Drawing.Size(245, 26);
            this.initialMessageTextBox.TabIndex = 1;
            this.initialMessageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialMessageTextBox_KeyPress);
            // 
            // encodedMessageLabel
            // 
            this.encodedMessageLabel.AutoSize = true;
            this.encodedMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encodedMessageLabel.Location = new System.Drawing.Point(47, 187);
            this.encodedMessageLabel.Name = "encodedMessageLabel";
            this.encodedMessageLabel.Size = new System.Drawing.Size(255, 20);
            this.encodedMessageLabel.TabIndex = 2;
            this.encodedMessageLabel.Text = "Закодированное сообщение:";
            // 
            // encodeMessageButton
            // 
            this.encodeMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encodeMessageButton.Location = new System.Drawing.Point(206, 108);
            this.encodeMessageButton.Name = "encodeMessageButton";
            this.encodeMessageButton.Size = new System.Drawing.Size(268, 43);
            this.encodeMessageButton.TabIndex = 3;
            this.encodeMessageButton.Text = "Закодировать сообщение";
            this.encodeMessageButton.UseVisualStyleBackColor = true;
            this.encodeMessageButton.Click += new System.EventHandler(this.encodeMessageButton_Click);
            // 
            // encodedMessageTextBox
            // 
            this.encodedMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encodedMessageTextBox.Location = new System.Drawing.Point(330, 181);
            this.encodedMessageTextBox.Name = "encodedMessageTextBox";
            this.encodedMessageTextBox.ReadOnly = true;
            this.encodedMessageTextBox.Size = new System.Drawing.Size(245, 26);
            this.encodedMessageTextBox.TabIndex = 4;
            // 
            // decodeMessageButton
            // 
            this.decodeMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodeMessageButton.Location = new System.Drawing.Point(206, 233);
            this.decodeMessageButton.Name = "decodeMessageButton";
            this.decodeMessageButton.Size = new System.Drawing.Size(268, 43);
            this.decodeMessageButton.TabIndex = 5;
            this.decodeMessageButton.Text = "Декодировать сообщение";
            this.decodeMessageButton.UseVisualStyleBackColor = true;
            this.decodeMessageButton.Click += new System.EventHandler(this.decodeMessageButton_Click);
            // 
            // decodedMessageLabel
            // 
            this.decodedMessageLabel.AutoSize = true;
            this.decodedMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodedMessageLabel.Location = new System.Drawing.Point(47, 309);
            this.decodedMessageLabel.Name = "decodedMessageLabel";
            this.decodedMessageLabel.Size = new System.Drawing.Size(256, 20);
            this.decodedMessageLabel.TabIndex = 6;
            this.decodedMessageLabel.Text = "Декодированное сообщение:";
            // 
            // decodedMessageTextBox
            // 
            this.decodedMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodedMessageTextBox.Location = new System.Drawing.Point(330, 303);
            this.decodedMessageTextBox.Name = "decodedMessageTextBox";
            this.decodedMessageTextBox.ReadOnly = true;
            this.decodedMessageTextBox.Size = new System.Drawing.Size(245, 26);
            this.decodedMessageTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 397);
            this.Controls.Add(this.decodedMessageTextBox);
            this.Controls.Add(this.decodedMessageLabel);
            this.Controls.Add(this.decodeMessageButton);
            this.Controls.Add(this.encodedMessageTextBox);
            this.Controls.Add(this.encodeMessageButton);
            this.Controls.Add(this.encodedMessageLabel);
            this.Controls.Add(this.initialMessageTextBox);
            this.Controls.Add(this.inputMessageLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputMessageLabel;
        private System.Windows.Forms.TextBox initialMessageTextBox;
        private System.Windows.Forms.Label encodedMessageLabel;
        private System.Windows.Forms.Button encodeMessageButton;
        private System.Windows.Forms.TextBox encodedMessageTextBox;
        private System.Windows.Forms.Button decodeMessageButton;
        private System.Windows.Forms.Label decodedMessageLabel;
        private System.Windows.Forms.TextBox decodedMessageTextBox;
    }
}


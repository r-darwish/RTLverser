namespace RTLverser
{
    partial class MainForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.userText = new System.Windows.Forms.TextBox();
            this.machineTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Upper
            // 
            this.splitContainer.Panel1.Controls.Add(this.userText);
            // 
            // splitContainer.Lower
            // 
            this.splitContainer.Panel2.Controls.Add(this.machineTextBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 266;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.Text = "splitContainer1";
            // 
            // userText
            // 
            this.userText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userText.Location = new System.Drawing.Point(0, 0);
            this.userText.Multiline = true;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(800, 266);
            this.userText.TabIndex = 0;
            this.userText.TextChanged += new System.EventHandler(this.UserText_TextChanged);
            // 
            // machineTextBox
            // 
            this.machineTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineTextBox.Location = new System.Drawing.Point(0, 0);
            this.machineTextBox.Multiline = true;
            this.machineTextBox.Name = "machineTextBox";
            this.machineTextBox.Size = new System.Drawing.Size(800, 180);
            this.machineTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "RTLverser";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox machineTextBox;
    }
}


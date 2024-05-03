namespace MarkdigExtensions.RtfRenderer.Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MarkDown = new TextBox();
            RichText = new RichTextBox();
            SuspendLayout();
            // 
            // MarkDown
            // 
            MarkDown.Location = new Point(12, 12);
            MarkDown.Multiline = true;
            MarkDown.Name = "MarkDown";
            MarkDown.Size = new Size(396, 426);
            MarkDown.TabIndex = 0;
            MarkDown.Text = resources.GetString("MarkDown.Text");
            MarkDown.TextChanged += MarkDown_TextChanged;
            // 
            // RichText
            // 
            RichText.BackColor = SystemColors.Control;
            RichText.BorderStyle = BorderStyle.None;
            RichText.Location = new Point(414, 12);
            RichText.Name = "RichText";
            RichText.Size = new Size(374, 426);
            RichText.TabIndex = 1;
            RichText.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichText);
            Controls.Add(MarkDown);
            Name = "MainForm";
            Text = "Markdig RTF Renderer Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MarkDown;
        private RichTextBox RichText;
    }
}

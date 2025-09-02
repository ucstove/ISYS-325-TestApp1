namespace TestApp1
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
            pushmeButton = new Button();
            SuspendLayout();
            // 
            // pushmeButton
            // 
            pushmeButton.Location = new Point(325, 198);
            pushmeButton.Name = "pushmeButton";
            pushmeButton.Size = new Size(112, 34);
            pushmeButton.TabIndex = 0;
            pushmeButton.Text = "&Push Me";
            pushmeButton.UseVisualStyleBackColor = true;
            pushmeButton.Click += pushmeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pushmeButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button pushmeButton;
    }
}

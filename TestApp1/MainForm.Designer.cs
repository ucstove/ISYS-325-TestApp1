
namespace TestApp1
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
            pushmeButton = new Button();
            helloworldLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // pushmeButton
            // 
            pushmeButton.Location = new Point(55, 134);
            pushmeButton.Name = "pushmeButton";
            pushmeButton.Size = new Size(212, 134);
            pushmeButton.TabIndex = 0;
            pushmeButton.Text = "&Push Me";
            pushmeButton.UseVisualStyleBackColor = true;
            pushmeButton.Click += pushmeButton_Click;
            // 
            // helloworldLabel
            // 
            helloworldLabel.AutoSize = true;
            helloworldLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helloworldLabel.Location = new Point(368, 53);
            helloworldLabel.Name = "helloworldLabel";
            helloworldLabel.Size = new Size(76, 23);
            helloworldLabel.TabIndex = 1;
            helloworldLabel.Text = "Label1";
            helloworldLabel.Click += helloworldLabel_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(594, 351);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 34);
            closeButton.TabIndex = 2;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(helloworldLabel);
            Controls.Add(pushmeButton);
            Controls.Add(closeButton);
            Name = "MainForm";
            Text = "My Application";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button pushmeButton;
        private Label helloworldLabel;
        private Button closeButton;
    }
}


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
            carPicture = new PictureBox();
            testTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)carPicture).BeginInit();
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
            helloworldLabel.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helloworldLabel.Location = new Point(229, 34);
            helloworldLabel.Name = "helloworldLabel";
            helloworldLabel.Size = new Size(144, 44);
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
            // carPicture
            // 
            carPicture.ImageLocation = "C:\\Users\\uriah\\Downloads\\Bluecar.png";
            carPicture.Location = new Point(368, 155);
            carPicture.Name = "carPicture";
            carPicture.Size = new Size(304, 113);
            carPicture.TabIndex = 3;
            carPicture.TabStop = false;
            carPicture.Click += carPicture_Click;
            // 
            // testTextBox
            // 
            testTextBox.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testTextBox.Location = new Point(107, 342);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(328, 66);
            testTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 314);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 4;
            label1.Text = "&Age";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(testTextBox);
            Controls.Add(carPicture);
            Controls.Add(helloworldLabel);
            Controls.Add(pushmeButton);
            Controls.Add(closeButton);
            Name = "MainForm";
            Text = "My Application";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)carPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button pushmeButton;
        private Label helloworldLabel;
        private Button closeButton;
        private PictureBox carPicture;
        private TextBox testTextBox;
        private Label label1;
    }
}

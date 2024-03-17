namespace ConvertApp.WinForm.Forms
{
    partial class MainForm
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
            buttonStringConversion = new Button();
            buttonFileConversion = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // buttonStringConversion
            // 
            buttonStringConversion.Location = new Point(92, 59);
            buttonStringConversion.Name = "buttonStringConversion";
            buttonStringConversion.Size = new Size(500, 80);
            buttonStringConversion.TabIndex = 0;
            buttonStringConversion.Text = "文字列変換";
            buttonStringConversion.UseVisualStyleBackColor = true;
            buttonStringConversion.Click += OnButtonStringConversion_Click;
            // 
            // buttonFileConversion
            // 
            buttonFileConversion.Location = new Point(92, 188);
            buttonFileConversion.Name = "buttonFileConversion";
            buttonFileConversion.Size = new Size(500, 80);
            buttonFileConversion.TabIndex = 0;
            buttonFileConversion.Text = "ファイル変換";
            buttonFileConversion.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(92, 317);
            button3.Name = "button3";
            button3.Size = new Size(500, 80);
            button3.TabIndex = 0;
            button3.Text = "開発中";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(684, 461);
            Controls.Add(button3);
            Controls.Add(buttonFileConversion);
            Controls.Add(buttonStringConversion);
            Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "変換アプリ";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStringConversion;
        private Button buttonFileConversion;
        private Button button3;
    }
}
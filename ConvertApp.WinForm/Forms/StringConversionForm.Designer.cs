namespace ConvertApp.WinForm.Forms
{
    partial class StringConversionForm
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
            label1 = new Label();
            comboBoxConversion1 = new ComboBox();
            comboBoxConversion2 = new ComboBox();
            label2 = new Label();
            comboBoxConversion3 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            textBoxBefore = new TextBox();
            textBoxAfter = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "変換処理1";
            // 
            // comboBoxConversion1
            // 
            comboBoxConversion1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConversion1.FormattingEnabled = true;
            comboBoxConversion1.Location = new Point(50, 80);
            comboBoxConversion1.Name = "comboBoxConversion1";
            comboBoxConversion1.Size = new Size(200, 28);
            comboBoxConversion1.TabIndex = 1;
            // 
            // comboBoxConversion2
            // 
            comboBoxConversion2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConversion2.FormattingEnabled = true;
            comboBoxConversion2.Location = new Point(274, 80);
            comboBoxConversion2.Name = "comboBoxConversion2";
            comboBoxConversion2.Size = new Size(200, 28);
            comboBoxConversion2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 50);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "変換処理2";
            // 
            // comboBoxConversion3
            // 
            comboBoxConversion3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConversion3.FormattingEnabled = true;
            comboBoxConversion3.Location = new Point(498, 80);
            comboBoxConversion3.Name = "comboBoxConversion3";
            comboBoxConversion3.Size = new Size(200, 28);
            comboBoxConversion3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 50);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "変換処理3";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(50, 135);
            button1.Name = "button1";
            button1.Size = new Size(125, 58);
            button1.TabIndex = 2;
            button1.Text = "変換";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OnButtonConversion_Click;
            // 
            // textBoxBefore
            // 
            textBoxBefore.Location = new Point(50, 273);
            textBoxBefore.Multiline = true;
            textBoxBefore.Name = "textBoxBefore";
            textBoxBefore.ScrollBars = ScrollBars.Vertical;
            textBoxBefore.Size = new Size(648, 128);
            textBoxBefore.TabIndex = 3;
            // 
            // textBoxAfter
            // 
            textBoxAfter.Location = new Point(50, 472);
            textBoxAfter.Multiline = true;
            textBoxAfter.Name = "textBoxAfter";
            textBoxAfter.ScrollBars = ScrollBars.Vertical;
            textBoxAfter.Size = new Size(648, 128);
            textBoxAfter.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 427);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 0;
            label4.Text = "↓";
            // 
            // StringConversionForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(762, 666);
            Controls.Add(textBoxAfter);
            Controls.Add(textBoxBefore);
            Controls.Add(button1);
            Controls.Add(comboBoxConversion3);
            Controls.Add(comboBoxConversion2);
            Controls.Add(comboBoxConversion1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StringConversionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "文字列変換";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxConversion1;
        private ComboBox comboBoxConversion2;
        private Label label2;
        private ComboBox comboBoxConversion3;
        private Label label3;
        private Button button1;
        private TextBox textBoxBefore;
        private TextBox textBoxAfter;
        private Label label4;
    }
}
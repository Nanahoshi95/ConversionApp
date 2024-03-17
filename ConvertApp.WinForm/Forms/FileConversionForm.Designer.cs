namespace ConvertApp.WinForm.Forms
{
    partial class FileConversionForm
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
            buttonFileSelect = new Button();
            label1 = new Label();
            labelBeforeFile = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonFileSelect
            // 
            buttonFileSelect.BackColor = Color.SkyBlue;
            buttonFileSelect.Location = new Point(220, 74);
            buttonFileSelect.Name = "buttonFileSelect";
            buttonFileSelect.Size = new Size(125, 58);
            buttonFileSelect.TabIndex = 4;
            buttonFileSelect.Text = "ファイル選択";
            buttonFileSelect.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 183);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "変換元ファイル";
            // 
            // labelBeforeFile
            // 
            labelBeforeFile.BackColor = SystemColors.ScrollBar;
            labelBeforeFile.Location = new Point(57, 213);
            labelBeforeFile.Name = "labelBeforeFile";
            labelBeforeFile.Size = new Size(660, 27);
            labelBeforeFile.TabIndex = 5;
            labelBeforeFile.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 74);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "変換元ファイル";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(57, 323);
            button1.Name = "button1";
            button1.Size = new Size(125, 58);
            button1.TabIndex = 4;
            button1.Text = "出力先フォルダ選択";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(220, 323);
            button2.Name = "button2";
            button2.Size = new Size(125, 58);
            button2.TabIndex = 4;
            button2.Text = "変換";
            button2.UseVisualStyleBackColor = false;
            // 
            // FileConversionForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1143, 600);
            Controls.Add(comboBox1);
            Controls.Add(labelBeforeFile);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonFileSelect);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Meiryo UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FileConversionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ファイル変換";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFileSelect;
        private Label label1;
        private Label labelBeforeFile;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}
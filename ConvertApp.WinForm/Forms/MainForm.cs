using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertApp.WinForm.Forms
{
    /// <summary>
    /// アプリのメインフォームを提供します。
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文字列変換ボタンがクリックされた際の処理を行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonStringConversion_Click(object sender, EventArgs e)
        {
            var form = new StringConversionForm();
            form.ShowDialog();
        }

        /// <summary>
        /// ファイル変換ボタンがクリックされた際の処理を行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonFileConversion_Click(object sender, EventArgs e)
        {
            var form = new FileConversionForm();
            form.ShowDialog();
        }
    }
}

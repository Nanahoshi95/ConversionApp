using ConvertApp.Domain.DataClasses;
using ConvertApp.Domain.Strategies;
using ConvertApp.Domain.Utilities;

namespace ConvertApp.WinForm.Forms
{
    /// <summary>
    /// 文字列変換フォームを提供します。
    /// </summary>
    public partial class StringConversionForm : Form
    {
        private ComboBox[]? comboBoxes;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StringConversionForm()
        {
            InitializeComponent();

            this.InitializeComboBoxes();
        }

        /// <summary>
        /// コンボボックスを初期化します。
        /// </summary>
        private void InitializeComboBoxes()
        {
            this.comboBoxes = new ComboBox[]
            {
                this.comboBoxConversion1,
                this.comboBoxConversion2,
                this.comboBoxConversion3,
            };

            foreach (var comboBox in this.comboBoxes)
            {
                comboBox.DataSource = StringConversionUtility.GetDataSource();
                comboBox.ValueMember = nameof(KeyValueItem<int, string>.Key);
                comboBox.DisplayMember = nameof(KeyValueItem<int, string>.Value);
            }
        }

        /// <summary>
        /// 変換ボタンをクリックした場合の処理を行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonConversion_Click(object sender, EventArgs e)
        {
            if (this.comboBoxes == null) return;

            var after = this.textBoxBefore.Text;

            foreach (var comboBox in this.comboBoxes)
            {
                if (comboBox.SelectedValue is not IStringConversionStrategy conversionStrategy) continue;
                after = conversionStrategy.Convert(after);
            }

            this.textBoxAfter.Text = after;
        }
    }
}

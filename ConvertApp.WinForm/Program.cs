using ConvertApp.WinForm.Forms;

namespace ConvertApp.WinForm
{
    /// <summary>
    /// �A�v���P�[�V�����̊J�n�@�\��񋟂��܂��B
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  �A�v���P�[�V�����̊J�n���������s���܂��B
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
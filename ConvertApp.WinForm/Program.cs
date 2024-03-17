using ConvertApp.WinForm.Forms;

namespace ConvertApp.WinForm
{
    /// <summary>
    /// アプリケーションの開始機能を提供します。
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  アプリケーションの開始時処理を行います。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
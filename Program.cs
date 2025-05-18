
using ControleAlunos.Data;

namespace ControleAlunos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            await DataBase.Instance.InitAsync();
            Application.Run(new FormTelaInicial());
        }
    }
}
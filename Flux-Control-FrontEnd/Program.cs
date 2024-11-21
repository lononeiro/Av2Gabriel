using Flux_Control_prototipo.Formularios;

namespace Flux_Control_prototipo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Exibir o formulário de login
            FmrLogin loginForm = new FmrLogin();
            if (loginForm.ShowDialog() == DialogResult.OK) // Somente prosseguir se login for bem-sucedido
            {
                Application.Run(new FmrEstoque());
            }
        }
    }
}
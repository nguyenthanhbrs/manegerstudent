namespace StudentManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đảm bảo chạy new Form1()
            Application.Run(new Form1());
        }
    }
}
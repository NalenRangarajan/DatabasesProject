namespace GameApplication
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
			ApplicationConfiguration.Initialize();
			LoginView lv = new LoginView();
			
			while (lv.ShowDialog() != DialogResult.OK)
			{
				
			}
            Application.Run(new GameView());
        }
	}
}
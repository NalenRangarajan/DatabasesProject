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
			bool relog = true;
            while (relog)
            {
				relog = false;
                LoginView lv = new LoginView();
                if (lv.ShowDialog() == DialogResult.OK)
				{
					GameView gv = new GameView();
					if (gv.ShowDialog() == DialogResult.Retry)
					{
						relog = true;
					}
				}
			}
        }
	}
}
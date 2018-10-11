using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.Hello
{
	public partial class App : Application
	{
        public static Configurar ConfigModel { get; set; }

		public App ()
		{
            if (ConfigModel == null)
                ConfigModel = new Configurar();

            InitializeComponent();

            // NavigationPage - Inicia a pilha de navegação
            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

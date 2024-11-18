namespace Messenger
{
    public partial class App : Application
    {
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 945;
            window.Width = 1400;

            return window;
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

        }
    }

}

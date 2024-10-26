using jescobarS1.Views;

namespace jescobarS1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Empleado();
        }
    }
}

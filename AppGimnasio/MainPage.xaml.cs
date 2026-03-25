namespace AppGimnasio
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void MetodoDePrueba()
        {
            // Este es el método que yo hice en mi compu
            int x = 10;
        }

        private void MetodoDePrueba2()
        {
            // Este es el método que hizo mi compa desde su casa
            string saludo = "Hola";
        }




       
              private void rama2()
        {
            // Este es el método que hizo mi compa desde su casa
            string saludo = "Hola";
        }































































































































































        public void pruebaAronAlvarez()
        {

            string Aron = "Alvarez";
        }











    }

}

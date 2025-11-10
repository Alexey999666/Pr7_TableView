namespace Pr7_TableView
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void stAge_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblAge.Text = stAge.Value.ToString();
            lblAge.Text = e.NewValue.ToString();
        }
    }

}

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

        private async void btnChaos_Click(object sender, System.EventArgs e)
        {
            // Получаем значения из всех полей
            string name = !string.IsNullOrEmpty(ecName.Text) ? ecName.Text : "Неизвестно";
            string family = !string.IsNullOrEmpty(ecFamily.Text) ? ecFamily.Text : "Неизвестно";
            string dopName = !string.IsNullOrEmpty(ecDopName.Text) ? ecDopName.Text : "Неизвестно";
            string ras = !string.IsNullOrEmpty(ecRas.Text) ? ecRas.Text : "Неизвестно";
            string world = !string.IsNullOrEmpty(ecWorld.Text) ? ecWorld.Text : "Неизвестно";
            string fractia = !string.IsNullOrEmpty(ecFracia.Text) ? ecFracia.Text : "Неизвестно";
            string age = lblAge.Text ?? "18";
            string speshial = !string.IsNullOrEmpty(ecSpeshial.Text) ? ecSpeshial.Text : "Неизвестно";

            // Получаем значение из SwitchCell
            string psayker = swPsayker.On ? "Да" : "Нет";

            // Получаем значения из Picker'ов
            string god = !string.IsNullOrEmpty(pickerGod.SelectedItem?.ToString()) ?
                        pickerGod.SelectedItem.ToString() : "Не выбран";

            string legion = !string.IsNullOrEmpty(pickerLegion.SelectedItem?.ToString()) ?
                           pickerLegion.SelectedItem.ToString() : "Не выбран";

            // Создаем сообщение со всеми данными
            string message = $"Заявка на вступление в ряды Хаоса:\n\n" +
                            $"Имя: {name}\n" +
                            $"Фамилия: {family}\n" +
                            $"Титул или прозвище: {dopName}\n" +
                            $"Раса: {ras}\n" +
                            $"Родной мир: {world}\n" +
                            $"Прошлая фракция: {fractia}\n" +
                            $"Возраст: {age}\n" +
                            $"Специализация: {speshial}\n" +
                            $"Псайкер: {psayker}\n" +
                            $"Бог хаоса: {god}\n" +
                            $"Легион: {legion}";

            // Показываем сообщение
            await DisplayAlert("Заявка подана!", message, "Да здравствует Хаос!");
        }
    }

}

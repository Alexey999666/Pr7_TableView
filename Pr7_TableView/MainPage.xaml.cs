namespace Pr7_TableView
{
    public partial class MainPage : ContentPage
    {
        private string selectedImagePath;

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
            
            string name = !string.IsNullOrEmpty(ecName.Text) ? ecName.Text : "Неизвестно";
            string family = !string.IsNullOrEmpty(ecFamily.Text) ? ecFamily.Text : "Неизвестно";
            string dopName = !string.IsNullOrEmpty(ecDopName.Text) ? ecDopName.Text : "Неизвестно";
            string ras = !string.IsNullOrEmpty(ecRas.Text) ? ecRas.Text : "Неизвестно";
            string world = !string.IsNullOrEmpty(ecWorld.Text) ? ecWorld.Text : "Неизвестно";
            string fractia = !string.IsNullOrEmpty(ecFracia.Text) ? ecFracia.Text : "Неизвестно";
            string age = lblAge.Text ?? "18";
            string speshial = !string.IsNullOrEmpty(ecSpeshial.Text) ? ecSpeshial.Text : "Неизвестно";

            
            string psayker = swPsayker.On ? "Да" : "Нет";

            
            string god = !string.IsNullOrEmpty(pickerGod.SelectedItem?.ToString()) ?
                        pickerGod.SelectedItem.ToString() : "Не выбран";

            string legion = !string.IsNullOrEmpty(pickerLegion.SelectedItem?.ToString()) ?
                           pickerLegion.SelectedItem.ToString() : "Не выбран";

            string photoInfo = !string.IsNullOrEmpty(selectedImagePath) ?
                         $"Фото: {Path.GetFileName(selectedImagePath)}" : "Фото не выбрано";

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
                        $"Легион: {legion}\n" +
                        $"{photoInfo}";

            
            await DisplayAlert("Заявка подана!", message, "Да здравствует Хаос!");
        }

        private async void OnPickPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Выберите фото адепта Хаоса",
                    FileTypes = FilePickerFileType.Images
                });

                if (result != null)
                {
                    selectedImagePath = result.FullPath;
                    selectedImage.Source = ImageSource.FromFile(selectedImagePath);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Не удалось выбрать фото: {ex.Message}", "OK");
            }
        }
    }

}

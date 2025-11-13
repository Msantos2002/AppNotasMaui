using System;

namespace AppNotasMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAgregarNotaClicked(object sender, EventArgs e)
    {
        string nota = NotaEntry.Text;

        if (string.IsNullOrWhiteSpace(nota))
        {
            await DisplayAlert("Aviso", "Por favor escribe una nota.", "OK");
            return;
        }

        // Crear un nuevo Label para la nota
        Label nuevaNota = new Label
        {
            Text = "• " + nota,
            FontSize = 18,
            TextColor = Colors.DarkSlateBlue
        };

        // Agregarlo al contenedor de notas
        NotasContainer.Add(nuevaNota);

        // Limpiar Entry
        NotaEntry.Text = string.Empty;
    }
}

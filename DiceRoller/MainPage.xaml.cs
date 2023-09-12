namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker
    private void SortearNumeroAleatorio(object sender, EventArgs e)
    {
        var maxValue = SeletorDeLadosDoDado.SelectedItem;
        var numeroSorteado = new Random().Next(1, (int)maxValue);

        NumeroSorteado.Text = numeroSorteado.ToString();
    }

}


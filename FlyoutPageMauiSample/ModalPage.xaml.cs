namespace FlyoutPageMauiSample;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        _ = Navigation.PopModalAsync();
    }
    
    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        _ = Application.Current!.MainPage!.DisplayAlert("Popped", "Popped from ModalPage", "OK");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutPageMauiSample;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
    }
    
    private void OnButtonClicked(object sender, EventArgs e)
    {
        _ = Application.Current!.MainPage!.Navigation.PushModalAsync(new ModalPage());
    }
    
    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        _ = Application.Current!.MainPage!.DisplayAlert("Navigated", "Navigated from Detail Page", "OK");
    }
}
using LoginTaskPcl.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginTaskPcl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {

        private SignInPageViewModel _viewModel;

        public SignInPage()
        {
            InitializeComponent();
            _viewModel = new SignInPageViewModel();
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                _viewModel?.Init();
                this.BindingContext = _viewModel;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void signInButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await _viewModel.SignIn();
                if (result.ResultCode == -1)
                {
                    await DisplayAlert("Error", result.ResultMessage, "OK");
                }
                else
                {
                    ResultPage resultPage = new ResultPage();
                    resultPage.Init(result);
                    await PopupNavigation.PushAsync(resultPage, true);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void signUpButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SignUpPage(), true);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

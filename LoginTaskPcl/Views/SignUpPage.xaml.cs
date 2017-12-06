using LoginTaskPcl.ViewModels;
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
    public partial class SignUpPage : ContentPage
    {
        SignUpPageViewModel _viewModel;

        public SignUpPage()
        {
            InitializeComponent();
            _viewModel = new SignUpPageViewModel();
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                _viewModel?.Init();
                this.BindingContext = _viewModel;
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void registrationButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var prxCustomer = await _viewModel.SignUp();
                if (prxCustomer.ResultCode == 1)
                {
                    await Navigation.PopAsync(true);
                }
                else
                {
                    await DisplayAlert("Error", prxCustomer.ResultMessage, "OK");
                }
                _viewModel.Reset();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

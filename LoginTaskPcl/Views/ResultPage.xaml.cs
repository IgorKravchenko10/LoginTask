using LoginTaskPcl.Models;
using LoginTaskPcl.ViewModels;
using Rg.Plugins.Popup.Pages;
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
    public partial class ResultPage : PopupPage
    {

        ResultPageViewModel _viewModel;
        PrxCustomer _prxCustomer;

        public ResultPage()
        {
            InitializeComponent();
            this.CloseWhenBackgroundIsClicked = true;
            this.BackgroundColor = Color.FromHex("#E600FF00");
        }

        public void Init(PrxCustomer prxCustomer)
        {
            _prxCustomer = prxCustomer;
            _viewModel = new ResultPageViewModel();
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                _viewModel.Init(_prxCustomer);
                this.BindingContext = _viewModel;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDC03_MODULE07.Models;
using PDC03_MODULE07.ViewModels;

namespace PDC03_MODULE07.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeePage : ContentPage
    {
        EmployeeViewModel viewModel;
        public ShowEmployeePage()
        {
            InitializeComponent();
            viewModel = new EmployeeViewModel();

        }

        private void showEmployeePage()
        {
            var res = viewModel.GetAllEmployees().Result;
            lstData.ItemsSource = res;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showEmployeePage();
        }

        private void btnAddRecord_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddEmployee());
        }

        private async void lstData_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                EmployeeModel obj = (EmployeeModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");


                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new AddEmployee(obj));
                        break;

                    case "Delete":
                        viewModel.DeleteEmployee(obj);
                        showEmployeePage();
                        break;
                }
                lstData.SelectedItem = null;
            }
        }
    }
}
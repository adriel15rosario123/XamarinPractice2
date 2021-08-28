using Practice2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practice2.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; }
        public ICommand ShowSignUpPageCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            ShowSignUpPageCommand = new Command(ShowSignUpPage);
        }

        public async void Login()
        {
            if (String.IsNullOrWhiteSpace(Email) && String.IsNullOrWhiteSpace(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "the username and password are empty", "Ok");
                
            }
            else if (String.IsNullOrWhiteSpace(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "the username is empty", "Ok");
            }
            else if (String.IsNullOrWhiteSpace(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "the password is empty", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Email, "Ok");
            }
        }

        public async void ShowSignUpPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practice2.ViewModels
{
    class SignUpViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegistryCommand { get; }

        public SignUpViewModel()
        {
            RegistryCommand = new Command(Registry);
        }

        public async void Registry()
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email)
                 && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(ConfirmPassword))
            {

                if (Password == ConfirmPassword)
                {
                    await App.Current.MainPage.DisplayAlert("", $"Bienvenido, {Name}!","Ok");

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden, favor introducirlas nuevamente","Ok");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Faltan campos por llenar, favor verifique e intente de nuevo","Ok");
            }
        }
    }
}

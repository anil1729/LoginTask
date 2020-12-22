using LoginTask.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginTask.ViewModel
{
  public  class LoginPageViewModel
    {
        public LoginPageViewModel() 
        {
            _LoginButton = new Command(loginOperation);
        }
        private  void loginOperation()
        {
            if (!string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_Password))
            {
               App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else
            {
               App.Current.MainPage.DisplayAlert("Login Faild", "Invalid UserName & password", "Ok");
            }
        }
        private ICommand _LoginButton;
        public ICommand LoginButton 
        {
            set
            {
                _LoginButton = value;
            }
            get 
            {
                return _LoginButton;
            }
        }
        private string _UserName;
        public string UserName
        {
            set{
                _UserName = value;
            }
            get{
                return _UserName;
            }
        }

        private string _Password;
        public string Password
        {
            set {
                _Password = value;
            }
            get {
                return _Password;
            }
        }
    }
}

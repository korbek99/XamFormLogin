using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamFormLogin.Models;

namespace XamFormLogin.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_UserName.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
           // LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_UserName.Completed += (sender, e) => Entry_Password.Focus();
            Entry_Password.Completed += (sender, e) => SignInProcedure(sender, e);
        }
        private void SignInProcedure(object sender , EventArgs e)
        {
            User user = new User(Entry_UserName.Text, Entry_Password.Text);
            if(user.checkInformation())
            {
                DisplayAlert("Login","Login Success","Ok");
                App.Userdatabase.SaveUser(user);

            }else{

                DisplayAlert("Login", "Login Not Correct , empty field", "Ok");
            }
        }


    }
}

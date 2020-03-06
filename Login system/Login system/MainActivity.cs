using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace Login_system
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnSignUp;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            btnSignUp.Click += BtnSignUp_Click;
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            //Pull up dialog
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            dialog_SignUp signUpDialog = new dialog_SignUp();
            signUpDialog.Show(transaction, "Dialog fragment");
        }
    }
}
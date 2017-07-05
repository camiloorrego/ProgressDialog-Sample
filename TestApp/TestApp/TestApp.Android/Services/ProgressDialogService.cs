using Android.App;
using System;
using System.Threading;
using TestApp.Interfaces;
using Xamarin.Forms;

namespace TestApp.Droid.Services
{
    public class ProgressDialogService : IProgressDialog
    {
        public ProgressDialog ProgressDialog { get; set; }
        public void HideProgress()
        {

            new Thread(new ThreadStart(delegate
            {
                var activity = (Activity)Forms.Context;
                activity.RunOnUiThread(() =>
                {
                    ProgressDialog.Hide();
                });
            })).Start();
        }

        public void ShowProgress()
        {

            new Thread(new ThreadStart(delegate
            {
                var activity = (Activity)Forms.Context;
                activity.RunOnUiThread(() =>
                {
                    if (ProgressDialog == null)
                    {
                        ProgressDialog = ProgressDialog.Show(Forms.Context, "Please wait...", "Checking account info...", true);
                    }
                    else {
                        ProgressDialog.Show();
                    }

                });


            })).Start();


        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NotreApp2._0
{
    [Activity(Label = "Mizik", Theme = "@android:style/Theme.Light.NoTitleBar.Fullscreen")]
    public class Mizik : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MizkMwen);
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;

            var mizik = FindViewById<VideoView>(Resource.Id.MizikLa);
            mizik.Visibility = Android.Views.ViewStates.Invisible;
            //Teste internet
            var uri = Android.Net.Uri.Parse("http://ia600507.us.archive.org/25/items/Cartoontheater1930sAnd1950s1/PigsInAPolka1943.mp4");
            //Notre serveur Living Musem
            //var uri = Android.Net.Uri.Parse("http://192.168.2.2/Music/nokia.mp4");
            mizik.SetVideoURI(uri);

            var playButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonPlay);
            var pauseButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonPause);
            var replayButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonReplay);
            var backHome = FindViewById<Button>(Resource.Id.devirez);
            replayButton.Visibility = Android.Views.ViewStates.Invisible;
            playButton.Click += delegate
            {
                mizik.Start();
                replayButton.Visibility = Android.Views.ViewStates.Visible;
                mizik.Visibility = Android.Views.ViewStates.Visible;
            };
            pauseButton.Click += delegate
            {
                mizik.Pause();

            };
            replayButton.Click += delegate
            {
                mizik.Resume();
                mizik.Start();
            };
            backHome.Click += delegate
              {
                  Intent enKayLa= new Intent(this, typeof(MainActivity));
                  StartActivity(enKayLa);
                  //this.Finish();
              };
        }
    }
}
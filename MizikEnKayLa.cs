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
using Android.Media;
namespace NotreApp2._0
{
    [Activity(Label = "MizikEnKayLa",Theme = "@android:style/Theme.Light.NoTitleBar.Fullscreen")]
    public class MizikEnKayLa : Activity
    {
        MediaPlayer _sonMwen;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            SetContentView(Resource.Layout.Page4);
            _sonMwen = MediaPlayer.Create(this, Resource.Drawable.Mizik);
            var playButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonPlayM);
            var pauseButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonPauseM);
            var stopButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonStopM);
            var replayButton = FindViewById<ImageButton>(Resource.Id.ImaBoutonReplayM);
            var backHome = FindViewById<Button>(Resource.Id.devirez);
            
            replayButton.Visibility = ViewStates.Invisible;
            stopButton.Visibility = ViewStates.Invisible;

            playButton.Click += delegate
            {
                _sonMwen.Start();
                stopButton.Visibility = ViewStates.Visible;
            };

            pauseButton.Click += delegate
            {
                _sonMwen.Pause();
            };

            stopButton.Click += delegate
            {
                _sonMwen.Stop();
                replayButton.Visibility = ViewStates.Visible;
                playButton.Visibility = ViewStates.Invisible;
                pauseButton.Visibility = ViewStates.Invisible;
            };

            replayButton.Click += delegate
            {
                _sonMwen.Prepare();
                _sonMwen.Start();
                playButton.Visibility = ViewStates.Visible;
                pauseButton.Visibility = ViewStates.Visible;
            };

            backHome.Click += delegate
            {
                Intent enKayLa = new Intent(this, typeof(MainActivity));
                StartActivity(enKayLa);
                _sonMwen.Release();
                //this.Finish();
            };
        }
    }
}
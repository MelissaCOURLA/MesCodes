using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Net;
using static Java.Text.Normalizer;

namespace NotreApp2._0
{
    [Activity(Label = "Démo présentation", MainLauncher = true, Theme = "@android:style/Theme.Light.NoTitleBar.Fullscreen")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
              {
                  Intent Image = new Intent(this, typeof(Image));
                  StartActivity(Image);
              };
            var button = FindViewById<ImageButton>(Resource.Id.imageButton1);
            button.Click += delegate
              {
                  Intent ImageAnko = new Intent(this, typeof(Image2));
                  StartActivity(ImageAnko);

              };
            //audio en dure 
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            button4.Click += delegate
              {
                  Intent MizikLockal = new Intent(this, typeof(MizikEnKayLa));
                  StartActivity(MizikLockal);

              };
            //audio depuis serve
            
            


      
        }



    }
}


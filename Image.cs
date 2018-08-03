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
    [Activity(Label = "Image", Theme = "@android:style/Theme.Light.NoTitleBar.Fullscreen")]
    public class Image : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Image);

            RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
            var imageView = FindViewById<ImageView>(Resource.Id.imageView2);
            //Retour main
            Button buttonMusique = FindViewById<Button>(Resource.Id.button2);
            buttonMusique.Click += delegate
            {
                Intent JoueMizikLa = new Intent(this, typeof(Mizik));
                StartActivity(JoueMizikLa);
            };
            Button enKayLa = FindViewById<Button>(Resource.Id.DevirezImage);
            enKayLa.Click += delegate
              {
                 this.Finish();
              };
        }
    }
}
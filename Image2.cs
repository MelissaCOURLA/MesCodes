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
    [Activity(Label = "Image2", Theme = "@android:style/Theme.Light.NoTitleBar.Fullscreen")]
    public class Image2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Page3);
            var imageView = FindViewById<ImageView>(Resource.Id.imageView3);
            //Retour main
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            button3.Click += delegate
            {
                this.Finish();
            };
        }
    }
}
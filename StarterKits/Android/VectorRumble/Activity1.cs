using System;

using Android.App;
using Android.OS;

namespace VectorRumble
{
	[Activity (Label = "VectorRumble", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
	{
		protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            VectorRumbleGame.Activity = this;
            VectorRumbleGame g = new VectorRumbleGame();
            SetContentView(g.Window);
            g.Run();
        }
	}
}



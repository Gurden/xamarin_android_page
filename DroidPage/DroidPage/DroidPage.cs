﻿using System;
using Xamarin.Forms;

namespace DroidPage
{
	public class App : Application
	{
		public App() { this.MainPage = new NavigationPage( new MainPage() ); }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module02_Activity02.View.Gesture
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class gestureimage : ContentPage
	{
		public gestureimage ()
		{
			InitializeComponent ();
		}

		async void OnCorrectDrop(object sender, DropEventArgs e)
		{
			await DisplayAlert("Correct", "You are right!", "Ok");
		}

		void OnIncorrectDragOver(object sender, DragEventArgs e)
		{
			e.AcceptedOperation = DataPackageOperation.None;
		}
	}
}
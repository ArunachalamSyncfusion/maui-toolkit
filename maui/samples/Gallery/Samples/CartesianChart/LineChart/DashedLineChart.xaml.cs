﻿namespace Syncfusion.Maui.ControlsGallery.CartesianChart.SfCartesianChart
{
	public partial class DashedLineChart : SampleView
	{
		public DashedLineChart()
		{
			InitializeComponent();
		}

		public override void OnAppearing()
		{
			base.OnAppearing();
#if IOS
			if (IsCardView)
			{
				Chart1.WidthRequest = 350;
				Chart1.HeightRequest = 400;
				Chart1.VerticalOptions = LayoutOptions.Start;
			}
#endif
		}

		public override void OnDisappearing()
		{
			base.OnDisappearing();
			Chart1.Handler?.DisconnectHandler();
		}
	}
}

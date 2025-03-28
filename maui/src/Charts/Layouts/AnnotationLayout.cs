﻿using Syncfusion.Maui.Toolkit.Graphics.Internals;

namespace Syncfusion.Maui.Toolkit.Charts
{
	internal partial class AnnotationLayout : AbsoluteLayout
	{
		#region Fields

		readonly SfDrawableView _annotationDrawer;

		#endregion

		#region Constructor

		internal AnnotationLayout(SfCartesianChart chart)
		{
			_annotationDrawer = new AnnotationDrawableView(chart);
			AbsoluteLayout.SetLayoutBounds(_annotationDrawer, new Rect(0, 0, 1, 1));
			AbsoluteLayout.SetLayoutFlags(_annotationDrawer, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.All);
			Children.Add(_annotationDrawer);
		}

		#endregion

		#region Methods

		#region Internal Methods

		internal void InvalidateDrawable()
		{
			_annotationDrawer.InvalidateDrawable();
		}

		#endregion

		#endregion
	}

	internal partial class AnnotationDrawableView : SfDrawableView
	{
		#region Fields

		readonly SfCartesianChart _chart;

		#endregion

		#region Constructor

		internal AnnotationDrawableView(SfCartesianChart chart)
		{
			_chart = chart;
		}

		#endregion

		#region Methods

		#region Protected Methods

		protected override void OnDraw(ICanvas canvas, RectF dirtyRect)
		{
			if (_chart != null)
			{
				foreach (var annotation in _chart.Annotations)
				{
					if (annotation.IsVisible)
					{
						canvas.CanvasSaveState();
						annotation.Draw(canvas, dirtyRect);
						canvas.CanvasRestoreState();
					}
				}
			}
		}

		#endregion

		#endregion
	}
}
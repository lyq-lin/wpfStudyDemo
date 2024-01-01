using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace AdornerDemo
{
	internal class CustomAdorner : Adorner
	{
		public CustomAdorner(UIElement adornedElement) : base(adornedElement)
		{
		}

		protected override void OnRender(DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);

			Rect adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

			// Some arbitrary drawing implements.
			var renderBrush = new SolidColorBrush(Colors.Green);
			renderBrush.Opacity = 0.2;
			var renderPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
			var renderRadius = 5.0;

			// Draw a circle at each corner.
			drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
			drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
			drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
			drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
		}
	}
}

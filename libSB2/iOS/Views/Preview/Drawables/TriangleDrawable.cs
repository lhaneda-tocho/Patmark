﻿using System;

using UIKit;
using CoreGraphics;
using CoreAnimation;
using Foundation;

using TokyoChokoku.MarkinBox.Sketchbook.Fields;
using TokyoChokoku.MarkinBox.Sketchbook.Parameters;


namespace TokyoChokoku.MarkinBox.Sketchbook.iOS
{
	public class TriangleDrawable : FieldDrawable
	{
		private readonly TriangleParameter p;


        private readonly float  baseX;
        private readonly float  baseY;
        private readonly float  angle;


		private readonly CGPoint[] rectanglePoints;
		private readonly CGPoint[] trianglePoints;


        public TriangleDrawable (Triangle.Constant mbobject)
		{
			this.p = mbobject.Parameter;


            this.baseX = (float)p.X;
            this.baseY = (float)p.Y;
            this.angle = (float)p.Angle;


            var transform = FieldCanvas.MakeIdentity ();
            transform = FieldCanvas.Translate (transform, baseX, baseY);
            transform = FieldCanvas.Rotate    (transform, -angle);

			var rectanglePoints = CreateRectangle ();
			for (int i = 0; i < rectanglePoints.Length; i++) {
				rectanglePoints [i] = transform.TransformPoint (rectanglePoints [i]);
			}

			var trianglePoints = CreateTriangle ();
			for (int i = 0; i < trianglePoints.Length; i++) {
                trianglePoints [i] = transform.TransformPoint  (trianglePoints [i]);
			}

			this.rectanglePoints = rectanglePoints;
			this.trianglePoints  = trianglePoints;
		}


        public void Draw (FieldCanvas canvas)
		{
			var canvasView = canvas.CanvasViewMatrix;
			var viewPoints = Transform (canvasView, trianglePoints);


			canvas.Context.SaveState ();

    			canvas.Context.BeginPath  ();
    			canvas.Context.AddLines   (viewPoints);
    			canvas.Context.ClosePath  ();
    			canvas.Context.StrokePath ();

			canvas.Context.RestoreState ();
		}


        public void DrawBorder (FieldCanvas canvas)
		{
			var canvasView = canvas.CanvasViewMatrix;
			var viewPoints = Transform (canvasView, rectanglePoints);

			canvas.Context.SaveState ();

			canvas.Context.BeginPath ();
			canvas.Context.AddLines (viewPoints);
			canvas.Context.ClosePath ();
			canvas.Context.StrokePath ();

			canvas.Context.RestoreState ();
		}


        public void DrawBasePoint (FieldCanvas canvas)
        {
            canvas.DrawBasePoint (canvas.CanvasViewMatrix, baseX, baseY);
		}


		private static CGPoint[] Transform (CGAffineTransform matrix, CGPoint[] points) {
			points = (CGPoint[]) points.Clone ();

			for (int i = 0; i < points.Length; i++) {
				points [i] = matrix.TransformPoint (points [i]);
			}

			return points;
		}


		private CGPoint[] CreateRectangle () {
			nfloat x, y, width, height;

			width  = (nfloat)p.Width;
			height = (nfloat)p.Height;


			switch (p.BasePoint) {
			default:
			case Consts.FieldBasePointLB:
			case Consts.FieldBasePointLM:
			case Consts.FieldBasePointLT:
				x = 0;
				break;

			case Consts.FieldBasePointCB:
			case Consts.FieldBasePointCM:
			case Consts.FieldBasePointCT:
				x = -width / 2;
				break;

			case Consts.FieldBasePointRB:
			case Consts.FieldBasePointRM:
			case Consts.FieldBasePointRT:
				x = -width;
				break;
			}

			switch (p.BasePoint) {
			default:
			case Consts.FieldBasePointLT:
			case Consts.FieldBasePointCT:
			case Consts.FieldBasePointRT:
				y = 0;
				break;

			case Consts.FieldBasePointLM:
			case Consts.FieldBasePointCM:
			case Consts.FieldBasePointRM:
				y = -height / 2;
				break;

			case Consts.FieldBasePointLB:
			case Consts.FieldBasePointCB:
			case Consts.FieldBasePointRB:
				y = -height;
				break;
			}

			return new CGPoint[] {
				new CGPoint (x        ,            y),
				new CGPoint (x + width,            y),
				new CGPoint (x + width,   height + y),
				new CGPoint (x        ,   height + y)
			};
		}



		private CGPoint[] CreateTriangle () {
			nfloat x, y, width, height, hornX;

			width  = (nfloat)p.Width;
			height = (nfloat)p.Height;
			hornX  = (nfloat)p.HornX;

			switch (p.BasePoint) {
			default:
			case Consts.FieldBasePointLB:
			case Consts.FieldBasePointLM:
			case Consts.FieldBasePointLT:
				x = 0;
				break;

			case Consts.FieldBasePointCB:
			case Consts.FieldBasePointCM:
			case Consts.FieldBasePointCT:
				x = -width / 2;
				break;

			case Consts.FieldBasePointRB:
			case Consts.FieldBasePointRM:
			case Consts.FieldBasePointRT:
				x = -width;
				break;
			}

			switch (p.BasePoint) {
			default:
			case Consts.FieldBasePointLT:
			case Consts.FieldBasePointCT:
			case Consts.FieldBasePointRT:
				y = 0;
				break;

			case Consts.FieldBasePointLM:
			case Consts.FieldBasePointCM:
			case Consts.FieldBasePointRM:
				y = -height / 2;
				break;

			case Consts.FieldBasePointLB:
			case Consts.FieldBasePointCB:
			case Consts.FieldBasePointRB:
				y = -height;
				break;
			}

			return new CGPoint[] {
				new CGPoint (    hornX,            y),
				new CGPoint (x + width,   height + y),
				new CGPoint (x        ,   height + y)
			};
		}
	}
}


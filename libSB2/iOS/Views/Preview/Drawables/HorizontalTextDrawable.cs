﻿using System;

using CoreGraphics;
using UIKit;
using Foundation;

using TokyoChokoku.MarkinBox.Sketchbook.Parameters;
using TokyoChokoku.MarkinBox.Sketchbook.Fields;

namespace TokyoChokoku.MarkinBox.Sketchbook.iOS
{
	public class HorizontalTextDrawable : FieldDrawable
	{
		private readonly HorizontalTextParameter p;
        private readonly RootFieldTextNode       parsed;

        private readonly float  baseX;
        private readonly float  baseY;
        private readonly float  angle;

        private readonly float  oneCharWidth;
        private readonly float  oneCharHeight;
        private readonly float  pitchBetweenChars;

        private readonly float  boxWidth ;
        private readonly float  boxHeight;

        private readonly Cartesian2D drawStartFromBasePoint;

        public HorizontalTextDrawable (HorizontalText.Constant mbobject)
		{
			p = mbobject.Parameter;
            parsed = p.ParseText ();


            baseX = (float)p.X;
            baseY = (float)p.Y;
            angle = (float)p.Angle;

            oneCharWidth = (float)p.Width;
            oneCharHeight = (float)p.Height;
            pitchBetweenChars = (float)p.Pitch;

            boxWidth  = p.BoxWidth;
            boxHeight = p.BoxHeight;

            drawStartFromBasePoint = DrawStartFromBasePoint;
		}

        public void Draw (FieldCanvas canvas)
		{
            var m = canvas.CanvasViewMatrix;

            m = FieldCanvas.Translate (m, baseX, baseY);
            m = FieldCanvas.Rotate    (m, -angle);

            m = FieldCanvas.Translate (m, drawStartFromBasePoint.X, drawStartFromBasePoint.Y);

			// 描画
            DrawText (
                canvas,
                m,
                parsed,
                oneCharWidth,
                oneCharHeight,
                pitchBetweenChars,
                p.Mirrored);
		}


        private void DrawText(
            FieldCanvas canvas,
            CGAffineTransform transform,
            RootFieldTextNode root,
            float textWidth,
            float textHeight,
            float pitch,
            bool mirrored)
        {
            if (mirrored) {
                transform = FieldCanvas.XAxisMirror( transform, boxWidth/2 );
            }

            canvas.DrawFieldTextNode (root, (index) => {
                var m = transform;
                m = FieldCanvas.Translate (m, pitch * index, 0);
                m = FieldCanvas.Scale (m, textWidth, textHeight);
                return m;
            });
        }



        public void DrawBorder (FieldCanvas canvas)
		{
            var m = canvas.CanvasViewMatrix;

			CGPoint[] vertices = {
                new CGPoint (      0 ,         0),
                new CGPoint (boxWidth,         0),
                new CGPoint (boxWidth, boxHeight),
                new CGPoint (       0, boxHeight),
			};


			// ベースポイントの位置と回転を設定する．
			m = FieldCanvas.Translate (m, baseX, baseY);
            m = FieldCanvas.Rotate    (m, -angle);


			// 描画開始位置まで 移動する．
			var start = drawStartFromBasePoint;
            m = FieldCanvas.Translate (m, start.X, start.Y);


			// 描画
            canvas.DrawLoopedLines (m, vertices);
		}


        public void DrawBasePoint (FieldCanvas canvas)
		{
            canvas.DrawBasePoint (canvas.CanvasViewMatrix, baseX, baseY);
		}


		private Cartesian2D DrawStartFromBasePoint 
		{
			get {
				double startX, startY;

				switch (p.BasePoint) {
				default:
				case Consts.FieldBasePointLB:
					startX = 0f;
					startY = -p.BoxHeight;
					break;

				case Consts.FieldBasePointLM:
					startX = 0f;
					startY = -p.BoxHeight / 2;
					break;

				case Consts.FieldBasePointLT:
					startX = 0f;
					startY = 0f;
					break;

				case Consts.FieldBasePointCB:
					startX = -p.BoxWidth / 2;
					startY = -p.BoxHeight;
					break;

				case Consts.FieldBasePointCM:
					startX = -p.BoxWidth / 2;
					startY = -p.BoxHeight / 2;
					break;

				case Consts.FieldBasePointCT:
					startX = -p.BoxWidth / 2;
					startY = 0f;
					break;

				case Consts.FieldBasePointRB:
					startX = -p.BoxWidth;
					startY = -p.BoxHeight;
					break;

				case Consts.FieldBasePointRM:
					startX = -p.BoxWidth;
					startY = -p.BoxHeight / 2;
					break;

				case Consts.FieldBasePointRT:
					startX = -p.BoxWidth;
					startY = 0f;
					break;
				}

				return new Cartesian2D (startX, startY);
			}
		}

	}
}


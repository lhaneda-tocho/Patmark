﻿﻿// 
// This code is generated by template.
// Not allowed to modify this code because your changes are deleted when in regeration.
// 

namespace TokyoChokoku.MarkinBox.Sketchbook.Validators {
    using System;
    using TokyoChokoku.MarkinBox.Sketchbook.Parameters;

	public abstract partial class MarkingValidator {
    
        public static MarkingValidator CreateOfHorizontalText (IBaseHorizontalTextParameter param) {
            return new OfHorizontalTextParameter (param);
        }


        private class OfHorizontalTextParameter : MarkingValidator {
            IBaseHorizontalTextParameter p;

            public OfHorizontalTextParameter (IBaseHorizontalTextParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfYVerticalText (IBaseYVerticalTextParameter param) {
            return new OfYVerticalTextParameter (param);
        }


        private class OfYVerticalTextParameter : MarkingValidator {
            IBaseYVerticalTextParameter p;

            public OfYVerticalTextParameter (IBaseYVerticalTextParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfXVerticalText (IBaseXVerticalTextParameter param) {
            return new OfXVerticalTextParameter (param);
        }


        private class OfXVerticalTextParameter : MarkingValidator {
            IBaseXVerticalTextParameter p;

            public OfXVerticalTextParameter (IBaseXVerticalTextParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfInnerArcText (IBaseInnerArcTextParameter param) {
            return new OfInnerArcTextParameter (param);
        }


        private class OfInnerArcTextParameter : MarkingValidator {
            IBaseInnerArcTextParameter p;

            public OfInnerArcTextParameter (IBaseInnerArcTextParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfOuterArcText (IBaseOuterArcTextParameter param) {
            return new OfOuterArcTextParameter (param);
        }


        private class OfOuterArcTextParameter : MarkingValidator {
            IBaseOuterArcTextParameter p;

            public OfOuterArcTextParameter (IBaseOuterArcTextParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfQrCode (IBaseQrCodeParameter param) {
            return new OfQrCodeParameter (param);
        }


        private class OfQrCodeParameter : MarkingValidator {
            IBaseQrCodeParameter p;

            public OfQrCodeParameter (IBaseQrCodeParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfDataMatrix (IBaseDataMatrixParameter param) {
            return new OfDataMatrixParameter (param);
        }


        private class OfDataMatrixParameter : MarkingValidator {
            IBaseDataMatrixParameter p;

            public OfDataMatrixParameter (IBaseDataMatrixParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfRectangle (IBaseRectangleParameter param) {
            return new OfRectangleParameter (param);
        }


        private class OfRectangleParameter : MarkingValidator {
            IBaseRectangleParameter p;

            public OfRectangleParameter (IBaseRectangleParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfTriangle (IBaseTriangleParameter param) {
            return new OfTriangleParameter (param);
        }


        private class OfTriangleParameter : MarkingValidator {
            IBaseTriangleParameter p;

            public OfTriangleParameter (IBaseTriangleParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfCircle (IBaseCircleParameter param) {
            return new OfCircleParameter (param);
        }


        private class OfCircleParameter : MarkingValidator {
            IBaseCircleParameter p;

            public OfCircleParameter (IBaseCircleParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfLine (IBaseLineParameter param) {
            return new OfLineParameter (param);
        }


        private class OfLineParameter : MarkingValidator {
            IBaseLineParameter p;

            public OfLineParameter (IBaseLineParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfBypass (IBaseBypassParameter param) {
            return new OfBypassParameter (param);
        }


        private class OfBypassParameter : MarkingValidator {
            IBaseBypassParameter p;

            public OfBypassParameter (IBaseBypassParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        public static MarkingValidator CreateOfEllipse (IBaseEllipseParameter param) {
            return new OfEllipseParameter (param);
        }


        private class OfEllipseParameter : MarkingValidator {
            IBaseEllipseParameter p;

            public OfEllipseParameter (IBaseEllipseParameter p) {
                this.p = p;
            }

            protected override short Speed { get {
                return p.Speed;
            }}
            protected override short Power { get {
                return p.Power;
            }}
            protected override bool  Pause { get {
                return p.Pause;
            }}
        }


        
    }
}
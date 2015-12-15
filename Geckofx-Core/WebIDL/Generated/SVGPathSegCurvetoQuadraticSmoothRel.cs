namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegCurvetoQuadraticSmoothRel : WebIDLBase
    {
        
        public SVGPathSegCurvetoQuadraticSmoothRel(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public float X
        {
            get
            {
                return this.GetProperty<float>("x");
            }
            set
            {
                this.SetProperty("x", value);
            }
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
    }
}

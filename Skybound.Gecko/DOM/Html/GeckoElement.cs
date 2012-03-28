using System.Drawing;

namespace Gecko
{
	/// <summary>
	/// Represents a DOM HTML element.
	/// </summary>
	public class GeckoElement
		: GeckoDomElement
	{
		internal GeckoElement(nsIDOMHTMLElement element)
			: base(element)
		{
			this.DomElement = element;			
		}
		
		internal static GeckoElement Create(nsIDOMHTMLElement element)
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor(element);
		}

		internal static T Create<T>(nsIDOMHTMLElement element) where T : GeckoElement 
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor<T>(element);
		}
		
		nsIDOMHTMLElement DomElement;		
		
		/// <summary>
		/// Gets the inline style of the GeckoElement. 
		/// </summary>
		public GeckoStyle Style
		{
			get
			{
				return GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject).GetStyleAttribute());
			}
		}
		
		/// <summary>
		/// Gets the parent element of this one.
		/// </summary>
		public GeckoElement Parent
		{
			get
			{
				// note: the parent node could also be the document
				return GeckoElement.Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(DomElement.GetParentNodeAttribute()));
			}
		}


		
		/// <summary>
		/// Gets the value of the id attribute.
		/// </summary>
		public string Id
		{
			get { return nsString.Get(DomElement.GetIdAttribute); }
			set 
			{				
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("id");
				else
					nsString.Set(DomElement.SetIdAttribute, value); 
			}
		}
		
		/// <summary>
		/// Gets the value of the class attribute.
		/// </summary>
		public string ClassName
		{
			get { return nsString.Get(DomElement.GetClassNameAttribute); }
			set 
			{
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("class");
				else
					nsString.Set(DomElement.SetClassNameAttribute, value); 
			}
		}

		public void Blur()
		{
			DomElement.Blur();
		}

		public void Focus()
		{
			DomElement.Focus();
		}

		public void Click()
		{
			DomElement.Click();
		}
	
		/// <summary>
		/// Get the value of the ContentEditable Attribute
		/// </summary>
		public string ContentEditable
		{
			get { return nsString.Get(DomElement.GetContentEditableAttribute); }
			set { nsString.Set(DomElement.GetContentEditableAttribute, value); }
		}
		

		
		public System.Drawing.Rectangle BoundingClientRect
		{
			get
			{
				nsIDOMClientRect domRect = DomElement.GetBoundingClientRect();
				var r = new Rectangle((int)domRect.GetLeftAttribute(), (int)domRect.GetTopAttribute(), (int)domRect.GetWidthAttribute(), (int)domRect.GetHeightAttribute());
				return r;				
			}
		}

		public int ScrollLeft { get { return DomElement.GetScrollLeftAttribute(); } set { DomElement.SetScrollLeftAttribute(value); } }
		public int ScrollTop { get { return DomElement.GetScrollTopAttribute(); } set { DomElement.SetScrollTopAttribute(value); } }
		public int ScrollWidth { get { return DomElement.GetScrollWidthAttribute(); } }
		public int ScrollHeight { get { return DomElement.GetScrollHeightAttribute(); } }
		public int ClientWidth { get { return DomElement.GetClientWidthAttribute(); } }
		public int ClientHeight { get { return DomElement.GetClientHeightAttribute(); } }

		public int OffsetLeft { get { return DomElement.GetOffsetLeftAttribute(); } }
		public int OffsetTop { get { return DomElement.GetOffsetTopAttribute(); } }
		public int OffsetWidth { get { return DomElement.GetOffsetWidthAttribute(); } }
		public int OffsetHeight { get { return DomElement.GetOffsetHeightAttribute(); } }
		
		public GeckoElement OffsetParent
		{
			get { return GeckoElement.Create((nsIDOMHTMLElement)DomElement.GetOffsetParentAttribute()); }
		}
		
		public void ScrollIntoView(bool top)
		{
			DomElement.ScrollIntoView(top, 1);
		}
		
		public string InnerHtml
		{
			get { return nsString.Get(DomElement.GetInnerHTMLAttribute); }
			set { nsString.Set(DomElement.SetInnerHTMLAttribute, value); }
		}

		public virtual string OuterHtml
		{
			get { return nsString.Get(DomElement.GetOuterHTMLAttribute); }			
		}
		
		public int TabIndex
		{
			get { return DomElement.GetTabIndexAttribute(); }
			set { DomElement.SetTabIndexAttribute(value); }
		}
	}
}
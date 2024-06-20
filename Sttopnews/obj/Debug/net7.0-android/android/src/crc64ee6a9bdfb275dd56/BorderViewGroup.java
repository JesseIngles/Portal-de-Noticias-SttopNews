package crc64ee6a9bdfb275dd56;


public class BorderViewGroup
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dispatchDraw:(Landroid/graphics/Canvas;)V:GetDispatchDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Xe.AcrylicView.Platforms.Android.Drawable.BorderViewGroup, Xe.AcrylicView", BorderViewGroup.class, __md_methods);
	}


	public BorderViewGroup (android.content.Context p0)
	{
		super (p0);
		if (getClass () == BorderViewGroup.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.BorderViewGroup, Xe.AcrylicView", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public BorderViewGroup (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == BorderViewGroup.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.BorderViewGroup, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public BorderViewGroup (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == BorderViewGroup.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.BorderViewGroup, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public BorderViewGroup (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == BorderViewGroup.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.BorderViewGroup, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void dispatchDraw (android.graphics.Canvas p0)
	{
		n_dispatchDraw (p0);
	}

	private native void n_dispatchDraw (android.graphics.Canvas p0);


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

package crc64ee6a9bdfb275dd56;


public class CornerFrameLayout
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Xe.AcrylicView.Platforms.Android.Drawable.CornerFrameLayout, Xe.AcrylicView", CornerFrameLayout.class, __md_methods);
	}


	public CornerFrameLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CornerFrameLayout.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.CornerFrameLayout, Xe.AcrylicView", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public CornerFrameLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CornerFrameLayout.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.CornerFrameLayout, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public CornerFrameLayout (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CornerFrameLayout.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.CornerFrameLayout, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public CornerFrameLayout (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == CornerFrameLayout.class) {
			mono.android.TypeManager.Activate ("Xe.AcrylicView.Platforms.Android.Drawable.CornerFrameLayout, Xe.AcrylicView", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);

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

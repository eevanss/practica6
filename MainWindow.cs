using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtn1Clicked (object sender, EventArgs e)
	{
		double pr1 = double.Parse (this.p1.Text);
		double pr2 = double.Parse (this.p2.Text);
		double pr3 = double.Parse (this.p3.Text);

		double sub1 =pr1+pr2+pr3;
		this.sub.Text=sub1.ToString ();
		double iva1 = sub1*.16;
		this.iva.Text=iva1.ToString ();
		double total1 = sub1 + iva1;
		this.total.Text=total1.ToString ();

	}

	protected void OnBtn2Clicked (object sender, EventArgs e)
	{
		this.p1.Text="";
		this.p2.Text="";
		this.p3.Text="";
		this.sub.Text="";
		this.iva.Text="";
		this.total.Text="";
	}
}

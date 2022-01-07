using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    //Point noPoint;
    //Random ran;
    //Lul lal;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonMessageClicked(object sender, EventArgs e)
    {
        this.Title = "Ga-ga Buuuu";

    }
}

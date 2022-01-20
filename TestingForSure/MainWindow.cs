using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using Gtk;
using PdfSharp.Pdf;

public partial class MainWindow : Gtk.Window
{

    PdfDocument pdf = new PdfDocument();

    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();


    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //protected void OnLoadEvent(object sender, Loa)

    protected void OnButtonMessageClicked(object sender, EventArgs e)
    {
        this.Title = "New program 2022";

        NewMessage("it works");

        //string man = fixed1.ToString();
        //var bmp = (Bitmap)System.Drawing.Image.FromFile("/home/mikey/Desktop/Pictures/flower.jpg");

        //Gtk.Image img = new Gtk.Image("/home/mikey/Desktop/Pictures/flower.jpg");

        //imageLoadPic = img;
        //imageLoadPic.Show();

        //imageLoadPic.SetFromImage((Gtk.I)bmp, null);


        imageLoadPic.Pixbuf = new Gdk.Pixbuf("./flower.jpeg");

        
    }

    // MessageBox for Mono
    void NewMessage(string message)
    {
        MessageDialog messageBox = new MessageDialog(
        this,
        DialogFlags.DestroyWithParent,
        MessageType.Info,
        ButtonsType.Ok,
        message);

        messageBox.Run();
        messageBox.Destroy();
    }

    protected void OnButtonCalculateSumClicked(object sender, EventArgs e)
    {
        CalculateNow();
    }

    // calculate
    private void CalculateNow()
    {

        labelResult.Text = GetSumOfNumbers(comboboxArithmetic.ActiveText, float.Parse(spinbuttonNum1.Text), float.Parse(TextBoxSecondNum2.Text)).ToString();
    }

    // arithmetic
    private float GetSumOfNumbers(string operation, float num1, float num2)
    {
        float result = 0f;

        if(operation == "+")
        {
            result = num1 + num2;
        }
        else if(operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            result = num1 / num2;
        }

        return result;
    }

    protected void OnImageLoadPicButtonReleaseEvent(object o, ButtonReleaseEventArgs args)
    {
        Debug.WriteLine("image load event works");
    }

    protected void OnDefaultActivated(object sender, EventArgs e)
    {
        this.Title = "yes default load";
    }

    protected void OnFixed1ScrollEvent(object o, ScrollEventArgs args)
    {

    }

    protected void OnFixed1DragDrop(object o, DragDropArgs args)
    {
        NewMessage("drag drop works");
    }

    protected void OnFixed1DragBegin(object o, DragBeginArgs args)
    {
        NewMessage("drag begin works");
    }

    protected void OnDragDrop(object o, DragDropArgs args)
    {
        NewMessage("drag drop MainWindow works");
    }
}

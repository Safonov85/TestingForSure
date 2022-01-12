using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    public MainWindow() : base(Gtk.WindowType.Toplevel) => Build();

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonMessageClicked(object sender, EventArgs e)
    {
        this.Title = "New program 2022";

        NewMessage();

    }

    void NewMessage()
    {
        MessageDialog messageBox = new MessageDialog(
        this,
        DialogFlags.DestroyWithParent,
        MessageType.Info,
        ButtonsType.Ok,
        "MessageBox Works!");

        messageBox.Run();
        messageBox.Destroy();
    }

    protected void OnButtonCalculateSumClicked(object sender, EventArgs e)
    {
        CalculateNow();
    }

    void CalculateNow()
    {

        labelResult.Text = GetSumOfNumbers(comboboxArithmetic.ActiveText, float.Parse(spinbuttonNum1.Text), float.Parse(TextBoxSecondNum2.Text)).ToString();
    }

    float GetSumOfNumbers(string operation, float num1, float num2)
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
}


// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button ButtonMessage;

	private global::Gtk.SpinButton spinbuttonNum1;

	private global::Gtk.ComboBox comboboxArithmetic;

	private global::Gtk.Entry TextBoxSecondNum2;

	private global::Gtk.Button ButtonCalculateSum;

	private global::Gtk.Label labelResult;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ButtonMessage = new global::Gtk.Button();
		this.ButtonMessage.CanFocus = true;
		this.ButtonMessage.Name = "ButtonMessage";
		this.ButtonMessage.UseUnderline = true;
		this.ButtonMessage.FocusOnClick = false;
		this.ButtonMessage.Label = global::Mono.Unix.Catalog.GetString("      Try     ");
		this.fixed1.Add(this.ButtonMessage);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.ButtonMessage]));
		w1.X = 66;
		w1.Y = 57;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.spinbuttonNum1 = new global::Gtk.SpinButton(0D, 100D, 1D);
		this.spinbuttonNum1.CanFocus = true;
		this.spinbuttonNum1.Name = "spinbuttonNum1";
		this.spinbuttonNum1.Adjustment.PageIncrement = 10D;
		this.spinbuttonNum1.ClimbRate = 1D;
		this.spinbuttonNum1.Numeric = true;
		this.spinbuttonNum1.Value = 1D;
		this.fixed1.Add(this.spinbuttonNum1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.spinbuttonNum1]));
		w2.X = 85;
		w2.Y = 132;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxArithmetic = global::Gtk.ComboBox.NewText();
		this.comboboxArithmetic.AppendText(global::Mono.Unix.Catalog.GetString("+"));
		this.comboboxArithmetic.AppendText(global::Mono.Unix.Catalog.GetString("-"));
		this.comboboxArithmetic.AppendText(global::Mono.Unix.Catalog.GetString("*"));
		this.comboboxArithmetic.AppendText(global::Mono.Unix.Catalog.GetString("/"));
		this.comboboxArithmetic.Name = "comboboxArithmetic";
		this.fixed1.Add(this.comboboxArithmetic);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxArithmetic]));
		w3.X = 166;
		w3.Y = 129;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.TextBoxSecondNum2 = new global::Gtk.Entry();
		this.TextBoxSecondNum2.WidthRequest = 93;
		this.TextBoxSecondNum2.CanFocus = true;
		this.TextBoxSecondNum2.Name = "TextBoxSecondNum2";
		this.TextBoxSecondNum2.IsEditable = true;
		this.TextBoxSecondNum2.InvisibleChar = '•';
		this.fixed1.Add(this.TextBoxSecondNum2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.TextBoxSecondNum2]));
		w4.X = 255;
		w4.Y = 131;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.ButtonCalculateSum = new global::Gtk.Button();
		this.ButtonCalculateSum.CanFocus = true;
		this.ButtonCalculateSum.Name = "ButtonCalculateSum";
		this.ButtonCalculateSum.UseUnderline = true;
		this.ButtonCalculateSum.Label = global::Mono.Unix.Catalog.GetString("Calculate!");
		this.fixed1.Add(this.ButtonCalculateSum);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.ButtonCalculateSum]));
		w5.X = 380;
		w5.Y = 128;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelResult = new global::Gtk.Label();
		this.labelResult.Name = "labelResult";
		this.labelResult.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
		this.fixed1.Add(this.labelResult);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelResult]));
		w6.X = 542;
		w6.Y = 132;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1114;
		this.DefaultHeight = 696;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ButtonMessage.Clicked += new global::System.EventHandler(this.OnButtonMessageClicked);
		this.ButtonCalculateSum.Clicked += new global::System.EventHandler(this.OnButtonCalculateSumClicked);
	}
}

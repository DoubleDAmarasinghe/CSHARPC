using System;  
using System.Drawing;  
using System.Windows.Forms;  
class MyForm : System.Windows.Forms.Form  
{
	Form frm = new Form();
	Label lb = new Label();
	TextBox tb = new TextBox();
	Button btn = new Button();
	private int cunt = 0;
	
	public MyForm()
	{
		frm.Name = "frm";
		frm.Text = "AWT_Counter";
		frm.Size =  new Size(300, 150);
		frm.StartPosition = FormStartPosition.CenterScreen;
		
		lb.Name = "lb";
		lb.Text = "Counter";
		lb.Size = new Size(60, 20);
		lb.Location = new Point(5, 25);
		
		tb.Name = "tb";
		tb.Size = new Size(110, 20);
		tb.Location = new Point(50, 25);
		tb.Multiline = false;
		
		btn.Name = "btn";
		btn.Text = "Count";
		btn.Size = new Size(90, 20);
		btn.Location = new Point(170, 25);
		btn.MouseClick += getcount;
		
		frm.Controls.Add(btn);
		frm.Controls.Add(tb);
		frm.Controls.Add(lb);
		frm.ShowDialog();
	}
	
	void getcount(Object sender, EventArgs e)
	{
				++cunt;
				tb.Text = Convert.ToString(cunt);
	}
	
	public static void Main()
	{
		MyForm obj = new MyForm();
		
	}
}
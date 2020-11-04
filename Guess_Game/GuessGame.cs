using System;   
using System.Drawing;  
using System.Windows.Forms;  
class MyForm : System.Windows.Forms.Form  
{
	Form frm = new Form();
	Label lb = new Label();
	Label lb1 = new Label();
	TextBox tb = new TextBox();
	Button btn = new Button();
	Random rnd = new Random();
	private int num;
	
	public MyForm()
	{
		frm.Name = "frm";
		frm.Text = "Guess_Game";
		frm.Size =  new Size(300, 150);
		frm.StartPosition = FormStartPosition.CenterScreen;
		
		lb.Name = "lb";
		lb.Text = "Enter number (1-10)";
		lb.Size = new Size(120, 20);
		lb.Location = new Point(5, 25);
		
		lb1.Name = "lb1";
		lb1.Text = "";
		lb1.Size = new Size(120, 40);
		lb1.Location = new Point(90, 50);
		
		tb.Name = "tb";
		tb.Size = new Size(40, 20);
		tb.Location = new Point(115, 25);
		tb.Multiline = false;
		
		btn.Name = "btn";
		btn.Text = "HIT";
		btn.Size = new Size(80, 20);
		btn.Location = new Point(170, 25);
		btn.MouseClick += getcount;
		
		frm.Controls.Add(btn);
		frm.Controls.Add(tb);
		frm.Controls.Add(lb);
		frm.Controls.Add(lb1);
		frm.ShowDialog();
		
		
	}
	
	void getcount(Object sender, EventArgs e)
	{
				num = rnd.Next(1, 9);
				if(Convert.ToInt32(tb.Text) == num)
				{
					lb1.Text = "You Won!";
				}
				else
				{
					lb1.Text = ("Wrong!! Number was " + Convert.ToString(num));
				}
				
				tb.Text = "";
				
	}
	
	public static void Main()
	{
		MyForm obj = new MyForm();
		
	}
}
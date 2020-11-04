using System;   
using System.Drawing;  
using System.Windows.Forms;  
class MyForm : System.Windows.Forms.Form  
{
	Form frm = new Form();
	Label lb = new Label();
	Label lb1 = new Label();
	Label lb2 = new Label();
	TextBox tb = new TextBox();
	TextBox tb1 = new TextBox();
	Button btn = new Button();
	
	public MyForm()
	{
		frm.Size = new Size(400, 300);
		frm.Text = "Login_System";
		frm.StartPosition = FormStartPosition.CenterScreen;
		frm.MaximizeBox = false;
		frm.MinimizeBox = false;
		frm.HelpButton = true;
		frm.AutoSize = false;
		frm.FormBorderStyle = FormBorderStyle.FixedDialog; //Sizable
		
		lb.Size = new Size(100, 30);
		lb.Text = "User Name : ";
		lb.Location = new Point(40, 20);
		
		lb1.Size = new Size(100, 30);
		lb1.Text = "Password : ";
		lb1.Location = new Point(45, 70);
		
		tb.Size = new Size(160, 25);
		tb.Location = new Point(130, 20);
		
		tb1.Size = new Size(160, 25);
		tb1.Location = new Point(130, 70);
		tb1.PasswordChar = '@';
		
		btn.Size = new Size(160, 40);
		btn.Text = "Log In";
		btn.Location = new Point(90, 100);
		btn.MouseClick += check;
		
		lb2.Size = new Size(300, 30);
		lb2.Text = "";
		lb2.Location = new Point(100, 190);
		
		frm.Controls.Add(btn);
		frm.Controls.Add(lb2);
		frm.Controls.Add(tb1);
		frm.Controls.Add(tb);
		frm.Controls.Add(lb1);
		frm.Controls.Add(lb);
		frm.ShowDialog();
	}
	
	void check (Object sender, EventArgs e)
	{
		if(tb.Text == "DoubleD" && tb1.Text == "123456789")
		{
			lb2.Text = "Done!!";
		}
		else
		{
			lb2.Text = "Sorry! User name or Password incorrect.";
		}
		
		tb.Text = "";
		tb1.Text = "";
	}
	
	public static void Main()
	{
		MyForm obj = new MyForm();
	}
}
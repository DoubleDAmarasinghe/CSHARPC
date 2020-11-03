using System;  
using System.Drawing;  
using System.Windows.Forms;  
class MyForm : System.Windows.Forms.Form  
{  
    Label lb = new Label();
	Form frm = new Form();
	TextBox txt = new TextBox();
	public MyForm()  
    {  
		

		lb.Name = "lb";
		lb.Text = "label";
		//lb.AutoSize = true;
		lb.Location = new Point(100, 100);
		//lb.Size = new Size(150,60);
		//lb.BackColor = Color.Green;  
        lb.ForeColor = Color.Red;
        //lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; 	
		lb.Font = new Font("Arial", 11, FontStyle.Bold);
		//lb.BackgroundImage = imageList1.Images[0]; 
		//lb.FlatStyle = 
		//lb.Image = 
		//lb.Padding =  new Padding(5,5,5,5);
		//lb.TextAlign =
		//lb.Visible = true;
		//lb.KeyDown += new KeyEventHandler(top);
		
		
		txt.Location = new Point(100, 200);
		txt.KeyDown += new KeyEventHandler(top);
		txt.Visible = true;
		
		
		this.frm.Text = "DoubleD";
		frm.StartPosition = FormStartPosition.CenterScreen;
		frm.Opacity = 100.0;
		frm.MaximizeBox = true;
		frm.MinimizeBox = false;
		//frm.AutoSize = true;
		frm.Size = new Size(500,500);
		frm.HelpButton = true;
		//frm.FormBorderStyle = FormBorderStyle.FixedDialog;
		//frm.KeyPreview = true;
	
		
		frm.Controls.Add(lb);
		frm.Controls.Add(txt);
		frm.ShowDialog();
    } 
		
		void top(Object sender,KeyEventArgs e)
	{
		/*if(e.KeyCode == Keys.Up) //Enter or any key
   		   {
		    // lb.PerformClick();
		    // lb.Visible = true;
		     //lb.Text = "jhjhh";
		     lb.Location = new Point(lb.Location.X, lb.Location.Y-1);
			 
			 if(e.KeyCode == Keys.Down) //Enter or any key
   		   {
		    // lb.PerformClick();
		    // lb.Visible = true;
		     //lb.Text = "jhjhh";
		     lb.Location = new Point(lb.Location.X, lb.Location.Y+1);
			 
			 if(e.KeyCode == Keys.Right) //Enter or any key
   		   {
		    // lb.PerformClick();
		    // lb.Visible = true;
		     //lb.Text = "jhjhh";
		     lb.Location = new Point(lb.Location.X+1, lb.Location.Y);
			 
			 if(e.KeyCode == Keys.Left) //Enter or any key
   		   {
		    // lb.PerformClick();
		    // lb.Visible = true;
		     //lb.Text = "jhjhh";
		     lb.Location = new Point(lb.Location.X-1, lb.Location.Y);
			 
		   }*/
		   
		   switch(e.KeyCode)
		   {
			   case(Keys.Up):
			   lb.Location = new Point(lb.Location.X, lb.Location.Y-10);
			   break;
			   
			   case(Keys.Down):
			   lb.Location = new Point(lb.Location.X, lb.Location.Y+10);
			   break;
			   
			   case(Keys.Left):
			   lb.Location = new Point(lb.Location.X-10, lb.Location.Y);
			   break;
			   
			   case(Keys.Right):
			   lb.Location = new Point(lb.Location.X+10, lb.Location.Y);
			   break;
		   }
	}	

    public static void Main()  
    {  
        MyForm obj = new MyForm();
		//obj;
		//Application.Run(new MyForm());  
    }  
}  
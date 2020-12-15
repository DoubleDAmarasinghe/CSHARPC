using System; 


 
using System.Text; 
using System.Drawing; 
using System.Windows.Forms;
class MyForm : System.Windows.Forms.Form
{
	Form frm = new Form();
	Label l1 = new Label();
	Label l2 = new Label();
    Label l3 = new Label();
	TextBox txt = new TextBox();
	ListBox txt2 = new ListBox();
    TextBox txt3 = new TextBox();
	Button btn1 = new Button();
	Button btn6 = new Button();
	Button btn2 = new Button();
	Button btn4 = new Button();
	Button btn3 = new Button();
	Button btn5 = new Button();
	MyForm()
	{
		frm.Text = "List Application"; 
		frm.Size = new Size(900,500); 
		frm.StartPosition = FormStartPosition.CenterScreen; 
		frm.Opacity = 100.0; 
		frm.AutoSize = true; 
		frm.FormBorderStyle = FormBorderStyle.FixedDialog; 
		
		l1.Text = "Enter Value";
		l1.Size = new Size(300, 25);
		l1.Location = new Point(10, 15);
		
		l2.Text = "Elements in the List";
		l2.Size = new Size(300, 25);
		l2.Location = new Point(10, 75);
		
		txt.Location = new Point(10,30); 
		txt.Size = new Size(150,25); 
		txt.Multiline = true; 
		txt.AutoSize = true; 
		
		txt2.Location = new Point(10,90); 
		txt2.Size = new Size(550,210); 
		//txt2.Multiline = true; 
		txt2.AutoSize = true; 

		 
		btn1.Text = "Add Value"; 
		btn1.Location = new Point(610,15); 
		btn1.Size = new Size(260,15); 
		btn1.AutoSize = true; 
		btn1.MouseClick += read; 
	
		btn2.Text = "Remove Value"; 
		btn2.Location = new Point(610,75); 
		btn2.Size = new Size(260,15); 
		btn2.AutoSize = true; 
		//btn2.MouseClick += sum; 
		
		btn3.Text = "Read Value from a File"; 
		btn3.Location = new Point(610,135); 
		btn3.Size = new Size(260,15); 
		btn3.AutoSize = true; 
		//btn3.MouseClick += product; 
		
		btn4.Text = "Sort Values"; 
		btn4.Location = new Point(610,195); 
		btn4.Size = new Size(260,15); 
		btn4.AutoSize = true; 
		btn4.MouseClick += sort; 
		
		btn5.Text = "Writes Values to a File"; 
		btn5.Location = new Point(610,255); 
		btn5.Size = new Size(260,15); 
		btn5.AutoSize = true; 
		
		btn6.Text = "Reset"; 
		btn6.Location = new Point(610,305); 
		btn6.Size = new Size(260,15); 
		btn6.AutoSize = true; 
		btn6.MouseClick += reset; 

        l3.Text = "Size (Number of elements in List)";
		l3.Size = new  Size(300, 25);
		l3.Location = new Point(10, 320);

        txt3.Location = new Point(10,345); 
		txt3.Size = new Size(150,25); 
		txt3.Multiline = true; 
		txt3.AutoSize = true; 
		
		frm.Controls.Add(btn6);
		frm.Controls.Add(btn5);
		frm.Controls.Add(btn4);
		frm.Controls.Add(btn3);
		frm.Controls.Add(btn2);
		frm.Controls.Add(btn1);
		frm.Controls.Add(txt2);
		frm.Controls.Add(l2);
		frm.Controls.Add(txt);
		frm.Controls.Add(l1);
        frm.Controls.Add(l3);
        frm.Controls.Add(txt3);
		frm.ShowDialog();
	}
	
        int[] list = new int[4];
        int temp = 0;

	void read(Object sender,EventArgs e) 
	{ 
		if(temp < list.Length)
        {
            list[temp] = Convert.ToInt32(txt.Text);
            temp++;
            txt.Clear();
        }
        if(temp == list.Length){
        for(int i=0; i<list.Length; i++)
        {
            txt2.Items.Add(list[i]);
            txt3.Text = Convert.ToString(list.Length);
        }
        }

	}    

    void sort(Object sender,EventArgs e) 
	{ 	
        int tempp;	
	    for(int i=0; i < list.Length; i++) {
          for(int j = 1; j < list.Length-i; j++) {
	        if(list[j-1] > list[j]) {
		        tempp = list[j-1];
		        list[j-1] = list[j];
		        list[j] = tempp;
	    }
	  }
	}
        for(int i=0; i<list.Length; i++)
        {
            txt2.Items.Add(list[i]);
            txt3.Text = Convert.ToString(list.Length);
        }
	
	}    

    void reset(Object sender,EventArgs e) 
	{ 
		temp = 0;
        txt2.Items.Clear();
        txt3.Clear();
        txt.Clear();
	}    
	
	public static void Main()
	{
		MyForm obj = new MyForm();
		
	}
}
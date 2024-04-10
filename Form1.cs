using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace tic_tac_toe
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		public int cont=1;
		public double [,]arr=new double[9,9];
		int butt1=2,butt2=2,butt3=2,butt4=2,butt5=2,butt6=2,butt7=2,butt8=2,butt9=2;
		int t=0,k=0;
		int counter=0;
		int wino=0;
		int winx=0;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button9,
																					this.button8,
																					this.button7,
																					this.button6,
																					this.button5,
																					this.button4,
																					this.button3,
																					this.button2,
																					this.button1});
			this.groupBox1.Enabled = false;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(48, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 216);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tic Tac Toe";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(216, 152);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(48, 40);
			this.button9.TabIndex = 8;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(136, 152);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(48, 40);
			this.button8.TabIndex = 7;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(48, 152);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 40);
			this.button7.TabIndex = 6;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(216, 88);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 40);
			this.button6.TabIndex = 5;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(136, 88);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 40);
			this.button5.TabIndex = 4;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(48, 88);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(48, 40);
			this.button4.TabIndex = 3;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(216, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 40);
			this.button3.TabIndex = 2;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(136, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 40);
			this.button2.TabIndex = 1;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 40);
			this.button1.TabIndex = 0;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(72, 256);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(104, 32);
			this.button10.TabIndex = 1;
			this.button10.TabStop = false;
			this.button10.Text = "Start the Game with O";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(376, 256);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(96, 32);
			this.button11.TabIndex = 2;
			this.button11.Text = "Exit";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label1.Location = new System.Drawing.Point(384, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "player O";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(384, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "player X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label3.Location = new System.Drawing.Point(384, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "0";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label4.Location = new System.Drawing.Point(384, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "0";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(224, 256);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(104, 32);
			this.button12.TabIndex = 7;
			this.button12.Text = "Continue";
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(376, 192);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(96, 32);
			this.button13.TabIndex = 8;
			this.button13.Text = "Clear Score";
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button14
			// 
			this.button14.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
			this.button14.Location = new System.Drawing.Point(992, 16);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(8, 8);
			this.button14.TabIndex = 9;
			// 
			// button15
			// 
			this.button15.Image = ((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
			this.button15.Location = new System.Drawing.Point(984, 16);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(8, 8);
			this.button15.TabIndex = 10;
			// 
			// button16
			// 
			this.button16.Image = ((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			this.button16.Location = new System.Drawing.Point(976, 16);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(8, 8);
			this.button16.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 342);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button16,
																		  this.button15,
																		  this.button14,
																		  this.button13,
																		  this.button12,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.button11,
																		  this.button10,
																		  this.groupBox1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Game";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			groupBox1.Enabled=true;			
		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			Application.Exit();			
		}
		System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));

		private void button1_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt1<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));

					arr[0,0]=2;
					butt1++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button1.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[0,0]=1;
					butt1++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt2<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[0,1]=2;
					butt2++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button2.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
		            arr[0,1]=1;
					butt2++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt3<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button3.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[0,2]=2;
					butt3++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button3.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[0,2]=1;
					butt3++;
					chek(1);
					lose(counter);
				}				
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt4<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button4.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[1,0]=2;
					butt4++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button4.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[1,0]=1;
					butt4++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt5<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button5.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[1,1]=2;
					butt5++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button5.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[1,1]=1;
					butt5++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt6<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button6.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[1,2]=2;
					butt6++;
					chek(2);
					lose(counter);				
				}
				else
				{
					button6.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[1,2]=1;
					butt6++;
					chek(1);
					lose(counter);					
				}			
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt7<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button7.Image = ((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[2,0]=2;
					butt7++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button7.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[2,0]=1;
					butt7++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt8<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button8.Image=((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[2,1]=2;
					butt8++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button8.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[2,1]=1;
					butt8++;
					chek(1);
					lose(counter);					
				}				
			}
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			counter++;
			if(butt9<3)
			{
				cont=cont*-1; 
				if(cont<0)
				{
					button9.Image=((System.Drawing.Bitmap)(resources.GetObject("button14.Image")));
					arr[2,2]=2;
					butt9++;
					chek(2);
					lose(counter);					
				}
				else
				{
					button9.Image=((System.Drawing.Bitmap)(resources.GetObject("button15.Image")));
					arr[2,2]=1;
					butt9++;
					chek(1);
					lose(counter);					
				}				
			}
		}
		public void chek(int d)
		{
			if(arr[0,0]==arr[0,1]&&arr[0,1]==arr[0,2])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");                    
					counter--;
					
					
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}				
			}
			else if(arr[1,0]==arr[1,1]&&arr[1,1]==arr[1,2])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					counter--;
					
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}				
			}
			else if(arr[2,0]==arr[2,1]&&arr[2,1]==arr[2,2])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					counter--;
				}   
				
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}				
			}
			else if(arr[0,0]==arr[1,0]&&arr[1,0]==arr[2,0])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					counter--;
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}
			}
			else if(arr[0,1]==arr[1,1]&&arr[1,1]==arr[2,1])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					counter--;
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}
			}
			else if(arr[0,2]==arr[1,2]&&arr[1,2]==arr[2,2])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					 counter--;
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}
			}
			else if(arr[0,0]==arr[1,1]&&arr[1,1]==arr[2,2])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=wino.ToString();
					MessageBox.Show("  O has won");
					counter--;
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}
			}
			else if(arr[0,2]==arr[1,1]&&arr[1,1]==arr[2,0])
			{
				if(2==d)
				{
					t++;
					if(t==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						t--;
					}
					wino++;
					label3.Text=winx.ToString();
					MessageBox.Show("  O has won");
					counter--;
				}
				else if(1==d)
				{
					k++;
					if(k==1)
					{
						butt1=3;
						butt2=3;
						butt3=3;
						butt4=3;
						butt5=3;
						butt6=3;
						butt7=3;
						butt8=3;
						butt9=3;
						k--;
					}
					winx++;
					label4.Text=winx.ToString();
					MessageBox.Show("  X has won");
					counter--;
				}
			}
		}
		public void lose(int g)
		{
			if(counter==9)
			{
				MessageBox.Show("  Nobody has won");
			}
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			button1.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button2.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button3.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button4.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button5.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button6.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button7.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button8.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button9.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			
			for(int i=0;i<4;i++)
			{
				for(int j=0;j<4;j++)
				{
					arr[i,j]=i*100+j*12.35;
				}
			}
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<4;i++)
			{
				for(int j=0;j<4;j++)
				{
					arr[i,j]=i*100+j*12.354;
				}
			}
			//button1.Image=null;
			button1.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button2.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button3.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button4.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button5.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button6.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button7.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button8.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			button9.Image=((System.Drawing.Bitmap)(resources.GetObject("button16.Image")));
			if(butt1==3)
			{
				butt1--;
			}
			if(butt2==3)
			{
				butt2--;
			}
			if(butt3==3)
			{
				butt3--;
			}
			if(butt4==3)
			{
				butt4--;
			}
			if(butt5==3)
			{
				butt5--;
			}
			if(butt6==3)
			{
				butt6--;
			}
			if(butt7==3)
			{
				butt7--;
			}
			if(butt8==3)
			{
				butt8--;
			}
			if(butt9==3)
			{
				butt9--;
			}
			if(counter<=9)
			{
				counter=0;
			}				
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			cont=1;
            wino=0;
			winx=0;
			label3.Text=wino.ToString();
			label4.Text=wino.ToString();
		}															
	}
}

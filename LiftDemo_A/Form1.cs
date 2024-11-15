using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
	public partial class Form1 : Form
	{
		bool isClosing = false; //when door is closing
        bool isOpening = false;
		bool isDoorOpen = false;

		int doorMaxOpenWidth; //speed of door opeaning 
		int doorSpeed = 5;
		int liftSpeed = 5;

		private Lift lift; // lift and database connect instanc
        DataTable dt = new DataTable();
		DBContext dbContext = new DBContext();

		public Form1()
		{
			InitializeComponent();

			lift = new Lift(mainElevator, btn_1, btn_G, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown);


			doorMaxOpenWidth = mainElevator.Width / 2 - 30;

			dataGridViewLogs.ColumnCount = 2;
			dataGridViewLogs.Columns[0].Name = "Time";
			dataGridViewLogs.Columns[1].Name = "Events";

			dt.Columns.Add("Timestamp");
			dt.Columns.Add("Type");

		}

		private void logEvents(string message) //it logs events to database
		{
			string currentTime = DateTime.Now.ToString("hh:mm:ss");

			dt.Rows.Add(currentTime, message);
			dataGridViewLogs.Rows.Add(currentTime, message);

			dbContext.InsertLogsIntoDB(dt); //save logs to database
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			dbContext.loadLogsFromDB(dt, dataGridViewLogs);
		}

		public async void WaitForDoorToClose()
		{
			while (isDoorOpen)
			{
				await Task.Delay(50);
			}
		}

		public void btn_1_click(object sender, EventArgs e) //Click function handles button
        {
			if(isDoorOpen)
			{
                isOpening = false;
                isClosing = true;
                isDoorOpen = false;
                doorTimer.Start();
                logEvents("Door Closing");
				return;
			}

			lift.SetState(new MovingUpState());
			lift.LiftTimerUp.Start();
			btn_G.Enabled = false;
			logEvents("Going up!");
			doorTimer.Start();
		}

		public void btn_G_click(object sender, EventArgs e)
		{
			if(isDoorOpen)
			{
                isOpening = false;
                isClosing = true;
                isDoorOpen = false;
                doorTimer.Start();
                logEvents("Door Closing");
                return;
			}

			lift.SetState(new MovingDownState());
			lift.LiftTimerDown.Start();
			logEvents("Heading down!");
			doorTimer.Start();
		}

		public void liftTimerUp_Tick(object sender, EventArgs e) //indicates the floor no 
        {
			lift.MovingUp();
			if(lift._CurrentState is IdleState)
			{
				indicator.Text = "1";
			}
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
		{
			lift.MovingDown();
			if(lift._CurrentState is IdleState)
			{
				indicator.Text = "G";
			}
		}

		private void btn_Open_Click(object sender, EventArgs e)
		{
			if (isDoorOpen)
			{
				return;
			}
			isOpening=true;
			isClosing=false;
			isDoorOpen = true;
			doorTimer.Start();
			btn_Close.Enabled = false;
			logEvents("Door Opening");
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			if (!isDoorOpen)
			{
				return;
			}
			isOpening = false;
			isClosing = true;
			isDoorOpen = false;
			doorTimer.Start();
			logEvents("Door Closing");
		}

		private void door_Timer_Tick(object sender, EventArgs e)

		{
			if (mainElevator.Top != 0)
			{
				if (isOpening)
				{
					if (doorLeft_G.Left > doorMaxOpenWidth / 2)
					{
						doorLeft_G.Left -= doorSpeed;
						doorRight_G.Left += doorSpeed;
					}
					else
					{
						doorTimer.Stop();
						btn_Close.Enabled = true;
					}
				}

				if (isClosing)
				{
					if (doorLeft_G.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
					{
						doorLeft_G.Left += doorSpeed;
						doorRight_G.Left -= doorSpeed;
					}
					else
					{
						doorTimer.Stop();

					}
				}
			}

			else
			{
				if (isOpening)
				{
					if (doorLeft_1.Left > doorMaxOpenWidth / 2)
					{
						doorLeft_1.Left -= doorSpeed;
						doorRight_1.Left += doorSpeed;
					}
					else
					{
						doorTimer.Stop();
						btn_Close.Enabled = true;
					}
				}

				if (isClosing)
				{
					if (doorLeft_1.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
					{
						doorLeft_1.Left += doorSpeed;
						doorRight_1.Left -= doorSpeed;
					}
					else
					{
						doorTimer.Stop();

					}
				}
			}
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
			dbContext.clearLogsFromDB(dt, dataGridViewLogs);	 
        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void liftPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isDoorOpen)
            {
                isOpening = false;
                isClosing = true;
                isDoorOpen = false;
                doorTimer.Start();
                logEvents("Door Closing");
                return;
            }

            lift.SetState(new MovingUpState());
            lift.LiftTimerUp.Start();
            btn_G.Enabled = false;
            logEvents("Going up!");
            doorTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isDoorOpen)
            {
                isOpening = false;
                isClosing = true;
                isDoorOpen = false;
                doorTimer.Start();
                logEvents("Door Closing");
                return;
            }

            lift.SetState(new MovingDownState());
            lift.LiftTimerDown.Start();
            logEvents("Heading down!");
            doorTimer.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
	internal class Lift // Declares a class named Lift, which represents the elevator system
    {
		public ILiftState _CurrentState; // Holds the current state of the elevator, implementing the ILiftState interface.

        public PictureBox MainElevator;
		public Button Btn_1;
		public Button Btn_G;
		public int FormSize;
		public int LiftSpeed;
		public Timer LiftTimerUp;
		public Timer LiftTimerDown;

		public Lift(PictureBox mainElevator, Button btn_1, Button btn_G, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown)
		{
			MainElevator = mainElevator;
			Btn_1 = btn_1;
			Btn_G = btn_G;
			FormSize = formSize;
			LiftSpeed = liftSpeed;
			LiftTimerUp = liftTimerUp;
			LiftTimerDown = liftTimerDown;
			_CurrentState = new IdleState();
		}

		public void SetState(ILiftState state) //to change the current state of the elevator.
        {
			_CurrentState = state;
		}

		public void MovingUp()
		{
			_CurrentState.MovingUp(this);
		}

		public void MovingDown()
		{
			_CurrentState.MovingDown(this);
		}


	}
}

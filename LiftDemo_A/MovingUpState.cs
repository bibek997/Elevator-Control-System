using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftDemo_A
{
	internal class MovingUpState : ILiftState
	{
		public void MovingDown(Lift lift)
		{
			/* Do Nothing */
		}

		public void MovingUp(Lift lift)
		{

			if (lift.MainElevator.Top > 0)
			{
				lift.MainElevator.Top -= lift.LiftSpeed;
			}
			else
			{
				// Once it reaches the top, transition to StoppedState
				lift.SetState(new IdleState());
				lift.MainElevator.Top = 0;
				lift.Btn_G.BackColor = Color.White;
				lift.LiftTimerUp.Stop();  // Stop the timer when it reaches the top
				lift.Btn_G.Enabled = true;  // Re-enable the G button
				lift.Btn_1.Enabled = true;  // Enable other controls

            }
		}
	}
}

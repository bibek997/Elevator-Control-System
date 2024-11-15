using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftDemo_A
{
	internal class MovingDownState : ILiftState
	{
		public void MovingDown(Lift lift)
		{
			if (lift.MainElevator.Top == 0 || lift.MainElevator.Bottom < lift.FormSize)
			{
				lift.MainElevator.Top += lift.LiftSpeed;
			}
			else
			{
				// Once it reaches the bottom, transition to StoppedState
				lift.SetState(new IdleState());
				lift.MainElevator.Top = lift.FormSize - lift.MainElevator.Height;
				lift.Btn_1.BackColor = Color.White;
				lift.LiftTimerDown.Stop();  // Stop the timer when it reaches the bottom
				lift.Btn_1.Enabled = true;  // Re-enable the 1st floor button
				lift.Btn_G.Enabled = true;  // Enable other controls
			}
		}

		public void MovingUp(Lift lift)
		{
			/* Do Nothing */
		}
	}
}

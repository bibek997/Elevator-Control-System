using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftDemo_A
{
	internal class IdleState : ILiftState
	{
		public void MovingDown(Lift lift) // Implements the MovingDown method from the ILiftState class.
        {
			/* Do Nothing */
		}

		public void MovingUp(Lift lift)
		{
            /* Do Nothing */ 
        }
    }
}

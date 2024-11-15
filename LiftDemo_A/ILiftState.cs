using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftDemo_A
{
	internal interface ILiftState //it is defined so that it can only be used within the same assembly (or project) where it is declared.
    {
		void MovingUp(Lift lift); // Method for MovingUp, which takes a Lift object as a parameter and does not return a value.
        void MovingDown(Lift lift);
	}
}

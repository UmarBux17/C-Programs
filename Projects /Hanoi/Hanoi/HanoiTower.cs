using System;
namespace Hanoi
{
	public class HanoiTower
	{
		public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int> From { get; private set; }
        public Stack<int> To{ get; private set; }
        public Stack<int> Auxilary { get; private set; }
		public EventHandler<EventArgs> MoveCompleted;


        public HanoiTower(int discs)
		{
			DiscsCount = discs;
			From = new Stack<int>();
			To = new Stack<int>();
			Auxilary = new Stack<int>();
			for (int i = 1; i < discs; i++)
			{
				int size = discs - i + 1;
				From.Push(size);
			}//for loop ends

        }//contructor ends

		public void Start()
		{
			Move(DiscsCount, From, To, Auxilary);
		} 

		public void Move(int discs,Stack<int> from,Stack<int> to, Stack<int> auxilary)
		{
			if (discs > 0)
			{
				Move(discs - 1, from, auxilary, to);
				to.Push(from.Pop());
				MovesCount++;
				MoveCompleted?.Invoke(this, EventArgs.Empty);

				Move(discs - 1, auxilary, to, from);
			}
		}


	}//class ends
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_curriculum
{
	class Topic
	{
		private static int NextId { get; set; } = 13;
		public int Id { get; private set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public int Difficulty { get; set; }

		//public void SetId(int id)
		//{
		//	this.Id = id;
		//}

		public void Print()
		{
			Console.WriteLine($"{Id} | {Name} | {Category} | {Difficulty}");
		}

		public Topic()
		{
			this.Id = NextId;
			NextId = NextId + 17;
		}
	}
}

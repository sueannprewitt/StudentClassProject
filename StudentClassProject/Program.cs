using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
	class Program {

		void Run () {
			Student sa = new Student("Sue Ann", "Hazel");
			Student eb = new Student("Eric B", "Brown");
			Student go = new Student("Greg", "Blue");
			Student be = new Student("Bob", "Blue");
			Student es = new Student("Eric S", "Blue");
			}



		static void Main(string[] args) {
			new Program().Run();
		}
	}
}

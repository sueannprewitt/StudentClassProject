using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
	class Student {
		//Properties
		string Name;
		string EyeColor;
		DateTime DateRegistered = DateTime.Now;
		bool LikesMusic = true; //default value
		int YearsExperience = 1;
		
		
		
		//Methods
		public void SetDateRegistered(DateTime Registered) {
			 DateRegistered= Registered;
		}
		public void SetName(string name) {
			Name = name;
		}
		public void SetEyeColor(string color = "Brown") {
			EyeColor = color;
		}
		public void SetLikesMusic (bool likesMusic) {
			LikesMusic = likesMusic;
		}
		public void SetYearsExperience(int years) {
			YearsExperience = years;
		}
		//constructor (special method)
		//default constructor
		public Student() {

		}

		public Student (string name, string eyeColor) {
			Name = name;
			EyeColor = eyeColor;
		}
		}
}

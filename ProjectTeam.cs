using System;


namespace KAlmache_Project1
{
	public class ProjectTeam
	{

		private string projectName;
		private Programmer programmer1;
		private Programmer programmer2;
		List<Programmer> myProgrammers;

        public ProjectTeam(string projectName, Programmer programmer1, Programmer Programmer2)
        {
			this.projectName = projectName;
			this.myProgrammers = new List<Programmer>();
			myProgrammers.Add(programmer1);
			myProgrammers.Add(Programmer2);
		
        }

        public string ProjectName { get => projectName; set => projectName = value; }

		//Imprime los datos de arraylist







        //The Project team’s class, defines a group of programmers in charge. There is 2 differents types of teams.
        //One where programmers are payed 100% of their salary,  
        //and the other one at 50%.

        public void FullSalary() 
		{

		}

		public void HalflSalary()
		{ 
		
		
		}
	}
}
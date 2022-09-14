using KAlmache_Project1;
using System;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //Requirement: saved in a text file -- write
        Console.WriteLine("*********************READ********************");
    
      string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C:Files\\ITCompanyData.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        //crear objeto
        Programmer myProgrammer1 = new Programmer("kathy","almache",30,"ecuador","coding");
        Programmer myProgrammer2 = new Programmer("kathy2", "almache2", 30, "ecuador2", "coding2");
        ProjectTeam myTeam = new ProjectTeam("Team 1", myProgrammer1,myProgrammer2);
        Console.WriteLine(myTeam.ProjectName);
 
    }
}




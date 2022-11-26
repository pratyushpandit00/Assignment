using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class Instructor
    {
        float avgFeedback;
        int experience;
        String instructorName;
        string[] instructorSkill;

        public bool checkSkill(String technology)
        {
            for (int i = 0; i < instructorSkill.Length; i++)
            {
                if (technology == instructorSkill[i])
                {
                    if (validateEligibility())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public Instructor()
        {
            Console.WriteLine("Default Constructor");
        }

        public Instructor(string InstructorName, float avgFeedback, int experience, string[] instructorSkills)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkills;
        }

        public bool validateEligibility()
        {
            if (experience > 3)
            {
                if (avgFeedback >= 4.5)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float avgFeedback = 4.5f;
            int experience = 9;
            string instructorName = "Pranshi";
            string[] instructorSkill = { "C", "Python", "Java", "C#" };

            Instructor instructor = new Instructor(instructorName, avgFeedback, experience, instructorSkill);
            if (instructor.validateEligibility() && instructor.checkSkill("C#"))
            {
                Console.WriteLine("Instructor is Eligible for teaching");
            }
            else
            {
                Console.WriteLine("Instructor is not Eligible for teaching");
            }


        }
    }
}
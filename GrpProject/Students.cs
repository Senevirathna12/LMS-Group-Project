using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GrpProject
{
    public class Students


    {
        [Key]
        public int Id { get; set; }
        public String RegNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public int Age { get; set; }

        public double GPA { get; set; }

        public string Sex { get; set; }

        public string Batch { get; set; }

      

        public string Data { get; set; }

        public string Project { get; set; }
        public string Gui { get; set; }
        public string Signal { get; set; }
        public string Acon { get; set; }
        public string Maths { get; set; }
        public string Analog { get; set; }
        public string Elec { get; set; }


     
        public Students(string regno, string firstname, string lastname,  int age, string dateofbirth, double gpa,string sex, string batch ,string data, String project, string gui, string signal, string acon, string maths, string analog, string elec)
        {
            RegNo = regno;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            DateOfBirth = dateofbirth;
            GPA = gpa;
            Sex = sex; 
            Batch = batch;
            
            Data = data;
            Project = project;
            Gui = gui;
            Signal = signal;
            Acon = acon;
            Maths = maths;
            Analog = analog;
            Elec = elec;
        }

        public Students()
        {
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GrpProject
{
    public partial class AddUserVM: ObservableObject
    {

        [ObservableProperty]
        public string regno;

        [ObservableProperty]
        public string fristname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string sex;

        [ObservableProperty]
        public string batch;
       
        [ObservableProperty]
        public string data;

        [ObservableProperty]
        public string project;

        [ObservableProperty]
        public string gui;

        [ObservableProperty]
        public string signal;

        [ObservableProperty]
        public string acon;

        [ObservableProperty]
        public string maths;

        [ObservableProperty]
        public string analog;

        [ObservableProperty]
        public string elec;

        [ObservableProperty]
        public Students selectedstudent;
        public AddUserVM(Students s) 
        {
            User = s;

            regno = User.RegNo;
            fristname =User.FirstName;
            lastname = User.LastName;
            age = User.Age;
            gpa = User.GPA;
            sex = User.Sex;
            batch = User.Batch;
            dateofbirth = User.DateOfBirth;
            data = User.Data;
            project = User.Project;
            gui = User.Gui;
            signal = User.Signal;
            acon = User.Acon;
            maths = User.Maths;
            analog = User.Analog;
            elec = User.Elec;



        }

        public AddUserVM()
        {
        
        }

   

        public Action CloseAction { get; internal set; }


        [RelayCommand]
        public void Save()
        {

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between  and 4", "Error");
                return;
            }
          

            if (User == null)
            {

                User = new Students()
                {
                    RegNo = regno,
                    FirstName = fristname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    GPA = gpa,
                    Sex = sex,
                    Batch = batch,
                    Data = data,
                    Project=project,
                    Gui=Gui,
                    Signal=signal,
                    Acon=acon,
                    Maths=Maths,
                    Analog=analog,
                    Elec=elec

                };

                using (var db = new DataContext())
                {
                    db.Dbstudent.Add(User);
                    db.SaveChanges();
                    MessageBox.Show("New User Added", "Message");

                }

            }
            else
            {
                using (var db = new DataContext())
                {
                    Students s = db.Dbstudent.Find(User.Id);
                    s.FirstName = fristname;
                    s.LastName = lastname;
                    s.RegNo = regno;
                    s.Age = age;
                    s.GPA = gpa;
                    s.Sex = sex;
                    s.Batch = batch;

                    s.DateOfBirth = dateofbirth;
                    s.Data = data;
                    s.Project = project;
                    s.Gui = Gui;
                    s.Signal = signal;
                    s.Acon = acon;
                    s.Maths = Maths;
                    s.Analog = analog;
                    s.Elec = elec;

                    db.SaveChanges();
                    MessageBox.Show("Updated...!", "Message");

                }

             

            }

            if (User.FirstName != null)
            {

                CloseAction();
            }

            Application.Current.MainWindow.Show();




        }
        public Students User { get; private set; }
    }
}

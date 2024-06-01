using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GrpProject
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Students> student;

        [ObservableProperty]
        public Students selectedUser = null;


        public void LoadStuendts()
        {
            using (var db = new DataContext())
            {
                var list = db.Dbstudent.ToList();
                Student = new ObservableCollection<Students>(list);


            }
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            AddUserWindow2 window = new AddUserWindow2(vm);
            window.ShowDialog();
            LoadStuendts();

        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                Students student = SelectedUser;
                if (SelectedUser != null)
                {
                    using (var db = new DataContext())
                    {
                        db.Dbstudent.Remove(student);
                        db.SaveChanges();
                        MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");
                        LoadStuendts();


                    }
                }

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }
            LoadStuendts();
        }


        [RelayCommand]
        public void ExecuteEditStudent()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                var window = new AddUserWindow2(vm);
                window.ShowDialog();




                LoadStuendts();

            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        [RelayCommand]
        public void ExecuteEditStudent2()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                var window = new AddUserWindow3(vm);
                window.ShowDialog();



                LoadStuendts();


            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        [RelayCommand]
        public void Read()
        {

            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                var window = new ReadWindow(vm);
                window.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
            LoadStuendts();
        }

   

        [RelayCommand]
        public void As(){}


        public MainWindowVM()
        { 

            LoadStuendts();
         
        }
    }
   

  
}

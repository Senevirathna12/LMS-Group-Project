using FluentAssertions;
using Microsoft.Identity.Client;

namespace GrpProject.Tests
{
    public class UnitTest1
    {
       
     
        
            [Fact]
            public void Students_Initialization_Should_SetPropertiesCorrectly()
            {
                // Arrange
                string regNo = "123";
                string firstName = "John";
                string lastName = "Doe";
                int age = 25;
                string dateOfBirth = "1998-01-01";
                double gpa = 3.8;
                string sex = "Male";
                string batch = "2023";
                string data = "Data";
                string project = "Project";
                string gui = "GUI";
                string signal = "Signal";
                string acon = "Acon";
                string maths = "Maths";
                string analog = "Analog";
                string elec = "Elec";

                // Act
                var student = new Students(regNo, firstName, lastName, age, dateOfBirth, gpa, sex, batch, data, project, gui, signal, acon, maths, analog, elec);

                // Assert
                student.Id.Should().Be(0); // Assuming default value is 0
                student.RegNo.Should().Be(regNo);
                student.FirstName.Should().Be(firstName);
                student.LastName.Should().Be(lastName);
                student.Age.Should().Be(age);
                student.DateOfBirth.Should().Be(dateOfBirth);
                student.GPA.Should().Be(gpa);
                student.Sex.Should().Be(sex);
                student.Batch.Should().Be(batch);
                student.Data.Should().Be(data);
                student.Project.Should().Be(project);
                student.Gui.Should().Be(gui);
                student.Signal.Should().Be(signal);
                student.Acon.Should().Be(acon);
                student.Maths.Should().Be(maths);
                student.Analog.Should().Be(analog);
                student.Elec.Should().Be(elec);
            }
        }
    }

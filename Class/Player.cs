using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKU_ESport.Class
{
    public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string Major { get; set; }
        public string GameName { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }
        public int Age { get; set; }

        public Player(string Name, string LastName, string StudentID, string Major, string GameName, string Email, string Tell, int Age)
        {
            this.Name = Name; this.LastName = LastName; this.StudentID = StudentID; this.Major = Major; this.GameName = GameName; this.Email = Email; this.Tell = Tell; this.Age = Age;
        }
        public string getName()
        {
            return Name;
        }
        public string getLastName()
        {
            return LastName;
        }
        public string getStudentID()
        {
            return StudentID;
        }
        public string getMajor()
        {
            return Major;
        }
        public string getGameName()
        {
            return GameName;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getTell()
        {
            return Tell;
        }
        public int getAge()
        {
            return Age;
        }
    }
}

using System;
namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        private string _twitter;
        public string Twitter
        {
            get { return _twitter; }

            set
            {
                if (value.StartsWith("@"))
                {
                    _twitter = value;
                }
                else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
         }

        public School()
        {
            Name = "Untitled School";
            Address = "0 No Street";
            City = "No City";
            State = "XX";
            Zip = "00000";
            Phone = "000-000-0000";
        }

        public School(string SchoolName, string SchoolPhone)
        {
            Name = SchoolName;
            Address = "0 No Street";
            City = "No City";
            State = "XX";
            Zip = "00000";
            Phone = SchoolPhone;

        }

    }
}

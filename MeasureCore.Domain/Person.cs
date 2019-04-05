namespace RandREng.MeasuresCore.Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string FullNameReverse => $"{LastName}, {FirstName}";
    }
}

namespace IsPersonAdultTestProblem
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAdult { get; private set; }

        public Person (string firstName, string lastName, DateTime dateOfBirth, IDateTimeProvider dateTimeProvider)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            IsAdult = (dateTimeProvider.GetCurrentDate().Year - dateOfBirth.Year) >= 18;
        }
    }
}

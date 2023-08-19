namespace IsPersonAdultTestProblem
{
    public class PersonFactory
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public PersonFactory(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public Person CreatePerson(string firstName, string lastName, DateTime dateOfBirth)
        {
            return new Person(firstName, lastName, dateOfBirth, _dateTimeProvider);
        }
    }
}

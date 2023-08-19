namespace IsPersonAdultTestProblem
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }
    }
}

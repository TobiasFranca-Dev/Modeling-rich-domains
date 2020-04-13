using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(firstName))
            {
                AddNotification("firstName", "Invalid name");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                AddNotification("lastname", "Invalid lastname");
            }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

namespace XamlMvvmBasic
{
    public sealed class DataService
        : IDataService
    {
        public PersonData GetPerson()
        {
            // Open Db
            // Get data 
            // map to PersonData class

            return new PersonData
                {
                    Age       = 30,
                    FirstName = @"John",
                    LastName  = @"Doe"
                };
        }
    }
}
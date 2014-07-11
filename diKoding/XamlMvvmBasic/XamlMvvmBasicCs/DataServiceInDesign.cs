namespace XamlMvvmBasic
{
    public sealed class DataServiceInDesign
        : IDataService
    {
        public PersonData GetPerson()
        {
            return new PersonData
                {
                    Age       = 38, 
                    FirstName = @"James", 
                    LastName  = @"Bond"
                };
        }
    }
}
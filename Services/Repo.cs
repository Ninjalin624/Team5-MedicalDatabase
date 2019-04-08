using System.Collections.Generic;

using ClinicWeb.Model;

namespace ClinicWeb.Services
{
    public class Repo
    {
        public IEnumerable<Address> FetchAddresses()
        {
            var result = new List<Address>();

            var fakeAddr = new Address();
            fakeAddr.AddressId = 0;
            fakeAddr.City = "Houston";
            fakeAddr.PostalCode = 77573;
            fakeAddr.State = "Texas";
            fakeAddr.StreetAddress = "471 Looneyville Street";
            result.Add(fakeAddr);

            return result;
        }
    }
}

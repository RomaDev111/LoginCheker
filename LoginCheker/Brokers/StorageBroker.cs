using LoginCheker.Models;

namespace LoginCheker.Brokers
{
    internal class StorageBroker : IStorageBroker
    {
        private static Credential[] credentials =
        {
            new Credential { UserName = "Roma", Password = "123456" },
            new Credential { UserName = "Feruz", Password = "654321" }
        };
        public Credential[] GetAllCredentials() => credentials;
    }
}

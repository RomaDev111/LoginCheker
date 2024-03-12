using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginCheker.Models;

namespace LoginCheker.Brokers
{
    internal interface IStorageBroker
    {
        Credential[] GetAllCredentials();
    }
}

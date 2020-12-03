using ApiLibrary.RequestDTO;
using System;
using WebLibrary;

namespace SeleniumSpecFlow.Utilities
{
    public class ObjectFactory
    {
        public Lazy<DriverFactory> DriverFactory = new Lazy<DriverFactory>();

        public Lazy<PayLoad> PayLoad = new Lazy<PayLoad>();

        public Lazy<GitHub> GitHub = new Lazy<GitHub>(() => new GitHub(Hooks.Driver));
    }

}

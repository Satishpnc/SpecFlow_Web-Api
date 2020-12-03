using ApiLibrary;
using NUnit.Framework;
using RestSharp;
using SeleniumSpecFlow;
using SeleniumSpecFlow.Utilities;
using TechTalk.SpecFlow;
using TestLibrary.Utilities;

namespace TestLibrary.Steps
{
    [Binding]
    public class ApiTestSteps : ObjectFactory
    {
        public IRestResponse restResponse { get; private set; }

      
        [Given(@"I create request body for endpoint")]
        public void GivenICreateRequestBodyForEndpoint()
        {
            //Not Requried for this test
        }
        [When(@"I requested ""(.*)"" for ""(.*)""")]
        public void WhenIRequestedFor(string method, string endPoint)
        {
            restResponse = ApiHelper.CreateRequest(CreateUser, method, Hooks.restClient, endPoint);
        }
        [When(@"I requested ""(.*)"" for (.*) and (.*) to list pull requests")]
        public void WhenIRequestedForaEndPoint(string method, string paramOne, string paramTwo)
        {
            restResponse = ApiHelper.CreateRequest(CreateUser, method, Hooks.restClient, "/repos/"+ paramOne + "/"+ paramTwo + "/pulls");
        }

        [Then(@"I should see the status of pull request list (.*)")]
        public void ThenIValidateStatusShouldBe(string status)
        {
            string Status = restResponse.StatusCode.ToString();
            Assert.AreEqual(status, Status, "Status code is not " + status);
        }

       [Then(@"I should see the (.*)")]
        public void ThenIValidateResponseStatusShouldBe(int status)
        {
            int StatusCode = (int)restResponse.StatusCode;
            Assert.AreEqual(status, StatusCode, "Status code is not " + status);
        }
    }
}

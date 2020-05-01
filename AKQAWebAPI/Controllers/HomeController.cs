/// <summary>
/// AKQA Web API Controllers namespace
/// </summary>
namespace AKQAWebAPI.Controllers
{
    using AKQA.Utilities.Utility;
    using AKQAWebAPI.Models;
    using System.Collections.Generic;
    using System.Web.Http;

    public class HomeController : ApiController
    {
        // GET api/Home
        public IEnumerable<AkqaResponseModel> Get()
        {
            return new AkqaResponseModel[]
            {
                new AkqaResponseModel
                {
                    Name = "Name 1",
                    Number = "Number 1.0",
                },
                new AkqaResponseModel
                {
                    Name = "Name 2",
                    Number = "Number 2.0",
                }
            };
        }

        // GET api/Home/5
        public AkqaResponseModel Get(int id)
        {
            return new AkqaResponseModel
            {
                Name = $"Name {id}",
                Number = $"Number {id}.0",
            };
        }

        // GET api/Home?name=test&number=123.10
        public AkqaResponseModel Get(string name, string number)
        {
            AkqaRequestModel request = new AkqaRequestModel
            {
                Name = name,
                Number = number
            };
            return new AkqaResponseModel
            {
                Name = request.Name,
                Number = CurrencyConverter.ConvertToText(request.Amount, true, "-")
            };
        }

        // POST api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Home/5
        public void Delete(int id)
        {
        }
    }
}
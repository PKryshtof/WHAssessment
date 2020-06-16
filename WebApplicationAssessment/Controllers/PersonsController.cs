using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApplicationAssessment.Factories;
using WebApplicationAssessment.Models;

namespace WebApplicationAssessment.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody]object jsonPerson)
        {
            Person person;

            PersonFactory factory;

            JObject jobject = JObject.Parse(jsonPerson.ToString());

            if (jobject != null)
            {
                if (IsMrGreen(jobject))
                {
                    factory = new MrGreenFactory(jobject);
                }
                else if (IsRedBet(jobject))
                {
                    factory = new RedBetFactory(jobject);
                }
                else
                {
                    return BadRequest();
                }

                person = factory.GetPerson();

                return CreatedAtRoute("", person);
            }

            return BadRequest();
        }

        private bool IsMrGreen(JObject jobject)
        {
            return (jobject[JsonConsts.FavouriteFootbalTeam] == null && jobject[JsonConsts.PersonalNumber] != null);
        }
        private bool IsRedBet(JObject jobject)
        {
            return (jobject[JsonConsts.FavouriteFootbalTeam] != null && jobject[JsonConsts.PersonalNumber] == null);
        }
    }


}
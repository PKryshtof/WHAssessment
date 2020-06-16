using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAssessment.Models;

namespace WebApplicationAssessment.Factories
{
    public abstract class PersonFactory:BasePersonFactory
    {
        public abstract Person GetPerson();
    }
}

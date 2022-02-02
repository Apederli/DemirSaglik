using System;
using System.Collections.Generic;

namespace DemirSaglik.Project.Business.Concrete.ApiEntity
{
    public class Root
    {
        public List<Search> Search { get; set; }

        public string totalResult { get; set; }

        public string Response { get; set; }

        public Root()
        {
        }
    }
}

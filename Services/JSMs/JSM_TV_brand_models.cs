using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.JSMs
{
    public class JSM_TV_brand_models
    {
        public string List_TV_brand_models_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public JSM_TV_brand_models(string list_TV_brand_models_ID, string name, string description)
        {
            List_TV_brand_models_ID = list_TV_brand_models_ID;
            Name = name;
            Description = description;
        }
    }
}

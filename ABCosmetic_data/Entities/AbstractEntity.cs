using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.Entities
{
    public  class AbstractEntity
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
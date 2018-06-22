using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NIAMU.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Champions
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int Role { get; set; }

        public string Bio { get; set; }

        [StringLength(255)]
        public string Url_Image { get; set; }
        [JsonIgnore]
        public virtual Roles Roles { get; set; }
    }
}
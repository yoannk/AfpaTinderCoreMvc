using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCoreMvc.Models
{
    public class Loisir
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Nom { get; set; }

        public IList<PersonneLoisir> PersonneLoisirs { get; set; }
    }
}

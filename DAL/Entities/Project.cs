using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Console_Day2EF.DAL.Entities
{
    public class Project
    {
        [Key]
        public string Name { get; private set; }
        
        public string secondName { get; private set; }
    }
}

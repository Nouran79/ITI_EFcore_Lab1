using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Console_Day2EF.DAL.Entities
{
    [Table("Employee",Schema ="HR")]
    public class Employee
    {

        public int id { get; private set; }
        public int age { get; private set; }

        [MaxLength(100)]
        public string? name { get; private set; }
        public decimal? salary { get; private set; }
    }
}

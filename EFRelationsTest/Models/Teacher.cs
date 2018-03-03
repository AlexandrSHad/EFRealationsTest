using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsTest.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid().ToString();
        }

        [ForeignKey("User")]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ApplicationUser User { get; set; }
    }
}

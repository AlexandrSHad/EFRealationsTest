using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRelationsTest.Models
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public Teacher Teacher { get; set; }
    }
}

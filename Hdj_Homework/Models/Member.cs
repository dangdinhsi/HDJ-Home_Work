using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hdj_Homework.Models
{
    public class Member
    {
        private int id;
        private string name;
        private string email;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}

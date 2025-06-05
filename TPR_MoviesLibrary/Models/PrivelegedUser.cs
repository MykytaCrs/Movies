using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_MoviesLibrary
{
    public class PrivelegedUser
    {
        public int Id { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "Moderator"; // Admin або Moderator
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GymManagementSystem.Model
{
    public class Member
    {

        public int MemberID { get; set; }

        public string Character {  get; set; }

        public Brush brush { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Contact { get; set; }

        public string? ProfilePath { get; set; }


    }
}

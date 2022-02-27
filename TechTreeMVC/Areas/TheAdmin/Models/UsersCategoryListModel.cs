using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVC.Areas.TheAdmin.Models
{
    public class UsersCategoryListModel
    {
        public int CategoryId { get; set; }

        public ICollection<UserModel> Users { get; set; } //contain all the users registered in the db

        public ICollection<UserModel> UsersSelected { get; set; } 
        //contain all collections of users that has been saved to a particular category
    }
}

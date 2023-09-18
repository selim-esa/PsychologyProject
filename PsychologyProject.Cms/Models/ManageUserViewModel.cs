using System.Collections.Generic;

using PsychologyProject.Entities.Concrete;

namespace AspNetCoreTodo
{
    public class ManageUsersViewModel
    {
        public IEnumerable<AppRole> Administrators { get; set; }

        public IEnumerable<AppRole> Everyone { get; set; }
    }
}
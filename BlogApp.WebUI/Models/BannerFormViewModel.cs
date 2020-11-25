using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI.Models
{
    public class BannerFormViewModel
    {


        public Banner banner { get; set; }

        public List<Category> categories { get; set; }
    }
}

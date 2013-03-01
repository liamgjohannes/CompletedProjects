using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdDinner.Models
{
    public class DinnerFormViewModel
    {
        //Properties
        public Dinner Dinner { get; set; }
        public SelectList Countries { get; set; }

        // Constructor
        public DinnerFormViewModel(Dinner dinner)
        {
            Dinner = dinner;
            Countries = new SelectList(PhoneValidator.Countries, dinner.Country);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP1004_F2016_Mid_Term_200180985
{
    public class Character
    {
        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }


        // added to hold FirstName information for character
        public string FirstName { get; set; }

        // added to hold LastName information for character
        public string LastName { get; set; }
    }
}
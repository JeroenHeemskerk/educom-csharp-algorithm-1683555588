using System;
using System.Xml.Linq;

namespace BornToMove
{
	public class Move
	{
        private string id = "";
        private string name = "";
        private string description = "";
        private string sweatRate = "";

        public string Id
        {
        get { return id; }  // getter 
        set { id = value; } // setter
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        } 

        public string SweatRate
        {
            get { return sweatRate; }
            set { sweatRate = value; }
        }
    
	}
}


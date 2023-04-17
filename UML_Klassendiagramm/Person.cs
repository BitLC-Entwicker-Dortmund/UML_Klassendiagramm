using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Klassendiagramm {
    class Person {
        private string name;

        public void setName(string name) {
            this.name = name;
        }
        public string getName() { 
            return this.name;
        }
        // Standardkonstruktor
        public Person() { }

        // überladener Konstruktor
        public Person(string n) {
            this.name=n;
        }

        // Properties
        private int iq;

        public int Iq {
            get { return iq; }
            set { iq = value; }
        }

        //public int Iq { get; set; }

    }
}

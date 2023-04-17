using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Klassendiagramm {
    internal class Zielort {
        private Person person;
        private List<Person> personenListe = new List<Person>();

        public void setPerson(Person person) {
            this.person = person;
        }

        public Person getPerson() { 
            return this.person;
        }

        public void setPersonenListe(Person p) {
            personenListe.Add(p);
        }

        public void zeigePersonenListe() {
            foreach (Person  einePerson in personenListe) {
                Console.WriteLine(einePerson.getName());
            }
        }

    }
}

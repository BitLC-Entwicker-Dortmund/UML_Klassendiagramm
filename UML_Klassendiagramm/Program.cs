namespace UML_Klassendiagramm {
    internal class Program {
        static void Main(string[] args) {
            Person p = new Person();
            p.setName("Versuch");

            Console.WriteLine(  p.getName());

            Zielort zoo = new Zielort();
            zoo.setPerson(p);
            Console.WriteLine( zoo.getPerson().getName() );

            zoo.setPerson(null);
            //Console.WriteLine(zoo.getPerson().getName());
            Console.WriteLine(p.getName());

            Person p1 = new Person();
            p1.setName("Ur");
            Person p2 = new Person();
            p2.setName("laub");

            zoo.setPersonenListe(p1);
            zoo.setPersonenListe(p2);
            
            // Komposition
            zoo.setPersonenListe(new Person("komposition"));
            zoo.zeigePersonenListe();

            // Properties
            p.Iq = 99;
            Console.WriteLine(p.Iq);

            Console.Read();
        }
    }
}
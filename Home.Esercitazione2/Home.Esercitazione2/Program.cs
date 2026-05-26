using Home.Esercitazione2;

class Program
{
    static void Main(string[] args)
    {
        // Creazione guidata della Biblioteca
        Console.WriteLine("=== CONFIGURAZIONE BIBLIOTECA ===");
        Console.Write("Inserisci il nome della biblioteca: ");
        string Library = Console.ReadLine();
        Console.Write("Inserisci l'indirizzo: ");
        string Adress = Console.ReadLine();
        Console.Write("Orario Apertura (es. 09:00): ");
        string Opening = Console.ReadLine();
        Console.Write("Orario Chiusura (es. 18:00): ");
        string Closing = Console.ReadLine();

        Library MyLibrary = new Library(Library, Adress, Opening, Closing);

        bool IsRunning = true;
        while (IsRunning)
        {
            Console.WriteLine($"\n=== MENU {MyLibrary.Name.ToUpper()} (Aperta: {MyLibrary.OpeningHour}-{MyLibrary.ClosingHour}) ===");
            Console.WriteLine("1. Aggiungi un nuovo Libro");
            Console.WriteLine("2. Esci");
            Console.Write("Seleziona un'opzione: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Inserimento Nuovo Libro ---");
                    Console.Write("Autore: ");
                    string author = Console.ReadLine();
                    Console.Write("Titolo: ");
                    string title = Console.ReadLine();
                    Console.Write("Anno di Pubblicazione: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Editore: ");
                    string editor = Console.ReadLine();
                    Console.Write("Numero di Pagine: ");
                    int pages = int.Parse(Console.ReadLine());

                    // Istanziamo il libro usando il costruttore della tua classe Book
                    Book newbook = new Book(author, title, year, editor, pages);

                    // Lo aggiungiamo alla biblioteca
                    MyLibrary.AddBook(newbook);
                    break;

                case "2":
                    IsRunning = false;
                    Console.WriteLine("Chiusura del programma di test.");
                    break;

                default:
                    Console.WriteLine("Opzione non valida. Riprova.");
                    break;
            }
        }
    }
}

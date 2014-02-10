using System;
using mam.steuerung.serverportal;

namespace ServerPortalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new ServerPortal())
            {
                server.Zurücksetzungswunsch += () => Console.WriteLine("Zurücksetzungswunsch");
                server.Fehler += () => Console.WriteLine("Fehler");
                server.Reparaturwunsch += () => Console.WriteLine("Reparaturwunsch");
                server.HilfeUnterwegs += () => Console.WriteLine("Hilfe unterwegs");
                server.Starten();
                Console.ReadLine();
            }
        }
    }
}
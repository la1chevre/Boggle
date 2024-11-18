namespace Projet_Boogle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionnaire mots = new Dictionnaire("fr");
            string a = mots.toString();
            Console.WriteLine(a);
        }
    }
}
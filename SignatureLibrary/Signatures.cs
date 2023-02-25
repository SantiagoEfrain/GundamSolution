namespace SignatureLibrary
{
    public class Signatures
    {
        public static void Header(string title)
        {
            Console.Title = "=========" + title.ToUpper() + "=========";
            Console.WriteLine("-= CSF 2: Breaking New Ground on " + title.ToUpper() + "=-");
        }//end header

        public static void Footer()
        {
            Console.WriteLine("\n\nCode completed. Press any key to exit.");
            Console.ReadKey(true);
        }//end footer()

    }
}
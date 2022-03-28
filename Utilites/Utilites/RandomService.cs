namespace Utilites
{
    public class RandomService
    {
        public static string RandomString ()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[8];
            Random random = new();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new (stringChars);
            return finalString;
        }

        public static int RandomNumber()
        {
            var random = new Random();
            return random.Next(1949,DateTime.Now.Year + 1);
        }
    }
}

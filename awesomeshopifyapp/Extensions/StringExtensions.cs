namespace awesomeshopifyapp.Extensions
{
    public static class IntExtensions
    {
        public static int Factorial(this int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * (number - 1).Factorial();
        }
    }
}

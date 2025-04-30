namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}

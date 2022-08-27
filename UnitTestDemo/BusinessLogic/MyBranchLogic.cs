namespace BusinessLogic
{
    public static class MyBranchLogic
    {
        public static bool BranchLogic(bool a, bool b)
        {
            var result = false;

            if (a)
            {
                if (b)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

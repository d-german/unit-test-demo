using BusinessLogic;

namespace Controller
{
    internal class Program
    {
        private static void Main()
        {
            var res = MyBranchLogic.BranchLogic(true, true);

            Console.WriteLine(res);

            res = MyBranchLogic.BranchLogic(true, false);

            Console.WriteLine(res);
        }
    }
}

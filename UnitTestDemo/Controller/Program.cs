using BusinessLogic;

namespace Controller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = MyBranchLogic.BranchLogic(true, true);

            Console.WriteLine(res);

            res = MyBranchLogic.BranchLogic(true, false);

            Console.WriteLine(res);
        }
    }
}
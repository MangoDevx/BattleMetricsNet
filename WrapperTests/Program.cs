using System.Threading.Tasks;

namespace WrapperTests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new WrapperTests().BeginTests();
            await Task.Delay(-1);
        }
    }
}
namespace SingASong
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var tests = new SongTests();
			tests.Test_Original_Song();
			tests.Test_Custom_Song();
		}
	}
}
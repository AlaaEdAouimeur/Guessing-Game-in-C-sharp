using System; 
namespace Number{
	class MainC{
		public static void Main () {
			Random rnd = new System.Random ();
			int choice ,Random=0,pick;
			Char go;
			bool lucky = false;
			Console.WriteLine("-----Welcome To My Number Guessing Game-----")	;
			do {
				lucky = false;
			Console.WriteLine("1.Easy (1-10)");
			Console.WriteLine("2.Medium (1-50)");
			Console.WriteLine("3.Hard (1-100)");
			Console.WriteLine("Pick the Level Of Your Choice : ");
			choice =Convert.ToInt32(Console.ReadLine());
			if (choice == 1)
				Random = rnd.Next (1, 10);
			else if (choice == 2)
				Random = rnd.Next (1, 50);
			else if (choice == 3)
				Random = rnd.Next (1, 100);
			Console.WriteLine (" Try To Geuss My Number");
			while (lucky==false){
				pick = Convert.ToInt32 (Console.ReadLine ());
				if (pick == Random) {
					Console.WriteLine ("CORRECT! ,That Is My Number!!");
					lucky = true;
				}
				else if (pick < Random)
					Console.WriteLine ("Try Guessing A Little Bit Higher");
				else if (pick > Random)
					Console.WriteLine ("try Guessing A little Bit Lower");
			}
				Console.WriteLine("Wanna Go Again Type (Y/y) if You Want to ");
				go =Convert.ToChar(Console.ReadLine());
			}while (go=='y' || go == 'Y' );
			
			


		}
	}
}
	
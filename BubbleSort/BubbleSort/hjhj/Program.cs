using System;

namespace hjhj
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] kek = { 8, 4, 12, 3, 5, 9 };
			int j = 0;
			int x;

			for (int i = 0; i < kek.Length; i++) {
				for (j = kek.Length - 1; j > i; j--) {
					if (kek [j - 1] > kek [j]) {
						x = kek [j - 1]; 
						kek [j - 1] = 0;
						kek [j - 1] = kek [j];
						kek [j] = x;
					}

				}


			}
			foreach (var a in kek) {
				Console.Write (a + ", ");
			}
		}
	}
}

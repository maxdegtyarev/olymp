using System;

class app
{
	static void Main()
	{
		/*
		 *	Постановка задачи: найти количество сочетаний букв в виде слова hello в строке 
		 * 	Данный алгоритм можно юзнуть для динамического программирования, только без всяких массивов)
		 * 	
		 * 	2016, Максим Дегтярёв
		 * 
		 * 
		*/
		//Алгоритм неэффективен по памяти, но если тут динамически вводить, то норм)
		string input = "hello";
		char[] text = "mynameismaximhelloimfinehello".ToCharArray();

		//Длина входной строки
		var leng = (input.ToCharArray()).Length;
		int result = 0;
		string dline;

		for (int i = 0; i < text.Length - input.Length; i++) {
			//Создаём временную переменную для хранения временной строки

			dline = string.Empty;
			for (int z = i; z < leng; z++) {
				dline = dline + text[z];
			}
			if (input == dline) {
				result++;
			}
			leng++;
		}

		Console.WriteLine (result);
		Console.ReadKey ();


	
	}

}
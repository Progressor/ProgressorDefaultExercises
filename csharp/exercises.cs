using System;

namespace Progressor.DefaultExercises.CSharp {

	public class Program {

		static void Main() {

			var program = new Program();
			Console.WriteLine(program.helloWorld());
			Console.WriteLine(program.alternate("Hlo ol!", "el,Wrd"));
		}

		public string helloWorld() => "Hello, World!";

		public string alternate(string first, string second) {
			var result = string.Empty;
			int i;
			for (i = 0; i < first.Length && i < second.Length; i++)
				result += first[i].ToString() + second[i];
			result += first.Substring(i) + second.Substring(i);
			return result;
		}
	}
}

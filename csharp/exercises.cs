using System;

namespace Progressor.DefaultExercises.CSharp {

	public class Exercises {

		static void Main() {

			var exercises = new Exercises();
			Console.WriteLine(exercises.helloWorld());
			Console.WriteLine(exercises.alternate("Hlo ol!", "el,Wrd"));
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

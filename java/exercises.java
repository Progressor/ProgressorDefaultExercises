
public class exercises {

	public static void main(String... args) {

		exercises inst = new exercises();
		System.out.println(inst.helloWorld());
		System.out.println(inst.alternate("Hlo ol!", "el,Wrd"));
	}

	public String helloWorld() {
		return "Hello, World!";
	}

	public String alternate(String first, String second) {
		String result = "";
		int i;
		for (i = 0; i < first.length() && i < second.length(); i++)
			result += first.substring(i, i + 1) + second.substring(i, i + 1);
		result += first.substring(i) + second.substring(i);
		return result;
	}
}

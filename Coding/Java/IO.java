import java.util.Scanner;

public class IO {
	public static void main(String args[]) {
		Scanner in = new Scanner(System.in);
		System.out.println("Type something: ");
		String userInput = in.nextLine();
		System.out.println("You typed in: " + userInput);
		in.close();
	}
}
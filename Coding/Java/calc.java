import java.util.Scanner;

class calc {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int z;
		System.out.println("Enter an operator: ");
		String op = input.nextLine();
		System.out.println("Enter a number: ");
		String stringX = input.nextLine();
		System.out.println("Enter another number: ");
		String stringY = input.nextLine();
		int x = Integer.parseInt(stringX);
		int y = Integer.parseInt(stringY);
		if (op == "+") {
			try {
				z = x + y;
				System.out.println("The sum is: " + z);
			} catch (Exception e) {
				System.out.println("Something went wrong. Try again later.");
			}
		} else if (op == "-") {
			try {
				z = x - y;
				System.out.println("The sum is: " + z);
			} catch (Exception e) {
				System.out.println("Something went wrong. Try again later.");
			}
		} else if (op == "*") {
			try {
				z = x * y;
				System.out.println("The sum is: " + z);
			} catch (Exception e) {
				System.out.println("Something went wrong. Try again later.");
			}
		} else if (op == "/") {
			try {
				z = x / y;
				System.out.println("The sum is: " + z);
			} catch (Exception e) {
				System.out.println("Something went wrong. Try again later.");
			}
		} else {
			System.out.println("Something went wrong. Try again later.");
		}
	}
}
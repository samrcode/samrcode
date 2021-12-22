// IO
import java.util.Scanner;

public class IO {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Type something: ");
        String input = String.valueOf(in.nextLine());
        System.out.println("The user typed: " + input);
        in.close();
    }
}

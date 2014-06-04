import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner n = new Scanner(System.in);
		int number = n.nextInt();
		String[] town = new String[number];
		for (int i = 0; i < number; i++) {
			town[i] = n.next();
		}
		System.out.println();
		Arrays.sort(town);
		for (int i = 0; i < number; i++) {
			System.out.println(town[i]);
		}
	}

}

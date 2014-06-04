import java.util.Scanner;

public class LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		/*
		 * Write a program that enters an array of strings and finds in it the
		 * largest sequence of equal elements. If several sequences have the
		 * same longest length, print the leftmost of them. The input strings
		 * are given as a single line, separated by a space.
		 */

		Scanner in = new Scanner(System.in);
		String str = in.nextLine();
		String[] arr = str.split(" ");
		int counter = 1;
		int count = 1;
		int position = 0;

		for (int i = 1; i < arr.length; i++) {
			if (arr[i].equals(arr[i - 1])) {
				counter++;
			} else {
				counter = 1;
			}
			if (counter > count) {
				count = counter;
				position = i;
			}
		}
		for (int j = 0; j < count - 1; j++) {
			System.out.print(arr[position] + " ");
		}
		System.out.println(arr[position]);

	}

}

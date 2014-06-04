import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {

	public static void main(String[] args) {
		/*
		 * Write a program to enter a number n and n integer numbers and sort
		 * and print them.
		 */
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		in.nextLine();
		int[] number = new int[n];
		for (int i = 0; i < number.length; i++) {
			number[i] = in.nextInt();
		}
		Arrays.sort(number);
		for (int j = 0; j < number.length - 1; j++) {
			System.out.print(number[j] + " ");
		}
		System.out.print(number[n - 1]);

	}

}

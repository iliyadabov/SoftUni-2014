package JavaSyntax;

import java.util.Scanner;

public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int bit = 0;
		int counter = 0;
		int foundPairs = 0;

		while (n > 0) {

			if ((n & 1) == 1 && bit == 0) {
				counter = 0;
				bit = 1;
			}

			if ((n & 1) == 0 && bit == 1) {
				counter = 0;
				bit = 0;
			}

			if ((n & 1) == 1) {
				bit = 1;
			} else {
				bit = 0;
			}

			if ((n & 1) == 1 && bit == 1) {
				counter++;
				if (counter == 2) {
					foundPairs++;
					counter = 1;
				}
			}

			if ((n & 1) == 0 && bit == 0) {
				counter++;
				if (counter == 2) {
					foundPairs++;
					counter = 1;
				}
			}

			n = n >> 1;
		}
		System.out.println(foundPairs);

	}

}

package SortArrayOfNumbers;


import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num = scan.nextInt();
        scan.nextLine();
        String[] numbers = scan.nextLine().split(" ");
        int[] ints = new int[numbers.length];

        for (int i = 0; i < num; i++) {
            ints[i] = Integer.parseInt(numbers[i]);
        }
        Arrays.sort(ints);

        for (int anInt : ints) {
            System.out.print(anInt + " ");
        }
    }
}

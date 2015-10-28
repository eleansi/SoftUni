package ImplementRecursiveBinarySearch;


import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class ImplementRecursiveBinarySearch {
    static List<Integer> hayStack;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Insert the number to search for = ");
        int needle = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Insert integers separated by space on a single line = ");
        hayStack = Stream.of(scanner.nextLine().split(" "))
                .map(num -> Integer.parseInt(num))
                .sorted()
                .collect(Collectors.toList());

        int needleIndex = binarySearch(needle, 0, hayStack.size() - 1);
        System.out.println(needleIndex);
    }
    private static int binarySearch(int needle, int start, int end) {

        if (end < start) {
            return -1;
        }

        int middle = (start + end) / 2;

        if (hayStack.get(middle) < needle) {
            return binarySearch(needle, middle + 1, end);
        }

        if (hayStack.get(middle) > needle) {
            return binarySearch(needle, start, middle - 1);
        }

        return middle;
    }
}

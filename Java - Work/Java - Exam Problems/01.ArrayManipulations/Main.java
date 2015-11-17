package com.company;

import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
       /* Scanner console = new Scanner(System.in);
        int[] input = Arrays.stream(console.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        List<Integer> numbers = addNumbersToList(input);
        numbers = addNumbersToList(input);
        String[] commands = console.nextLine().split("\\s+");

        while (!commands[0].equals("end")) {
            String command = commands[0];
            if (command.equals("exchange")) {
                numbers = exchange(numbers, commands);
            }
            if (command.equals("max")) {
                maxEvenOdd(numbers, commands);
            }
            if (command.equals("min")) {
                minEvenOdd(numbers, commands);
            }
            if (command.equals("first")) {
                firstEvenOdd(numbers, commands);
            }
            if (command.equals("last")) {
                lastEvenOdd(numbers, commands);
            }
            commands = console.nextLine().split("\\s+");
        }
        System.out.println(numbers);*/

        Scanner scan = new Scanner(System.in);
        String[] inputArray = scan.nextLine().split(" ");
        int[] arr = new int[inputArray.length];
        for (int i = 0; i < inputArray.length; i++) {
            arr[i] = Integer.parseInt(inputArray[i]);
        }

        String inputLine = scan.nextLine();
        while (!inputLine.equals("end")) {
            String[] inputArgs = inputLine.split(" ");
            String command = inputArgs[0];
            switch (command) {
                case "exchange":
                    int index = Integer.parseInt(inputArgs[1]);
                    if (index < 0 || index >= arr.length) {
                        System.out.println("Invalid index");
                        break;
                    }
                    arr = exchange(arr, index);
                    break;
                case "min":
                    System.out.println(getMin(arr, inputArgs[1]));
                    break;
                case "max":
                    System.out.println(getMax(arr, inputArgs[1]));
                    break;
                case "first":
                    System.out.println(getFirst(arr, Integer.parseInt(inputArgs[1]), inputArgs[2]));
                    break;
                case "last":
                    System.out.println(getLast(arr, Integer.parseInt(inputArgs[1]), inputArgs[2]));
                    break;
            }
            inputLine = scan.nextLine();
        }
        System.out.println(Arrays.toString(arr));
    }

    private static int[] exchange(int[] arr, int index) {
        int[] tempArr = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            tempArr[i] = arr[(index + i + 1) % arr.length];
        }
        return tempArr;
    }

    private static String getMin(int[] arr, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        int max = Integer.MAX_VALUE;
        int index = -1;
        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];
            if (current % 2 == remainder && current <= max) {
                max = current;
                index = i;
            }
        }
        return index < 0 ? "No matches" : Integer.toString(index);
    }

    private static String getMax(int[] arr, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        int max = Integer.MIN_VALUE;
        int index = -1;
        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];
            if (current % 2 == remainder && current >= max) {
                max = current;
                index = i;
            }
        }
        return index < 0 ? "No matches" : Integer.toString(index);
    }

    private static String getFirst(int[] arr, int count, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        ArrayList<Integer> tempList = new ArrayList<>();

        if (count > arr.length) {
            return "Invalid count";
        }
        for (int i = 0; i < arr.length; i++) {
            int current = arr[i];

            if (current % 2 == remainder) {
                tempList.add(current);
            }
            if (tempList.size() >= count) {
                break;
            }
        }
        return "["+ String.join(", ", tempList.stream().map(e -> Integer.toString(e)).collect(Collectors.toList()))+ "]";
    }

    private static String getLast(int[] arr, int count, String parity) {
        int remainder = parity.equals("odd") ? 1 : 0;
        ArrayList<Integer> tempList = new ArrayList<>();

        if (count > arr.length) {
            return "Invalid count";
        }
        for (int i = arr.length - 1; i >= 0; i--) {
            int current = arr[i];
            if (current % 2 == remainder) {
                tempList.add(0, current);
            }

            if (tempList.size() >= count) {
                break;
            }
        }
        return "["+ String.join(", ", tempList.stream().map(e -> Integer.toString(e)).collect(Collectors.toList()))+"]";
    }

    /*public static void maxEvenOdd(List<Integer> numbers, String[] commands) {
        List<Integer> maxNumberIndex;
        if (commands[1].equals("odd")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 1)) {
                System.out.println("No matches");
            } else {
                maxNumberIndex = numbers.stream().filter(num -> num % 2 == 1).sorted().collect(Collectors.toList());
                System.out.println(numbers.lastIndexOf(maxNumberIndex.get(maxNumberIndex.size() - 1)));
            }
        }
        if (commands[1].equals("even")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 0)) {
                System.out.println("No matches");
            } else {
                maxNumberIndex = numbers.stream().filter(num -> num % 2 == 0).sorted().collect(Collectors.toList());
                System.out.println(numbers.lastIndexOf(maxNumberIndex.get(maxNumberIndex.size() - 1)));
            }
        }
    }

    public static void minEvenOdd(List<Integer> numbers, String[] commands) {
        // this probably has a mistake about indexOf
        List<Integer> maxNumberIndex;
        if (commands[1].equals("odd")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 1)) {
                System.out.println("No matches");
            } else {
                maxNumberIndex = numbers.stream().filter(num -> num % 2 == 1).sorted().collect(Collectors.toList());
                System.out.println(numbers.lastIndexOf(maxNumberIndex.get(0)));
            }
        }
        if (commands[1].equals("even")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 0)) {
                System.out.println("No matches");
            } else {
                maxNumberIndex = numbers.stream().filter(num -> num % 2 == 0).sorted().collect(Collectors.toList());
                System.out.println(numbers.lastIndexOf(maxNumberIndex.get(0)));
            }
        }
    }

    public static List<Integer> addNumbersToList(int[] input) {
        List<Integer> numbers = new ArrayList<Integer>();
        for (int i = 0; i < input.length; i++) {
            numbers.add(input[i]);
        }
        return numbers;
    }

    public static List<Integer> exchange(List<Integer> numbers, String[] commands) {
        int index = Integer.parseInt(commands[1]);

        List<Integer> tempList = new ArrayList<>();
        if (index<0  || index >= numbers.size()) {
            System.out.println("Invalid index");
        } else {
            index++;
            tempList.addAll(numbers.subList(index, numbers.size()));
            for (int i = numbers.size() - 1; i >= index; i--) {
                numbers.remove(i);
            }
            numbers.addAll(0, tempList);
        }
        return numbers;
    }

    public static void firstEvenOdd(List<Integer> numbers, String[] commands) {
        int count = Integer.parseInt(commands[1]);
        List<Integer> output = new ArrayList<>();
        if (count > numbers.size()) {
            System.out.println("Invalid count");
            return;
        }
        if (commands[2].equals("odd")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 1)) {
                System.out.println("[]");
            } else {
                numbers = numbers.stream().filter(num -> num % 2 == 1).collect(Collectors.toList());
                count=count>numbers.size()?numbers.size():count;
                output.addAll(numbers.subList(0, count));
                System.out.println(output);
            }
        }
        if (commands[2].equals("even")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 0)) {
                System.out.println("[]");
            } else {
                numbers = numbers.stream().filter(num -> num % 2 == 0).collect(Collectors.toList());
                count=count>numbers.size()?numbers.size():count;
                output.addAll(numbers.subList(0, count));
                System.out.println(output);
            }
        }

    }

    public static void lastEvenOdd(List<Integer> numbers, String[] commands) {
        int count = Integer.parseInt(commands[1]);
        List<Integer> output = new ArrayList<>();
        if (count > numbers.size()) {
            System.out.println("Invalid count");
            return;
        }
        if (commands[2].equals("odd")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 1)) {
                System.out.println("[]");
            } else {
                numbers = numbers.stream().filter(num -> num % 2 == 1).collect(Collectors.toList());
                count=count>numbers.size()?numbers.size():count;
                output.addAll(numbers.subList(numbers.size() - count, numbers.size()));
                System.out.println(output);
            }
        }
        if (commands[2].equals("even")) {
            if (numbers.stream().noneMatch(num -> num % 2 == 0)) {
                System.out.println("[]");
            } else {
                numbers = numbers.stream().filter(num -> num % 2 == 0).collect(Collectors.toList());
                count=count>numbers.size()?numbers.size():count;
                output.addAll(numbers.subList(numbers.size() - count, numbers.size()));
                System.out.println(output);
            }
        }
    }*/
}
package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class P13GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        String[] commands = sc.nextLine().split(" ");
        Integer numCount = Integer.parseInt(commands[1]);
        String oddOrEven = commands[2];
        List<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            numbers.add(Integer.parseInt(input[i]));
        }

        switch(oddOrEven){
            case "even": getEvenElements(numCount, numbers);
                break;
            case "odd": getOddElements(numCount, numbers);
                break;
            default: System.out.println("Invalid command");
                break;
        }

    }
    private static void getEvenElements(int numCount, List<Integer> numbers){
        int counter = 0;
        for (int i = 0; i < numbers.size(); i++) {
            if (numbers.get(i) % 2 == 0) {
                System.out.print(numbers.get(i) + " ");
                counter++;
            }
            if (counter >= numCount){
                break;
            }
        }
    }
    private static void getOddElements(int numCount, List<Integer> numbers){
        int counter = 0;
        for (int i = 0; i < numbers.size(); i++) {
            if (numbers.get(i) % 2 == 1) {
                System.out.print(numbers.get(i) + " ");
                counter++;
            }
            if (counter >= numCount){
                break;
            }
        }
    }
}

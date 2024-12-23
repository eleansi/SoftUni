package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class P8OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        List<Integer> numbers = new ArrayList();
        for (int i = 0; i < input.length; i++) {
            numbers.add(Integer.parseInt(input[i]));
        }

        if (numbers.size() % 2 == 1) {
            System.out.println("Invalid length");
        }
        for (int i = 0; i < numbers.size(); i += 2) {
            boolean isOdd = false;
            boolean isEven = false;

            if (numbers.get(i) % 2 == 0 && numbers.get(i + 1) % 2 == 0) {
                isEven = true;
            }
            else if (numbers.get(i) % 2 == 1 && numbers.get(i + 1) % 2 == 1){
                isOdd = true;
            }
            System.out.printf("%s, %s -> ", numbers.get(i), numbers.get(i + 1));
            if(isEven){
                System.out.println("both are even");
            } else if(isOdd){
                System.out.println("both are odd");
            } else {
                System.out.println("different");
            }
        }

    }
}

package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
        String[] tokens = sc.nextLine().split("\\s+");
        double totalSum = 0;
        for (String token : tokens){
            char firstLetter = token.charAt(0);
            char lastLetter = token.charAt(token.length() - 1);
            double number = Double.parseDouble(token.substring(1, token.length() - 1));


            if (Character.isUpperCase(firstLetter)){
                number /= (firstLetter - 'A' + 1);
            } else {
                number *= (firstLetter - 'a' + 1);
            }
            if (Character.isUpperCase(lastLetter)){
                number -= lastLetter - 'A' + 1;
            } else {
                number += lastLetter - 'a' + 1;
            }
            totalSum += number;
        }
        System.out.printf("%.2f", totalSum);
    }
}

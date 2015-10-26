package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();
        inputLine = inputLine.replaceAll("[\\\\\\/\\(\\)\\|\\s]+", "");

        String[] allwords = inputLine.split("[^a-zA-Z]+");
        String bestWords = "";

        int bestWeight = Integer.MIN_VALUE;
        for (int i = 0; i < allwords.length - 1; i++) {
            int firstWordWeight = getWeight(allwords[i]);
            int secondWordWeight = getWeight(allwords[i + 1]);

            int currentWordWeight = firstWordWeight + secondWordWeight;
            if (currentWordWeight >= bestWeight){
                bestWeight = currentWordWeight;
                bestWords = allwords[i] + "\n" + allwords[i + 1];
            }
        }
        System.out.println(bestWords);
    }
    private static int getWeight(String str){
        str = str.toLowerCase();
        int totalWeight = 0;
        for (int i = 0; i < str.length(); i++) {
            int currentWeight = str.charAt(i) - 'a' + 1;
            totalWeight += currentWeight;
        }
        return totalWeight;
    }
}

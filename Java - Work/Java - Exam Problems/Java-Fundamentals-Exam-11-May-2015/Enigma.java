package com.company;

import java.util.Scanner;

public class Enigma {

    public static void main(String[] args) {
	    Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        String[] lines = new String[n];
        for (int i = 0; i < lines.length; i++) {
            lines[i] = scan.nextLine();
        }

        int m;

        for (int i = 0; i < lines.length; i++) {
            m = lines[i]
                    .replaceAll("[\\s\\d]+", "")
                    .length() / 2;
            for (int j = 0; j < lines[i].length(); j++) {
                char currentChar = lines[i].charAt(j);

                if ((currentChar >= '0' && currentChar <= '9') || currentChar == ' ') {
                    System.out.print(currentChar);
                    continue;
                }
                char c = (char)(currentChar + m);
                System.out.print(c);
            }
            System.out.println();
        }


    }
}

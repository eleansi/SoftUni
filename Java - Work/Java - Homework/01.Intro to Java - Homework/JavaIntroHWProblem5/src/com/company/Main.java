package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter your number:");
        int number = Integer.parseInt(sc.nextLine());
        for (int row = 0; row < number; row++) {
            PrintLine(0, (char)row);
        }
        for (int row = number - 1; row >= 0; row--){
            PrintLine(0, (char)row - 1);
        }
    }
    static void PrintLine(int start, int end){
        for (int i = start; i <= end; i++) {
            System.out.print((char) (i + 97) + " ");
        }
        System.out.println();
    }
    }


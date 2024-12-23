package com.company;

import java.util.Scanner;

public class P1RectangleArea {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
        String[] numbers = sc.nextLine().split(" ");
        Integer x = Integer.parseInt(numbers[0]);
        Integer y = Integer.parseInt(numbers[1]);
        Integer area = x * y;
        System.out.println(area);
    }
}

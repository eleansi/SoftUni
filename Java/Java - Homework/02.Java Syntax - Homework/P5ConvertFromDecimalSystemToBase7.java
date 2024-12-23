package com.company;


import java.util.Scanner;

public class P5ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Integer number = sc.nextInt();
        int baseToConvertTo = 7;
        System.out.println(Long.toString(number, baseToConvertTo));
    }
}

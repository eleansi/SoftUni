package com.company;


import com.sun.deploy.util.StringUtils;

import java.util.Scanner;

public class P3FormatingNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Integer a = sc.nextInt();
        float b = sc.nextFloat();
        float c = sc.nextFloat();

        String hex = Integer.toHexString(a).toUpperCase();
        String toBinary = String.format("%10s", Integer.toBinaryString(a)).replace(" ", "0");


        System.out.printf("|%-10s|%s|%10.2f|%-10.3f", hex, toBinary, b, c);
    }
}

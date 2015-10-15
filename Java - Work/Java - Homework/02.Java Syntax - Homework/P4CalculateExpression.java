package com.company;


import com.sun.org.apache.bcel.internal.classfile.SourceFile;

import java.util.Scanner;

public class P4CalculateExpression {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        double result1 =
                Math.pow((((a * a) + (b * b))) / ((a * a) - (b * b)),
                        (a + b + c) / Math.sqrt(c));
        double result2 = Math.pow(((a * a) + (b * b) - (c * c * c)), a - b);
        double average = ((a + b + c) / 3.0) - ((result1 + result2) / 2.0);

        System.out.printf("F1 result: %.2f", result1);
        System.out.print(" ");
        System.out.printf("F2 result: %.2f", result2);
        System.out.print(" ");
        System.out.printf("Diff: %.2f", Math.abs(average));
    }
}

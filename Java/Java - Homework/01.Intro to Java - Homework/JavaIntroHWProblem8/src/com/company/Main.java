package com.company;

import java.math.BigDecimal;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();

        double result = FindAverage(a, b, c);
        System.out.println(String.format("%.2f", result));
    }

    static double FindAverage(double a, double b, double c){
        double average = (a + b + c) / 3.0;
        return average;
    }
}

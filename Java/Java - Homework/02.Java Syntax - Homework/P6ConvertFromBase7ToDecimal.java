package com.company;


import com.sun.org.apache.xpath.internal.SourceTree;

import java.math.BigDecimal;
import java.util.Scanner;

public class P6ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String number = sc.next();
        try{
            Integer decimalNum = Integer.valueOf(number, 7);
            System.out.println(decimalNum);
        } catch(NumberFormatException e) {
            System.out.println("Invalid number");
        }

    }
}

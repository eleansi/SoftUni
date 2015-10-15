package com.company;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P10ExtractWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern pat = Pattern.compile("([A-Za-z]+)");
        Matcher match = pat.matcher(input);
        while (match.find()){
            System.out.print(match.group() + " ");
        }
    }
}

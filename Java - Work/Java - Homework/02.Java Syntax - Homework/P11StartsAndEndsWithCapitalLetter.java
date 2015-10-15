package com.company;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P11StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern pat = Pattern.compile("(\\b[A-Z]\\w*[A-Z]\\b)");
        Matcher match = pat.matcher(input);
        while (match.find()){
            System.out.print(match.group() + " ");
        }
    }
}

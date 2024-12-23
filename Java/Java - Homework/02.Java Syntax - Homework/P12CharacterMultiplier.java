package com.company;


import java.util.Scanner;

public class P12CharacterMultiplier {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstString = sc.next();
        String secondString = sc.next();
        Long sum = 0L;
        for (int i = 0; i < firstString.length(); i++) {
            sum += firstString.charAt(i) * secondString.charAt(i);
        }
        sum += getReminder(firstString, secondString);

        System.out.println(sum);
    }

    private static Long getReminder(String firstString, String secondString) {
        Long sumReminder = 0L;
        if (firstString.length() > secondString.length()){
            String reminder = firstString.substring(secondString.length());
            for (int i = 0; i < reminder.length(); i++) {
                sumReminder += reminder.charAt(i);

            }
        } else if(secondString.length() > firstString.length()){
            String reminder = secondString.substring(firstString.length());
            for (int i = 0; i < reminder.length(); i++) {
                sumReminder += reminder.charAt(i);

            }
        }
        return sumReminder;
    }
}

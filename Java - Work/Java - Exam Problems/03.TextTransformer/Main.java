package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        String line = scan.nextLine();

        while(!line.equals("burp")){
            sb.append(line);
            line = scan.nextLine();
        }
        String finalString = sb.toString();
        finalString = finalString.replaceAll("\\s+", " ");
        StringBuilder output = new StringBuilder();
        Pattern pattern = Pattern.compile("([$'%&])([^$'%&]+)\\1");
        Matcher match = pattern.matcher(finalString);
        while(match.find()){
            char specialChar = match.group(1).charAt(0);
            int weight = getWeight(specialChar);
            String stringCaptured = match.group(2);


            for (int i = 0; i < stringCaptured.length(); i++) {
                char nextChar = stringCaptured.charAt(i);
                char newChar;
                if (i % 2 == 0) {
                    newChar = (char)(weight + nextChar);
                } else {
                    newChar = (char)(nextChar - weight);
                }
                output.append(newChar);
            }
            output.append(" ");
        }
        System.out.print(output.toString());
    }

    private static int getWeight(char specialChar) {
        switch (specialChar){
            case '$': return 1;
            case '%': return 2;
            case '\'': return 3;
        }
        return 4;
    }
}

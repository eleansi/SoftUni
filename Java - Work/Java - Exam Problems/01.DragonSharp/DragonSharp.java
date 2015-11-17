package com.company;


import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DragonSharp {
    private static ArrayList<String> outputList;
    private static String[] tokens;
    public static void main(String[] args) {
        outputList = new ArrayList<>();

        Scanner scan = new Scanner(System.in);
        int numOfRows = Integer.parseInt(scan.nextLine());
        String pattern = "(.*?)\"(.*?)\";";

        Pattern pat = Pattern.compile(pattern);
        boolean expectElse = false;
        boolean isError = false;
        int errorLine = 0;

        for (int i = 1; i <= numOfRows; i++) {
            String line = scan.nextLine();
            Matcher match = pat.matcher(line);

            if (match.find()){
                tokens = match.group(1).trim().split("\\s+");
                String output = match.group(2);

                if (tokens[0].equals("if")) {
                    if (evaluateCondition(tokens[1])){
                        executeCommand(output, false);
                        expectElse = false;
                    } else {
                        expectElse = true;
                    }
                } else if (tokens[0].equals("else") && expectElse) {
                    executeCommand(output, true);
                }
            } else {
                isError = true;
                errorLine = i;
            }
        }
        if (isError){
            System.out.println("Compile time error @ line " + errorLine);
        } else {
            for (String line : outputList) {
                System.out.println(line);
            }
        }
    }
    private static boolean evaluateCondition(String condition){
        condition = condition.substring(1, condition.length() - 1);
        String[] parameters = condition.split("[<=>]+");

        int param1 = Integer.parseInt(parameters[0]);
        int param2 = Integer.parseInt(parameters[1]);
        String operator = condition.replaceAll("\\d+", "");
        boolean result;
        switch (operator){
            case "==": result = param1 == param2; break;
            case "<": result = param1 < param2; break;
            case ">": result = param1 > param2; break;
            default: result = false;
        }
        return result;
    }

    private static void executeCommand(String output, boolean isElse){
        int loopIndex = isElse ? 1 : 2;
        boolean isLoop = tokens[loopIndex].equals("loop");
        int execution = isLoop ? Integer.parseInt(tokens[loopIndex + 1]) : 1;
        for (int i = 1; i <= execution; i++) {
            outputList.add(output);
        }
    }
}
package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
	    Scanner scan = new Scanner(System.in);
        int numberOfRows = Integer.parseInt(scan.nextLine());

        TreeMap<String, LinkedHashMap<String, Integer>> data = new TreeMap<>();
        for (int i = 1; i <= numberOfRows; i++) {
            String[] lineArgs = scan.nextLine().split("\\s+");
            String company = lineArgs[0];
            String nuts = lineArgs[1];
            String amountAsString = lineArgs[2].replaceAll("\\D+", "");
            int amount = Integer.parseInt(amountAsString);
            if (!data.containsKey(company)){
                data.put(company, new LinkedHashMap<>());
            }
            if (!data.get(company).containsKey(nuts)){

                data.get(company).put(nuts, 0);
            }
            int currentamount = data.get(company).get(nuts);
            if (data.get(company).containsKey(nuts)){
                data.get(company).put(nuts, amount + currentamount);
            }
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> company : data.entrySet()) {
            System.out.print(company.getKey() + ": ");
            StringBuilder output = new StringBuilder();
            for (Map.Entry<String,Integer> nutsAndAmount : company.getValue().entrySet()) {
                output.append(nutsAndAmount.getKey() + "-" + nutsAndAmount.getValue() + "kg, ");
            }
            String outputString = output.toString().substring(0, output.length() - 2);
            System.out.println(outputString);
        }
    }
}

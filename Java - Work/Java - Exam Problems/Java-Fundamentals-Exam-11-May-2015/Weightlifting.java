package com.company;


import java.util.*;

public class Weightlifting {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());

        TreeMap<String, TreeMap<String, Long>> weightlifting = new TreeMap<String, TreeMap<String, Long>>();
        for (int i = 0; i < n; i++) {

            String[] inputArgs = scan.nextLine().split(" ");
            String name = inputArgs[0];
            String exercise = inputArgs[1];
            Long weight = Long.parseLong(inputArgs[2]);

            if (!weightlifting.containsKey(name)) {
                weightlifting.put(name, new TreeMap<String, Long>());

            }
            if (!weightlifting.get(name).containsKey(exercise)) {
                weightlifting.get(name).put(exercise, weight);

            } else {
               long previousWeight = weightlifting.get(name).get(exercise);
               weightlifting.get(name).put(exercise, weight + previousWeight);
                }
            }


        for (Map.Entry<String, TreeMap<String, Long>> nameEntry : weightlifting.entrySet()) {
            String s = nameEntry.getKey();
            System.out.print(s + " : ");
            List<String> values = new ArrayList<>();
            for (Map.Entry<String, Long> innerEntry : nameEntry.getValue().entrySet()) {
                values.add(innerEntry.getKey() + " - " + innerEntry.getValue() + " kg");
            }
            System.out.println(String.join(", ", values));
        }
    }
}


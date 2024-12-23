package com.company;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String line = sc.nextLine();

        LinkedHashMap<String, LinkedHashMap<String, Integer>> venues = new LinkedHashMap<>();

        while(!line.equals("End")){
            //(\w+\s+\w+|\w+)\s+@(\w+\s+\w+)\s+(\d+)\s+(\d+)
            Pattern pat = Pattern.compile("([A-Za-z ]+)\\s+@([A-Za-z ]+)\\s+([0-9]+)\\s+([0-9]+)");
            Matcher matcher = pat.matcher(line);
            while(matcher.find()){
                String name = matcher.group(1);
                String venue = matcher.group(2);
                int ticketPrice = Integer.parseInt(matcher.group(3));
                int numberOfTickets = Integer.parseInt(matcher.group(4));
                int totalSum = ticketPrice * numberOfTickets;
                if (!venues.containsKey(venue)) {
                    venues.put(venue, new LinkedHashMap<>());
                }
                if (!venues.get(venue).containsKey(name)) {
                    venues.get(venue).put(name, 0);
                }
                venues.get(venue).put(name, venues.get(venue).get(name) + totalSum);

            }

            line = sc.nextLine();
        }
        for (Map.Entry<String, LinkedHashMap<String, Integer>> venuesPrint : venues.entrySet()) {
            System.out.println(venuesPrint.getKey());

                venuesPrint.getValue().entrySet().stream().sorted((x, y)
                        -> y.getValue().compareTo(x.getValue())).forEach((output) -> {
                    System.out.printf("#  %s -> %d\n", output.getKey(), output.getValue());
                });
        }
    }
}

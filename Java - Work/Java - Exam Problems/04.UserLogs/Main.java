
package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pattern pat = Pattern.compile("IP=([\\w.:]+)\\s+message='.*?'\\s+user=(.*)");

        String line = sc.nextLine();
        TreeMap<String, LinkedHashMap<String, Integer>> userLogs =
                new TreeMap<>();

        while(!line.equals("end")) {
            Matcher match = pat.matcher(line);
            if(match.find()){
                String ip = match.group(1);
                String username = match.group(2);
                if (!userLogs.containsKey(username)){
                    userLogs.put(username, new LinkedHashMap<>());
                }
                if (!userLogs.get(username).containsKey(ip)){
                    userLogs.get(username).put(ip, 0);
                }
                int currentCount = userLogs.get(username).get(ip);
                userLogs.get(username).put(ip, currentCount + 1);
            }
            line = sc.nextLine();
        }
        for (Map.Entry<String, LinkedHashMap<String, Integer>> pair : userLogs.entrySet()) {
            System.out.println(pair.getKey() + ": ");
            StringBuilder sb = new StringBuilder();
            for (Map.Entry<String,Integer> innerPair : userLogs.get(pair.getKey()).entrySet()) {
                sb.append(innerPair.getKey());
                sb.append(" => ");
                sb.append(innerPair.getValue());
                sb.append(", ");
            }

            String output = sb.toString();
            output = output.substring(0, output.length() - 2);
            System.out.println(output + ".");
        }
    }
}

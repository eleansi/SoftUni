package Problem4_LogsAggregator;


import java.util.Scanner;
import java.util.TreeMap;

public class LogsAggregator {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int numOfLines = Integer.parseInt(scan.nextLine());

        TreeMap<String, TreeMap<String, Integer>> users = new TreeMap<>();

        for (int i = 0; i < numOfLines; i++) {
            String line = scan.nextLine();
            String[] input = line.split(" ");
            String iP = input[0];
            String name = input[1];
            int duration = Integer.parseInt(input[2]);

            if (!users.containsKey(name)) { // Check if the name exists
                users.put(name, new TreeMap<>());
                users.get(name).put(iP, duration);
            } else if (users.get(name).containsKey(iP)) {
                int tempMinutes = users.get(name).get(iP);
                users.get(name).put(iP, tempMinutes + duration);
            }
            else{
                users.get(name).put(iP, duration);
            }
        }
        for (String user : users.keySet()) {
            System.out.printf("%s: ", user);
            int totalMinutes = 0;
            for (String ip : users.get(user).keySet()) {
                totalMinutes += users.get(user).get(ip);

            }
            System.out.print(totalMinutes + " ");
            System.out.print(users.get(user).keySet());
            System.out.println();
        }

    }
}

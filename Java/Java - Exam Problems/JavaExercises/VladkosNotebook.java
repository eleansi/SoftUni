package Problem7_VladkosNotebook;

import java.util.*;

public class VladkosNotebook {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String line = scan.nextLine();
        TreeMap<String, Player> pages = new TreeMap<>();
        boolean isValid = false;
        while(!line.equals("END")) {
            String[] inputArgs = line.split("\\|");
            String color = inputArgs[0];
            if (!pages.containsKey(color)) {
                pages.put(color, new Player());
            }
            if (inputArgs[1].equals("win")) {
                pages.get(color).winCount++;

                pages.get(color).opponents.add(inputArgs[2]);

            } else if (inputArgs[1].equals("loss")) {
                pages.get(color).loseCount++;
                pages.get(color).opponents.add(inputArgs[2]);
            } else if (inputArgs[1].equals("name")) {
                pages.get(color).name = inputArgs[2];
            } else if (inputArgs[1].equals("age")) {
                int age = Integer.parseInt(inputArgs[2]);
                pages.get(color).age = age;
            }

            line = scan.nextLine();
        }
        for (String color : pages.keySet()) {
            if (pages.get(color).name != null && pages.get(color).age != 0){
                System.out.println("Color: " + color);
                System.out.printf("-age: %d\n", pages.get(color).age);
                System.out.printf("-name: %s\n", pages.get(color).name);
                ArrayList<String> opponents = pages.get(color).opponents;
                if (opponents.size() == 0){
                    opponents.add("(empty)");
                } else {
                    Collections.sort(opponents);
                }
                System.out.printf("-opponents: %s\n", String.join(", ", opponents));
                double rank = (double)(pages.get(color).winCount + 1)/(pages.get(color).loseCount + 1);
                System.out.printf("-rank: %.2f\n", rank);
                isValid = true;
            }
        }
        if (!isValid){
            System.out.println("No data recovered.");
        }
    }
}

class Player {
    public String name = null;
    public int age = 0;
    public ArrayList<String> opponents = new ArrayList<String>();
    public int winCount;
    public int loseCount;
}
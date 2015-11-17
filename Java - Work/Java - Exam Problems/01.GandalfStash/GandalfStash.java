import java.util.Scanner;

public class GandalfStash {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int startMood = Integer.parseInt(scan.nextLine());
        String line = scan.nextLine();

        // ([,]?)|\s+
        String[] foods = line.split("[^a-zA-Z]+");
        String[] replacedFoods = new String[foods.length];
        for (int i = 0; i < foods.length; i++) {
            replacedFoods[i] =  foods[i].replaceAll("[\\W+\\_]", "").trim();

        }

        for (int i = 0; i < replacedFoods.length; i++) {
            switch (replacedFoods[i].toLowerCase()) {
                case "cram":
                    startMood += 2;
                    break;
                case "lembas":
                    startMood += 3;
                    break;
                case "apple":
                    startMood += 1;
                    break;
                case "melon":
                    startMood += 1;
                    break;
                case "honeycake":
                    startMood += 5;
                    break;
                case "mushrooms":
                    startMood -= 10;
                    break;
                case "_":
                    startMood += 1;
                    break;
                default:
                    startMood -= 1;
                    break;

            }
        }
        if (startMood < -5) {
            System.out.println(startMood);
            System.out.println("Angry");
        }
        if (startMood >= -5 && startMood <= 0) {
            System.out.println(startMood);
            System.out.println("Sad");
        }
        if (startMood > 0 && startMood <= 15) {
            System.out.println(startMood);
            System.out.println("Happy");
        }
        if (startMood > 15) {
            System.out.println(startMood);
            System.out.println("Special JavaScript mood");
        }
    }
}

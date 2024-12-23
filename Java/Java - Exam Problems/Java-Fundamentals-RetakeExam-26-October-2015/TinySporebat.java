package Problem1_TinySporebat;


import java.util.Scanner;

public class TinySporebat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        int totalHealth = 5800;
        int flocapsToBuySporebat = 30;
        int totalGlowcaps = 0;
        String enemies;
        int glowcaps;

        while(!input.equals("Sporeggar")){
            enemies = input.substring(0, input.length() - 1);
            glowcaps = Integer.parseInt(input.substring(input.length() - 1, input.length()));
            char[] enemiesToChars = enemies.toCharArray();

            for (char ch : enemiesToChars) {
                if (ch != 'L'){
                    totalHealth -= ch;
                } else {
                    totalHealth += 200;
                }
            }
            if (totalHealth <= 0){
                break;
            }
            totalGlowcaps += glowcaps;
            input = scan.nextLine();
        }
        if (totalHealth <= 0){
            System.out.printf("Died. Glowcaps: %d", totalGlowcaps);
        } else if (totalHealth >= 0 && totalGlowcaps < flocapsToBuySporebat){
            System.out.printf("Health left: %d\n", totalHealth);
            System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", flocapsToBuySporebat - totalGlowcaps);
        } else if (totalHealth >= 0 && totalGlowcaps >= flocapsToBuySporebat){
            System.out.printf("Health left: %d\n", totalHealth);
            System.out.printf("Bought the sporebat. Glowcaps left: %d", totalGlowcaps - flocapsToBuySporebat);
        }
    }
}

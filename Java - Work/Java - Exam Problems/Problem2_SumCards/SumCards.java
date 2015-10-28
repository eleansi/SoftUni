package Problem2_SumCards;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SumCards {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String inputLine = sc.nextLine();

        Pattern pat = Pattern.compile("[\\dJQKA]+");
        Matcher match = pat.matcher(inputLine);
        ArrayList<Integer> cards = new ArrayList<>();

        while(match.find()){
            if (match.group().equals("J")){
                cards.add(12);
            } else if (match.group().equals("Q")) {
                cards.add(13);
            } else if (match.group().equals("K")) {
                cards.add(14);
            } else if (match.group().equals("A")) {
                cards.add(15);
            } else {
                cards.add(Integer.parseInt(match.group()));
            }
        }

        int sum = 0;
        int count = 1;
        for (int i = 0; i < cards.size(); i += count) {
            int tempWeight = 0;
            count = 1;
            for (int j = i + 1; j < cards.size(); j++) {
                if (cards.get(i) == cards.get(j)){
                    count++;
                } else {
                    break;
                }
            }
            tempWeight = cards.get(i) * count;
            if (count != 1) {
                tempWeight *= 2;
            }
            sum += tempWeight;
        }
        System.out.println(sum);
    }
}

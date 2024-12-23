package CardsFrequencies;


import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] input = scr.nextLine().split(" ");
        int N = input.length;
        for (int i = 0; i < input.length; i++) {
            input[i] =  input[i].replaceAll("\\?", " ");
        }
        Map<String, Integer> wordsCount = new LinkedHashMap<>();
        for (String word : input) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            wordsCount.put(word, count + 1);
        }
        for (Map.Entry<String, Integer> stringIntegerEntry : wordsCount.entrySet()) {
            double result = ((stringIntegerEntry.getValue()/ (N + 0.0))* 100);

            System.out.printf("%s-> %.2f\n",stringIntegerEntry.getKey(),result);
        }
    }
}

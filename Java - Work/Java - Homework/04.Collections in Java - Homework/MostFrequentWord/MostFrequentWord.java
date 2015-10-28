package MostFrequentWord;


import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        TreeMap<String,Integer> list = new TreeMap<>();

        for (int i = 0; i < text.length; i++) {
            Integer count = list.get(text[i].toLowerCase());
            if (count == null){
                count = 0;
            }
            list.put(text[i].toLowerCase(),count + 1);
        }

        for (Map.Entry<String, Integer> stringIntegerEntry : list.entrySet()) {
            int longest = 0;
            if (stringIntegerEntry.getValue() > 1){
                longest = stringIntegerEntry.getValue();
                System.out.printf("%s -> %d\n", stringIntegerEntry.getKey(), longest);
            }

        }
    }
}


package com.company;


import java.util.HashMap;
import java.util.Scanner;

public class MagicCards {
    public static void main(String[] args) {
        Scanner scan =  new Scanner(System.in);

        String[] cards = scan.nextLine().split(" ");
        String oddOrEven = scan.nextLine();
        String magicCard = scan.nextLine();

        int sum = 0;
        HashMap<String, Integer> values = new HashMap<>();
        values.put("2", 20);
        values.put("3", 30);
        values.put("4", 40);
        values.put("5", 50);
        values.put("6", 60);
        values.put("7", 70);
        values.put("8", 80);
        values.put("9", 90);
        values.put("10", 100);
        values.put("J", 120);
        values.put("Q", 130);
        values.put("K", 140);
        values.put("A", 150);

        String magicCardFace = magicCard.substring(0, magicCard.length() - 1);
        String magicCardSuit = magicCard.substring(magicCard.length() - 1, magicCard.length());
        int cardsCount = cards.length;
        int startPosition = oddOrEven.equals("odd") ? 1 : 0;

        for (int i = startPosition; i < cardsCount; i += 2) {
            String card = cards[i];
            String cardFace = card.substring(0, card.length() - 1);
            String cardSuit = card.substring(card.length() - 1, card.length());

            int value = values.get(cardFace);
            if (cardFace.equals(magicCardFace)){
                value *= 3;
            }
            if (cardSuit.equals(magicCardSuit)){
                value *= 2;
            }

            sum += value;
        }
        System.out.println(sum);

    }
}

package com.company;


import java.util.*;
import java.util.concurrent.ThreadLocalRandom;

public class P7RandomizeNumberFromNToM {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Integer n = sc.nextInt();
        Integer m = sc.nextInt();
        Integer smallestNum = Math.min(n, m);
        Integer biggestNum = Math.max(n, m);
        List<Integer> randomizeNumbers = new ArrayList<>();
        Random rand = new Random();

        for (int i = 0; i <= biggestNum - smallestNum ; i++) {
            Integer randomNumber = rand.nextInt(biggestNum - smallestNum + 1) + smallestNum;
            while(randomizeNumbers.contains(randomNumber)){
                randomNumber = rand.nextInt(biggestNum - smallestNum + 1) + smallestNum;
            }
            randomizeNumbers.add(randomNumber);
        }

    }
}

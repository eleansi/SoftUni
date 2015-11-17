package com.company;


import java.util.*;

public class DragonArmy {
    private static final int DEFAULT_HEALTH = 250;
    private static final int DEFAULT_ARMOR = 10;
    private static final int DEFAULT_DMG = 45;
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int numOfRows = Integer.parseInt(sc.nextLine());

        LinkedHashMap<String, TreeMap<String, int[]>> dragons = new LinkedHashMap<>();

        for (int i = 0; i < numOfRows; i++) {
            String[] lines = sc.nextLine().split(" ");
            String type = lines[0];
            String name = lines[1];
            int damage = lines[2].equals("null") ? DEFAULT_DMG : Integer.parseInt(lines[2]);
            int health = lines[3].equals("null") ? DEFAULT_HEALTH : Integer.parseInt(lines[3]);
            int armor = lines[4].equals("null") ? DEFAULT_ARMOR : Integer.parseInt(lines[4]);

            if (!dragons.containsKey(type)) {
                dragons.put(type, new TreeMap<>());
            }
            if (!dragons.get(type).containsKey(name)){
                dragons.get(type).put(name, new int[3]);
            }
            dragons.get(type).get(name)[0] = damage;
            dragons.get(type).get(name)[1] = health;
            dragons.get(type).get(name)[2] = armor;
        }


        for (Map.Entry<String, TreeMap<String, int[]>> typeInfo : dragons.entrySet()) {
            double totalEntries = typeInfo.getValue().size();
            int totalDamage = 0;
            int totalHealth = 0;
            int totalArmor = 0;
            for (Map.Entry<String, int[]> entry : typeInfo.getValue().entrySet()) {
                totalDamage += entry.getValue()[0];
                totalHealth += entry.getValue()[1];
                totalArmor += entry.getValue()[2];
            }
            double[] average = {
                    totalDamage / totalEntries,
                    totalHealth / totalEntries,
                    totalArmor / totalEntries
            };
            System.out.printf("%s::(%.2f/%.2f/%.2f)\n", typeInfo.getKey(), average[0],
                    average[1], average[2]);

            for (Map.Entry<String,int[]> dragonInfo : typeInfo.getValue().entrySet()) {
                System.out.printf("-%s -> damage: %d, health: %d, armor: %d\n",
                        dragonInfo.getKey(),
                        dragonInfo.getValue()[0],
                        dragonInfo.getValue()[1],
                        dragonInfo.getValue()[2]);
            }
        }
    }
}

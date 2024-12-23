package Problem4_LegendaryFarming;

import com.sun.javafx.collections.IntegerArraySyncer;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class LegendaryFarming {
   public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        LinkedHashMap<String, Integer> keyMaterials = new LinkedHashMap<String,Integer>(){
            {
                put("fragments", 0);
                put("motes", 0);
                put("shards", 0);
            }
        };

        TreeMap<String, Integer> junk = new TreeMap<>();
        String keyMaterialCollectedFirst = "";
        while(true){
            String[] items = scan.nextLine().split(" ");
            for (int i = 0; i < items.length; i += 2) {
                int quantity = Integer.parseInt(items[i]);
                String material = items[i + 1].toLowerCase();

                if (keyMaterials.containsKey(material)){
                    keyMaterials.put(material, keyMaterials.get(material) + quantity);

                    if (keyMaterials.get(material) >= 250){
                        keyMaterials.put(material, keyMaterials.get(material) - 250);
                        keyMaterialCollectedFirst = material;
                        break;
                    }
                } else {
                    if (!junk.containsKey(material)){
                        junk.put(material, 0);
                    }
                    junk.put(material, junk.get(material) + quantity);
                }
            }
            if (keyMaterialCollectedFirst.length() > 0) {
                break;
            }
        }
        System.out.println(getMaterial(keyMaterialCollectedFirst) + " obtained!");
        keyMaterials.entrySet().stream().sorted((x, y) -> y.getValue().compareTo(x.getValue()))
                .forEach(k -> System.out.println(k.getKey() + ": " + k.getValue()));

        junk.entrySet().forEach(j -> System.out.println(j.getKey() + ": " + j.getValue()));
    }

    private static String getMaterial(String material){
        if (material.equals("shards")) return "Shadowmourne";
        if (material.equals("fragments")) return "Valanyr";

        return "Dragonwrath";
    }
}

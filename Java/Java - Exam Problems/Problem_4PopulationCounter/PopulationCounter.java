package Problem_4PopulationCounter;

import java.util.Scanner;
import java.util.TreeMap;

public class PopulationCounter {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();
        TreeMap<String, Long> totalPopulationSum = new TreeMap<>();
        TreeMap<String, TreeMap<String, Long>> populationData = new TreeMap<>();
        while (!inputLine.equals("report")) {
            String[] inputParams = inputLine.split("[|]");
            String city = inputParams[0];
            String country = inputParams[1];
            long population = Long.parseLong(inputParams[2]);

            if (!populationData.containsKey(country)) {
                populationData.put(country, new TreeMap<>());
            }
            if (!populationData.get(country).containsKey(city)) {
                populationData.get(country).put(city, population);
            }
            if (!totalPopulationSum.containsKey(country)) {
                totalPopulationSum.put(country, 0L);
            }

            totalPopulationSum.put(country, totalPopulationSum.get(country) + population);
            inputLine = scan.nextLine();
        }

        totalPopulationSum.entrySet().stream().sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                .forEach(entry -> {
                    System.out.printf("%s (total population: %d)\n", entry.getKey(), entry.getValue());
                    populationData.get(entry.getKey()).entrySet()
                            .stream()
                            .sorted((a,b)-> b.getValue().compareTo(a.getValue()) )
                            .forEach(m -> System.out.printf("=>%s: %d\n",
                                    m.getKey(),
                                    m.getValue()));
                });
    }
}

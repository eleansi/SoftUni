package Problem_4OlympicsAreComing;


import java.util.*;

public class OlympicsAreComing {

    public static void main(String[] args) {
        /*Scanner scan = new Scanner(System.in);
        String line = scan.nextLine();

        LinkedHashMap<String, LinkedHashMap<String, Integer>> olympicData = new LinkedHashMap<>();
        LinkedHashMap<String, Integer> wins = new LinkedHashMap<>();


        while (!line.equals("report")) {
            String[] inputArgs = line.split("\\|");
            String name = inputArgs[0];
            String athlete = name.replaceAll("\\s{2,}", " ").trim();
            String c = inputArgs[1];
            String country = c.replaceAll("\\s{2,}", " ").trim();

            if (!olympicData.containsKey(country)) {
                olympicData.put(country, new LinkedHashMap<>());
            }
            if (!olympicData.get(country).containsKey(athlete)) {
               olympicData.get(country).put(athlete, 0);
            }
            /*if (olympicData.get(theCountry).containsKey(fullName)) {
               junkAthletes.add(fullName);
            }

            if (olympicData.containsKey(theCountry)) {
                junk.put(theCountry, + 1);
            }*/

            /*if (junk.containsKey(theCountry))
            {
                junk.put(theCountry, + 1);
            }*/
            /*int winsCount = olympicData.get(country).get(athlete) + 1;
            olympicData.get(country).put(athlete, winsCount);

            line = scan.nextLine();
        }*/
        //LinkedHashMap<String, LinkedHashMap<String, Integer>> finalSort = new LinkedHashMap<>();

        //NavigableSet<String> orderedStats = olympicData.descendingKeySet();
        /*for (Map.Entry<String, LinkedHashMap<String, Integer>> iter : olympicData.entrySet()) {
            int totalWins = 0;
            //System.out.printf("%s (%d participants):", iter.getKey(), iter.getValue().size());
                if(!finalSort.containsKey(iter.getKey())) {
                    finalSort.put(iter.getKey(), new LinkedHashMap<>());
                }
            if (!finalSort.get(iter.getKey()).containsKey(iter.getValue())) {
                finalSort.get(iter.getKey()).put(String.valueOf(iter.getValue()), totalWins);
            }
            for (Map.Entry<String, Integer> innerIter : junk.entrySet()) {
                totalWins = (iter.getValue().size()) + innerIter.getValue();
            }
            finalSort.get(iter.getKey()).put(String.valueOf(iter.getValue()), iter.getValue().size() + totalWins);

            //System.out.printf(" %d wins\n", totalWins);
        }*/

        /*for (Map.Entry<String, LinkedHashMap<String, Integer>> sorted : finalSort.entrySet()) {
            System.out.printf("%s ", sorted.getKey());
            for (Map.Entry<String, Integer> innerSort : sorted.getValue().entrySet()) {
                System.out.printf("(%d participants): %d wins\n", sorted.getValue().size(), innerSort.getValue());
            }
        }*/

        /*for (Map.Entry<String, LinkedHashMap<String, Integer>> countries : olympicData.entrySet()) {
            int sum = 0;
            for (Map.Entry<String,Integer> winCount : wins.entrySet()) {
                sum += winCount.getValue();
            }
        }

        wins.entrySet().stream().sorted((a, b) -> b.getValue().compareTo(a.getValue())).forEach(
                x -> System.out.printf("\"%s (%d participants): %d wins\n", x.getKey(), olympicData.get(x).size(), wins.get(x.getKey()))
        );*/






        Scanner input = new Scanner(System.in);
        String line = input.nextLine();

        LinkedHashMap<String, Integer> winz = new LinkedHashMap<>();
        LinkedHashMap<String, List<String>> participants = new LinkedHashMap<>();



        while(!line.equals("report")){
            String[]tokens = line.split("\\s*\\|\\s*");
            String n = tokens[0];
            String name = n.replaceAll("\\s{2,}"," ").trim();
            String c = tokens[1];
            String country = c.replaceAll("\\s{2,}"," ").trim();



            List<String> oldNames = participants.get(country);
            //TODO check if null
            if(oldNames == null){
                participants.put(country,new ArrayList<>());
            }

            if (!participants.get(country).contains(name)) {
                participants.get(country).add(name);
            }

            Integer oldWins = winz.get(country);
            if(oldWins == null){
                oldWins = 0;
            }
            winz.put(country, oldWins+1);

            line = input.nextLine();
        }


        winz.entrySet().stream()
                .sorted((t1, t2) -> t2.getValue().compareTo(t1.getValue()))
                .forEach(k -> System.out.printf("%s (%d participants): %d wins\r\n",
                                k.getKey(),
                                participants.get(k.getKey()).size(),
                                k.getValue())
                );
                /*LinkedHashMap<String, LinkedHashMap<Integer, Integer>> finalSort = new LinkedHashMap<>();

                //NavigableSet<String> orderedStats = olympicData.descendingKeySet();
                for (Map.Entry<String, ArrayList<String>> iter : olympicData.entrySet()) {
                    int totalWins = 0;
                    //System.out.printf("%s (%d participants):", iter.getKey(), iter.getValue().size());
                    if(!finalSort.containsKey(iter.getKey())) {
                        finalSort.put(iter.getKey(), new LinkedHashMap<>());
                    }
                    for (Map.Entry<String, Integer> innerIter : junk.entrySet()) {
                        totalWins = (iter.getValue().size() - 1) + innerIter.getValue();

                    }
                    finalSort.get(iter.getKey()).put(iter.getValue().size(), totalWins);

                    //System.out.printf(" %d wins\n", totalWins);
                }

                for (Map.Entry<String, LinkedHashMap<Integer, Integer>> sorted : finalSort.entrySet()) {
                    System.out.printf("%s ", sorted.getKey());
                    for (Map.Entry<Integer, Integer> innerSort : sorted.getValue().entrySet()) {
                        System.out.printf("(%d participants): %d wins\n", innerSort.getKey(), innerSort.getValue());
                    }
                }*/
            }
        }




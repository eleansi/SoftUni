package Problem_1CommandInterpreter;

import java.util.*;

public class CommandInterpreter {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        List<String> mainList = new ArrayList<>(Arrays.asList(scan.nextLine().split("\\s+")));
        List<String> tempList = new ArrayList<>();
        String[] commandArgs = scan.nextLine().split("\\s+");

        while (!commandArgs[0].equals("end")) {
            String command = commandArgs[0];
            tempList.clear();
            switch (command) {
                case "reverse":
                    int start = Integer.parseInt(commandArgs[2]);
                    int count = Integer.parseInt(commandArgs[4]);

                    if (start < 0 || start >= mainList.size() || count < 0 || count > mainList.size() ||
                            start + count > mainList.size()) {
                        System.out.println("Invalid input parameters.");

                    } else {
                        tempList.addAll(mainList.subList(start, start + count));
                        Collections.reverse(tempList);
                        mainList = removeRange(start, count, mainList);
                        mainList.addAll(start, tempList);
                        System.out.println(mainList);
                    }
                    break;
                case "sort":
                    int sortStart = Integer.parseInt(commandArgs[2]);
                    int sortCount = Integer.parseInt(commandArgs[4]);

                    if (sortStart < 0 || sortStart >= mainList.size() || sortCount < 0 || sortCount > mainList.size() ||
                            sortStart + sortCount > mainList.size()) {
                        System.out.println("Invalid input parameters.");
                    } else {
                        tempList.addAll(mainList.subList(sortStart, sortCount + sortStart));
                        Collections.sort(tempList);
                        mainList = removeRange(sortStart, sortCount, mainList);
                        mainList.addAll(sortStart, tempList);
                        System.out.println(mainList);
                    }
                    break;
                case "rollLeft":
                    int rollLeftCount = Integer.parseInt(commandArgs[1]);
                    if (rollLeftCount < 0) {
                        System.out.println("Invalid input parameters.");

                    } else {
                        rollLeftCount %= mainList.size();
                        tempList.addAll(mainList.subList(0, rollLeftCount));
                        mainList = removeRange(0, rollLeftCount, mainList);
                        mainList.addAll(mainList.size(), tempList);
                        System.out.println(mainList);
                    }
                    break;
                case "rollRight":
                    int rollRightCount = Integer.parseInt(commandArgs[1]);
                    if (rollRightCount < 0) {
                        System.out.println("Invalid input parameters.");

                    } else {
                        rollRightCount %= mainList.size();
                        tempList.addAll(mainList.subList(mainList.size() - rollRightCount, mainList.size()));
                        mainList = removeRange(mainList.size() - rollRightCount, rollRightCount, mainList);
                        mainList.addAll(0, tempList);
                        System.out.println(mainList);
                    }
                    break;

            }
            commandArgs = scan.nextLine().split("\\s+");
        }
        System.out.println(mainList);
    }

   public static List<String> removeRange(int start, int count, List<String> list) {
        for (int i = start + count - 1; i >= start; i--) {
            list.remove(i);
        }
        return list;
    }
}
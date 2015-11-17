package Problem1_PlusRemoval;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class PlusRemoval {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        List<char[]> inputArray = new ArrayList<>();
        List<char[]> outputArray = new ArrayList<>();
        String inputLine = scan.nextLine();

        while(!inputLine.equals("END")){
            char[] charArray = inputLine.toCharArray();
            outputArray.add(charArray);
            char[] toLowerChars = inputLine.toLowerCase().toCharArray();
            inputArray.add(toLowerChars);
            inputLine = scan.nextLine();
        }
        for (int row = 0; row < inputArray.size() - 2; row++) {
            int maxLength = Math.min(
                    Math.min(inputArray.get(row).length - 1, inputArray.get(row + 1).length - 2),
                    inputArray.get(row + 2).length - 1);
            for (int col = 0; col < maxLength; col++) {
                char first = inputArray.get(row)[col + 1];
                char second = inputArray.get(row + 1)[col];
                char third = inputArray.get(row + 1)[col + 1];
                char fourth = inputArray.get(row + 1)[col + 2];
                char fifth = inputArray.get(row + 2)[col + 1];
                if ((first == second) && (second == third) && (third == fourth) && (fourth == fifth)){
                    outputArray.get(row)[col + 1] = '\0';
                    outputArray.get(row + 1)[col] = '\0';
                    outputArray.get(row + 1)[col + 1] = '\0';
                    outputArray.get(row + 1)[col + 2] = '\0';
                    outputArray.get(row + 2)[col + 1] = '\0';
                }
            }
        }
        for (char[] ch : outputArray) {
            for (char c : ch) {
                if (c != '\0') {
                    System.out.print(c);
                }
            }
            System.out.println();
        }
    }
}

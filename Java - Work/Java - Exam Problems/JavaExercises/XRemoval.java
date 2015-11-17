package Problem6_XRemoval;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class XRemoval {
    public static void main(String[] args) {
        Scanner scna = new Scanner(System.in);
        List<char[]> inputArray = new ArrayList<>();
        List<char[]> outputArray = new ArrayList<>();
        String inputLine = scna.nextLine();

        while(!inputLine.equals("END")){
            char[] charArray = inputLine.toCharArray();
            outputArray.add(charArray);
            char[] toLowerArray = inputLine.toLowerCase().toCharArray();
            inputArray.add(toLowerArray);
            inputLine = scna.nextLine();
        }

        for (int row = 0; row < inputArray.size() - 2; row++) {
            int maxLength = Math.min(
                    Math.min(inputArray.get(row).length - 2, inputArray.get(row + 1).length - 1),
                    inputArray.get(row + 2).length - 2);
            for (int col = 0; col < maxLength; col++) {
                char first = inputArray.get(row)[col];
                char second = inputArray.get(row)[col + 2];
                char third = inputArray.get(row + 1)[col + 1];
                char fourth = inputArray.get(row + 2)[col];
                char fifth = inputArray.get(row + 2)[col + 2];

                if((first == second) && (second == third) && (third == fourth) && (fourth == fifth)){
                    outputArray.get(row)[col] = '\0';
                    outputArray.get(row)[col + 2] = '\0';
                    outputArray.get(row + 1)[col + 1] = '\0';
                    outputArray.get(row + 2)[col] = '\0';
                    outputArray.get(row + 2)[col + 2] = '\0';
                }
            }
        }
        for (char[] chars : outputArray) {
            for (char ch : chars) {
                if (ch != '\0'){
                    System.out.print(ch);
                }
            }
            System.out.println();
        }
    }
}

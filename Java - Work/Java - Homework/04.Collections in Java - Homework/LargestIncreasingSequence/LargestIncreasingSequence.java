package LargestIncreasingSequence;


import java.util.Arrays;
import java.util.Scanner;

public class LargestIncreasingSequence {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        String[] lineSplited = input.nextLine().split(" ");
        int[] numbers = new int[lineSplited.length];
        //Parse string to int
        for (int i = 0; i < lineSplited.length; i++) {
            numbers[i] = Integer.parseInt(lineSplited[i]);
        }

        int counter = 0;
        int counterSequence = 1;
        int indexNumber = 0;
        System.out.print(numbers[0] + " ");
        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] > numbers[i - 1]) {
                System.out.print(numbers[i] + " ");
                counterSequence++;
            } else {
                System.out.println();
                System.out.print(numbers[i] + " ");
                counterSequence = 1;
            }

            if (counterSequence > counter) {
                counter = counterSequence;
                indexNumber = i;
            }
        }

        System.out.println();
        System.out.print("Longest: ");
        int index = (indexNumber - (counter - 1));

        if(counter > 1){
            for (int y = 0; y < counter; y++) {
                System.out.print(numbers[index] + " ");
                index++;
            }
        }else{
            System.out.print(numbers[0]);
        }
    }
}

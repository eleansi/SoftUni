package LargestSequenceOfStrings;


import java.util.Scanner;

public class LargestSequenceOfStrings {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] splitStr = input.nextLine().split(" ");

        int counter = 1;
        int maxCounter = 1;
        int index = 0;
        for(int i = 1;i < splitStr.length;i++){
            if(splitStr[i].equals(splitStr[i-1])){
                counter++;
            }else{
                counter = 1;
            }

            if(counter > maxCounter){
                maxCounter = counter;
                index = i;
            }
        }

        for(int i = 0;i < maxCounter;i++){
            System.out.print(splitStr[index] + " ");
        }
    }
}

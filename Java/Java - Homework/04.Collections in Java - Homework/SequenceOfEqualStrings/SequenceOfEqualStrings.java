package SequenceOfEqualStrings;


import java.util.Scanner;

public class SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] array = scan.nextLine().split(" ");
        for (int i = 0; i < array.length - 1; i++) {
            if (array[i].equals(array[i + 1])){
                System.out.print(array[i] + " ");
            } else {
                System.out.println(array[i]);
            }
        }
        if(array[array.length-2].equals(array[array.length-1])){
            System.out.print(array[array.length-1]);
        }else{
            System.out.println(array[array.length-1]);
        }
    }
}

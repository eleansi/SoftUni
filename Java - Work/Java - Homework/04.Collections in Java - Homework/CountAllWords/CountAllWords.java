package CountAllWords;


import java.util.Scanner;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        System.out.println(text.length);
    }
}

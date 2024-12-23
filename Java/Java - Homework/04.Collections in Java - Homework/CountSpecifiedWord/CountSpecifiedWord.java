package CountSpecifiedWord;


import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String[] text = scr.nextLine().split("\\W+");
        String search = scr.nextLine();
        int count = 0;
        for (int i = 0; i < text.length; i++) {
            if (search.toLowerCase().equals(text[i].toLowerCase())){
                count++;
            }
        }
        System.out.println(count);
    }
}


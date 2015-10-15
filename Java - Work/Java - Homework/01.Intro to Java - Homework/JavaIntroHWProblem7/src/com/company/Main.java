package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();

        String zero = "Gee";
        String one = "Bro";
        String two = "Zuz";
        String three = "Ma";
        String four = "Duh";
        String five = "Yo";
        String six = "Dis";
        String seven = "Hood";
        String eight = "Jam";
        String nine = "Mack";

        for (int i = 0; i < number.length(); i++) {
            char c = number.charAt(i);

            if (c == '0'){
                System.out.print(zero);
            }
            else if (c == '1'){
                System.out.print(one);
            }
            else if (c == '2'){
                System.out.print(two);
            }
            else if (c == '3'){
                System.out.print(three);
            }
            else if (c == '4'){
                System.out.print(four);
            }
            else if (c == '5'){
                System.out.print(five);
            }
            else if (c == '6'){
                System.out.print(six);
            }
            else if (c == '7'){
                System.out.print(seven);
            }
            else if (c == '8'){
                System.out.print(eight);
            }
            else {
                System.out.print(nine);
            }

        }


    }
}

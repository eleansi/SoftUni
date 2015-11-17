package com.company;


import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Pattern pat = Pattern.compile("(int|double)\\s+([a-z][A-Za-z]*)");
        String input = scan.nextLine();

        List<String> doubles = new ArrayList<>();
        List<String> ints = new ArrayList<>();
        while(!input.equals("//END_OF_CODE")){
            Matcher matcher = pat.matcher(input);
            while(matcher.find()){
                String intOrDouble = matcher.group(1);
                String value = matcher.group(2);

                if (intOrDouble.equals("double")){
                    doubles.add(value);
                } else {
                    ints.add(value);
                }
            }
            input = scan.nextLine();
        }
        Collections.sort(doubles);
        Collections.sort(ints);
        System.out.printf("Doubles: %s", String.join(", ", doubles));
        if (doubles.size() <= 0){
            System.out.print("None");
        }
        System.out.println();
        System.out.printf("Ints: %s", String.join(", ", ints));
        if (ints.size() <= 0){
            System.out.print("None");
        }
    }
}

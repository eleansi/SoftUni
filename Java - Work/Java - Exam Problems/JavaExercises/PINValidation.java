package Problem18_PINValidation;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class PINValidation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();
        StringBuilder sb = new StringBuilder();
        while (!inputLine.equals("END")) {
            sb.append(inputLine);
            inputLine = scan.nextLine();
        }
        String hyperlinks = sb.toString();
        Pattern pattern = Pattern.compile("<(\\s*a\\s*)([^<>]+)\\s*href\\s*=\\s*(?:(\"([^\"]+)\")|('([^']+)')|([^\\s>]+))[^>]*>");
        Matcher match = pattern.matcher(hyperlinks);
        while (match.find()) {
            String match1 = match.group(4);
            String match2 = match.group(6);
            String match3 = match.group(7);

            if(match1 != null){
                System.out.println(match1);
            } else if (match2 != null) {
                System.out.println(match2);
            } else if (match3 != null) {
                System.out.println(match3);
            } else {
                System.out.println();
            }
        }
    }
}

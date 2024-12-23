package Problem_3RageQuit;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RageQuit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();

        Pattern pat = Pattern.compile("([\\D]+)(\\d+)");
        Matcher match = pat.matcher(inputLine);
        StringBuilder result = new StringBuilder();


        while (match.find()) {
            String str = match.group(1).toUpperCase();
            int count = Integer.parseInt(match.group(2));
            for (int i = 0; i < count; i++) {
                result.append(str);
            }
        }
        int uniqueSymbols = (int) result.chars().distinct().count();
        System.out.printf("Unique symbols used: %d\n", uniqueSymbols);
        System.out.println(result);
    }
}

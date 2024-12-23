package Problem_3TextTransformer;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class TextTransformer {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        StringBuilder informationStorage = new StringBuilder();

        while (!input.equals("burp")) {
            informationStorage.append(input);
            input = scan.nextLine();
        }
        String info = informationStorage.toString();
        String replaced = info.replaceAll("\\s{2,}", " ");
        //System.out.println(replaced);

        StringBuilder appender = new StringBuilder();
        Pattern regex = Pattern.compile("([$%&\\'])([^$%&\\']+)\\1");
        Matcher match = regex.matcher(replaced);
        int weight = 0;
        while (match.find()) {
            String symbol = match.group(1);
            String data = match.group(2);

            appender.append(" ");
            switch (symbol) {
                case "$":
                    weight = 1;
                    break;
                case "%":
                    weight = 2;
                    break;
                case "&":
                    weight = 3;
                    break;
                case "\'":
                    weight = 4;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < data.length(); i++) {
                if (i % 2 == 0) {
                  appender.append((char)(data.charAt(i) + (char)weight));
                } else {
                    appender.append((char)(data.charAt(i) - (char)weight));
                }
            }

        }
        System.out.println(appender.toString());
    }
}

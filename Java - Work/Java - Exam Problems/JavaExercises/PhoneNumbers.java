package Problem12_PhoneNumbers;


import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class PhoneNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        StringBuilder sb = new StringBuilder();
        while (!input.equals("END")) {
            sb.append(input);
            input = scan.nextLine();
        }


        List<String> oneStepCloser = new ArrayList<>();
        Pattern pat = Pattern.compile("([A-Z]{1}[A-Za-z]*)([^A-Za-z0-9+]*)([+]*[0-9]{1}[0-9()\\/.\\s-]*[0-9]{1})");
        Matcher match = pat.matcher(sb);
        while(match.find()) {
            String name = match.group(1);
            String number = match.group(3);
            number = number.replaceAll("[^0-9+]+", "");
            String line = String.format("<li><b>%s:</b> %s</li>", name, number);
            oneStepCloser.add(line);
        }

        if (oneStepCloser.size() == 0)
        {
            System.out.println("<p>No matches!</p>");
        }
        else
        {
            StringBuilder result = new StringBuilder();
            result.append("<ol>");
            for (String num : oneStepCloser) {
                result.append(num);
            }
            result.append("</ol>");
            String res = result.toString();
            System.out.println(res);
        }

        /*StringBuilder oneMore = new StringBuilder();
        Pattern secondPat = Pattern.compile("([^\\/\\_\\(\\)\\-\\.\\s]+)([\\/\\_\\(\\)\\-\\.\\s])");
        Matcher secondMatch = secondPat.matcher(oneStepCloser);
        while (secondMatch.find()) {
            oneMore.append(secondMatch.group(1));
            oneMore.append(" ");
        }

        System.out.println(oneMore);
        //StringBuilder theLastOne = new StringBuilder();
        LinkedHashMap<String, String> output = new LinkedHashMap<>();
        Pattern thirdPattern = Pattern.compile("([A-Za-z]+|[A-Z]+)\\s*([\\+\\d\\s\\-]{2,})\\s*");
        Matcher thirdMatch = thirdPattern.matcher(oneMore);
        while (thirdMatch.find()) {

            if (!thirdMatch.group(1).isEmpty()) {
                output.put(thirdMatch.group(1), thirdMatch.group(2).replaceAll("\\s+", ""));
            }
        }

        if (!output.isEmpty()) {
            System.out.print("<ol>");
            for (Map.Entry<String, String> iter : output.entrySet()) {
                System.out.print("<li>");
                System.out.printf("<b>%s:</b> %s", iter.getKey(), iter.getValue());
                System.out.print("</li>");

            }
            System.out.print("</ol>");
        }
        if (output.isEmpty()) {
            System.out.println("<p>No matches!</p>");
        }*/
    }
}

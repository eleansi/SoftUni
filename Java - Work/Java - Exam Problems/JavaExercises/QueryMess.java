package Problem4_QueryMess;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class QueryMess {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String pattern = "([^&=?]+)=([^&=?\\n]+)";
        while(true) {
            String input = scan.nextLine();
            if (input.equals("END")) {
                break;
            }

            HashSet<String> keys = new HashSet<>();
            LinkedHashMap<String, ArrayList<String>> result = new LinkedHashMap<>();
            Pattern pat = Pattern.compile(pattern);
            Matcher match = pat.matcher(input);
            while (match.find()) {
                String field = match.group(1);
                String value = match.group(2);

                field = field.replace("%20", " ");
                field = field.replace("+", " ");
                field = field.replace("\\s+", " ");
                field = field.trim();

                value = value.replace("%20", " ");
                value = value.replace("+", " ");
                value = value.replace("\\s+", " ");
                value = value.trim();

                keys.add(field);
                if (result.containsKey(field)) {
                    result.get(field).add(value);
                }
                if (!result.containsKey(field)){
                    result.get(field).add(String.valueOf(new ArrayList<>()));
                }
            }
            for (String key : keys) {
                System.out.printf("%s=[%s]", key, String.join(", ", result.get(key)));
            }
            System.out.println();
        }
    }
}

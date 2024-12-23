package Problem3_SimplseExpression;


import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SimplseExpression {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputLine = scan.nextLine();

        ArrayList<String> numbers = new ArrayList<>();
        ArrayList<String> operants = new ArrayList<>();

        Pattern digitRegex = Pattern.compile("[\\d\\.]+");
        Matcher digitMatch = digitRegex.matcher(inputLine);

        while(digitMatch.find()){
            numbers.add(digitMatch.group());
        }

        Pattern operantsRegex = Pattern.compile("[+-]+");
        Matcher operantsMatcher = operantsRegex.matcher(inputLine);

        while(operantsMatcher.find()){
            operants.add(operantsMatcher.group());
        }

        BigDecimal sum = new BigDecimal(numbers.get(0));
        for (int i = 0; i < operants.size(); i++) {
            if (operants.get(i).equals("+")){
                sum = sum.add(new BigDecimal(numbers.get(i + 1)));
            }
            if (operants.get(i).equals("-")){
                sum = sum.subtract(new BigDecimal(numbers.get(i + 1)));
            }
        }
        System.out.println(sum);
    }
}

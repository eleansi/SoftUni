package Problem15_TheNumbers;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class TheNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        Pattern pat = Pattern.compile("(\\d+)");
        Matcher matche = pat.matcher(input);
        
        List<String> numbers = new ArrayList<>();
        while(matche.find()){
            StringBuilder sb = new StringBuilder();
            sb.append("0x");
            String hex = Integer.toHexString(Integer.parseInt(matche.group(1)));
            String num = String.format("%4s", hex).replace(' ', '0');
            sb.append(num.toUpperCase());
            numbers.add(sb.toString());
        }
        System.out.print(String.join("-", numbers));
    }
}

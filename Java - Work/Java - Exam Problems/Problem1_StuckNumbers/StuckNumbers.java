package Problem1_StuckNumbers;


import java.util.ArrayList;
import java.util.Scanner;

public class StuckNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = Integer.parseInt(scan.nextLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = scan.nextInt();
        }

        ArrayList<String> output = new ArrayList<>();

        for (int a = 0; a < numbers.length; a++) {
            for (int b = 0; b < numbers.length; b++) {
                for (int c = 0; c < numbers.length; c++) {
                    for (int d = 0; d < numbers.length ; d++) {
                        boolean isValid = numbers[a] != numbers[b] &&
                                          numbers[a] != numbers[c] &&
                                          numbers[a] != numbers[d] &&
                                          numbers[b] != numbers[c] &&
                                          numbers[b] != numbers[d] &&
                                          numbers[c] != numbers[d];
                                if (isValid && ("" + numbers[a] + numbers[b])
                                        .equals("" + numbers[c] + numbers[d])){
                                    output.add(numbers[a]+ "|" +numbers[b]+ "==" + numbers[c]+ "|" + numbers[d]);
                                }
                        
                    }
                }
            }
        }
        if (output.isEmpty()){
            System.out.println("No");
        }
        for (String s : output) {
            System.out.println(s);
        }
    }
}

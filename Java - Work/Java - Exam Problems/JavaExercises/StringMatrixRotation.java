package Problem2_StringMatrixRotation;


import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StringMatrixRotation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        ArrayList<String> matrix = new ArrayList<>();

        int degrees = 0;

        Pattern pat = Pattern.compile("\\d+");
        Matcher matcher = pat.matcher(input);
        while (matcher.find()){
            degrees = (Integer.parseInt(matcher.group())) % 360;
        }

        while(!input.equals("END")){
            matrix.add(input);
            input = scan.nextLine();
        }
        matrix.remove(0);
        int cols = getLongestString(matrix);
        int rows = matrix.size();

        for (int row = 0; row < rows; row++) {
            if (matrix.get(row).length() < cols) {
                int fill = cols - matrix.get(row).length();
                String currentLine = matrix.get(row);
                for (int col = 0; col < fill; col++) {
                    currentLine += ' ';
                }
                matrix.set(row, currentLine);
            }
        }

        if (degrees == 0 || degrees == 360){
            for (int i = 0; i < matrix.size(); i++) {
                for (int j = 0; j < matrix.get(i).length(); j++) {
                    System.out.print(matrix.get(i).charAt(j));
                }
                System.out.println();
            }
        }
        if (degrees == 180){
            getRotate180(matrix);
        }
        if (degrees == 90){
            getRotate90(matrix);
        }
        if (degrees == 270){
            getRotate270(matrix);
        }
    }

    private static void getRotate270(ArrayList<String> matrix) {
        for (int col = matrix.get(0).length() - 1; col >= 0; col--) {
            for (int row = 0; row < matrix.size(); row++) {
                System.out.print(matrix.get(row).charAt(col));
            }
            System.out.println();
        }
    }

    private static void getRotate90(ArrayList<String> matrix) {
        for (int col = 0; col < matrix.get(0).length(); col++) {

            for (int row = matrix.size() - 1; row >= 0; row--) {
                System.out.print(matrix.get(row).charAt(col));
            }
            System.out.println();
        }
    }

    private static void getRotate180(ArrayList<String> matrix) {
        for (int i = matrix.size() - 1; i >= 0; i--) {
            for (int j = matrix.get(i).length() - 1; j >= 0; j--) {
                System.out.print(matrix.get(i).charAt(j));
            }
            System.out.println();
        }
    }

    public static int getLongestString(List<String> array) {
        int maxLength = 0;

        for (String s : array) {
            if (s.length() > maxLength) {
                maxLength = s.length();
            }
        }
        return maxLength;
    }
}

package Problem1SumLines;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SumLines {

    public static void main(String[] args) throws IOException {

        BufferedReader reading = new BufferedReader(new FileReader("src\\Problem1SumLines\\lines.txt"));
        String currentLine = reading.readLine();
        int sum = 0;

        try {
            while (currentLine != null) {

                for (int i = 0; i < currentLine.length(); i++) {
                    sum += currentLine.charAt(i);
                }
                System.out.println(sum);
                sum = 0;
                currentLine = reading.readLine();
            }
        } finally {
            reading.close();
        }
   }
}

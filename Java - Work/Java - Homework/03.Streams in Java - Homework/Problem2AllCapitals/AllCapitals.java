package Problem2AllCapitals;


import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class AllCapitals {
    public static void main(String[] args) throws IOException {
        BufferedReader reading = new BufferedReader(new FileReader("src\\Problem2AllCapitals\\lines.txt"));
        FileWriter fw = new FileWriter("src\\Problem2AllCapitals\\lines.txt", true);
        PrintWriter print = new PrintWriter(fw, true);

        try {
            List<String> lines = new ArrayList<>();
            String currentLine = reading.readLine();
            while (currentLine != null) {
                lines.add(currentLine);
                currentLine = reading.readLine();
            }

            PrintWriter write = new PrintWriter("src\\Problem2AllCapitals\\lines.txt");
            write.print("");
            write.close();
            for (int i = 0; i < lines.size(); i++) {
                print.println(lines.get(i).toUpperCase());
            }
        } finally {
            reading.close();
            fw.close();
            print.close();
        }
    }
}

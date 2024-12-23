package Problem3CountCharTypes;


import java.io.*;
import java.util.Arrays;
import java.util.List;

public class CountChars {
    public static void main(String[] args) throws IOException {
        BufferedReader reading = new BufferedReader(new FileReader("src\\Problem3CountCharTypes\\words.txt"));
        FileWriter fw = new FileWriter("src\\Problem3CountCharTypes\\count-chars.txt", true);
        PrintWriter print = new PrintWriter(fw, true);

        List vowelsList = Arrays.asList(new Character[]{'a','e','i','o','u'});
        List punctuations = Arrays.asList(new Character[] {'!','.',',','?'});
        int vowsCount = 0;
        int consonantsCount = 0;
        int punctuationCount = 0;



        try {
            String currentLine = reading.readLine();
            while (currentLine != null) {
                for (int i = 0; i < currentLine.length(); i++) {
                    if (currentLine.charAt(i) != ' ') {
                        if (vowelsList.contains(currentLine.charAt(i))) {
                            vowsCount++;
                        } else if (punctuations.contains(currentLine.charAt(i))) {
                            punctuationCount++;
                        } else {
                            consonantsCount++;
                        }
                    }
                }
                currentLine = reading.readLine();
            }
            print.println("Vowels: " + vowsCount);
            print.println("Consonants: " + consonantsCount);
            print.println("Punctuation: " + punctuationCount);

        } finally {
            reading.close();
            fw.close();
            print.close();
        }
    }
}

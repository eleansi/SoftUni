package Problem4CopyJPG;


import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Problem4CopyJPG {
    public static void main(String[] args) throws IOException {
        FileInputStream inputStream = new FileInputStream("src\\Problem4CopyJPG\\jim.jpg");
        FileOutputStream outputStream = new FileOutputStream("src\\Problem4CopyJPG\\jim-copy.jpg");
        int container;
        while((container = inputStream.read()) != -1){
            outputStream.write(container);
        }
        inputStream.close();
        outputStream.close();
    }
}

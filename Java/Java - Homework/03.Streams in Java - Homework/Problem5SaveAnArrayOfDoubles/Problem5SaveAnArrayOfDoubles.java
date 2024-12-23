package Problem5SaveAnArrayOfDoubles;


import java.io.*;

import java.util.ArrayList;

public class Problem5SaveAnArrayOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream outputStream = new ObjectOutputStream(
                new FileOutputStream("src\\Problem5SaveAnArrayOfDoubles\\doubles.list"));
        ArrayList<Double> doubles = new ArrayList<>();
        doubles.add(6.00);
        doubles.add(6.42);
        doubles.add(4.20);
        doubles.add(9.90);
        doubles.add(1234.56);
        doubles.add(1000.200);

        outputStream.writeObject(doubles);
        outputStream.flush();
        ObjectInputStream inputStream = new ObjectInputStream(
                new FileInputStream("src\\Problem5SaveAnArrayOfDoubles\\doubles.list"));
        System.out.println(inputStream.readObject());
        inputStream.close();
    }
}

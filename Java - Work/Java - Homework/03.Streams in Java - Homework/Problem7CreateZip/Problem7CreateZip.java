package Problem7CreateZip;


import java.io.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class Problem7CreateZip {
    public static void main(String[] args) throws IOException {
        ZipOutputStream zos = new ZipOutputStream(
                new FileOutputStream("src\\Problem7CreateZip\\text-files.zip"));
        FileInputStream fis = new FileInputStream(
                new File("src\\Problem7CreateZip\\words.txt"));
        int byteContainter;
        zos.putNextEntry(new ZipEntry("words.txt"));

        while((byteContainter = fis.read())!=-1){
            zos.write(byteContainter);
        }
        zos.closeEntry();
        zos.putNextEntry(new ZipEntry("count-chars.txt"));
        fis = new FileInputStream(
                new File("src\\Problem7CreateZip\\count-chars.txt"));
        while((byteContainter = fis.read())!=-1){
            zos.write(byteContainter);
        }
        zos.closeEntry();
        zos.putNextEntry(new ZipEntry("lines.txt"));
        fis = new FileInputStream(
                new File("src\\Problem7CreateZip\\lines.txt"));
        while((byteContainter = fis.read())!=-1){
            zos.write(byteContainter);
        }
        zos.closeEntry();
        zos.finish();
        zos.close();
    }
}

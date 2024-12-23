import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] coordinates = scan.nextLine().split(" ");
        int rows = Integer.parseInt(coordinates[0]);
        int cols = Integer.parseInt(coordinates[1]);

        int playerRow = -1;
        int playerCol = -1;
        List<char[]> matrix = new ArrayList<>();
        for (int i = 0; i < rows; i++) {
            String line = scan.nextLine();
            int playerColumn = line.indexOf('P');
            if (playerColumn != -1){
                playerCol = playerColumn;
                playerRow = i;
            }

            matrix.add(line.toCharArray());
        }

        char[] cmds = scan.nextLine().toCharArray();
        boolean hasWon = false;
        boolean hasDied = false;

        for (int i = 0; i < cmds.length; i++) {
            char cmd = cmds[i];
            switch (cmd){
                case 'U':
                    if (playerRow == 0){
                        hasWon = true;
                        matrix.get(playerRow)[playerCol] = '.';
                    } else {
                        if (matrix.get(playerRow - 1)[playerCol] == 'B'){
                            hasDied = true;
                        } else {
                            matrix.get(playerRow - 1)[playerCol] = 'P';
                            matrix.get(playerRow)[playerCol] = '.';
                        }
                        playerRow--;
                    }
                    break;
                case 'D':
                    if (playerRow == rows - 1){
                        hasWon = true;
                        matrix.get(playerRow)[playerCol] = '.';
                    } else {
                        if (matrix.get(playerRow + 1)[playerCol] == 'B'){
                            hasDied = true;
                        } else {
                            matrix.get(playerRow + 1)[playerCol] = 'P';
                            matrix.get(playerRow)[playerCol] = '.';
                        }
                        playerRow++;
                    }
                    break;
                case 'L':
                    if (playerCol == 0){
                        hasWon = true;
                        matrix.get(playerRow)[playerCol] = '.';
                    } else {
                        if (matrix.get(playerRow)[playerCol - 1] == 'B'){
                            hasDied = true;
                        } else {
                            matrix.get(playerRow)[playerCol - 1] = 'P';
                            matrix.get(playerRow)[playerCol] = '.';
                        }
                        playerCol--;
                    }
                    break;
                case 'R':
                    if (playerCol == cols - 1){
                        hasWon = true;
                        matrix.get(playerRow)[playerCol] = '.';
                    } else {
                        if (matrix.get(playerRow)[playerCol + 1] == 'B'){
                            hasDied = true;
                        } else {
                            matrix.get(playerRow)[playerCol + 1] = 'P';
                            matrix.get(playerRow)[playerCol] = '.';
                        }
                        playerCol++;
                    }
                    break;
                default:
                    break;
            }

            List<char[]> tempMatrix = new ArrayList<>();
            for (int r = 0; r < rows; r++) {
                tempMatrix.add(new char[cols]);
                for (int c = 0; c < cols; c++) {
                    tempMatrix.get(r)[c] = matrix.get(r)[c];
                }
            }

            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++) {
                    if (matrix.get(r)[c] == 'B') {
                        if (r > 0) {
                            if (matrix.get(r - 1)[c] == 'P') {
                                hasDied = true;
                            }
                            tempMatrix.get(r - 1)[c] = 'B';
                        }
                        if (r < rows - 1) {
                            if (matrix.get(r + 1)[c] == 'P') {
                                hasDied = true;
                            }
                            tempMatrix.get(r + 1)[c] = 'B';
                        }
                        if (c > 0) {
                            if (matrix.get(r)[c - 1] == 'P') {
                                hasDied = true;
                            }
                            tempMatrix.get(r)[c - 1] = 'B';
                        }
                        if (c < cols - 1) {
                            if (matrix.get(r)[c + 1] == 'P') {
                                hasDied = true;
                            }
                            tempMatrix.get(r)[c + 1] = 'B';
                        }
                    }
                }
            }
            matrix = tempMatrix;
            if (hasWon){
                hasDied = false;
                break;
            }
            if (hasDied){
                break;
            }
        }
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                System.out.print(matrix.get(r)[c]);
            }
            System.out.println();
        }
        if (hasWon){

            System.out.println("won: " + playerRow + " "+ playerCol);
        } else {
            System.out.println("dead: " + playerRow + " " + playerCol);
        }
    }
}

package Problem_1BunkerBuster;


import java.util.Scanner;

public class BunkerBuster {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] dimensions = scan.nextLine().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);
        int[][] matrix = new int[rows][cols];
        for (int row = 0; row < matrix.length; row++) {
            String[] cells = scan.nextLine().split("\\s+");
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = Integer.parseInt(cells[col]);
            }
        }


        String commands = scan.nextLine();

        while (!commands.equals("cease fire!")) {
            String[] coordinates = commands.split("\\s+");
            int hitRow = Integer.parseInt(coordinates[0]);
            int hitCol = Integer.parseInt(coordinates[1]);
            char bombPower = coordinates[2].charAt(0);

            matrix[hitRow][hitCol] -= bombPower;
            int reduceBombPower = (int)Math.ceil(bombPower / 2.0);
            hitTarget(matrix, rows, cols, hitRow, hitCol, reduceBombPower);
            commands = scan.nextLine();
        }
        int destroyedBunkers = countDestroied(matrix);
        int matrixSize = 0;

        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrixSize++;
            }
        }


        double damageDone = ((double) destroyedBunkers / matrixSize) * 100;
        System.out.printf("Destroyed bunkers: %d\n", destroyedBunkers);
        System.out.printf("Damage done: %.1f ", damageDone);
        System.out.print("%\n");
        //printMatrix(matrix);
    }
    public static void hitTarget(int[][] matrix, int rows, int cols, int hitRow, int hitCol, int bombPower) {
        int minRow = Math.max(0, hitRow - 1);
        int maxRow = Math.min(hitRow + 1,  rows - 1);
        int minCol = Math.max(0, hitCol - 1);
        int maxCol = Math.min(hitCol + 1, cols - 1);

        for (int row = minRow; row <= maxRow; row++) {
            for (int col = minCol; col <= maxCol; col++) {
                if (row == hitRow && col == hitCol)
                {
                    continue;
                }
                matrix[row][col] -= bombPower;
            }
        }
    }
    static void printMatrix(int[][] matrix) {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }
    public static Integer countDestroied(int[][] matrix) {
        int destroyedBunkers = 0;
        for (int[] cell : matrix) {
            for (int value : cell) {
                if (value <= 0) {
                    destroyedBunkers++;
                }
            }
        }
        return destroyedBunkers;
    }
}

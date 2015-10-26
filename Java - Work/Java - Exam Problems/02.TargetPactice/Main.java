package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner scan = new Scanner(System.in);
        // Matrix size
        String[] dimensions = scan.nextLine().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);

        // Reading the input word
        String input = scan.nextLine();

        // Reading shooting parameters
        String[] shotParams = scan.nextLine().split("\\s+");
        int impactRow = Integer.parseInt(shotParams[0]);
        int impactcol = Integer.parseInt(shotParams[1]);
        int radius = Integer.parseInt(shotParams[2]);

        boolean isGoingLeft = true;
        int counter = 0;

        char[][] matrix = new char[rows][cols];

        // Filling matrix on Zig-Zag
        for (int row = rows - 1; row >= 0; row--) {
            if (isGoingLeft) {
                for (int col = cols - 1; col >= 0; col--) {
                  matrix[row][col] = input.charAt(counter++ % input.length());
                }
            } else {
                for (int col = 0; col < cols; col++) {
                    matrix[row][col] = input.charAt(counter++ % input.length());
                }
            }
            isGoingLeft = !isGoingLeft;
        }

        // Shooting

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                if (isInCircle(row, col, impactRow, impactcol, radius)){
                    matrix[row][col] = ' ';
                }
            }
        }

        // Falling chars
        boolean isFalling = false;
        do {
            isFalling = false;
            for (int row = 0; row < matrix.length - 1; row++) {
                for (int col = 0; col < matrix[row].length; col++) {
                    if (matrix[row][col] != ' ' && matrix[row + 1][col] == ' ') {
                        matrix[row + 1][col] = matrix[row][col];
                        matrix[row][col] = ' ';
                        isFalling = true;
                    }
                }
            }
        } while(isFalling);
        printMatrix(matrix);
    }

    private static void printMatrix(char[][] matrix) {
        for (int i = 0; i < matrix.length ; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.print(matrix[i][j]);
            }
            System.out.println();
        }
    }

    // check (x - center_x)^2 + (y - center_y)^2 < radius^2
    private static boolean isInCircle(int row, int col, int centerX, int centerY, int radius){
        int deltaX = row - centerX;
        int deltaY = col - centerY;
        return Math.pow(deltaX, 2) + Math.pow(deltaY, 2) <= Math.pow(radius, 2);
    }
}

package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LabyrinthDash {
    public static void main(String[] args) {
        /*
        Scanner scn = new Scanner(System.in);
        int numOfRows = Integer.parseInt(scn.nextLine());
        char[][] labyrinth = new char[numOfRows][];

        for (int row = 0; row < numOfRows; row++) {
            labyrinth[row] = scn.nextLine().toCharArray();
        }

        char[] commands = scn.nextLine().toCharArray();
        int currentRow = 0;
        int currentCol = 0;
        int movesMade = 0;
        int lives = 3;
        for (char command : commands) {
            int impactRow = currentRow;
            int impactCol = currentCol;
            switch(command){
                case '>':
                    currentCol++;
                    break;
                case '<':
                    currentCol--;
                    break;
                case '^':
                    currentRow--;
                    break;
                case 'v':
                    currentRow++;
                    break;
            }
            if (isOutside(currentRow, currentCol, labyrinth)){
                movesMade++;
                System.out.println("Fell off a cliff! Game Over!");
                break;
            } else if(isObstacle(currentRow, currentCol, labyrinth)){
                movesMade++;
                lives--;
                System.out.printf("Ouch! That hurt! Lives left: %d%n", lives);
                if (lives == 0){
                    System.out.println("No lives left! Game Over!");
                    break;
                }
            } else if (isLife(currentRow, currentCol, labyrinth)){
                movesMade++;
                lives++;
                labyrinth[currentRow][currentCol] = '.';
                System.out.printf("Awesome! Lives left: %d%n", lives);
            } else if(isWall(currentRow, currentCol, labyrinth)){
                currentRow = impactRow;
                currentCol = impactCol;
                System.out.println("Bumped a wall.");
            }
            else{
                movesMade++;
                System.out.println("Made a move!");
            }
        }
        System.out.printf("Total moves made: %d", movesMade);
        */

        Scanner scn = new Scanner(System.in);
        int numofRows = Integer.parseInt(scn.nextLine());
        char[][] labyrinth = new char[numofRows][];

        for (int row = 0; row < numofRows; row++) {
            labyrinth[row] = scn.nextLine().toCharArray();
        }

        String commands = scn.nextLine();
        int row = 0;
        int col = 0;
        int lives = 3;
        boolean dead = false;
        int movesCount = 0;
        for (int i = 0; i < commands.length(); i++) {
            switch (commands.charAt(i)) {
                case 'v':
                    if (row + 1 < numofRows && labyrinth[Math.min(numofRows - 1, row + 1)][col] != ' ') {
                        char curChar = labyrinth[row + 1][col];
                        if (curChar == '_' || curChar == '|') {
                            System.out.println("Bumped a wall.");
                            break;
                        } else if (curChar == '@' || curChar == '*' || curChar == '#') {
                            lives--;
                            if (lives <= 0) {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                                System.out.println("No lives left! Game Over!");
                                dead = true;
                            } else {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                            }
                        } else if (curChar == '$') {
                            lives++;
                            System.out.println("Awesome! Lives left: " + lives);
                            labyrinth[row + 1][col] = '.';
                        } else {
                            System.out.println("Made a move!");
                        }
                        row++;
                    } else {
                        System.out.println("Fell off a cliff! Game Over!");
                        dead = true;
                    }
                    movesCount++;
                    break;
                case '^':
                    if (row - 1 >= 0 && labyrinth[Math.max(0, row - 1)][col] != ' ') {
                        char curChar = labyrinth[row - 1][col];
                        if (curChar == '_' || curChar == '|') {
                            System.out.println("Bumped a wall.");
                            break;
                        } else if (curChar == '@' || curChar == '*' || curChar == '#') {
                            lives--;
                            if (lives <= 0) {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                                System.out.println("No lives left! Game Over!");
                                dead = true;
                            } else {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                            }
                        } else if (curChar == '$') {
                            lives++;
                            System.out.println("Awesome! Lives left: " + lives);
                            labyrinth[row - 1][col] = '.';
                        } else {
                            System.out.println("Made a move!");
                        }
                        row--;
                    } else {
                        System.out.println("Fell off a cliff! Game Over!");
                        dead = true;
                    }
                    movesCount++;
                    break;
                case '>':
                    if (col + 1 < labyrinth[row].length && labyrinth[row][Math.min(col + 1, labyrinth[row].length - 1)] != ' ') {
                        char curChar = labyrinth[row][col + 1];
                        if (curChar == '_' || curChar == '|') {
                            System.out.println("Bumped a wall.");
                            break;
                        } else if (curChar == '@' || curChar == '*' || curChar == '#') {
                            lives--;
                            if (lives <= 0) {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                                System.out.println("No lives left! Game Over!");
                                dead = true;
                            } else {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                            }
                        } else if (curChar == '$') {
                            lives++;
                            System.out.println("Awesome! Lives left: " + lives);
                            labyrinth[row][col + 1] = '.';
                        } else {
                            System.out.println("Made a move!");
                        }
                        col++;
                    } else {
                        System.out.println("Fell off a cliff! Game Over!");
                        dead = true;
                    }
                    movesCount++;
                    break;
                case '<':
                    if (col - 1 >= 0 && labyrinth[row][Math.max(col - 1, 0)] != ' ') {
                        char curChar = labyrinth[row][col - 1];
                        if (curChar == '_' || curChar == '|') {
                            System.out.println("Bumped a wall.");
                            break;
                        } else if (curChar == '@' || curChar == '*' || curChar == '#') {
                            lives--;
                            if (lives <= 0) {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                                System.out.println("No lives left! Game Over!");
                                dead = true;
                            } else {
                                System.out.println("Ouch! That hurt! Lives left: " + lives);
                            }
                        } else if (curChar == '$') {
                            lives++;
                            System.out.println("Awesome! Lives left: " + lives);
                            labyrinth[row][col - 1] = '.';
                        } else {
                            System.out.println("Made a move!");
                        }
                        col--;
                    } else {
                        System.out.println("Fell off a cliff! Game Over!");
                        dead = true;
                    }
                    movesCount++;
                    break;
            }
            if (dead) {
                break;
            }
        }
        System.out.println("Total moves made: " + movesCount);
    }



    /*
    public static boolean isOutside(int row, int col, char[][] labyrinth){

        if (row < 0 || row >= labyrinth.length){
            return true;
        }
        if (col < 0 || col >= labyrinth[row].length) {
            return true;
        }
        return labyrinth[row][col] == ' ';
    }

    public static boolean isObstacle(int row, int col, char[][] labyrinth){
        return labyrinth[row][col] == '@' || labyrinth[row][col] == '#' || labyrinth[row][col] == '*';
    }
    public static boolean isWall(int row, int col, char[][] labyrinth){
        return labyrinth[row][col] == '|' || labyrinth[row][col] == '_';
    }
    public static boolean isLife(int row, int col, char[][] labyrinth) {
        return labyrinth[row][col] == '$';
    }
    */
}

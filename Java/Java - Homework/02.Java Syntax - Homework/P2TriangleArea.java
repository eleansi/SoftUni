package com.company;

import java.util.Scanner;

public class P2TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] coodrinateA = sc.nextLine().split(" ");
        Integer aX = Integer.parseInt(coodrinateA[0]);   // -5
        Integer aY = Integer.parseInt(coodrinateA[1]);   // 10
        String[] CoordinateB = sc.nextLine().split(" ");
        Integer bX = Integer.parseInt(CoordinateB[0]);   // 25
        Integer bY = Integer.parseInt(CoordinateB[1]);    // 30
        String[] coordinateC = sc.nextLine().split(" ");
        Integer cX = Integer.parseInt(coordinateC[0]);    // 60
        Integer cY = Integer.parseInt(coordinateC[1]);     // 15
        Integer pointA = aX * (bY - cY);
        Integer pointB = bX * (cY - aY);
        Integer pointC = cX * (aY - bY);
        Integer area = Math.abs((pointA + pointB + pointC) / 2);
        System.out.printf("%d", area);
    }
}

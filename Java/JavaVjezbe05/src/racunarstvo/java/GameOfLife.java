package racunarstvo.java;

import java.util.Random;

public class GameOfLife {

    public static void main(String[] args) {
        
        int[][] field = new int[100][100];
        initialFill(field);
        
        while(true) {
            liveOrDie(field, field[0].length, field[1].length);
            printOut(field, field[0].length, field[1].length);
            
            try {
                Thread.sleep(1000);
            }
            catch(InterruptedException e) {
                Thread.currentThread().interrupt();
            }
            
            System.out.println("\n\n\n");
        }
    }

    private static void initialFill(int[][] field) {
        
        Random r = new Random();
        
        for(int i = 0; i < field[0].length; i++) {
            for(int j = 0; j < field[1].length; j++) {
                field[i][j] = r.nextInt(2);
            }
        }
    }

    private static void liveOrDie(int[][] originalField, int rows, int columns) {
        
        int[][] tempField = new int[rows][columns];
        cloneField(originalField, tempField);
        
        int counter = 0;
        
        //middle
        for(int i = 1; i < rows - 1; i++) {
            for(int j = 1; j < columns - 1; j++) {
                counter = originalField[i - 1][j - 1] + originalField[i - 1][j] + originalField[i - 1][j + 1];
                counter += originalField[i][j - 1] + originalField[i][j + 1];
                counter += originalField[i + 1][j - 1] + originalField[i + 1][j] + originalField[i + 1][j + 1];
                
                if(counter < 2 || counter > 3) {
                    tempField[i][j] = 0;
                }
                else if(counter == 2) {
                    tempField[i][j] = originalField[i][j];
                }
                else {
                    tempField[i][j] = 1;
                }
            }
        }
        
        //top line
        for(int j = 1; j < columns - 1; j++) {
            counter = originalField[0][j - 1] + originalField[0][j + 1] + originalField[1][j - 1];
            counter += originalField[1][j] + originalField[1][j + 1];
            
            if(counter < 2 || counter > 3) {
                tempField[0][j] = 0;
            }
            else if(counter == 2) {
                tempField[0][j] = originalField[0][j];
            }
            else {
                tempField[0][j] = 1;
            }
        }
        
        //bottom line
        for(int j = 1; j < columns - 1; j++) {
            counter = originalField[rows - 2][j - 1] + originalField[rows - 2][j + 1] + originalField[rows - 2][j];
            counter += originalField[rows - 1][j - 1] + originalField[rows - 1][j + 1];
            
            if(counter < 2 || counter > 3) {
                tempField[rows - 1][j] = 0;
            }
            else if(counter == 2) {
                tempField[rows - 1][j] = originalField[rows - 1][j];
            }
            else {
                tempField[rows - 1][j] = 1;
            }
        }
        
        //left line
        for(int i = 1; i < rows - 1; i++) {
            counter = originalField[i - 1][0] + originalField[i - 1][1] + originalField[i][1];
            counter += originalField[i + 1][0] + originalField[i + 1][1];
            
            if(counter < 2 || counter > 3) {
                tempField[i][0] = 0;
            }
            else if(counter == 2) {
                tempField[i][0] = originalField[i][0];
            }
            else {
                tempField[i][0] = 1;
            }
        }
        
        //right line
        for(int i = 1; i < rows - 1; i++) {
            counter = originalField[i - 1][columns - 1] + originalField[i - 1][columns - 2] + originalField[i][columns - 2];
            counter += originalField[i + 1][columns - 1] + originalField[i + 1][columns - 2];
            
            if(counter < 2 || counter > 3) {
                tempField[i][columns - 1] = 0;
            }
            else if(counter == 2) {
                tempField[i][columns - 1] = originalField[i][columns - 1];
            }
            else {
                tempField[i][columns - 1] = 1;
            }
        }
        
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < columns; j++) {
                originalField[i][j] = tempField[i][j];
            }
        }
    }
    
    private static void cloneField(int[][] originalField, int[][] tempField) {
        
        for(int i = 0; i < originalField[0].length; i++) {
            for(int j = 0; j < originalField[1].length; j++) {
                tempField[i][j] = originalField[i][j];
            }
        }
    }

    private static void printOut(int[][] field, int rows, int columns) {
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < columns; j++) {
                if(field[i][j] == 1) {
                    System.out.print("*");
                }
                else {
                    System.out.print("-");
                }
            }
            System.out.println();
        }
    }
}

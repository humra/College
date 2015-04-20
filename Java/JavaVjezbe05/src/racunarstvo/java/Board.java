package racunarstvo.java;

import java.util.Random;
import java.util.Scanner;

public class Board {

    private char[][] board = new char[3][3];
    boolean gameOver;
    String userInput;
    private Scanner s;
    Random r;

    public Board() {
        s = new Scanner(System.in);
        r = new Random();
    }

    public void newGame() {
        resetBoard();
        gameOver = false;

        while (!gameOver) {
            userTurn();
            if (gameOver) {
                break;
            }
            computerTurn();
        }
    }
    
    private void computerTurn() {
        boolean legalMove = false;
        int x;
        int y;        
        
        while(!legalMove) {
            x = r.nextInt(3);
            y = r.nextInt(3);
            
            if(inputComputerMove(x, y)) {
                System.out.printf("I choose coordinates %d and %d\n", x + 1, y + 1);
                showBoard();
                legalMove = true;
            }
        }
        
        checkForVictory();
    }
    
    private boolean inputComputerMove(int x, int y) {
        if (board[x][y] != 'X' && board[x][y] != 'O') {
            board[x][y] = 'O';
            return true;
        }

        return false;
    }

    private void userTurn() {
        boolean legalMove = false;
        int x;
        int y;
        
        while (!legalMove) {
            System.out.print("Input coordinates: ");
            userInput = s.nextLine();

            x = Integer.parseInt(Character.toString(userInput.charAt(0)));
            y = Integer.parseInt(Character.toString(userInput.charAt(2)));

            if (inputUserMove(x - 1, y - 1)) {
                legalMove = true;
                showBoard();
            }
            else {
                System.out.println("Illegal move!");
            }
        }
        
        checkForVictory();
    }
    
    private void checkForVictory() {
        gameOver = (rowCheck() || columnCheck() || xCheck());
    }
    
    private boolean columnCheck() {
        for(int i = 0; i < 3; i++) {
            if(board[0][i] == 'X' && board[1][i] == 'X' && board[2][i] == 'X') {
                System.out.println("Player victory!");
                return true;
            }
            else if(board[0][i] == 'O' && board[1][i] == 'O' && board[2][i] == 'O') {
                System.out.println("Computer victory!");
                return true;
            }
        }
        
        return false;
    }
    
    private boolean xCheck() {
        if(board[0][0] == 'X' && board[1][1] == 'X' && board[2][2] == 'X') {
            System.out.println("Player victory!");
            return true;
        }
        else if(board[0][0] == 'O' && board[1][1] == 'O' && board[2][2] == 'O') {
            System.out.println("Computer victory!");
            return true;
        }
        else if(board[0][2] == 'X' && board[1][1] == 'X' && board[2][0] == 'X') {
            System.out.println("Player victory!");
            return true;
        }
        else if(board[0][2] == 'O' && board[1][1] == 'O' && board[2][0] == 'O') {
            System.out.println("Computer victory");
            return true;
        }
        
        return false;
    }
    
    private boolean rowCheck() {
        for(char[] array : board) {
            if(array[0] == 'X' && array[1] == 'X' && array[2] == 'X') {
                System.out.println("Player victory!");
                return true;
            }
            else if(array[0] == 'O' && array[1] == 'O' && array[2] == 'O') {
                System.out.println("Computer victory!");
                return true;
            }
        }
        
        return false;
    }

    private void showBoard() {
        for (char[] array : board) {
            System.out.println("------------");
            for (char c : array) {
                System.out.printf("| %s ", c);
            }
            System.out.println("|");
        }
        System.out.println("------------");
    }

    private boolean inputUserMove(int x, int y) {
        if (board[x][y] != 'X' && board[x][y] != 'O') {
            board[x][y] = 'X';
            return true;
        }

        return false;
    }

    private void resetBoard() {
        for (char[] array : board) {
            for (char c : array) {
                c = ' ';
            }
        }
    }
}

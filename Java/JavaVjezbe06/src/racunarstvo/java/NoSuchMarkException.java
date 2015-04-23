package racunarstvo.java;

public class NoSuchMarkException extends Exception {
    
    public NoSuchMarkException() {}
    
    public NoSuchMarkException(String message) {
        super(message);
    }
}

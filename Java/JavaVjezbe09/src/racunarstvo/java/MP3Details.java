package racunarstvo.java;

import java.io.*;

public class MP3Details {

    public static void main(String[] args) {
        try {
            File songs = new File("mp3");
            File[] list = songs.listFiles();
            
            for (int i = 0; i < list.length; i++) {
                InputStream file = new FileInputStream(list[i]);
                
                int size = (int) list[i].length();
                file.skip(size - 128);
                
                byte[] last128 = new byte[128];
                file.read(last128);
                
                String id3 = new String(last128);
                String tag = id3.substring(0, 3);
                
                if (tag.equals("TAG")) {
                    System.out.println("Title: " + id3.substring(3, 32));
                    System.out.println("Artist: " + id3.substring(33, 62));
                    System.out.println("Album: " + id3.substring(63, 91));
                    System.out.println("Year: " + id3.substring(93, 97));
                }
                else {
                    System.out.println(" does not contain"
                            + " ID3 info.");
                }
                System.out.println();
                file.close();
            }
        }
        catch (Exception e) {
            System.out.println("Error ? " + e.toString());
        }
    }
}

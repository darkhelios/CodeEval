
import java.io.*;

public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File("C:/Users/CSI - Pro/Desktop/texto.txt");
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();


            String[] letras = line.split(";");
            String[] a = letras[1].split(",");

            for (int i = 0; i < a.length ; i++) {

                for (int j = i+1 ; j < a.length; j++)
                {
                    if (a[i].equals( a[j]) )
                    {
                        System.out.println(a[j]);
                    }
                }
            }
        }
    }
}

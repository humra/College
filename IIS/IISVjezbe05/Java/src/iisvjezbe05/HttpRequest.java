package iisvjezbe05;

import java.net.URL;
import java.util.List;
import java.util.Map;
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;

public class HttpRequest {

    private final String USER_AGENT = "Mozilla/5.0";

    public static void main(String[] args) throws IOException, Exception {
        HttpRequest http = new HttpRequest();

        http.doGet();

        http.doPost();
    }

    private void doGet() throws MalformedURLException, IOException {
        String url = "http://ates-test.algebra.hr/iis/testSubmit.aspx?username=matija&passwd=1234";

        URL obj = new URL(url);
        HttpURLConnection con = (HttpURLConnection) obj.openConnection();

        con.setRequestMethod("GET");
        con.setRequestProperty("User-Agent", USER_AGENT);

        int responseCode = con.getResponseCode();
        System.out.println("\n'GET' na URL : " + url);
        System.out.println("Response code : " + responseCode);

        BufferedReader in = new BufferedReader(new InputStreamReader(con.getInputStream()));
        String inputLine;
        StringBuilder response = new StringBuilder();

        System.out.println("Headeri za URL: "
                + obj.toString() + "\n");

        Map<String, List<String>> mapOfHeaders = con.getHeaderFields();
        for (Map.Entry<String, List<String>> entry : mapOfHeaders.entrySet()) {
            System.out.println(entry.getKey() + " : " + entry.getValue());
        }

        while ((inputLine = in.readLine()) != null) {
            response.append(inputLine);
        }
        in.close();

        System.out.println(response.toString());
    }

    private void doPost() throws Exception {

        String url = "http://ates-test.algebra.hr/iis/testSubmit.aspx";
        URL obj = new URL(url);
        HttpURLConnection con = (HttpURLConnection) obj.openConnection();

        con.setRequestMethod("POST");
        con.setRequestProperty("User-Agent", USER_AGENT);
        con.setRequestProperty("Accept-Language", "en-US,en;q=0.5");

        String urlParameters = "username=matija&passwd=1234";

        con.setDoOutput(true);
        DataOutputStream wr = new DataOutputStream(con.getOutputStream());
        wr.writeBytes(urlParameters);
        wr.flush();
        wr.close();

        int responseCode = con.getResponseCode();
        System.out.println("\n'POST' na URL : " + url);
        System.out.println("Parametri: " + urlParameters);
        System.out.println("Response code: " + responseCode);

        BufferedReader in = new BufferedReader(new InputStreamReader(con.getInputStream()));
        String inputLine;
        StringBuilder response = new StringBuilder();

        System.out.println("Headeri za URL: "
                + obj.toString() + "\n");

        Map<String, List<String>> mapOfHeaders = con.getHeaderFields();
        for (Map.Entry<String, List<String>> entry : mapOfHeaders.entrySet()) {
            System.out.println(entry.getKey() + " : " + entry.getValue());
        }

        while ((inputLine = in.readLine()) != null) {
            response.append(inputLine);
        }
        in.close();

        System.out.println(response.toString());
    }
}

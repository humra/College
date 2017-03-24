package com.vjezba.vrijeme;

import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class UpraviteljIPAdresa implements Runnable{
	URL url;
	IVrijeme iVrijeme;

	public UpraviteljIPAdresa(URL url, IVrijeme iVrijeme)
	{
		this.url = url;
		this.iVrijeme = iVrijeme;
	}
	
	public PodaciIPAdresa dohvatiPodatke () throws Exception
	{
		PodaciIPAdresa podaciIP = new PodaciIPAdresa();
		
		HttpURLConnection veza=(HttpURLConnection) this.url.openConnection();
		veza.connect();
		if (veza.getResponseCode() != HttpURLConnection.HTTP_OK)
			return podaciIP;
			
		InputStream is = veza.getInputStream();
		
		DocumentBuilder db = DocumentBuilderFactory.newInstance().newDocumentBuilder();
		
		Document dokument = db.parse(is);
		
		Element dokumentElement = dokument.getDocumentElement();
		
		NodeList djeca =  dokumentElement.getChildNodes();
		for (int i = 0; i < djeca.getLength(); i++)
		{
			Node node = djeca.item(i);
			if (!(node instanceof Element))
				continue;
			String naziv = node.getNodeName();
			String vrijednost = node.getTextContent();
			
			if (naziv.equals("status"))
				podaciIP.setStatus(vrijednost);
			else if (naziv.equals("country"))
				podaciIP.setDrzava(vrijednost);
			else if (naziv.equals("city"))
				podaciIP.setGrad(vrijednost);
			else if (naziv.equals("zip"))
				podaciIP.setPostanskiBroj(vrijednost);
			else if (naziv.equals("lat"))
				podaciIP.setSirina(Double.parseDouble(vrijednost));
			else if (naziv.equals("lon"))
				podaciIP.setDuzina(Double.parseDouble(vrijednost));
			else if (naziv.equals("query"))
				podaciIP.setIPAdresa(vrijednost);
		}
		
		return podaciIP;
	}

	@Override
	public void run() {
		try {
			PodaciIPAdresa podaci = this.dohvatiPodatke();
			this.iVrijeme.ipProcesiranjeZavrseno(podaci, null);
		}
		catch (Exception ex) {
			this.iVrijeme.ipProcesiranjeZavrseno(null, ex.toString());
		}
	}
}

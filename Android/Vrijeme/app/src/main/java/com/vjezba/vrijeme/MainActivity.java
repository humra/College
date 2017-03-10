package com.vjezba.vrijeme;

import java.net.MalformedURLException;
import java.net.URL;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity implements IVrijeme{

	TextView tvIPAdresa;
	TextView tvLokacija;
	TextView tvGrad;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		this.tvIPAdresa = (TextView) this.findViewById(R.id.tvIPAdresa);
		this.tvLokacija = (TextView) this.findViewById(R.id.tvLokacija);
		this.tvGrad = (TextView) this.findViewById(R.id.tvGrad);
		
		String adresa = this.getResources().getString(R.string.IP_URL);
		URL url = null;
		try {
			url = new URL(adresa);
		} catch (MalformedURLException e) {
			e.printStackTrace();
			Toast.makeText(MainActivity.this, e.toString(), Toast.LENGTH_LONG).show();
			return;
		}
		
		UpraviteljIPAdresa upraviteljIP = new UpraviteljIPAdresa(url, this);
		try {
			Thread t = new Thread(upraviteljIP);
			t.start();
		} catch (Exception e) {
			e.printStackTrace();
			Toast.makeText(MainActivity.this, e.toString(), Toast.LENGTH_LONG).show();
		}
	}

	@Override
	public void ipProcesiranjeZavrseno(final PodaciIPAdresa podaci, final String pogreska) {

		this.runOnUiThread(new Runnable() {
			@Override
			public void run() {
				if(pogreska != null) {
					Toast.makeText(MainActivity.this, pogreska, Toast.LENGTH_LONG).show();
					return;
				}

				tvIPAdresa.setText(podaci.getIPAdresa());
				tvGrad.setText(String.format("%s %s", podaci.getPostanskiBroj(), podaci.getGrad()));
				String lokacija = String.format("%s,  %s", podaci.getDuzina(), podaci.getSirina());
				tvLokacija.setText(lokacija);
			}
		});


	}
}

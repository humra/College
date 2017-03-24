package com.vjezba.todolist;

import android.app.Activity;
import android.content.ContentUris;
import android.content.Intent;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.vjezba.todolist.podaci.Kontakt;
import com.vjezba.todolist.podaci.Kontakti;

public class OdabirKontaktaActivity extends Activity{

	ListView lvKontakti;	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		this.setContentView(R.layout.kontakt_odabir);

		this.lvKontakti = (ListView) this.findViewById(R.id.lvKontakti);

		final ArrayAdapter<Kontakt> adapter = new ArrayAdapter<Kontakt>(
				this, 
				android.R.layout.simple_list_item_1, 
				Kontakti.Singleton().vratiKontakte());
		this.lvKontakti.setAdapter(adapter);

		this.lvKontakti.setOnItemClickListener(new OnItemClickListener() {
			@Override
			public void onItemClick(AdapterView<?> parent, View view,
					int position, long id) {
				Kontakt kontakt = adapter.getItem(position);
				Intent intent = new Intent();
				//intent.putExtra("KontaktID", kontakt.getId());
				intent.setData(ContentUris.withAppendedId(
						ContactsContract.Contacts.CONTENT_URI, 
						kontakt.getId()));
				OdabirKontaktaActivity.this.setResult(RESULT_OK, intent);
				finish();

			}
		});

	}
}

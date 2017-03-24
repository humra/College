package com.vjezba.todolist.podaci;

import android.content.ContentResolver;
import android.database.Cursor;
import android.provider.ContactsContract;

public class Kontakti {

	ContentResolver resolver;
	private Kontakti(ContentResolver resolver)
	{
		this.resolver = resolver;
	}

	public ListKontakt vratiKontakte() {

		ListKontakt rezultat = new ListKontakt();
		
		String[] projekcija = new String[]
				{
				ContactsContract.Contacts._ID,
				ContactsContract.Contacts.DISPLAY_NAME
				};
		
		Cursor cursor = this.resolver.query(
				ContactsContract.Contacts.CONTENT_URI, //	uri 
				projekcija, //	projection 
				null, //	selection, 
				null, //	selectionArgs, 
				null  //	sortOrder
				);
		
		while (cursor.moveToNext())
		{
			Kontakt kontakt = new Kontakt();

			kontakt.setId(cursor.getInt(cursor.getColumnIndex(ContactsContract.Contacts._ID)));
			kontakt.setNaziv(cursor.getString(cursor.getColumnIndex(ContactsContract.Contacts.DISPLAY_NAME)));
			//kontakt.setMobitel(this.vratiMobitel(kontakt.getId()));
			//kontakt.setEmail(this.vratiEmail(kontakt.getId()));
			rezultat.add(kontakt);
		}

		return rezultat;
	}

	public Kontakt vratiKontakt (Integer ID)
	{
		String[] projekcija = new String[]
				{
				ContactsContract.Contacts.DISPLAY_NAME
				};

		Cursor cursor = this.resolver.query(
				ContactsContract.Contacts.CONTENT_URI, //	uri 
				projekcija, //	projection 
				ContactsContract.Contacts._ID + "=?", //	selection, 
				new String[]{String.valueOf(ID)}, //	selectionArgs, 
				null  //	sortOrder
				);

		Kontakt kontakt = null;
		if (cursor.moveToNext())
		{
			kontakt = new Kontakt();

			kontakt.setId(ID);
			kontakt.setNaziv(cursor.getString(cursor.getColumnIndex(ContactsContract.Contacts.DISPLAY_NAME)));
			kontakt.setMobitel(this.vratiMobitel(ID));
			kontakt.setEmail(this.vratiEmail(ID));
		}

		return kontakt;
	}

	private String vratiMobitel (Integer ID)
	{
		// naziv
		String[] projekcija = new String[]
				{
				ContactsContract.CommonDataKinds.Phone.NUMBER
				};

		Cursor cursor = this.resolver.query(
				ContactsContract.CommonDataKinds.Phone.CONTENT_URI, //	uri 
				projekcija, //	projection 
				ContactsContract.CommonDataKinds.Phone.CONTACT_ID + "=?", //	selection, 
				new String[]{String.valueOf(ID)}, //	selectionArgs, 
				null  //	sortOrder
				);

		if (cursor.moveToNext())
			return cursor.getString(cursor.getColumnIndex(ContactsContract.CommonDataKinds.Phone.NUMBER));
		return null;
	}


	private String vratiEmail (Integer ID)
	{
		// naziv
		String[] projekcija = new String[]
				{
				ContactsContract.CommonDataKinds.Email.ADDRESS
				};

		Cursor cursor = this.resolver.query(
				ContactsContract.CommonDataKinds.Email.CONTENT_URI, //	uri 
				projekcija, //	projection 
				ContactsContract.CommonDataKinds.Email.CONTACT_ID + "=?", //	selection, 
				new String[]{String.valueOf(ID)}, //	selectionArgs, 
				null  //	sortOrder
				);

		if (cursor.moveToNext())
			return cursor.getString(cursor.getColumnIndex(ContactsContract.CommonDataKinds.Email.ADDRESS));
		return null;
	}

	private static Kontakti _Singleton;

	public static Kontakti Singleton() {
		return _Singleton;
	}

	public static void Inicijaliziraj (ContentResolver resolver)
	{
		_Singleton = new Kontakti (resolver);
	}
}

package com.humra.ishod04part01;

import android.content.ContentProvider;
import android.content.ContentUris;
import android.content.ContentValues;
import android.content.Context;
import android.content.UriMatcher;
import android.database.Cursor;
import android.net.Uri;
import android.support.annotation.Nullable;

/**
 * Created by Matija on 28/08/2016.
 */
public class DjelatnikProvider extends ContentProvider {

    private static final String PROVIDER_NAME = "humra.provider.djelatnici";
    private static final Uri CONTENT_URI = Uri.parse("content://" + PROVIDER_NAME + "/djelatnici");
    private static final int DJELATNICI  = 1;
    private static final int DJELATNIK_ID = 2;
    private static final UriMatcher matcher = getUriMatcher();

    private BazaHelper db;

    private static final UriMatcher getUriMatcher() {
        UriMatcher matcher = new UriMatcher(UriMatcher.NO_MATCH);
        matcher.addURI(PROVIDER_NAME, "djelatnici", DJELATNICI);
        matcher.addURI(PROVIDER_NAME, "djelatnici/#", DJELATNIK_ID);

        return matcher;
    }

    @Override
    public boolean onCreate() {
        Context context = getContext();
        db = new BazaHelper(context);
        return true;
    }

    @Nullable
    @Override
    public Cursor query(Uri uri, String[] projection, String selection, String[] selectionArgs, String sortOrder) {
        String id = null;

        if(matcher.match(uri) == DJELATNIK_ID) {
            id = uri.getPathSegments().get(1);
        }

        return db.getDjelatniciCursor(Integer.parseInt(id), projection, selection, selectionArgs, sortOrder);
    }

    @Nullable
    @Override
    public String getType(Uri uri) {
        switch(matcher.match(uri)) {
            case DJELATNICI:
                return "vnd.cursor.dir/vnd.com.humra.provider.djelatnici";
            case DJELATNIK_ID:
                return "vnd.cursor.item/vnd.com.humra.provider.djelatnici";
        }

        return "";
    }

    @Nullable
    @Override
    public Uri insert(Uri uri, ContentValues values) {
        try {
            long id = db.addNewDjelatnik(values);
            Uri returnUri = ContentUris.withAppendedId(CONTENT_URI, id);
            return returnUri;
        }
        catch(Exception ex) {
            return null;
        }
    }

    @Override
    public int delete(Uri uri, String selection, String[] selectionArgs) {
        String id = null;

        if(matcher.match(uri) == DJELATNIK_ID) {
            id = uri.getPathSegments().get(1);
        }

        return db.deleteDjelatnik(id);
    }

    @Override
    public int update(Uri uri, ContentValues values, String selection, String[] selectionArgs) {
        String id = null;

        if(matcher.match(uri) == DJELATNIK_ID) {
            id = uri.getPathSegments().get(1);
        }

        return db.updateDjelatnik(id, values);
    }
}

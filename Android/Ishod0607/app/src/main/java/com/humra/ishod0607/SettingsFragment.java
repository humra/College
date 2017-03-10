package com.humra.ishod0607;

import android.os.Bundle;
import android.preference.PreferenceFragment;

/**
 * Created by Matija on 07/09/2016.
 */
public class SettingsFragment extends PreferenceFragment {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        addPreferencesFromResource(R.xml.preferences);
    }
}

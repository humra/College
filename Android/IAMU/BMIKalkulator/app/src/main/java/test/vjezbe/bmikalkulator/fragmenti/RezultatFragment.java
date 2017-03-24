package test.vjezbe.bmikalkulator.fragmenti;

/**
 * Created by Matija on 18/04/2016.
 */
import test.vjezbe.bmikalkulator.R;

import android.app.Fragment;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

public class RezultatFragment extends Fragment {
    public static final String TAG = "Rezultat";
    double bmi;

    TextView tvBMI;
    TextView tvOpis;
    ImageView ivBMI;
    Drawable dSretan;
    Drawable dTuzan;

    public RezultatFragment(double rezultat) {
        this.bmi = rezultat;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState)
    {
        View view = inflater.inflate(R.layout.rezultat, container, false);

        this.tvBMI = (TextView) view.findViewById(R.id.tvBMI);
        this.tvOpis = (TextView) view.findViewById(R.id.tvOpis);
        this.ivBMI = (ImageView) view.findViewById(R.id.ivBMI);
        this.dSretan = this.getResources().getDrawable(R.drawable.sretan);
        this.dTuzan = this.getResources().getDrawable(R.drawable.tuzan);

        if (bmi == -1)
        {
            tvBMI.setText("");
            tvOpis.setText("");
            ivBMI.setImageDrawable(null);
        }
        else
        {
            tvBMI.setText(String.format("%.1f", bmi));
            if (bmi <= 20)
            {
                tvOpis.setText(getResources().getString(R.string.text_pothranjeno));
                ivBMI.setBackground(dTuzan);
            }
            else if (bmi <= 25)
            {
                tvOpis.setText(getResources().getString(R.string.text_normalno));
                ivBMI.setBackground(dSretan);
            }
            else
            {
                tvOpis.setText(getResources().getString(R.string.text_prekomjerno));
                ivBMI.setBackground(dTuzan);
            }
        }

        return view;

    }


}

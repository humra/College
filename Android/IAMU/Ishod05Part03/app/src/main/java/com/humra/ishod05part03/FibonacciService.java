package com.humra.ishod05part03;

import android.app.IntentService;
import android.content.Intent;
import android.support.v4.content.LocalBroadcastManager;

/**
 * Created by Matija on 06/09/2016.
 */
public class FibonacciService extends IntentService {

    /**
     * Creates an IntentService.  Invoked by your subclass's constructor.
     *
     * @param name Used to name the worker thread, important only for debugging.
     */
    public FibonacciService(String name) {
        super(name);
    }

    @Override
    protected void onHandleIntent(Intent intent) {
        final int broj = intent.getIntExtra("BROJ", 1);

        new Runnable() {
            @Override
            public void run() {
                if(broj == 1 || broj == 2) {
                    broadcastaj(1);
                }

                long fib1 = 1;
                long fib2 = 1;
                long fibonacci = 1;

                for(int i = 3; i <= broj; i++) {
                    fibonacci = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fibonacci;
                }

                broadcastaj(fibonacci);
            }
        }.run();

    }

    public void broadcastaj(long result) {

        Intent localIntent = new Intent(Constants.BROADCAST_ACTION);
        localIntent.putExtra(Constants.EXTENDED_VARIABLE, result);

        LocalBroadcastManager.getInstance(this).sendBroadcast(localIntent);
    }
}

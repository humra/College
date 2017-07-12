package com.humra.medjuispit01zadatak02;


public class Prezenter implements IPrezenter {

    public IView view;
    public Prezenter(IView view) {
        this.view = view;
    }

    @Override
    public void processMessage(String message) {
        try {
            Integer number = Integer.parseInt(message);
            if(number % 2 == 0) {
                view.showMessage("Broj je paran");
            }
            else {
                view.showMessage("Broj je neparan");
            }
        }
        catch(Exception ex) {
            view.showError();
        }
    }
}

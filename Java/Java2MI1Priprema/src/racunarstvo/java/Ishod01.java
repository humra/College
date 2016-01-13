/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package racunarstvo.java;

import java.awt.Color;
import java.util.Random;

/**
 *
 * @author Matija
 */
public class Ishod01 extends javax.swing.JPanel {
    
    /**
     * Creates new form Ishod01
     */
    public Ishod01() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        lblBoja = new javax.swing.JPanel();

        jButton1.setText("Pokreni");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout lblBojaLayout = new javax.swing.GroupLayout(lblBoja);
        lblBoja.setLayout(lblBojaLayout);
        lblBojaLayout.setHorizontalGroup(
            lblBojaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 327, Short.MAX_VALUE)
        );
        lblBojaLayout.setVerticalGroup(
            lblBojaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 53, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(28, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton1)
                    .addComponent(lblBoja, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblBoja, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButton1)
                .addContainerGap(28, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        mijenjajBoje();
    }//GEN-LAST:event_jButton1ActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JPanel lblBoja;
    // End of variables declaration//GEN-END:variables

    public Thread t = new Thread() {
            @Override
            public void run() {
                try {
                    while(true) {
                        Color c = vratiBoju();
                        lblBoja.setBackground(c);
                        sleepyTime();
                    }
                }
                catch(Exception e) {
                    System.out.println(e.getMessage());
                }
            }

            private Color vratiBoju() {
                Random r = new Random();
                int broj = r.nextInt(3);
                
                Color c = null;
                
                switch(broj) {
                    case 0:
                        c = Color.RED;
                        break;
                    case 1:
                        c = Color.BLUE;
                        break;
                    case 2:
                        c = Color.GREEN;
                        break;
                    case 3:
                        c = Color.YELLOW;
                        break;
                    default:
                        break;
                }
                
                return c;
            }

            private void sleepyTime() {
                try {
                    Thread.sleep(1000);
                }
                catch(Exception e) {
                    System.out.println(e.getMessage());
                }
            }
        };
    
    private void mijenjajBoje() {     
        t.start();
    }
}
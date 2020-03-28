package com.MJZF.x00155619;

public class GeneradorISBN {

    private static int contador=0;

    private GeneradorISBN() {
    }

    public static int nuevoISBN(){
        contador++;
        return contador;
    }

}

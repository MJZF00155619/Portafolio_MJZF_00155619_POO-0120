package com.MJZF.x00155619;

public class Libro {
    //atributos
    private int ISBN;
    private String nombre;
    private int paginas;

    //constructores

    public Libro (int ISBN,String nombre, int paginas){
        this.ISBN = GeneradorISBN.nuevoISBN();
        this.nombre= nombre;
        this.paginas = paginas;
    }
    public int getISBN(){
        return ISBN;
    }

    public String getNombre(){
        return nombre;
    }

    public int getPaginas(){
        return paginas;
    }

    public String toString(){
        return "\n ISBN: "+ISBN+"\n NOMBRE: "+ nombre +"\n PAGINAS: "+ paginas;
    }

}

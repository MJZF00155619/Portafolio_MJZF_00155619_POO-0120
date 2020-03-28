package com.MJZF.x00155619;

public class Autor {

    //atributos
    private String nombre;
    private String email;
    private char genero;

        //constructor
    public Autor (String nombre, String email, char genero){
        this.nombre= nombre;
        this.email = email;
        this.genero= genero;
    }

    //metodos
    public String getNombre(){
        return nombre;
    }

    public String getEmail(){
        return email;
    }

    public void setEmail(String email){
        this.email = email;
    }

    public char getGenero(){
        return genero;
    }
    public String toString(){
        return "\n NOMBRE: "+nombre+"\n EMAIL: "+ email+"\n GENERO: "+genero;
    }
}



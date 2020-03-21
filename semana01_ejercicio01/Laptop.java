package com.MJZF.x00155619;

public class Laptop {

    //atributos
    private String marca;
    private String OS;
    private int modelo;
    private String OSextra;


    //metodo constructor
    public Laptop (String marca, String OS){
        this.marca= marca;
        this.OS = OS;

    }
    public Laptop (int modelo){
        this.modelo = modelo;
    }


    //metodos
    public void Encender(){
        System.out.println("Laptop " + marca + " OS: " + OS + " esta encendiendo...\n");
    }

    public void Encender (int model){
        System.out.println("Laptop " + modelo + " esta encendiendo...\n");
    }

    public void Reiniciar(String marca, String OS){
        System.out.println("Laptop "+ marca + " OS: " +OS + " se reiniciara...\n");
    }
    public void Apagar (String marca, String OS){
        System.out.println("Laptop "+ marca + " OS: " +OS + " se esta apagando...\n");
    }

    public void setOSextra(String OSextra){
        this.OSextra=OSextra;
    }

    public String getOS(){
        return OS;
    }



}

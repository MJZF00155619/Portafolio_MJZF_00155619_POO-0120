package com.MJZF.x00155619;

import java.util.Scanner;

public class Main {


    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        byte clase;
        do{
        System.out.println("¿Que clase desea utilizar?");
        System.out.println("1. Laptop");
        System.out.println("2. Usuario");
            System.out.println("0. Salir");
        clase = in.nextByte();
        in.nextLine();

        if (clase == 1) {
            byte n;
            do {
                mainmenu();
                n = in.nextByte();
                in.nextLine();
                Laptop laptop1 = new Laptop("HP", "WINDOWS");
                switch (n) {

                    case 1:    //Mostrar por marca y sistema operativo
                        laptop1.Encender();
                        //Mostrar por modelo
                        laptop1.Encender(34544);
                        break;
                    case 2:
                        laptop1.Reiniciar("HP", "WINDOWS");
                        break;
                    case 3:
                        laptop1.Apagar("HP", "WINDOWS");
                        break;

                    case 4:
                        String extra;
                        System.out.println("¿Que sistema operativo extra desea?");
                        extra = in.nextLine();
                        laptop1.setOSextra(extra);
                        break;
                    case 5:
                        System.out.println("El sistema operativo principal es: " + laptop1.getOS() + "\n");
                }
            } while (n != 0);
        }else if(clase==2){
            byte n2;
            do{
                mainmenu2();
                n2 = in.nextByte();in.nextLine();

                Usuario user = new Usuario("Mauricio","Mauricio53@uca.edu.sv");
                switch (n2){
                    case 1 : user.IniciarSesion("Mauricio");break;
                    case 2: user.Verificacion("Mauricio53@uca.edu.sv");
                }

            }while(n2!=0);
        }else{
            System.out.println("Saliendo...");
        }}while(clase!=0);
    }
        public static void mainmenu () {
            System.out.println("¿Que desea hacer?");
            System.out.println("1. Encender");
            System.out.println("2- Reiniciar");
            System.out.println("3. Apagar");
            System.out.println("4 Agregar Sistema Operativo extra");
            System.out.println("5 Ver el sistema operativo principal");
            System.out.println("0 para salir");
        }
        public static void mainmenu2(){
            System.out.println("¿Que dese hacer?");
            System.out.println("1. iniciar session");
            System.out.println("2. verificacion");
            System.out.println("0. Salir");
        }
    }


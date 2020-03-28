package com.MJZF.x00155619;

import java.util.Scanner;
import  java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        ArrayList<Autor> autores = new ArrayList<>();
        String nombre;
        String email;
        char genero;

        ArrayList<Libro> libros = new ArrayList<>();
        String ISBN;
        String nombreL;
        int paginas;

        byte n;
        do {
            menu();
            n=in.nextByte();in.nextLine();
            switch (n){
                case 1 :
                    byte n2;
                    do {
                        System.out.println("¿Que desea hacer?");
                        menuAutor();
                        n2 = in.nextByte(); in.nextLine();
                        switch (n2){
                            case 1:
                                System.out.println("NOMBRE DEL AUTOR: "); nombre = in.nextLine();
                                System.out.println("EMAIL DEL AUTOR: "); email = in.nextLine();
                                System.out.println("GENERO DEL AUTOR (M/F): "); genero = in.next().charAt(0);
                                autores.add(new Autor(nombre, email, genero)); break;
                            case 2:
                                for (Autor e:autores
                                     ) {
                                    System.out.println(e);
                                }break;
                            case 3:
                                System.out.println("INGRESE EL NOMBRE DEL AUTOR A ELIMINAR: "); nombre = in.nextLine();
                                String finalNombre = nombre;

                                autores.removeIf(s -> s.getNombre().equalsIgnoreCase(finalNombre));
                                System.out.println("Revise la lista para verificar...");
                                break;
                            default:
                                if(n2!=0)System.out.println("Esa opcion no existe");break;
                        }
                    }while(n2!=0);break;
                case 2 :
                    do {
                        System.out.println("¿Que desea hacer?");
                        menuLibros();
                        n2 = in.nextByte(); in.nextLine();
                        switch (n2){
                            case 1:
                                System.out.println("ISBN DEL LIBRO: "); ISBN = in.nextLine();
                                System.out.println("NOMBRE DEL LIBRO: "); nombreL = in.nextLine();
                                System.out.println("PAGINAS DEL LIBRO: "); paginas = in.nextInt(); in.nextLine();
                                libros.add(new Libro(ISBN, nombreL, paginas)); break;
                            case 2:
                                for (Libro e:libros
                                     ) {
                                    System.out.println(e);
                                }break;
                            case 3:
                                System.out.println("INGRESE EL NOMBRE DEL LIBRO A ELIMINAR: "); nombreL = in.nextLine();
                                String finalNombreL = nombreL;

                                libros.removeIf(s -> s.getNombre().equalsIgnoreCase(finalNombreL));
                                System.out.println("Revise la lista para verificar...");
                                break;
                            default: if(n2!=0)System.out.println("Esa opcion no existe");break;
                        }
                    }while(n2!=0);break;
            }
        }while(n!=0);


    }

    public static void menu(){
        System.out.println("¿Donde desea navegar? ");
        System.out.println("1. Autores");
        System.out.println("2. Libros");
        System.out.println("0. Para salir");
    }
    public static void menuLibros(){
        System.out.println("1. Agregar Libro");
        System.out.println("2. Mostrar Libros");
        System.out.println("3. Eliminar Libro");
        System.out.println("0  para salir");
    }
    public static void menuAutor(){
        System.out.println("1. Agregar Autor");
        System.out.println("2. Mostrar Autores");
        System.out.println("3. Eliminar Autor");
        System.out.println("0  para salir");
    }

}

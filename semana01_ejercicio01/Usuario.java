package com.MJZF.x00155619;

public class Usuario {
    private String nombre;
    private String contraseña;
    private String correo;

    public Usuario (String contraseña){
        this.contraseña = contraseña;
    }
    public Usuario (String nombre, String correo){
        this.nombre=nombre;
        this.correo=correo;
    }

    public void setCorreo(String correo){
        this.correo = correo;
    }
    public void setContraseña (String contraseña){
        this.contraseña = contraseña;
    }
    public String getNombre (){
        return nombre;
    }

    public void IniciarSesion(String nombre){
        System.out.println("Bienvenido "+ nombre);
    }
    public void Verificacion (String correo){
        System.out.println("Se ha enviado un codigo de verificacion al correo "+ correo);
    }

}

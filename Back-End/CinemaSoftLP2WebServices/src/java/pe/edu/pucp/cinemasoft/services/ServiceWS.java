/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.cinemasoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.cinemasoft.dao.ActorDAO;
import pe.edu.pucp.cinemasoft.dao.GeneroDAO;
import pe.edu.pucp.cinemasoft.dao.PeliculaDAO;
import pe.edu.pucp.cinemasoft.model.Actor;
import pe.edu.pucp.cinemasoft.model.Genero;
import pe.edu.pucp.cinemasoft.model.Pelicula;
import pe.edu.pucp.cinemasoft.mysql.ActorMySQL;
import pe.edu.pucp.cinemasoft.mysql.GeneroMySQL;
import pe.edu.pucp.cinemasoft.mysql.PeliculaMySQL;

/**
 *
 * @author joham
 */
@WebService(serviceName = "ServiceWS")
public class ServiceWS {
    private GeneroDAO daoGenero=new GeneroMySQL();
    private ActorDAO daoActor=new ActorMySQL();
    private PeliculaDAO daoPelicula = new PeliculaMySQL();
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    @WebMethod(operationName = "ListarGeneros")
    public ArrayList<Genero> ListarGeneros() {
        ArrayList<Genero> generos = new ArrayList<>();
        try{
            generos = daoGenero.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return generos;
    }
    @WebMethod(operationName = "ListarActoresPorNombre")
    public ArrayList<Actor> ListarActoresPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Actor> actores = new ArrayList<>();
        try{
            actores = daoActor.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return actores;
    }
    @WebMethod(operationName = "GuardarPelicula")
    public int GuardarPelicula(@WebParam(name = "pelicula") Pelicula pelicula) {
        int resultado=0;
        try{
            resultado = daoPelicula.insertar(pelicula);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "ListarPeliculasPorTitulo")
    public ArrayList<Pelicula> ListarPeliculasPorTitulo(@WebParam(name = "nombre") String nombre) {
        ArrayList<Pelicula> peliculas = new ArrayList<>();
        try{
            peliculas = daoPelicula.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return peliculas;
    }
}
